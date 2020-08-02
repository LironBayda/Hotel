using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class RoomForTwo : Room
    {

        public RoomForTwo(int roonNumber,Client.Guest guest,bool isClean) :base(roonNumber,guest)
        {
            
        }
        protected override void SetFeatures()
        {
           _features="TV, Minibar";
        }
    }
}
