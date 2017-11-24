using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monkeys
{
    public abstract class Monkey
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Sizeoftale { get; set; }
        public int Weight { get; set; }
    }

    public class BigMonkey : Monkey
    {
        private int tale = 50;
    }

    public class LittleMonkey : Monkey
    {
        private int tale = 20;
    }

    public class Gibbon : BigMonkey
    {
        public Gibbon()
        {
            Name = "Гиббон";
            Age = 10;
            Weight = 50;
            Sizeoftale = 20;
        }
    }

    public class Baboon : BigMonkey
    {
        public Baboon()
        {
            Name = "Бабуин";
            Age = 20;
            Weight = 30;
            Sizeoftale = 13;
        }
    }
    public class Orangitan : LittleMonkey
    {
        public Orangitan()
        {
            Name = "Орангутан";
            Age = 30;
            Weight = 70;
            Sizeoftale = 5;
        }
    }
    public class Chimpanzee : LittleMonkey
    {
        public Chimpanzee()
        {
            Name = "Шимпанзе";
            Age = 40;
            Weight = 20;
            Sizeoftale = 22;
        }
    }
}