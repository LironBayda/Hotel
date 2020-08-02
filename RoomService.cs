using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class RoomService
    {
        internal void CleanRoom(RoomForTwo roomForTwo)
        {
            // we cant set directly isClean parameters therefore we use isClean function that change 
            //the value of the parameter. the if check that the room clean. 

            if (!roomForTwo.isClean())
                roomForTwo.isClean();
            Console.WriteLine($"{roomForTwo.GetFeatures()} is clean now");
        }

        internal void CleanRoom(FamilyRoom familyRoom )
        {
            // we cant set directly isClean parameters therefore we use isClean function that change 
            //the value of the parameter. the if check that the room clean. 


            if (!familyRoom.isClean())
                familyRoom.isClean();

            Console.WriteLine($"{familyRoom.GetFeatures()} is clean now");

        }

        internal void CleanRoom( Suite suite)
        {
            // we cant set directly isClean parameters therefore we use isClean function that change 
            //the value of the parameter. the if check that the room clean. 


            if (!suite.isClean())
                suite.isClean();

            Console.WriteLine($"{suite.GetFeatures()} is clean now");

        }
    }
}
