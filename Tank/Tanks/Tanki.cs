using System;
using System.Collections.Generic;
using System.Text;

namespace Tank.Tanks
{
    class Tanki
    {
        private string name;
        private int ammunition;
        private int armor;
        private int mobility;

        public Tanki(string name)
        {
            this.name = name;
            Random random = new Random();
            ammunition = random.Next(0, 101);
            armor = random.Next(0, 101);
            mobility = random.Next(0, 101);
        }

        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return $"{name}: Ammo={ammunition}, Armor={armor}, Mobility={mobility}";
        }

        public static bool operator ^(Tanki tank1, Tanki tank2)
        {
            int winCriteria = 0;
            if (tank1.ammunition > tank2.ammunition) winCriteria++;
            if (tank1.armor > tank2.armor) winCriteria++;
            if (tank1.mobility > tank2.mobility) winCriteria++;

            return winCriteria >= 2;
        }
    }
}
