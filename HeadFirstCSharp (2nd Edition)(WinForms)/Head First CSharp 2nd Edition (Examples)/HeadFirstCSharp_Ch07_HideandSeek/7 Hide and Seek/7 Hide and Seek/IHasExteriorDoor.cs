using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace __Hide_and_Seek
{
    public interface IHasExteriorDoor
    {
        string DoorDescription { get; }
        Location DoorLocation { get; set; }
    }
}
