using Client;
using System;

namespace Hotel
{
    public abstract  class Room
    {
        protected int _roonNumber;
        protected float _price;
        protected Client.Guest _guest;
        protected bool _isClean;
        protected string _features;

        protected Room(int roonNumber, Guest guest)
        {
            _roonNumber = roonNumber;
            SetPrice ();
            _guest=guest;
            _isClean = true;
            SetFeatures();
        }
        
        internal void SetGuest(Client.Guest guest)
        {
            _guest = guest;
        }

        virtual protected void SetPrice()
        {
            _price = 50;
            if (DateTime.Now.Month == 7 || DateTime.Now.Month == 8)
                _price += 25;

        }
        abstract protected void SetFeatures();

        public int GetRoomNumber()
        {
            return _roonNumber;
        }

        public float GetPrice()
        {
            return _price;
        }

        public Client.Guest GetGuest()
        {
            return _guest;
        }

        /// <summary>
        /// change the isClean and return the new value
        /// </summary>
        /// <returns></returns>
        public bool isClean()
        {
            if (_isClean)
                _isClean = false;
            else
                _isClean = true;
                
            return _isClean;
        }

        public string GetFeatures()
        {
            return _features;
        }

        public override string ToString()
        {
            return base.ToString()+$"_price: {_price}_isClean{_isClean} _roonNumber {_roonNumber}" +
                $"{_guest.ToString()} _features {_features}";

            
        }

    }
}
