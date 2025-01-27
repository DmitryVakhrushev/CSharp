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

namespace LoopyTeddies
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

        const int INITIAL_NUM_TEDDIES = 1;

        // random teddy bear support
        Random rand = new Random();
        List<Texture2D> sprites = new List<Texture2D>();

        // spawning support
        const int TOTAL_SPAWN_DELAY_MILLISECONDS = 1000;
        int elapsedSpawnDelayMilliseconds = 0;

        // game objects
        List<TeddyBear> bears = new List<TeddyBear>();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = WINDOW_WIDTH;
            graphics.PreferredBackBufferHeight = WINDOW_HEIGHT;

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

            // load sprites for efficiency
            sprites.Add(Content.Load<Texture2D>("teddybear0"));
            sprites.Add(Content.Load<Texture2D>("teddybear1"));
            sprites.Add(Content.Load<Texture2D>("teddybear2"));

            // create initial game objects
            for (int i = 0; i < INITIAL_NUM_TEDDIES; i++)
            {
                bears.Add(GetRandomTeddyBear());
            }
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

            // spawn teddies as appropriate
            elapsedSpawnDelayMilliseconds += gameTime.ElapsedGameTime.Milliseconds;
            if (elapsedSpawnDelayMilliseconds >= TOTAL_SPAWN_DELAY_MILLISECONDS)
            {
                elapsedSpawnDelayMilliseconds = 0;
                bears.Add(GetRandomTeddyBear());
            }

            // update teddy bears
            for (int i = 0; i < bears.Count; i++)
            {
                bears[i].Update(gameTime);
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

            // draw teddy bears
            spriteBatch.Begin();

            for (int i = 0; i < bears.Count; i++)
            {
                bears[i].Draw(spriteBatch);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// Gets a random teddy bear
        /// </summary>
        /// <returns>random teddy bear</returns>
        private TeddyBear GetRandomTeddyBear()
        {
            Texture2D sprite = sprites[rand.Next(3)];
            return new TeddyBear(sprite,
                rand.Next(WINDOW_WIDTH - sprite.Width),
                rand.Next(WINDOW_HEIGHT - sprite.Height),
                WINDOW_WIDTH, WINDOW_HEIGHT);
        }
    }
}
