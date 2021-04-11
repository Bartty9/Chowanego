using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chowanego
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
        public RoomWithDoor(string name, string decoration, string hidingPlaceName, string doorDescription) : base(name, decoration, hidingPlaceName)
        {
            DoorDescription = doorDescription;
        }
        public override string Description => base.Description + " Widzisz też " + DoorDescription + ".";
    }
}
