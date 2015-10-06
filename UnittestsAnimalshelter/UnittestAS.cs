using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnittestsAnimalshelter
{
    [TestClass]
    public class UnittestAS
    {
        [TestMethod]
        public void TestAddDog()
        {
            SimpleDate simpleDate = new SimpleDate(06, 11, 1996);  
            SimpleDate lastWalk = new SimpleDate(06, 11, 1996);

            Dog dog = new Dog("12345", simpleDate, "testdog", lastWalk);
            Assert.AreEqual(lastWalk, dog.LastWalkDate, "Incorrect Last Walk Date");

            //Chipnumber of dog < 50000
            Assert.AreEqual(200, dog.Price, "Incorrect Price with chipnumber < 50000");

            //Chipnumber of dog >= 50000
            Dog dog2 = new Dog("52345", simpleDate, "testdog", lastWalk);
            Assert.AreEqual(350, dog2.Price, "Incorrect Price with chipnumber >= 50000");
        }

        [TestMethod]
        public void TestAddCat()
        {
            SimpleDate simpleDate = new SimpleDate(06, 11, 1996);

            //60-badhabits.length = price of cat
            Cat cat = new Cat("12345", simpleDate, "testcat", "0123456789");
            Assert.AreEqual((60 - 10), cat.Price, "Incorrect Price");

            //badhabits <= 20 : price = 20
            Cat cat2 = new Cat("12345", simpleDate, "testcat", "12345678901234567890123456789012345678901");
            Assert.AreEqual(20, cat2.Price);
        }

        [TestMethod]
        public void AddAnimalToAdministration()
        {
            SimpleDate simpleDate = new SimpleDate(06, 11, 1996);
            Administration administration = new Administration();
            Cat cat = new Cat("12345", simpleDate, "testAnimal", "badHabits");
            //Add Original Cat
            Assert.IsTrue(administration.Add(cat));
            //Add cat that with the same chipnumber
            Assert.IsFalse(administration.Add(cat));
        }

        [TestMethod]
        public void RemoveAnimalFromAdministration()
        {
            SimpleDate simpleDate = new SimpleDate(06, 11, 1996);
            Administration administration = new Administration();
            Cat cat = new Cat("12345", simpleDate, "testAnimal", "badHabits");
            administration.Add(cat);
            //Remove excisting animal
            Assert.IsTrue(administration.RemoveAnimal("12345"));

            //Remove Animal that doesn't Excist
            Assert.IsFalse(administration.RemoveAnimal("00000"));
        }

        [TestMethod]
        public void FindAnimal()
        {
            SimpleDate simpleDate = new SimpleDate(06, 11, 1996);
            Administration administration = new Administration();
            Cat cat = new Cat("12345", simpleDate, "testAnimal", "badHabits");
            administration.Add(cat);

            //Find excisting Animal
            Assert.AreEqual(cat, administration.FindAnimal("12345"));

            //Find Animal that does not exist.
            Assert.IsNull(administration.FindAnimal("00000"));
        }

        [TestMethod]
        public void AnimalPropsTest()
        {
            SimpleDate simpleDate = new SimpleDate(06, 11, 1996);
            
            //if chip is longer than 5 digits, just add the first 5;
            Cat cat = new Cat("123456", simpleDate, "testAnimal", "badHabits");
            Assert.AreEqual("12345", cat.ChipRegistrationNumber, "Chip failed when more than 5 digits are inserted");

            //if chip is shorter than 5, add zeros before the chip until the chip has 5 digits
            Cat cat2 = new Cat("1234", simpleDate, "testAnimal", "badHabits");
            Assert.AreEqual("01234", cat2.ChipRegistrationNumber, "Chip failed when less than 5 digits were inserted");

            //Check rest of properties;
            Assert.AreEqual(simpleDate, cat.DateOfBirth, "Incorrect DateOfBirth");
            Assert.AreEqual("testAnimal", cat.Name, "Incorrect Name");            
        }

        [TestMethod]
        public void AnimalReserving()
        {
            SimpleDate simpleDate = new SimpleDate(06, 11, 1996);
            Cat cat = new Cat("123456", simpleDate, "testAnimal", "badHabits");

            Assert.IsFalse(cat.IsReserved);
            cat.IsReserved = true;
            Assert.IsTrue(cat.IsReserved);
        }

        [TestMethod]
        public void AnimalComparing()
        {
            Administration administration = new Administration();
            SimpleDate simpleDate = new SimpleDate(06, 11, 1996);
            Cat cat = new Cat("99999", simpleDate, "testAnimal", "badHabits");
            Cat cat2 = new Cat("00000", simpleDate, "testAnimal", "badHabits");
            administration.Add(cat);
            administration.Add(cat2);

            administration.Animallist.Sort();

            Assert.AreEqual(cat2, administration.Animallist[0]);
        }
        [TestMethod]
        public void SimpleDatePropTest()
        {
            SimpleDate simpledate = new SimpleDate(06, 11, 1996);
            //Standard property testing
            Assert.AreEqual(06, simpledate.Day);
            Assert.AreEqual(11, simpledate.Month);
            Assert.AreEqual(1996, simpledate.Year);
        }

        [TestMethod]
        public void SimpleDateDaysDifference()
        {
            SimpleDate simpledate = new SimpleDate(06, 11, 1996);
            SimpleDate simpledate2 = new SimpleDate(20, 11, 1996);
            Assert.AreEqual(14, simpledate.DaysDifference(simpledate2));
        }

    }
}
