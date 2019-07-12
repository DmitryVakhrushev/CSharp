
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameProject
{
    /// <remarks>
    /// A number tile
    /// </remarks>
    class NumberTile
    {
        #region Fields

        // original length of each side of the tile
        int originalSideLength;

        // whether or not this tile is the correct number
        bool isCorrectNumber;

        // drawing support
        Texture2D texture;
        Rectangle drawRectangle;
        Rectangle sourceRectangle;

        // step 40 - declare blinking texture
        Texture2D blinkingTexture;

        //Step 42 - declare Texture2D to hold the "current" texture
        Texture2D currentTexture;

        // blinking support
        const int TOTAL_BLINK_MILLISECONDS = 2000; // originally was 4000
        int elapsedBlinkMilliseconds = 0;
        const int FRAME_BLINK_MILLISECONDS = 500; // originally was 1000
        int elapsedFrameMilliseconds = 0;

        // Increment 4. Shrinking support
        const int TOTAL_SHRINK_MILLISECONDS = 4000;
        int elapsedShrinkMilliseconds = 0;

        // Increment 4. Tile: visible, blinking, shrinking
        bool tileVisible = true;
        bool tileBlinking = false;
        bool tileShrinking = false;

        // Click detection fields
        bool clickStarted = false;
        bool buttonReleased = true;

        // Sound support
        SoundBank _soundBank;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="contentManager">the content manager</param>
        /// <param name="center">the center of the tile</param>
        /// <param name="sideLength">the side length for the tile</param>
        /// <param name="number">the number for the tile</param>
        /// <param name="correctNumber">the correct number</param>
        /// <param name="soundBank">the sound bank for playing cues</param>
        public NumberTile(ContentManager contentManager, Vector2 center, int sideLength,
            int number, int correctNumber, SoundBank soundBank)
        {
            // set original side length field
            this.originalSideLength = sideLength;

            // Step 67 -- set sound bank field
            this._soundBank = soundBank;

            // load content for the tile and create draw rectangle
            LoadContent(contentManager, number);
            drawRectangle = new Rectangle(
                 (int)center.X - sideLength / 2
                ,(int)center.Y - sideLength / 2
                ,sideLength
                ,sideLength);

            // set isCorrectNumber flag
            isCorrectNumber = number == correctNumber;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Updates the tile based on game time and mouse state
        /// </summary>
        /// <param name="gameTime">the current GameTime</param>
        /// <param name="mouse">the current mouse state</param>
        /// <return>true if the correct number was guessed, false otherwise</return>
        public bool Update(GameTime gameTime, MouseState mouse)
        {
            // Increment 4. Step 37. Shrink a tile if it was clicked
            if (tileBlinking)
            {
                elapsedBlinkMilliseconds += gameTime.ElapsedGameTime.Milliseconds;
                if (elapsedBlinkMilliseconds > TOTAL_BLINK_MILLISECONDS)
                {
                    return true;
                }

                else
                {
                    elapsedFrameMilliseconds += gameTime.ElapsedGameTime.Milliseconds;
                    if (elapsedFrameMilliseconds > FRAME_BLINK_MILLISECONDS)
                    {
                        if (sourceRectangle.X == 0)
                        {
                            sourceRectangle.X = texture.Width / 2;
                        }
                        else
                        {
                            sourceRectangle.X = 0;
                        }
                        elapsedFrameMilliseconds = 0;
                    }   
                }
            }


            else if (tileShrinking)
            {
                elapsedShrinkMilliseconds += gameTime.ElapsedGameTime.Milliseconds;
                float ratio = (float)(TOTAL_SHRINK_MILLISECONDS - elapsedShrinkMilliseconds) / TOTAL_SHRINK_MILLISECONDS;

                if (ratio > 0)
                {
                    drawRectangle.Width = (int)(drawRectangle.Width * ratio);
                    drawRectangle.Height = (int)(drawRectangle.Height * ratio);
                }
                else
                {
                    tileVisible = false;
                }
            }

            else
            {
                // check for mouse over button
                if (drawRectangle.Contains(mouse.X, mouse.Y))
                {
                    sourceRectangle.X = texture.Width / 2;

                    // check for click started on button
                    if (mouse.LeftButton == ButtonState.Pressed && buttonReleased)
                    {
                        clickStarted = true;
                        buttonReleased = false;
                    }
                    else if (mouse.LeftButton == ButtonState.Released)
                    {
                        buttonReleased = true;

                        // if click finished on the tile, change game state
                        if (clickStarted)
                        {
                            // player clicks on the tile and the tile corresponds to the correct number --> "blinking" = true
                            // The texture starts blinking and "correctGuess" sound is played
                            if (isCorrectNumber)
                            {
                                this.tileBlinking = true;
                                _soundBank.PlayCue("correctGuess");
                                currentTexture = blinkingTexture;
                                sourceRectangle.X = 0;
                            }

                            // if the guess is not correct the tile is shrinking
                            else
                            {
                                this.tileShrinking = true;
                                _soundBank.PlayCue("incorrectGuess");
                            }

                            clickStarted = false;
                        }
                    }
                }

                else
                {
                    // if no clicking happened on this tile
                    sourceRectangle.X = 0;
                    clickStarted = false;
                    buttonReleased = false;
                }
            }
            // if we get here, return false
            return false;
        }

        /// <summary>
        /// Draws the number tile
        /// </summary>
        /// <param name="spriteBatch">the SpriteBatch to use for the drawing</param>
        public void Draw(SpriteBatch spriteBatch)
        {
            // draw the tile if it's visible
            if (tileVisible)
            {
                // step 44 -- draw "currentTexture"
                spriteBatch.Draw(currentTexture, drawRectangle, sourceRectangle, Color.White);
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Loads the content for the tile
        /// </summary>
        /// <param name="contentManager">the content manager</param>
        /// <param name="number">the tile number</param>
        private void LoadContent(ContentManager contentManager, int number)
        {
            // convert the number to a string
            string numberString = ConvertIntToString(number);

            // load content for the tile and set source rectangle
            texture = contentManager.Load<Texture2D>(numberString);
            sourceRectangle = new Rectangle(0, 0, texture.Width / 2, texture.Height);

            // step 41 -- load blinking tile texture
            blinkingTexture = contentManager.Load<Texture2D>("blinking"+numberString);

            // step 42 -- set the current texture to non-blinking texture
            currentTexture = texture;
        }

        /// <summary>
        /// Converts an integer to a string for the corresponding number
        /// </summary>
        /// <param name="number">the integer to convert</param>
        /// <returns>the string for the corresponding number</returns>
        private String ConvertIntToString(int number)
        {
            switch (number)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new Exception("Unsupported number for number tile");
            }
        }

        #endregion
    }
}
