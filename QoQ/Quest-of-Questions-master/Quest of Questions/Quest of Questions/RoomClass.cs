
using System;
using System.Collections.Generic;
using System.Text;

namespace Quest_of_Questions
{
    class RoomClass
    {
        private int roomNumber;
        private string roomName;
        private string roomDescription;
        private int toNorth;
        private int toEast;
        private int toSouth;
        private int toWest;
        private int toUp;
        private int toDown;
        private bool visited;
        private bool hasHelper;
        private bool hasMonster;
        private bool riddleSolved;
        public List<ItemClass> roomItem = new List<ItemClass>();
        public List<RiddleClass> riddle = new List<RiddleClass>();
        public List<WallClass> wall = new List<WallClass>();
        //public List<MonsterClass> monster = new List<MonsterClass>();

        //public List<HelperClass> helper = new List<HelperClass>();
        //public List<NoteClass> roomNote = new List<NoteClass>();
        public HelperClass[] helper = new HelperClass[50];
        public MonsterClass[] monster = new MonsterClass[50];




        public int RoomNumber
        {
            get
            {
                return roomNumber;
            }
            set
            {
                this.roomNumber = value;
            }
        }
        public string RoomName
        {
            get
            {
                return roomName;
            }
            set
            {
                this.roomName = value;
            }
        }

        public string RoomDescription
        {
            get
            {
                return roomDescription;
            }
            set
            {
                this.roomDescription = value;
            }
        }
        public int ToNorth
        {
            get
            {
                return toNorth;
            }
            set
            {
                this.toNorth = value;
            }
        }
        public int ToEast
        {
            get
            {
                return toEast;
            }
            set
            {
                this.toEast = value;
            }
        }
        public int ToSouth
        {
            get
            {
                return toSouth;
            }
            set
            {
                this.toSouth = value;
            }
        }
        public int ToWest

        {
            get
            {
                return toWest;
            }
            set
            {
                this.toWest = value;
            }
        }
        public int ToUp
        {
            get
            {
                return toUp;
            }
            set
            {
                this.toUp = value;
            }
        }
        public int ToDown
        {
            get
            {
                return toDown;
            }
            set
            {
                this.toDown = value;
            }
        }
        public bool Visited
        {
            get
            {
                return visited;
            }
            set
            {
                this.visited = value;
            }
        }
        public bool HasHelper
        {
            get
            {
                return hasHelper;
            }
            set
            {
                this.hasHelper = value;
            }
        }
        public bool HasMonster
        {
            get
            {
                return hasMonster;
            }
            set
            {
                this.hasMonster = value;
            }
        }

        public bool RiddleSolved { get => riddleSolved; set => riddleSolved = value; }

        public RoomClass(bool riddleSolved, bool hasMonster, bool hasHelper, int toNorth, int toEast, int toSouth, int toWest, int toUp, int toDown,
            string roomName, string roomDescription)
        {
            this.RiddleSolved = riddleSolved;
            this.HasMonster = hasMonster;
            this.HasHelper = hasHelper;
            this.RoomName = roomName;
            this.RoomDescription = roomDescription;
            this.ToNorth = toNorth;
            this.ToEast = toEast;
            this.ToSouth = toSouth;
            this.ToWest = toWest;
            this.ToUp = toUp;
            this.ToDown = toDown;
            this.Visited = false;
        }

        //public string roomItem()
        //{

        //}
        public string visitRoom()
        {
            string info = roomName;
            if (visited != true)
            {
                visited = true;
                info += " " + roomDescription;
            }
            info += " You See an Exit to the: ";
            if (this.toNorth >= 1 && this.toNorth <= 100)
            {
                info += "N ";
            }
            if (this.toEast >= 1 && this.toEast <= 100)
            {
                info += "E ";
            }
            if (this.toSouth >= 1 && this.toSouth <= 100)
            {
                info += "S ";
            }
            if (this.toWest >= 1 && this.toWest <= 100)
            {
                info += "W ";
            }
            if (this.toUp >= 1 && this.toUp <= 100)
            {
                info += "U ";
            }
            if (this.toDown >= 1 && this.toDown <= 100)
            {
                info += "D ";
            }

            if (this.roomItem.Count > 0)
            {
                info += "\n In the room you see:";
                foreach (ItemClass item in roomItem)
                {
                    if(item.ItemNumber >= 0)
                    {
                        info += item.ItemName + "; ";
                    }
                    else
                    {
                        info += "You must solve the riddle to be able to get " + item.ItemName + "; "; 
                    }
                    
                }
            }
            
            
            
            return info;
        }

        

        /*public string ReadNote()
        {
            string info = " ";
            if (this.roomNote.Count > 0)
            {
                foreach (NoteClass note in roomNote)
                {
                    info = note.NoteNumber + "      " + note.NoteTitle + "      " + note.NoteMessage;
                }
            }
            return info;
        }*/

        }
}
