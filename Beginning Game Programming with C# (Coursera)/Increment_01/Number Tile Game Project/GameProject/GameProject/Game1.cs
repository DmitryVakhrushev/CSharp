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

        //------------------------------
        Texture2D ship;
        Rectangle shipTotalRect;

        Rectangle shipRect = new Rectangle();
        Rectangle shipSourceRec;
        //------------------------------

        // Increment 2: the board


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

            // load audio content


            // Increment 1: load opening screen and set opening screen draw rectangle
            openingScreen = Content.Load<Texture2D>("openingscreen");
            //opscrRectangle = new Rectangle(0, 0, openingScreen.Width, openingScreen.Height);
            opscrRectangle = new Rectangle(0, 0, WINDOW_WIDTH, WINDOW_HEIGHT);

            //--------------------------------------
            ship = Content.Load<Texture2D>("double_ship");

            

            shipTotalRect = new Rectangle(0, 0, ship.Width, ship.Height);

            //shipRect.Y = 300;
            //shipRect.Width = 90;
            //shipRect.Height = 90;

            //shipRect = new Rectangle(0, 0, 90, 90);
            shipRect = new Rectangle(300, 150, 200, 200);

            //shipSourceRec = new Rectangle(0, 0, 90, 90);
            shipSourceRec = new Rectangle(90, 30, 40, 40);

            //shipRect.Y = 300;

          

            //---------------------------------------


            // Increment 2: create the board object (this will be moved before you're done with the project)
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

            // Increment 2: change game state if game state is GameState.Menu and user presses Enter

            // if we're actually playing, update mouse state and update board

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
            
            spriteBatch.Draw(openingScreen, opscrRectangle, Color.White);

            
            //spriteBatch.Draw(ship, shipTotalRect, Color.White);

            spriteBatch.Draw(ship, shipRect, shipSourceRec, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }

        /// <summary>
        /// Starts a game
        /// </summary>
        void StartGame()
        {
            // randomly generate new number for game

            // create the board object (this will be moved before you're done)

        }
    }
}
