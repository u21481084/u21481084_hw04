using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04.Models
{
    public class SpiderCrab: Animal
    {
        
        public SpiderCrab()
        {

        }
        public SpiderCrab(string animalName) : base(animalName)
        {
            
        }
        public override string AnimalType()
        {
            return "Crustacean";
        }
        public override string GetSciName()
        {
            return "Macrocheira kaempferi";
        }
        public override string GetSize()
        {
            return "Carapace up to 12 inches (30 cm) across, legs span up to 12 feet (3.8 m) from claw to claw.";

        }
        public override string GetHabitat()
        {
            return "Deep Sea";
        }
        public override string GetDiet()
        {
            return "Decaying fish, crustaceans, invertebrates, and algae";
        }
        public override string VideoUrl()
        {
            return "Crab.mp4";
        }
        public override string Conservation()
        {
            return "Over the past 40 years, the catch of Japanese spider crabs has declined. To help the population recover, Japanese law bans fishing for this species during its mating season. " +

                 "Rising ocean temperatures due to climate change may negatively impact this species by reducing the number of larvae that survive to become adults and by degrading seaweed beds that could reduce the amount of food that falls to the seafloor where the crabs live.";
        }
        public override string Fact1()
        {
            return "This crab’s carapace stays the same size once it becomes an adult, but the legs keep growing.";

        }
        public override string Fact2()
        {
            return "These crabs are thought to live 50 to 100 years.";
        }

        public override string Fact3()
        {
            return "Female Japanese spider crabs can lay up to 1.5 million eggs in a season, but only a few survive.";
        }
        public override string pSciName()
        {
            return "/Japanese Spider Crab/SciName.jpg";
        }
        public override string pHab()
        {
            return "/Japanese Spider Crab/SciName.jpg";
        }
        public override string pSize()
        {
            return "/Japanese Spider Crab/size.jpg";
        }
        public override string pDiet()
        {
            return "/Japanese Spider Crab/Diet.jpg";
        }
        public override string pCon()
        {
            return "/Japanese Spider Crab/Con.jpg";
        }
        public override string pFacts()
        {
            return "/Japanese Spider Crab/Facts.jpg";
        }
    }
}