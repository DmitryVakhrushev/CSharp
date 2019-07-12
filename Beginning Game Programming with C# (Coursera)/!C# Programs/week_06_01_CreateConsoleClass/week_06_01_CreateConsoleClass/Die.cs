using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week_06_01_CreateConsoleClass
{
    /// <summary>
    /// A die
    /// </summary>
    class Die
    {
        #region Fields -- fields to store the state internally

        private int _numSides;
        private int _topSide;
        Random rand = new Random();
        
        #endregion

        #region Constructors

        /// <summary>
        /// Standard Constructor
        /// </summary>
        public Die():this(6) // Constructors are always have the NAME OF THE CLASS
        {
        }

        /// <summary>
        /// Constructor with num sodes specified
        /// </summary>
        /// <param name="numSides">number of sides for die</param>
        public Die (int numSides)
        {
            this._numSides = numSides;
            this._topSide = 3;
        }

        #endregion

        #region Properties
        // 1. Properties are CAPITALIZED
        // 2. Use "return" keyword for the GET method
        // 3. Use "value" keyword for the SET method

        ///<summary>
        /// Gets the number of sides
        ///</summary> 
        public int NumSides
        {
            get { return _numSides;}
            //set { _numSides = value; } // we do not need to change the number of the die later on
        }

        ///<summary>
        /// Gets the Top Side
        ///</summary>
        public int TopSide
        {
            get { return _topSide; }
        }
        #endregion

        #region Methods
        
        /// <summary>
        /// Rolls the die
        /// </summary>
        public void Roll()
        {
            this._topSide = rand.Next(1, this._numSides + 1);
            Console.WriteLine("Top side after Rolling a Die: " + this.TopSide);
        }
        
        #endregion
    }
}
