using System;
using System.Collections.Generic;
using System.Text;

namespace Quest_of_Questions
{
    class RiddleClass
{
        private string riddle;
        private string riddleAnswer;
        private int riddleNumber;
        private int writtenNumber;
        private int tryCount;
        private bool isSolved;

        public int RiddleNumber
        {
            get
            {
                return this.riddleNumber;
            }
            set
            {
                this.riddleNumber = value;
            }
        }
        public int TryCount
        {
            get
            {
                return this.tryCount;
            }
            set
            {
                this.tryCount = value;
            }
        }
        public string Riddle
        {
            get
            {
                return this.riddle;
            }
            set
            {
                this.riddle = value;
            }
        }
        public string RiddleAnswer
        {
            get
            {
                return this.riddleAnswer;
            }
            set
            {
                this.riddleAnswer = value;
            }
        }
        public bool IsSolved
        {
            get
            {
                return this.isSolved;
            }
            set
            {
                this.isSolved = value;
            }
        }

        public int WrittenNumber { get => writtenNumber; set => writtenNumber = value; }

        public RiddleClass(int riddleNumber, int writtenNumber, int tryCount, string riddle, string riddleAnswer, bool isSolved)
        {
            this.RiddleNumber = riddleNumber;
            this.WrittenNumber = writtenNumber;
            this.TryCount = tryCount;
            this.Riddle = riddle;
            this.RiddleAnswer = riddleAnswer;
            this.IsSolved = isSolved;
            //this.AssociationNumber = associationNumber;
        }
    }
}
