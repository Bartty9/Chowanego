using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chowanego
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public string HidingPlaceName { get; private set; }
        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName) : base(name, decoration)
        {
            this.HidingPlaceName = hidingPlaceName;
        }
        public override string Description => base.Description + " Ktoś może ukrywać się " + HidingPlaceName + ".";
    }
}
