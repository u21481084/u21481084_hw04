using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04.Models
{
    public class Fish:Animals
    {
        public string AnimalName { get; set; }
        public int num { get; set; }
        public string Status { get; set; }
        public Fish()
        {

        }
        public Fish(string id, string type, string animalname, string hab, string food, int x, string status) : base(id, type, hab, food, x, status)
        {
            AnimalName = animalname;
            num = x;
            Status = status;
        }
        public override int NumOfAnimal()
        {
            return num;
        }
    }
}