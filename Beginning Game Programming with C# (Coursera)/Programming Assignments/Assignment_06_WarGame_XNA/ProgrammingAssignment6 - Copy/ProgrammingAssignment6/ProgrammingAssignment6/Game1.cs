using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

using XnaCards;

namespace ProgrammingAssignment6
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // Declare Widht and Height of the screen
        const int WINDOW_WIDTH = 800;
        const int WINDOW_HEIGHT = 600;

        // keep track of game state and current winner
        static GameState gameState = GameState.Play;

        // hands and battle piles for the players
        WarHand warHand1 = new WarHand(WINDOW_WIDTH / 2, 100);
        WarHand warHand2 = new WarHand(WINDOW_WIDTH / 2, 500);

        WarBattlePile battlePile1;
        WarBattlePile battlePile2;

        // winner messages for players
        WinnerMessage winner1Message;
        WinnerMessage winner2Message;

        //Texture2D warMessage;
        //Rectangle warMessageRectangle;
        //Rectangle flipSourceRectangle;

        // menu buttons
        MenuButton flipButton;
        MenuButton collectWinningsButton;
        MenuButton quitButton;

        // current ("open") cards for each player
        Card card1;
        Card card2;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // make mouse visible and set resolution
            IsMouseVisible = true;

            graphics.PreferredBackBufferWidth = WINDOW_WIDTH;
            graphics.PreferredBackBufferHeight = WINDOW_HEIGHT;

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // create the deck object and shuffle
            Deck deck = new Deck(Content, 50, 50);
            deck.Shuffle();

            // create the player hands and fully deal the deck into the hands
            //while (!deck.Empty)
            //{
            //    warHand1.AddCard(deck.TakeTopCard());
            //    if (!deck.Empty)
            //    {
            //        warHand2.AddCard(deck.TakeTopCard());
            //    }
            //}

            //--------------------------------------------------
             //Pass 3 cards to test
            for (int i = 1; i < 4; i++)
            {
                warHand1.AddCard(deck.TakeTopCard());
                warHand2.AddCard(deck.TakeTopCard());
            }
            //--------------------------------------------------

            // create the player battle piles
            battlePile1 = new WarBattlePile(WINDOW_WIDTH / 2, 200);
            battlePile2 = new WarBattlePile(WINDOW_WIDTH / 2, 400);

            // create the player winner messages   
            winner1Message = new WinnerMessage(Content, 600, 150);
            winner2Message = new WinnerMessage(Content, 600, 450);

            //winnerMessage = Content.Load<Texture2D>("winner");
            //winnerMessageRectangle = new Rectangle(500, 475, winnerMessage.Width, winnerMessage.Height);

            // Flip Button -- without MenuButtin class
            //flipButton = Content.Load<Texture2D>("flipbutton");
            //flipRectangle = new Rectangle(50, 100, flipButton.Width / 2, flipButton.Height);
            //flipSourceRectangle = new Rectangle(0, 0, flipButton.Width / 2, flipButton.Height);

            // create the menu buttons
            flipButton = new MenuButton(Content, "flipbutton", 150, 150, GameState.Flip);

            collectWinningsButton = new MenuButton(Content, "collectwinningsbutton", 150, 300, GameState.CollectWinnings);
            collectWinningsButton.Visible = false;

            quitButton = new MenuButton(Content, "quitbutton", 150, 450, GameState.Quit);

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // update the menu buttons
            MouseState mouse = Mouse.GetState();
            flipButton.Update(mouse);
            collectWinningsButton.Update(mouse);
            quitButton.Update(mouse);

            // update based on game state
            // Check "Collect Winnigs" button
            if (Game1.gameState == GameState.CollectWinnings)
            {
                if (card1.WarValue > card2.WarValue)
                {
                    warHand1.AddCards(battlePile1);
                    warHand1.AddCards(battlePile2);

                    if (warHand2.Empty)
                    {
                        gameState = GameState.GameOver;
                    }
                    else
                    {
                        gameState = GameState.Play;
                        collectWinningsButton.Visible = false;
                        flipButton.Visible = true;
                        winner1Message.Visible = false;
                        winner2Message.Visible = false;
                    }
                }

                else if (card1.WarValue < card2.WarValue)
                {
                    warHand2.AddCards(battlePile1);
                    warHand2.AddCards(battlePile2);

                    if (warHand1.Empty)
                    {
                        gameState = GameState.GameOver;
                    }
                    else
                    {
                        gameState = GameState.Play;
                        collectWinningsButton.Visible = false;
                        flipButton.Visible = true;
                        winner1Message.Visible = false;
                        winner2Message.Visible = false;
                    }
                }

                else if (card1.WarValue == card2.WarValue)
                {
                    warHand1.AddCards(battlePile1);
                    warHand2.AddCards(battlePile2);

                    gameState = GameState.Play;
                    collectWinningsButton.Visible = false;
                    flipButton.Visible = true;
                    winner1Message.Visible = false;
                    winner2Message.Visible = false;
                }
            }

            // Check "Flip" button
            if (Game1.gameState == GameState.Flip)
            {
                collectWinningsButton.Visible = true;
                flipButton.Visible = false;

                //pass crads to player1 and player2
                card1 = warHand1.TakeTopCard();
                card1.FlipOver();
                battlePile1.AddCard(card1);

                card2 = warHand2.TakeTopCard();
                card2.FlipOver();
                battlePile2.AddCard(card2);

                if (card1.WarValue > card2.WarValue)
                {
                    winner1Message.Visible = true;
                }
                else if (card2.WarValue > card1.WarValue)
                {
                    winner2Message.Visible = true;
                }

                else if (card2.WarValue == card1.WarValue)
                {
                    winner1Message.Visible = false;
                    winner2Message.Visible = false;
                }

                gameState = GameState.Play;

            }


            // Check "Game Over" and "Quit" states
            if (Game1.gameState == GameState.GameOver)
            {
                flipButton.Visible = false;
                collectWinningsButton.Visible = false;
            }

            if (Game1.gameState == GameState.Quit)
            {
                this.Exit();
            }


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Goldenrod);

            spriteBatch.Begin();

            // draw the game objects
            warHand1.Draw(spriteBatch);
            warHand2.Draw(spriteBatch);

            // draw the winner messages
            winner1Message.Draw(spriteBatch);
            winner2Message.Draw(spriteBatch);

            // draw the menu buttons
            //spriteBatch.Draw(flipButton, flipRectangle, flipSourceRectangle, Color.White);
            flipButton.Draw(spriteBatch);
            collectWinningsButton.Draw(spriteBatch);
            quitButton.Draw(spriteBatch);

            battlePile1.Draw(spriteBatch);
            battlePile2.Draw(spriteBatch);

            spriteBatch.End();
            base.Draw(gameTime);
        }

        /// <summary>
        /// Changes the state of the game
        /// </summary>
        /// <param name="newState">the new game state</param>
        public static void ChangeState(GameState newState)
        {
            gameState = newState;
        }
    }
}
