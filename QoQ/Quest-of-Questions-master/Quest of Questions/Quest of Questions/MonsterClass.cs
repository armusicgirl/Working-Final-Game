using System;
using System.Collections.Generic;
using System.Text;

namespace Quest_of_Questions
{
    class MonsterClass
    {
        private string monsterName;
        private string monsterDescription;
        private int monsterHealth;
        private int monsterStrength;
        private bool isAlive;
        private bool fightClose;

        public string MonsterName { get => monsterName; set => monsterName = value; }
        public string MonsterDescription { get => monsterDescription; set => monsterDescription = value; }
        public int MonsterHealth { get => monsterHealth; set => monsterHealth = value; }
        public int MonsterStrength { get => monsterStrength; set => monsterStrength = value; }
        public bool IsAlive { get => isAlive; set => isAlive = value; }
        public bool FightClose { get => fightClose; set => fightClose = value; }

        public MonsterClass(string monsterName, string monsterDescription, int monsterHealth, int monsterStrength, bool isAlive, bool fightClose)
        {
            this.MonsterName = monsterName;
            this.MonsterDescription = monsterDescription;
            this.MonsterHealth = monsterHealth;
            this.MonsterStrength = monsterStrength;
            this.IsAlive = isAlive;
            this.FightClose = fightClose;
        }
    }
}
