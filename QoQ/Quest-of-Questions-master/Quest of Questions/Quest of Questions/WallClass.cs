using System;
using System.Collections.Generic;
using System.Text;

namespace Quest_of_Questions
{
    class WallClass
    {
        private string wallMessage;
        private string wallName;
        private int wallNumber;

        public string WallMessage { get => wallMessage; set => wallMessage = value; }
        public string WallName { get => wallName; set => wallName = value; }
        public int WallNumber { get => wallNumber; set => wallNumber = value; }

        public WallClass(int wallNumber, string wallName, string wallMessage)
        {
            this.WallNumber = wallNumber;
            this.WallName = wallName;
            this.WallMessage = wallMessage;
        }
    }
}
