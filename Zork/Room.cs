﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zork
{
    class Room
    {
        public string Name { get; }

        public string Description { get; set; }

        public Room(string name, string description = "")
        {
            Name = name;
            Description = description;
        }

        private static readonly Room[,] Rooms = {
            { new Room("Rocky Trail"), new Room("South of House"), new Room("Canyon View") },
            { new Room("Forest"), new Room("West of House"), new Room("Behind House") },
            { new Room("Dense Woods"), new Room("North of House"), new Room("Clearing") }
        };

        private static void InitializeRoomDescriptions()
        {
            Rooms[0, 0].Description = "You are in a rock-strewn trail.";                                                                                //Rocky Trail
            Rooms[0, 1].Description = "You are facing the south side of a white house. There is no door here, and all the windows are barred.";         //South of House
            Rooms[0, 2].Description = "You are at the top of the Great Canyon on its south wall.";                                                      //Canyon View

            Rooms[1, 0].Description = "This is a forest, with trees in all directions around you.";                                                     //Forest
            Rooms[1, 1].Description = "This is an open field west of a white house, with a boarded front door.";                                        //West of House
            Rooms[1, 2].Description = "You are behind the white house. In one corner of the house there is a small window which is slightly ajar.";     //Behind House

            Rooms[2, 0].Description = "This is a dimly lit forest, with large trees all around. To the east, there appears to be sunglight.";           //Dense Woods
            Rooms[2, 1].Description = "You are facing the north side of a white house. There is no door here, and all the windows are barred.";         //North of House
            Rooms[2, 2].Description = "You are in a clearing, with a forest surrounding you on the west and south.";                                    //Clearing
        }
    }
}
