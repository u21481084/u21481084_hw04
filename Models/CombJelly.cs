using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04.Models
{
    public class CombJelly:Animal
    {
        public CombJelly()
        {

        }
        public CombJelly(string animalName) : base(animalName)
        {

        }
        public override string AnimalType()
        {
            return "Tentaculata";
        }
        public override string GetSciName()
        {
            return "Lampocteis cruentiventer";
        }
        public override string GetSize()
        {
            return "Up to 6 inches";

        }
        public override string GetHabitat()
        {
            return "Deep Sea";
        }
        public override string GetDiet()
        {
            return "Unknown";
        }
        public override string VideoUrl()
        {
            return "CombJelly.mp4";
        }
        public override string Conservation()
        {
            return "The deep sea may seem distant, but deep sea animals are part of a thriving ecosystem. Our trash and chemicals may harm them if we are careless with our waste.";
        }
        public override string Fact1()
        {
            return "Scientists believe the bloody-belly's red belly helps mask bioluminescent light from the prey it consumes. A predator with a glowing gut could easily become prey.";

        }
        public override string Fact2()
        {
            return "The genus name Lampocteis derives from the Greek roots for “brilliant comb,” referring to the bright iridescence diffracted from the animal’s comb rows.";
        }

        public override string pSciName()
        {
            return "/Comb Jelly/SciName.jpg";
        }
        public override string pHab()
        {
            return "/Comb Jelly/Hab.jpg";
        }
        public override string pSize()
        {
            return "/Comb Jelly/Size.png";
        }
        public override string pDiet()
        {
            return "/Comb Jelly/Diet.jpg";
        }
        public override string pCon()
        {
            return "/Comb Jelly/Con.jpg";
        }
        public override string pFacts()
        {
            return "/Comb Jelly/Facts.jpg";
        }
    }
}