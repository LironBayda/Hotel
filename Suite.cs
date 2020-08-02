using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Suite:Room
    {
        public Suite(int roonNumber, Client.Guest guest, bool isClean) : base(roonNumber, guest)
        {

        }
        protected override void SetFeatures()
        {
            _features = "TV, Minibar, jacuzzi";
        }

        override protected void SetPrice()
        {
            _price = 150;
            if (DateTime.Now.Month == 7 || DateTime.Now.Month == 8)
                _price += 25;

        }
    }
}
