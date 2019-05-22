using System;
using System.Collections.Generic;
using System.Text;

namespace Quest_of_Questions
{
    class HelperClass
    {
        private string helperName;
        private string helperInfo;
        private int helperNumber;
        public List<QandA> QA = new List<QandA>();


        public string HelperName
        {
            get
            {
                return helperName;
            }
            set
            {
                this.helperName = value;
            }
        }
        public string HelperInfo
        {
            get
            {
                return helperInfo; 
            }
            set
            {
                this.helperInfo = value;
            }
        }
        public int HelperNumber
        {
            get
            {
                return helperNumber;
            }
            set
            {
                this.helperNumber = value;
            }
        }

        public HelperClass(int helperNumber, string helperName, string helperInfo)
        {
            this.HelperNumber = helperNumber;
            this.HelperName = helperName;
            this.HelperInfo = helperInfo;
        }

        
    }
}
