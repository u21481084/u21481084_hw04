using HW04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Data.SqlClient;


namespace HW04.Controllers
{
    public class HomeController : Controller
    {
        private SqlConnection myConnection = new SqlConnection(GlobalDB.ConnectionString);
        
        public static List<Animal> animals = new List<Animal>();
        public static List<Animals> creatures = new List<Animals>();
        public ActionResult Index()
        {
            return View(animals);
        }
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpGet]
        public ActionResult AddAnimals()
        {
            return View();
        }
       [HttpPost]
        public ActionResult AddAnimals(string id, string type, string animalname, string hab, string food, int x, string status)
        {
            Animals animal = null;
            if (type == "Mammals")
            {
                Mammals newMammal = (Mammals)animal;
                newMammal = new Mammals(id, type, animalname, hab, food, x, status);
                creatures.Add(newMammal);
                try
                {
                    SqlCommand myCommand = new SqlCommand(" insert into [Animals] values('"+newMammal.AnimalType+"'"+
                        ","+"'"+newMammal.AnimalID+"'"+ ","+"'"+newMammal.AnimalHabitat+"'"+ ","+"'"+newMammal.AnimalFood+"'"+","
                        +newMammal.NumOfAnimal()+","+ "'"+ newMammal.sStatus+"')", myConnection);
                    myConnection.Open();
                    ViewBag.Message = "Success" + myCommand.ExecuteNonQuery() + "rows affected";
                    myConnection.Close();
                }
                catch (Exception err)
                {
                    ViewBag.Message = err.Message;
                    myConnection.Close();
                }

            }
            if (type == "Fish")
            {
                Fish newFish = (Fish)animal;
                newFish = new Fish(id, type, animalname, hab, food, x, status);
                creatures.Add(newFish);
                try
                {
                    SqlCommand myCommand = new SqlCommand(" insert into [Animals] values('" + newFish.AnimalType + "'" +
                        "," + "'" + newFish.AnimalID + "'" + "," + "'" + newFish.AnimalHabitat + "'" + "," + "'" + newFish.AnimalFood + "'" + ","
                        + newFish.NumOfAnimal() + "," + "'" + newFish.sStatus + "')", myConnection);
                    myConnection.Open();
                    ViewBag.Message = "Success" + myCommand.ExecuteNonQuery() + "rows affected";
                    myConnection.Close();
                }
                catch (Exception err)
                {
                    ViewBag.Message = err.Message;
                    myConnection.Close();
                }
            }
            if (type == "Reptiles")
            {
                Reptiles newRep = (Reptiles)animal;
                newRep = new Reptiles(id, type, animalname, hab, food, x, status);
                creatures.Add(newRep);
                try
                {
                    SqlCommand myCommand = new SqlCommand(" insert into [Animals] values('" + newRep.AnimalType + "'" +
                        "," + "'" + newRep.AnimalID + "'" + "," + "'" + newRep.AnimalHabitat + "'" + "," + "'" + newRep.AnimalFood + "'" + ","
                        + newRep.NumOfAnimal() + "," + "'" + newRep.sStatus + "')", myConnection);
                    myConnection.Open();
                    ViewBag.Message = "Success" + myCommand.ExecuteNonQuery() + "rows affected";
                    myConnection.Close();
                }
                catch (Exception err)
                {
                    ViewBag.Message = err.Message;
                    myConnection.Close();
                }
            }
            return RedirectToAction("ViewAnimalsDB");
        }
        [HttpGet]
        public ActionResult Animals()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Animals(string animalName)
        {
            Animal newA = null;
            if (animalName == "Blue Whale")
            {
                BlueWhale newBW = (BlueWhale)newA;
                newBW = new BlueWhale(animalName);
                animals.Clear();
                animals.Add(newBW);
            }
            if (animalName=="Japanese Spider Crab")
            {
                SpiderCrab spiderCrab = (SpiderCrab)newA;
                spiderCrab = new SpiderCrab(animalName);
                animals.Clear();
                animals.Add(spiderCrab);
            }
            if (animalName == "Blood Belly Comb Jelly")
            {
                CombJelly newComb = (CombJelly)newA;
                newComb = new CombJelly(animalName);
                animals.Clear();
                animals.Add(newComb);
            }
            if (animalName == "Clownfish")
            {
                Clownfish newClown = (Clownfish)newA;
                newClown = new Clownfish(animalName);
                animals.Clear();
                animals.Add(newClown);
            }
            if (animalName == "Green Turtle")
            {
                Turtle newTurtle = (Turtle)newA;
                newTurtle = new Turtle(animalName);
                animals.Clear();
                animals.Add(newTurtle);
            }

            return  RedirectToAction("Index");
        }
        public ActionResult Pollution()
        {
            return View();
        }
        public ActionResult PollutionProblem()
        {
            return View();
        }
        public ActionResult PollutionSol()
        {
            return View();
        }
        public ActionResult ClimateChallenge()
        {
            return View();
        }
        public ActionResult ClimateSol()
        {
            return View();
        }
        public ActionResult ClimateChange()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }
        public ActionResult AddUser(User newUser)
        {
            
            string name=newUser.Name; 
            int num=newUser.NumOfTickets;
            DateTime d=newUser.rDate;
            try
            {
                SqlCommand myCommand = new SqlCommand(" insert into [User] values('" + name + "'," + num + ",'" + d + "')",myConnection);
                myConnection.Open();
                ViewBag.Message = "Success" + myCommand.ExecuteNonQuery() + "rows affected";
                myConnection.Close();
            }
            catch(Exception err)
            {
                ViewBag.Message = err.Message;
                myConnection.Close();
            }
            return RedirectToAction("ViewUsers");
        }
        public ActionResult ViewUsers()
        {
             List <User> users = new List<User>();
            myConnection.Open();
            SqlCommand command = new SqlCommand("Select * from [User]", myConnection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    User tmpPerson = new User();
                    tmpPerson.UserID = Convert.ToInt32(reader["UserID"]);
                    tmpPerson.Name = reader["Name"].ToString();
                    tmpPerson.NumOfTickets = Convert.ToInt32(reader["NumTickets"]);
                    tmpPerson.rDate = Convert.ToDateTime(reader["ResDate"]);
                    
                    
                    users.Add(tmpPerson);
                }
            }
            return View(users);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            User person = new User();

            List<User> persons = getUsers();
            if (persons.Any(x => x.UserID == id))
            {
                int index = persons.FindIndex(x => x.UserID == id);
                if (index != -1)
                {
                    person = persons[index];
                }
            }

            return View(person);
        }
        [HttpPost]
        public ActionResult Edit(User person)
        {
            myConnection.Open();
            String cmd = "Update [User] Set Name = '" + person.Name + "', NumTickets = " + person.NumOfTickets + ",ResDate = '"+person.rDate+"' where UserID = " + person.UserID + ";";
            SqlCommand command = new SqlCommand(cmd, myConnection);
            command.ExecuteNonQuery();
            myConnection.Close();
            return RedirectToAction("ViewUsers");
        }

        [HttpGet]
        public ActionResult EditAnimalDB(string id)
        {
            AnimalRead swimmer = new AnimalRead();

            List<AnimalRead> a = getAnimals();
            if (a.Any(x => x.AnimalID == id))
            {
                int index = a.FindIndex(x => x.AnimalID == id);
                if (index != -1)
                {
                    swimmer = a[index];
                }
            }

            return View(swimmer);
        }

        [HttpPost]
        public ActionResult EditAnimalDB(AnimalRead swimmer)
        {
            myConnection.Open();
            String cmd = @"Update [Animals] Set Num_Animals = " + swimmer.NumAnimals + ", Animal_Diet = '"+swimmer.AnimalFood+"'"+
                ", Animal_Habitat = '"+swimmer.AnimalHabitat+"'"+ ", Animal_Status = '"+swimmer.sStatus+"'"+
                " WHERE AnimalID = '" + swimmer.AnimalID + "'";
            SqlCommand command = new SqlCommand(cmd, myConnection);
            command.ExecuteNonQuery();
            myConnection.Close();
            return RedirectToAction("ViewAnimalsDB");
        }













        public List<User> getUsers()
        {
            
            List<User> users = new List<User>();
            myConnection.Open();
            SqlCommand command = new SqlCommand("Select * from [User]", myConnection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    User tmpPerson = new User();
                    tmpPerson.UserID = Convert.ToInt32(reader["UserID"]);
                    tmpPerson.Name = reader["Name"].ToString();
                    tmpPerson.NumOfTickets = Convert.ToInt32(reader["NumTickets"]);
                    tmpPerson.rDate = Convert.ToDateTime(reader["ResDate"]);


                    users.Add(tmpPerson);
                }
            }
            myConnection.Close();
            return users;
        }
        public List<AnimalRead> getAnimals()
        {

            List<AnimalRead> users = new List<AnimalRead>();
            myConnection.Open();
            SqlCommand command = new SqlCommand("Select * from [Animals]", myConnection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    AnimalRead tmpPerson = new AnimalRead();
                    tmpPerson.AnimalID = reader["AnimalID"].ToString();
                    tmpPerson.AnimalType = reader["AnimalType"].ToString();
                    tmpPerson.AnimalHabitat = reader["Animal_Habitat"].ToString();
                    tmpPerson.AnimalFood = reader["Animal_Diet"].ToString();
                    tmpPerson.NumAnimals = Convert.ToInt32(reader["Num_Animals"]);
                    tmpPerson.sStatus = reader["Animal_Status"].ToString();


                    users.Add(tmpPerson);
                }
            }
            myConnection.Close();
            return users;
        }
        public ActionResult Delete(int id)
        {
            
                myConnection.Open();
                SqlCommand command = new SqlCommand("delete from [User] where UserID = " + id + ";",myConnection);
                command.ExecuteNonQuery();
                myConnection.Close();
            return RedirectToAction("ViewUsers");

            
           
        }
        public ActionResult RemoveAnimal(string id)
        {

            myConnection.Open();
            SqlCommand command = new SqlCommand("delete from [Animals] where AnimalID = '" + id + "'", myConnection);
            command.ExecuteNonQuery();
            myConnection.Close();
            return RedirectToAction("ViewAnimalsDB");



        }
        public ActionResult ViewAnimalsDB()
        {
            List<AnimalRead> ani = getAnimals();
            return View(ani);
        }


    }
}