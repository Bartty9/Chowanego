using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chowanego
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public string HidingPlaceName { get; }
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName) : base(name, hot)
        {
            this.HidingPlaceName = hidingPlaceName;
        }
        public override string Description => base.Description + " Ktoś może ukrywać się " + HidingPlaceName + ".";
    }
}
