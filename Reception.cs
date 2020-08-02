using Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public static class Reception
    {
         const  int NUMBER_OF_ROOM=100;
        static int numberOfGuests=0;
        static Room[] rooms=new Room [NUMBER_OF_ROOM];
       
        static RoomService RoomService=new RoomService();

      
        public static Room CheckIn(Guest guest)
        {
            Random gen = new Random();

            //frist tine we check in we need to create rooms element
            if (rooms[0] == null)
            {
                for (int i = 0; i < rooms.Length; i++)
                {
                    Room room = null;
                    int type = gen.Next(0, 3);


                    switch (type)
                    {

                        case 0:
                            room = new Suite(i, null, true);
                            break;
                        case 1:
                            room = new FamilyRoom(i, null, true);
                            break;
                        case 2:
                            room = new RoomForTwo(i, null, true);
                            break;

                    }

                    rooms[i] = room;

                }

            }
            int room_num;

            do
            {
                room_num = gen.Next(0, NUMBER_OF_ROOM);
            }
            while (rooms[room_num].GetGuest()!= null);
            
               rooms[room_num].SetGuest(guest);

            numberOfGuests++;
            return rooms[room_num];
        }

        public static void CheckOut(Room room)
        {
            room.SetGuest(null);
            numberOfGuests--;
        }

        public static bool isRoomFree(Room room)
        {
            return room.GetGuest() == null;
        }

        //canot convert from Hotel.Room to Hotel.RoomForTwo therefore i write tree function.
        private static void sendRoomService(RoomForTwo room)
        {
            RoomService.CleanRoom(room);
        }

        private static void sendRoomService(Suite room)
        {
            RoomService.CleanRoom(room);
        }

        private static void sendRoomService(FamilyRoom room)
        {
            RoomService.CleanRoom(room);
        }

    }
}
