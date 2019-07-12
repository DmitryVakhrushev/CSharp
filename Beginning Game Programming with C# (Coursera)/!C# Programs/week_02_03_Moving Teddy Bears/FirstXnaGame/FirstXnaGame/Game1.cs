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

//------------------------------------------------------
//-- import the TeddyBear class from TeddyBear.cs file

using Lab6;
//------------------------------------------------------

namespace FirstXnaGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // define WIDTH and HEIGHT constants
        const int WINDOW_WIDTH = 800;
        const int WINDOW_HEIGHT = 600;

        // teddy bear drawing support
        // This time we have the Class TeddyBear, so we do not need to use Texture2D and Rectangle

        TeddyBear bear0;
        TeddyBear bear1;
        TeddyBear bear2;

        TeddyBear sql1;

        //Texture2D bear0; // object "bear0" to hold pictures
        //Rectangle drawRectangle0; // object "drawRectangle0" to hold "bear0"


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // change resolution to 800 by 600
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

            // TODO: use this.Content to load your game content here
            //--------------------------------------------
            // load teddy bears and build draw rectangles
            //drawRectangle0 = new Rectangle(150, 100, 200, 200);

            bear0 = new TeddyBear(Content, "teddybear0",100,100,WINDOW_WIDTH,WINDOW_HEIGHT);
            bear1 = new TeddyBear(Content, "teddybear1", 300, 10, WINDOW_WIDTH, WINDOW_HEIGHT);
            bear2 = new TeddyBear(Content, "teddybear2", 450,200, WINDOW_WIDTH, WINDOW_HEIGHT);

            sql1 = new TeddyBear(Content, "sqlserver", 550, 320, WINDOW_WIDTH, WINDOW_HEIGHT);

            //bear0 = Content.Load<Texture2D>("teddybear0");
            //drawRectangle0 = new Rectangle(150, 100, bear0.Width, bear0.Height);

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

            // TODO: Add your update logic here
            // update a teddy bear position

            bear0.Update();
            bear1.Update();
            bear2.Update();

            sql1.Update();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            // draw teddy bears
            
            spriteBatch.Begin();

            bear0.Draw(spriteBatch);
            bear1.Draw(spriteBatch);
            bear2.Draw(spriteBatch);

            sql1.Draw(spriteBatch);

            //spriteBatch.Draw(bear0, drawRectangle0, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
