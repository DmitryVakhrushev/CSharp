﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace __Explore_the_House
{
    public class Room : Location {
        private string decoration;

        public Room(string name, string decoration)
            : base(name)
        {
            this.decoration = decoration;
        }

        public override string Description {
            get
            {
                return base.Description + " You see " + decoration + ".";
            }
        }
    }
}
