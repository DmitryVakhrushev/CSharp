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

namespace FishGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        const int WINDOW_WIDTH = 800;
        const int WINDOW_HEIGHT = 600;

        // game objects
        List<TeddyBear> bears = new List<TeddyBear>();
        Fish fish;

        // bear spawn timing
        const int BEAR_SPAWN_DELAY_TIME = 500;
        int elapsedBearSpawnTime = 0;

        // text display
        SpriteFont font;
        Vector2 scorePosition = new Vector2(WINDOW_WIDTH / 12, WINDOW_HEIGHT / 12);

        // score handling
        int score = 0;
        const int BEAR_SCORE = 10;
        const string SCORE_STRING_PREFIX = "Score: ";
        string scoreString;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

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

            // create the fish
            fish = new Fish(Content, graphics.PreferredBackBufferWidth,
                graphics.PreferredBackBufferHeight, "fish", graphics.PreferredBackBufferWidth / 2, 
                graphics.PreferredBackBufferHeight / 2);

            // load sprite font and initialize score string
            font = Content.Load<SpriteFont>("Arial");
            scoreString = GetScoreString(score);
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
            KeyboardState keyboard = Keyboard.GetState();

            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                keyboard.IsKeyDown(Keys.Escape))
                this.Exit();

            // spawn bears as appropriate
            elapsedBearSpawnTime += gameTime.ElapsedGameTime.Milliseconds;
            if (elapsedBearSpawnTime > BEAR_SPAWN_DELAY_TIME)
            {
                elapsedBearSpawnTime -= BEAR_SPAWN_DELAY_TIME;
                TeddyBear newBear = new TeddyBear(Content, "teddybear",
                    WINDOW_WIDTH, WINDOW_HEIGHT);
                bears.Add(newBear);
            }

            // update the fish
            fish.Update(keyboard);

            // update all the bears
            foreach (TeddyBear bear in bears)
            {
                bear.Update();

                // kill bears that are colliding with the fish
                if (bear.Active && fish.CollisionRectangle.Intersects(bear.CollisionRectangle))
                {
                    bear.Active = false;
                    score += BEAR_SCORE;
                    scoreString = GetScoreString(score);
                }
            }

            // clean dead bears out of list
            for (int i = bears.Count - 1; i >= 0; i--)
            {
                if (!bears[i].Active)
                {
                    bears.RemoveAt(i);
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

            // draw all the game objects
            spriteBatch.Begin();
            foreach (TeddyBear bear in bears)
            {
                bear.Draw(spriteBatch);
            }
            fish.Draw(spriteBatch);

            // draw score

            // method to draw LESS efficient
            // here we create a new string 60 times a second
            //spriteBatch.DrawString(font, "Score: " + score, scorePosition, Color.White);
            
            // second better method to draw
            spriteBatch.DrawString(font, scoreString, scorePosition, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// Gets the score string for the given score
        /// </summary>
        /// <param name="score">score</param>
        /// <returns>score string</returns>
        private string GetScoreString(int score)
        {
            return SCORE_STRING_PREFIX + score;
        }
    }
}
