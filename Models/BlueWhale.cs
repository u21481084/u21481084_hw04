using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04.Models
{
    public class BlueWhale:Animal
    {
        public string sStatus { get; set; }
        public string pStatus { get; set; }
        public BlueWhale()
        {

        }
        public BlueWhale(string animalName): base(animalName)
        {
            sStatus = "Endangered";
            pStatus = "/Blue Whale/bwStatus.png";
        }
        public override string AnimalType()
        {
            return "Mammal";
        }
        public override string GetSciName()
        {
            return "Balaenoptera musculus";
        }
        public override string GetSize()
        {
            return "Average 27m (Largest measured 33m)";
        }
        public override string GetHabitat()
        {
            return "Open Waters";
        }
        public override string GetDiet()
        {
            return "Krill; occasionally, pelagic crabs";
        }
        public override bool HasStatus()
        {
            return true;
        }
        public override string VideoUrl()
        {
            return "BlueWhale.mp4";
        }
        public override string Conservation()
        {
            return " Decimated by whaling" +
                "Whalers began hunting blue whales in earnest after the invention of the harpoon gun. The pre-whaling population of blue whales quickly fell from an estimated 350,000 to 1,000 in the mid-1920s. It became so scarce that in 1966 the International Whaling Commission belatedly declared it a protected species worldwide. The Endangered Species Act also protects the blue whale." +
                "Is the blue whale endangered?" +
                "Yes — the blue whale is classified as endangered on the International Union for the Conservation of Nature and Natural Resources(IUCN) red list.It’s also listed as endangered under the Endangered Species Act." +
                "Threats" +
                "The IUCN lists the main threats to these animals as the fishing industry and climate change.Although the fishing industry no longer directly hunts whales, a number of blue whale deaths have been tied to direct ship strikes.Climate change may cause a decline of their primary food source, Antarctic krill(Euphausia superba) and Antarctic coastal krill(E.crystallorophias), because warmer temperatures lead to lower productivity overall and ocean acidification affects the krill’s ability to develop shells.";
        }
        public override string Fact1()
        {
            return "The blue whale has a nickname totally unrelated to its size. In Arctic or Antarctic waters, yellow diatoms (microscopic algae) often stick to the blue whale’s underbody, giving it the nickname sulfur bottom.";

        }
        public override string Fact2()
        {
            return "Nursing calves can gain up to 200 pounds (90 kg) of body weight a day.";
        }

        public override string Fact3()
        {
            return "A blue whale sleeps while swimming, although it’s never fully unconscious — that could result in drowning. Instead, the blue whale lightly naps as it slowly swims along the surface of the water.";
        }
        public override string pSciName()
        {
            return "/Blue Whale/bwSciName.jpg";
        }
        public override string pHab()
        {
            return "/Blue Whale/bwHab.jpg";
        }
        public override string pSize()
        {
            return "/Blue Whale/bwSize.jpg";
        }
        public override string pDiet()
        {
            return "/Blue Whale/bwDiet.jpg";
        }
        public override string pCon()
        {
            return "/Blue Whale/bwCon.jpg";
        }
        public override string pFacts()
        {
            return "/Blue Whale/bwFacts.jpg";
        }
        
        
    }
}