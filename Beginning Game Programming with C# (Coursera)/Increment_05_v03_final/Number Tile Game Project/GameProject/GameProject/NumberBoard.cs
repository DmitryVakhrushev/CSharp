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
    /// Class that encapsulates the board of number tiles to guess
    /// </remarks>
    class NumberBoard
    {
        #region Fields

        const int BORDER_SIZE = 8;
        const int NUM_COLUMNS = 3;
        const int NUM_ROWS = NUM_COLUMNS;

        // To draw the correct number on the board
        int actualTileNumber;

        // drawing support
        Texture2D boardTexture;
        Rectangle drawRectangle;

        // side length for each tile
        int tileSideLength;

        // tiles
        NumberTile[,] tiles = new NumberTile[NUM_ROWS, NUM_COLUMNS];


        bool correctNumber;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="contentManager">the content manager</param>
        /// <param name="center">the center of the board</param>
        /// <param name="sideLength">the side length for the board</param>
        /// <param name="correctNumber">the correct number</param>
        /// <param name="soundBank">the sound bank for sound effects</param>
        public NumberBoard(ContentManager contentManager, Vector2 center, int sideLength,
            int correctNumber, SoundBank soundBank)
        {
            // load content for the board and create draw rectangle
            LoadContent(contentManager);
            drawRectangle = new Rectangle(
                  (int)(center.X - sideLength / 2)
                , (int)(center.Y - sideLength / 2)
                , sideLength
                , sideLength);

            // calculate side length for number tiles
            //sideLength = 3 * tileSideLength + (3 + 1) * BORDER_SIZE;
            tileSideLength = (sideLength - 4 * BORDER_SIZE) / 3;

            actualTileNumber = 1;
            // initialize array of number tiles
            for (int i = 0; i < NUM_ROWS; i++)
            {
                for (int j = 0; j < NUM_COLUMNS; j++)
                {
                    //tiles[i, j] = new NumberTile(contentManager, CalculateTileCenter(i, j), tileSideLength, actualTileNumber, 8, null);
                    //tiles[i, j] = new NumberTile(contentManager, CalculateTileCenter(i, j), tileSideLength, actualTileNumber, correctNumber, null);
                    tiles[i, j] = new NumberTile(contentManager, CalculateTileCenter(i, j), tileSideLength, actualTileNumber, correctNumber, soundBank);
                    actualTileNumber++;
                }
            }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Updates the board based on the current mouse state. The only required action is to identify
        /// that the left mouse button has been clicked and update the state of the appropriate number
        /// tile.
        /// </summary>
        /// <param name="gameTime">the current GameTime</param>
        /// <param name="mouse">the current mouse state</param>
        /// <return>true if the correct number was guessed, false otherwise</return>
        public bool Update(GameTime gameTime, MouseState mouse)
        {
            // update all the number tiles
            for (int i = 0; i < NUM_ROWS; i++)
            {
                for (int j = 0; j < NUM_COLUMNS; j++)
                {
                    //step 52
                    //tiles[i, j].Update(gameTime, mouse);
                    correctNumber = tiles[i, j].Update(gameTime, mouse);

                    if (correctNumber)
                    {
                        //return true;
                        return correctNumber;
                    }
                    
                }
            }

            // return false because the correct number wasn't guessed
            return false;
        }

        /// <summary>
        /// Draws the board
        /// </summary>
        /// <param name="spriteBatch">the SpriteBatch to use for the drawing</param>
        public void Draw(SpriteBatch spriteBatch)
        {
            // draw the board
            spriteBatch.Draw(boardTexture, drawRectangle, Color.White);

            // draw all the number tiles
            for (int i = 0; i < NUM_ROWS; i++)
            {
                for (int j = 0; j < NUM_COLUMNS; j++)
                {
                    tiles[i, j].Draw(spriteBatch);
                }
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Loads the content for the board
        /// </summary>
        /// <param name="contentManager">the content manager</param>
        private void LoadContent(ContentManager contentManager)
        {
            // load the background for the board
            boardTexture = contentManager.Load<Texture2D>("board");
        }

        /// <summary>
        /// Calculates the center of the tile at the given row and column
        /// </summary>
        /// <param name="row">the row in the array</param>
        /// <param name="column">the column in the array</param>
        /// <returns>the center of the tile in the given row and column</returns>
        private Vector2 CalculateTileCenter(int row, int column)
        {
            int upperLeftX = drawRectangle.X + (BORDER_SIZE * (column + 1)) +
                tileSideLength * column;
            int upperLeftY = drawRectangle.Y + (BORDER_SIZE * (row + 1)) +
                tileSideLength * row;
            return new Vector2(upperLeftX + tileSideLength / 2,
                upperLeftY + tileSideLength / 2);
        }

        #endregion
    }
}
