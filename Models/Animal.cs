using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04.Models
{
    public abstract class Animal
    {
        public string NameOfAnimal { get; set; }
        public abstract string pSciName();
        public abstract string pHab();
        public abstract string pSize();
        public abstract string pDiet();
        public abstract string pCon();
        public abstract string pFacts();
        public Animal()
        {

        }

        public Animal( string nameofanimal)
        {
            NameOfAnimal = nameofanimal;
            
        }
        public abstract string GetSciName();
        public abstract string GetHabitat();
        public abstract string GetSize();
        public abstract string GetDiet();
        public abstract string AnimalType();
        public abstract string VideoUrl();
        public virtual string Conservation()
        {
            return "Conservation on this sea animal";
        }
        public virtual string Fact1()
        {
            return "";
        }
        public virtual string Fact2()
        {
            return "";
        }
        public virtual string Fact3()
        {
            return "";
        }

        public virtual bool HasStatus()
        {
            return false;
        }
    }
}