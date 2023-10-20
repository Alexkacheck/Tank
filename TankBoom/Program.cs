using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBoom
{
    class TankBattle
    {
        static void Main(string[] args)
        {


            Tankii[] t34Tanks = new Tankii[5];
            Tankii[] panteraTanks = new Tankii[5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                t34Tanks[i] = new Tankii("T-34");
                panteraTanks[i] = new Tankii("Pantera");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Battle {i + 1}: {t34Tanks[i]} vs. {panteraTanks[i]}");

                if (t34Tanks[i] ^ panteraTanks[i])
                {
                    Console.WriteLine($"{t34Tanks[i].GetName()} wins!");
                }
                else
                {
                    Console.WriteLine($"{panteraTanks[i].GetName()} wins!");
                }

                Console.WriteLine();
            }
        }
    }
    }
}
