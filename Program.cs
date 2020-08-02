using Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porgram_part
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.Guest guest1 = new Client.Guest(5674674,"gal");
            Client.Guest guest2 = new Client.Guest(56756674, "tal");
            Client.Guest guest3 = new Client.Guest(5567835, "sal");

            Hotel.Room room1=Hotel.Reception.CheckIn(guest1);
            Hotel.Room room2 = Hotel.Reception.CheckIn(guest2);
            Hotel.Room room3 = Hotel.Reception.CheckIn(guest3);

            Console.WriteLine(room1.ToString());
            Console.WriteLine(room2.ToString());
            Console.WriteLine(room3.ToString());

           Hotel.Reception.CheckOut(room1);

            room1 = Hotel.Reception.CheckIn(guest1);

            Console.WriteLine();
            Console.WriteLine(room1.ToString());
            Console.WriteLine(room2.ToString());
            Console.WriteLine(room3.ToString());


            Console.ReadLine();

        }
    }
}
