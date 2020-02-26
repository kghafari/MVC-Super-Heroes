using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day26_MVCSuperHeroes.Models
{
    public class Super
    {
        public int SuperID { get; set; }
        public string Name { get; set; }
        public string SuperName { get; set; }
        public string Power { get; set; }
        public int PowerLevel { get; set; }
        public bool Cape{ get; set; }
        public bool Good { get; set; } //good = true

        public Super()
        {

        }

        public Super(int id, string name, string superName, string power, int powerlevel, bool cape, bool good)
        {
            SuperID = id;
            Name = name;
            SuperName = superName;
            Power = power;
            PowerLevel = powerlevel;
            Cape = cape;
            Good = good;
        }

        public static List<Super> GetSuperList()
        {
            List<Super> superList = new List<Super>
            {
            new Super(1, "Cam", "Super Coding Man", "C#", 5, false, false),
            new Super(2, "Danny Fenton", "Danny Phantom", "going ghost", 700, false, true),
            new Super(3, "Peter Parker", "Spider Man", "Spidey Sense", 140, false, true),
            new Super(4, "Triple OG", "Detroit", "The Streets", 313, true, true),
            };
            return superList;
        }
      
    }
}
