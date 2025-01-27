﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework.Graphics; // Texture2D
using Microsoft.Xna.Framework; // Rectangle
using Microsoft.Xna.Framework.Input; // MouseState

namespace RubberChicken
{
    /// <summary>
    /// A rubber chicken class
    /// </summary>
    class RubberChicken
    {
        #region Fields

        bool active = true;
        int damage;
        //drawing support fields
        Texture2D sprite;
        Rectangle drawRectangle;

        // moving support
        Vector2 velocity = Vector2.Zero; // explicitly say that this is a (0,0) vector
        const int RUBBER_CHICKEN_SPEED = 1;

        // click processing
        bool clickStarted = false;
        bool buttonReleased = true;
        bool moving = false;

        #endregion

        #region Constructors
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="sprite">sprite</param>
        /// <param name="location">location of center</param>
        /// <param name="damage">damage from rubber chicken</param>
        public RubberChicken(Texture2D sprite, Vector2 location, int damage)
        {
            this.sprite = sprite;
            this.damage = damage;

            // build draw rectangle
            drawRectangle = new Rectangle(
                  (int)location.X - sprite.Width/2
                , (int) location.Y - sprite.Height / 2
                ,sprite.Width
                ,sprite.Height);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets and sets whether the rubber chicken is active
        /// </summary>
        /// <returns></returns>
        public bool Active
        {
            get { return active; }
            set { active = value; }
        }

        /// <summary>
        /// Gets the collision rectangle of the rubber chicken
        /// </summary>
        public Rectangle CollisionRectangle
        {
            get { return drawRectangle; }
        }

        /// <summary>
        /// Gets the damage rubber chicken inflicts
        /// </summary>
        public int Damage
        {
            get { return damage; }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Draws the rubber chicken
        /// </summary>
        /// <param name="spriteBach">sprite batch</param>
        public void Draw(SpriteBatch spriteBach)
        {
            spriteBach.Draw(sprite, drawRectangle, Color.White);
        }

        /// <summary>
        /// Updates rubber chicken, moving and launching when clicked
        /// </summary>
        /// <param name="gameTime">game time</param>
        /// <param name="mouse">mouse state</param>
        public void Update(GameTime gameTime, MouseState mouse)
        { 
        // move based on velocity
            drawRectangle.X += (int)(velocity.X * gameTime.ElapsedGameTime.Milliseconds);
            drawRectangle.Y += (int)(velocity.Y * gameTime.ElapsedGameTime.Milliseconds);
        
        // launched on click
        // check for the mouse over rubber chicken
            if (drawRectangle.Contains(mouse.X, mouse.Y))
            {
                // for click started on rubber chicken
                if (mouse.LeftButton == ButtonState.Pressed &&
                    buttonReleased)
                {
                    clickStarted = true;
                    buttonReleased = false;
                }
                else if (mouse.LeftButton == ButtonState.Released)
                {
                    buttonReleased = true;

                    // if click finished on rubber chicken, change game state
                    if (clickStarted)
                    {
                     // launch if not already moving
                        if (!moving)
                        {
                            moving = true;
                            velocity = new Vector2(0, -1 * RUBBER_CHICKEN_SPEED);
                        }
                    clickStarted = false;
                    }
                }
            }

            else
            { 
            // no clicking on rubber chicken
                clickStarted = false;
                buttonReleased = false;
            }
        }

        #endregion

    }
}
