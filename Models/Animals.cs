using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04.Models
{
    public abstract class Animals
    {
        public string AnimalID { get; set; }
        public string AnimalHabitat { get; set; }
        public string AnimalFood { get; set; }
        public string AnimalType { get; set; }
        public int NumAnimals { get; set; }
        public string sStatus { get; set; }
        public Animals()
        {

        }
        public Animals(string id, string type, string hab, string food, int num, string status)
        {
            AnimalID = id;
            AnimalType = type;
            AnimalHabitat = hab;
            AnimalFood = food;
            NumAnimals = num;
            sStatus = status;
        }
        public abstract int NumOfAnimal();
        public virtual string AnimalStatus()
        {
            return "Endangered";
        }
    }
}