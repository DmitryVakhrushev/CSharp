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

namespace ProgrammingAssignment2
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        const int WINDOW_WIDTH = 800;
        const int WINDOW_HEIGHT = 600;

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // STUDENTS: add your sprite variables here
        // Create 5 "Texture2D" variables
        Texture2D tomato;
        Texture2D pear;
        Texture2D banana;
        Texture2D kiwi;
        Texture2D cherry;

        // used to handle generating random values
        Random rand = new Random();
        const int CHANGE_DELAY_TIME = 1000;
        int elapsedTime = 0;

        // used to keep track of current sprite and location
        Texture2D currentSprite;
        Rectangle drawRectangle = new Rectangle();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Set the Width and Heigh of the canvas
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

            // STUDENTS: load the images here
            // Loading the images from the Content folder to the Texture2D variables
            tomato = Content.Load<Texture2D>("Tomato_100x100");
            pear = Content.Load<Texture2D>("Pear_100x100");
            banana = Content.Load<Texture2D>("Banana_100x100");
            kiwi = Content.Load<Texture2D>("Kiwi_100x100");
            cherry = Content.Load<Texture2D>("Cherry_100x100");

            // STUDENTS: set the currentSprite variable to one of the sprite variables
            currentSprite = tomato;

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

            elapsedTime += gameTime.ElapsedGameTime.Milliseconds;
            if (elapsedTime > CHANGE_DELAY_TIME)
            {
                elapsedTime = 0;

                // STUDENTS: Generate a random number between 0 and 4
                int spriteNumber = rand.Next(5);

                // STUDENTS
                // Assign the "currentSprite" variable to a sprite based on the generated random number between 0 and 4
                if (spriteNumber == 0)
                {
                    currentSprite = tomato;
                }
                else if (spriteNumber == 1)
                {
                    currentSprite = pear;
                }
                else if (spriteNumber == 2)
                {
                    currentSprite = banana;
                }
                else if (spriteNumber == 3)
                {
                    currentSprite = kiwi;
                }
                else if (spriteNumber == 4)
                {
                    currentSprite = cherry;
                }

                // STUDENTS: Set drawRectangle.X to a random number between 0
                // the preferred backbuffer width - the width of the current sprite 
                
                int x = rand.Next(WINDOW_WIDTH - currentSprite.Width);
                drawRectangle.X = x;

                // STUDENTS: uncomment the line below to set drawRectangle.Y to a random number between 0
                // the preferred backbuffer height - the height of the current sprite

                int y = rand.Next(WINDOW_HEIGHT - currentSprite.Height);
                drawRectangle.Y = y;

                // STUDENTS: set the drawRectangle.Width and drawRectangle.Height to match the width and height of currentSprite
                drawRectangle.Height = currentSprite.Height;
                drawRectangle.Width = currentSprite.Width;
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

            // STUDENTS: draw "currentSprite" on the canvas
            spriteBatch.Begin();
            spriteBatch.Draw(currentSprite, drawRectangle, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
