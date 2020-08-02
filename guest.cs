using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
   public class Guest
    {
        int _id;
        string _name;

        public Guest(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public override string ToString()
        {
            return base.ToString()+ $" _id: {_id} _name:{_name}";
        }
    }
}
