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

namespace GameProject
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // game state
        GameState gameState = GameState.Menu;

        // Increment 1: opening screen fields
        const int WINDOW_WIDTH = 800;
        const int WINDOW_HEIGHT = 600;

        // Opening screen image drawing support
        Texture2D openingScreen;
        Rectangle opscrRectangle;

        // Increment 2: the board
        NumberBoard numberBoard;

        // step 58 - Initialize a variable to hold a random number
        Random rand = new Random();

        // correct guess
        bool correct;

        // step 62 declare fields for the audio api components
        AudioEngine audioEngine;
        WaveBank waveBank;
        SoundBank soundBank;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Increment 1: set window resolution
            graphics.PreferredBackBufferWidth = WINDOW_WIDTH;
            graphics.PreferredBackBufferHeight = WINDOW_HEIGHT;

            // Increment 1: make the mouse visible
            IsMouseVisible = true;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
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

            // step 63 -- load audio content
            audioEngine = new AudioEngine(@"Content\sounds.xgs");
            waveBank = new WaveBank(audioEngine, @"Content\Wave Bank.xwb");
            soundBank = new SoundBank(audioEngine, @"Content\Sound Bank.xsb");

            // Increment 1: load opening screen and set opening screen draw rectangle
            openingScreen = Content.Load<Texture2D>("openingscreen");
            opscrRectangle = new Rectangle(0, 0, openingScreen.Width, openingScreen.Height);

            StartGame(); // step 55 
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

            // Step 70 -- exit when "Escape" is pressed
            KeyboardState keyboard = Keyboard.GetState();
            if (keyboard.IsKeyDown(Keys.Escape)) this.Exit();

            // Increment 2: change game state if game state is GameState.Menu and user presses Enter
            if (gameState == GameState.Menu && Keyboard.GetState().IsKeyDown(Keys.Enter))
            {
                gameState = GameState.Play;
            }

            // Increment 4. If we're actually playing, update mouse state and update board
            if (gameState == GameState.Play)
            {
                MouseState mouse = Mouse.GetState();
                // step 54 - return correct/ not correct guess (true/false)
                correct = numberBoard.Update(gameTime, mouse);

                // step 56 - call StartGame method if the correct number was guessed
                if (correct)
                {
                    soundBank.PlayCue("newGame");
                    StartGame();
                }

            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Increments 1 and 2: draw appropriate items here
            spriteBatch.Begin();

            if (gameState == GameState.Menu)
            {
                spriteBatch.Draw(openingScreen, opscrRectangle, Color.White);
            }
            else  if (gameState == GameState.Play)
            {
                numberBoard.Draw(spriteBatch);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// Starts a game
        /// </summary>
        void StartGame()
        {
            // step 59 - randomly generate new number for the correct tile between 1 and 9
            int myCorrect = rand.Next(1, 10);

            // create a number board
            Vector2 center = new Vector2(WINDOW_WIDTH / 2, WINDOW_HEIGHT / 2);
            numberBoard = new NumberBoard(Content
                                        , center
                                        , (int)(WINDOW_HEIGHT * 0.8)
                                        , myCorrect // previously we passed "8" for testing 
                                        , soundBank); // previously we passed "null" for testing 
        }
    }
}
