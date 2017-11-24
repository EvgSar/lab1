using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys
{
    class Program
    {
        static void Main(string[] args)
        {
            var monkey = new List<Monkey>
            {
                new Gibbon(),
                new Baboon(),
                new Orangitan(),
                new Chimpanzee()
            };

            foreach (var Monkey in monkey)
            {
                if (Monkey.Sizeoftale <= 10)
                {
                    Console.WriteLine($"У {Monkey.Name} маленький хвост, всего {Monkey.Sizeoftale} см.");
                }
                else if (Monkey.Sizeoftale >= 11)
                {
                    Console.WriteLine($"У {Monkey.Name} большой хвост, целых {Monkey.Sizeoftale} см.");
                }

                if (Monkey.Age <= 20)
                {
                    Console.WriteLine($"{Monkey.Name} молодая особь, всего {Monkey.Age} лет.");
                }
                else if (Monkey.Age >= 21)
                {
                    Console.WriteLine($"{Monkey.Name} старая особь, целых {Monkey.Age} лет.");
                }

                if (Monkey.Weight <= 40)
                {
                    Console.WriteLine($"{Monkey.Name} худой, всего {Monkey.Weight} кг.");
                }
                else if (Monkey.Weight > 41)
                {
                    Console.WriteLine($"{Monkey.Name} толстый, целых {Monkey.Weight} кг.");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

