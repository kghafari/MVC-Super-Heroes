using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day26_MVCSuperHeroes.Models
{
    public class Mission
    {
        //prop
        public int SuperID { get; set; }
        public string MissionName { get; set; }
        public bool Completed { get; set; }
        public int Difficulty { get; set; }
        public DateTime DueDate { get; set; }

        //ctor
        public Mission()
        {

        }
        public Mission(int superId, string mission, bool completed, int difficulty, DateTime due)
        {
            SuperID = superId;
            MissionName = mission;
            Completed = completed;
            Difficulty = difficulty;
            DueDate = due;
        }

        //mthd
        public static List<Mission> MissionList()
        {
            return new List<Mission>
            {
                new Mission(1, "Do the thing", false, 10, DateTime.Parse("12/21/19")),
                new Mission(1, "Hack into the Pentagon", false, 1, DateTime.Parse("02/25/2020")),
                new Mission(4, "Patrol the lower east side... On foot.", false, 5, DateTime.Parse("03/06/2020")),
                new Mission(3, "Just do it", false, 5, DateTime.Parse("02/25/2020")),
                new Mission(4, "Brawl at American Coney Island", true, 7, DateTime.Parse("01/25/2020")),
                new Mission(2, "Saving a ghost kitty in a ghost tree", true, 3, DateTime.Parse("9/22/2019")),
                new Mission(3, "Do the laundry", false, 1, DateTime.Now),
                new Mission(4, "Save granny from her fall", true, 3, DateTime.Parse("2/19/2018")),
                new Mission(1, "Storm area 51", false, 10, DateTime.Parse("09/20/2020")),
                new Mission(2, "Rob a bank", false, 9, DateTime.Parse("11/02/2020")),
                new Mission(1, "Crack a gibson", false, 7, DateTime.Parse("02/27/2020"))
            };
        }
    }
}
