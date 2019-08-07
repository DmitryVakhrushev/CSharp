using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace __Explore_the_House
{
    public interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
}
