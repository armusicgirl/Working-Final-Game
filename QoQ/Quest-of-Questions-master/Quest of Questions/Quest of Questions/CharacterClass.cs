using System;
using System.Collections.Generic;
using System.Text;

namespace Quest_of_Questions
{
    class CharacterClass
    {

        private string characterName;
        private string specialCharacter;
        private string characterInfo;
        private int maxHealth;
        private double health;
        private int goldHolding;
        private int itemHoldingNumber;
        private int itemLimit;
        private int characterStrength;
        private int characterNumber;
        


         public string CharacterName
        {
            get
            {
                return this.characterName;
            }
            set
            {
                this.characterName = value;
            }
        }

        public string SpecialCharacter
        {
            get
            {
                return this.specialCharacter;
            }
            set
            {
                this.specialCharacter = value;
            }
        }
        public string CharacterInfo
        {
            get
            {
                return this.characterInfo;
            }
            set
            {
                this.characterInfo = value;
            }
        }
        public int GoldHolding
        {
            get
            {
                return this.goldHolding;
            }
            set
            {
                this.goldHolding = value;
            }
        }
        public int MaxHealth
        {
            get
            {
                return this.maxHealth;
            }
            set
            {
                this.maxHealth = value;
            }
        }
        public double Health
        {
            get
            {
                return this.health;
            }
            set
            {
                this.health = value;
            }
        }

        public int ItemHoldingNumber
        {
            get
            {
                return this.itemHoldingNumber;
            }
            set
            {
                this.itemHoldingNumber = value;
            }
        }

        public string HealthInfo
        {
            get
            {
                if (this.health < 0)
                {
                    return "You are dead";
                }
                if (this.health >= 1 && this.health <= 3)
                {
                    return "Warning, Very Low Health. Healing will soon be nessary for survival.";
                }
                return this.characterName;
            }
            set
            {
                this.characterName = value;
            }
        }
        
            public int CharacterNumber
        {
            get
            {
                return this.characterNumber;
            }
            set
            {
                this.characterNumber = value;
            }
        }
        public int ItemLimit
        {
            get
            {
                return this.itemLimit;
            }
            set
            {
                this.itemLimit = value;
            }
        }
        public int CharacterStrength
        {
            get
            {
                return this.characterStrength;
            }
            set
            {
                this.characterStrength = value;
            }
        }

        public override string ToString()
        {
            return specialCharacter + " Health: " + health + " Strength: " + characterStrength + " Item Limit: " + itemLimit + " Gold: " + goldHolding;
        }
        public CharacterClass(int characterNumber, string name, string specialCharacter, string characterinfo, int maxHealth, double health, int goldHolding, int itemLimit, int characterStrength)
        {
            this.CharacterNumber = characterNumber;
            this.CharacterName = name;
            this.SpecialCharacter = specialCharacter;
            this.CharacterInfo = characterinfo;
            this.MaxHealth = maxHealth;
            this.Health = health;
            this.GoldHolding = goldHolding;
            this.ItemLimit = itemLimit;
            this.CharacterStrength = characterStrength;
        }
    }
}