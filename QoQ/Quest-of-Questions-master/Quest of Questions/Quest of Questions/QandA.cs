using System;
using System.Collections.Generic;
using System.Text;

namespace Quest_of_Questions
{
    class QandA
    {
        private string question;
        private string answer;
        //private int associationNumber;
        private int questionNumber;

        public int QuestionNumber
        {
            get
            {
                return this.questionNumber;
            }
            set
            {
                this.questionNumber = value;
            }
        }
        public string Question
        {
            get
            {
                return this.question;
            }
            set
            {
                this.question = value;
            }
        }
        public string Answer
        {
            get
            {
                return this.answer;
            }
            set
            {
                this.answer = value;
            }
        }
        //public int AssociationNumber
        //{
        //    get
        //    {
        //        return this.associationNumber;
        //    }
        //    set
        //    {
        //        this.associationNumber = value;
        //    }
        //}

        public QandA(int questionNumber, string question, string answer)
        {
            this.QuestionNumber = questionNumber;
            this.Question = question;
            this.Answer = answer;
            //this.AssociationNumber = associationNumber;
        }
    }
}
