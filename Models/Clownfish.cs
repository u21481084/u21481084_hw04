using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04.Models
{
    public class Clownfish: Animal
    {

        public Clownfish()
        {

        }
        public Clownfish(string animalName) : base(animalName)
        {

        }
        public override string AnimalType()
        {
            return "Fish";
        }
        public override string GetSciName()
        {
            return "Amphiprion sp.";
        }
        public override string GetSize()
        {
            return "Up to 4.5 inches (11 cm)";

        }
        public override string GetHabitat()
        {
            return "Coral reefs";
        }
        public override string GetDiet()
        {
            return "Tiny drifting animals like copepods and zooplankton; algae";
        }
        public override string VideoUrl()
        {
            return "Clownfish.mp4";
        }
        public override string Conservation()
        {
            return "In places, unscrupulous collectors use harmful chemicals to catch coral reef fishes for the pet trade. Applying the chemicals stuns the fish and makes it easy to collect. But these poisons can also kill fishes, corals and other reef life. If you have a home aquarium, buy fishes raised in captivity — not ones collected from the wild.";
        }
        public override string Fact1()
        {
            return "All clownfish start life as a male. As it grows, a male may change to become a female.";

        }
        public override string Fact2()
        {
            return "Before a clownfish can call an anemone home, it has to get comfortable. The fish gently touches the anemone's tentacles over a period of several hours or days, until the fish forms a layer of mucus that protects it from the stings.";
        }

        public override string pSciName()
        {
            return "/Clownfish/SciName.jpg";
        }
        public override string pHab()
        {
            return "/Clownfish/SciName.jpg";
        }
        public override string pSize()
        {
            return "/Clownfish/Size.jpg";
        }
        public override string pDiet()
        {
            return "/Clownfish/diet.jpg";
        }
        public override string pCon()
        {
            return "/Clownfish/Con.png";
        }
        public override string pFacts()
        {
            return "/Clownfish/Facts.jpg";
        }
    }
}