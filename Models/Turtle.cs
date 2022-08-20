using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04.Models
{
    public class Turtle: Animal
    {
        public string sStatus { get; set; }
        public string pStatus { get; set; }
        public Turtle()
        {

        }
        public Turtle(string animalName) : base(animalName)
        {
            sStatus = "Endangered";
            pStatus = "/Turtle/Status.jpg";
        }
        public override string AnimalType()
        {
            return "Reptile";
        }
        public override string GetSciName()
        {
            return "Chelonia mydas";
        }
        public override string GetSize()
        {
            return "Approximately 3-4 feet long (1.2 m) and up to 400 pounds (181 kg)";
        }
        public override string GetHabitat()
        {
            return "Open Waters";
        }
        public override string GetDiet()
        {
            return "Sea grasses and macroalgae; juveniles also eat invertebrates (including jellyfish)";
        }
        public override bool HasStatus()
        {
            return true;
        }
        public override string VideoUrl()
        {
            return "Turtles.mp4";
        }
        public override string Conservation()
        {
            return "Why are green turtles important? The green turtle helps keep nearshore ocean habitats healthy — acting a bit like a gardener. Just like mowing the lawn keeps your lawn full and green, a sea turtle’s grazing helps keep seagrass beds healthy and plentiful(trimming the ends of the seagrass stimulates new growth)."

            + "On the beach, a green turtle’s unhatched eggs can act as a fertilizer for plants that help stabilize beach dunes.When the eggs and shells — rich in marine nutrients — compost into the sand or get eaten by predators, they help feed the plants and animals in the area.";
        }
        public override string Fact1()
        {
            return "Sea turtles are reptiles whose ancestors took to the sea about 150 million years ago. They are one of the few species so ancient that they watched the dinosaurs evolve and become extinct.";
        }
        public override string Fact2()
        {
            return "On land turtles are slow, but in the water, their powerful flippers allow them to swim gracefully at speeds up to 35 mph!";
        }

        public override string Fact3()
        {
            return "The hatchlings’ gender depends on the sand temperature. Less dense, warmer sand decreases incubation time and results in more female hatchlings.";
        }
        public override string pSciName()
        {
            return "/Turtle/SciName.jpg";
        }
        public override string pHab()
        {
            return "/Turtle/SciName.jpg";
        }
        public override string pSize()
        {
            return "/Turtle/Size.jpg";
        }
        public override string pDiet()
        {
            return "/Turtle/Diet.png";
        }
        public override string pCon()
        {
            return "/Turtle/Con.jpg";
        }
        public override string pFacts()
        {
            return "/Turtle/Facts.jpg";
        }
    }
}