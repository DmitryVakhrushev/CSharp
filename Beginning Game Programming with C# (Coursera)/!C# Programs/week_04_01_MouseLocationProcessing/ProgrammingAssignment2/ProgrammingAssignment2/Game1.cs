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
        Texture2D character0;
        Texture2D character1;
        Texture2D character2;
        Texture2D character3;
        Texture2D character4;

        // click support - to store the previous button state
        ButtonState previousButtinState = ButtonState.Released;

        // previous character selection
        int previousCharacterSelection = 0;


        // used to handle generating random values
        Random rand = new Random();

        //const int CHANGE_DELAY_TIME = 500;
        //int elapsedTime = 0;

        // used to keep track of current sprite and location
        Texture2D currentCharacter;
        Rectangle drawRectangle = new Rectangle();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            // Set the Width and Heigh of the canvas
            // Set mouse cursor to be visible
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

            // STUDENTS: load the images here
            // Loading the images from the Content folder to the Texture2D variables
            character0 = Content.Load<Texture2D>("Tomato_100x100");
            character1 = Content.Load<Texture2D>("Pear_100x100");
            character2 = Content.Load<Texture2D>("Banana_100x100");
            character3 = Content.Load<Texture2D>("Kiwi_100x100");
            character4 = Content.Load<Texture2D>("Cherry_100x100");

            // set currentCharacter to one of the sprite variables
            currentCharacter = character0;


            // build drawRectangle for the "character0" at the center of the window
            drawRectangle.X = WINDOW_WIDTH / 2 - currentCharacter.Width / 2;
            drawRectangle.Y = WINDOW_HEIGHT / 2 - currentCharacter.Height / 2;
            drawRectangle.Height = currentCharacter.Height;
            drawRectangle.Width = currentCharacter.Width;

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

            // Make character follow the mouse 
            MouseState mouse = Mouse.GetState();
            drawRectangle.X = mouse.X - currentCharacter.Width / 2;
            drawRectangle.Y = mouse.Y - currentCharacter.Height / 2;

            // clamp character in window
            if (drawRectangle.Left < 0)
            {
                drawRectangle.X = 0;
            }

            if (drawRectangle.Right > WINDOW_WIDTH)
            {
                drawRectangle.X = WINDOW_WIDTH - drawRectangle.Width;
            }

            if (drawRectangle.Top < 0)
            {
                drawRectangle.Y = 0;
            }

            if (drawRectangle.Bottom > WINDOW_HEIGHT)
            {
                drawRectangle.Y = WINDOW_HEIGHT - drawRectangle.Height;
            }


            //elapsedTime += gameTime.ElapsedGameTime.Milliseconds;
            //if (elapsedTime > CHANGE_DELAY_TIME)
            //{
            //    elapsedTime = 0;
 

            // Change character on Left mouse CLICK (NOT LEFT MOUSE PRESS !!!)
            // Here we are detecting a click
            if (mouse.LeftButton == ButtonState.Released &&
                previousButtinState == ButtonState.Pressed)
            {

                //left mouse PRESS code - BAD
                //if (mouse.LeftButton == ButtonState.Pressed)
                //{

                // Generate a random number between 0 and 4
                int spriteNumber;
                
                do
                {
                    spriteNumber = rand.Next(5);
                } while (spriteNumber == previousCharacterSelection);

                previousCharacterSelection = spriteNumber; // current sprite number

                //Assign the "currentSprite" variable to a sprite based on the generated random number between 0 and 4
                if (spriteNumber == 0)
                {
                    currentCharacter = character0;
                }
                else if (spriteNumber == 1)
                {
                    currentCharacter = character1;
                }
                else if (spriteNumber == 2)
                {
                    currentCharacter = character2;
                }
                else if (spriteNumber == 3)
                {
                    currentCharacter = character3;
                }
                else if (spriteNumber == 4)
                {
                    currentCharacter = character4;
                }

            } // end of if (mouse.LeftButton == ButtonState.Released && previousButtinState == ButtonState.Pressed)

            previousButtinState = mouse.LeftButton; // override the current state of the left button

            //}

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
            spriteBatch.Draw(currentCharacter, drawRectangle, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
