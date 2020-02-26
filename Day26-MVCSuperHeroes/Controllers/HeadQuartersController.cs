using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day26_MVCSuperHeroes.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day26_MVCSuperHeroes.Controllers
{
    public class HeadQuartersController : Controller
    {
        List<Super> superList = Super.GetSuperList();
        List<Mission> missionList = Mission.MissionList();

        public IActionResult ListSupers()
        {
            return View(superList);
        }

        public IActionResult MissionsBySuper(int id)
        {
            //List<Mission> superMissions = new List<Mission>();
            //foreach (Mission mission in missionList)
            //{
            //    if(mission.SuperID == id)
            //    {
            //        superMissions.Add(mission);
            //    }
            //}
            List<Mission> linqMissions = missionList.Where(x => x.SuperID == id).ToList();
            return View(linqMissions);
        }
    }
}