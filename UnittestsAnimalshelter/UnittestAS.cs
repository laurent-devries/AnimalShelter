using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnittestsAnimalshelter
{
    [TestClass]
    public class UnittestAS
    {
        private SimpleDate simpleDate;
        private Administration administration;
        private SimpleDate lastWalk;
        private Dog dog;
        private Cat cat;
        [TestInitialize]
        public void Initialize()
        {
            simpleDate = new SimpleDate(06, 11, 1996);
            lastWalk = new SimpleDate(06, 11, 1996);
            administration = new Administration();
            dog = new Dog("12345", simpleDate, "testdog", lastWalk);
            cat = new Cat("12345", simpleDate, "testcat", "0123456789");
        }

        [TestMethod]
        public void TestAddDog()
        {                    
            Assert.AreEqual(lastWalk, dog.LastWalkDate, "Incorrect Last Walk Date");
            //Chipnumber of dog < 50000
            Assert.AreEqual(200, dog.Price, "Incorrect Price with chipnumber < 50000");

            //Chipnumber of dog >= 50000
            dog = new Dog("52345", simpleDate, "testdog", lastWalk);
            Assert.AreEqual(350, dog.Price, "Incorrect Price with chipnumber >= 50000");
        }

        [TestMethod]
        public void TestAddCat()
        {
            //60-badhabits.length = price of cat            
            Assert.AreEqual((60 - 10), cat.Price, "Incorrect Price");

            //badhabits <= 20 : price = 20
            cat = new Cat("12345", simpleDate, "testcat", "12345678901234567890123456789012345678901");
            Assert.AreEqual(20, cat.Price);
        }

        [TestMethod]
        public void AddAnimalToAdministration()
        {
            //Add Original Cat
            Assert.IsTrue(administration.Add(cat));
            //Add cat that with the same chipnumber
            Assert.IsFalse(administration.Add(cat));
        }

        [TestMethod]
        public void RemoveAnimalFromAdministration()
        {
            administration.Add(cat);
            //Remove excisting animal
            Assert.IsTrue(administration.RemoveAnimal("12345"));

            //Remove Animal that doesn't Excist
            Assert.IsFalse(administration.RemoveAnimal("00000"));
        }

        [TestMethod]
        public void FindAnimal()
        {
            administration.Add(cat);

            //Find excisting Animal
            Assert.AreEqual(cat, administration.FindAnimal("12345"));

            //Find Animal that does not exist.
            Assert.IsNull(administration.FindAnimal("00000"));
        }

        [TestMethod]
        public void AnimalPropsTest()
        {            
            //if chip is longer than 5 digits, just add the first 5;
            cat = new Cat("123456", simpleDate, "testAnimal", "badHabits");
            Assert.AreEqual("12345", cat.ChipRegistrationNumber, "Chip failed when more than 5 digits are inserted");

            //if chip is shorter than 5, add zeros before the chip until the chip has 5 digits
            cat = new Cat("1234", simpleDate, "testAnimal", "badHabits");
            Assert.AreEqual("01234", cat.ChipRegistrationNumber, "Chip failed when less than 5 digits were inserted");

            //Check rest of properties;
            Assert.AreEqual(simpleDate, cat.DateOfBirth, "Incorrect DateOfBirth");
            Assert.AreEqual("testAnimal", cat.Name, "Incorrect Name");
            Assert.AreEqual("01234, 06-11-1996, testAnimal, not reserved, badhabits: badHabits", cat.ToString());

            //test null birthdate for cat
            cat = new Cat("1234", null, "testAnimal", "badHabits");
            Assert.AreEqual("01234, 00-00-0000, testAnimal, not reserved, badhabits: badHabits", cat.ToString());
            //test "" badhabits
            cat = new Cat("1234", null, "testAnimal", "");
            Assert.AreEqual("01234, 00-00-0000, testAnimal, not reserved, badhabits: none", cat.ToString());

            //special dog test
            Assert.AreEqual("12345, 06-11-1996, testdog, not reserved, lastWalkDate: 06-11-1996", dog.ToString());
            dog = new Dog("12345", null, null, null);
            dog.IsReserved = true;
            Assert.AreEqual("12345, 00-00-0000, noname, reserved, lastWalkDate: 00-00-0000", dog.ToString());
        }

        [TestMethod]
        public void AnimalReserving()
        {
            Assert.IsFalse(cat.IsReserved);
            cat.IsReserved = true;
            Assert.IsTrue(cat.IsReserved);
        }

        [TestMethod]
        public void AnimalComparing()
        {
            cat = new Cat("99999", simpleDate, "testAnimal", "badHabits");
            Cat cat2 = new Cat("00000", simpleDate, "testAnimal", "badHabits");
            administration.Add(cat);
            administration.Add(cat2);

            administration.Animallist.Sort();

            Assert.AreEqual(cat2, administration.Animallist[0]);
        }
        [TestMethod]
        public void SimpleDatePropTest()
        {
            //Standard property testing
            Assert.AreEqual(06, simpleDate.Day);
            Assert.AreEqual(11, simpleDate.Month);
            Assert.AreEqual(1996, simpleDate.Year);
        }

        [TestMethod]
        public void SimpleDateDaysDifference()
        {
            //Check if difference between dates is correct.
            SimpleDate simpleDate2 = new SimpleDate(20, 11, 1996);
            Assert.AreEqual(14, simpleDate.DaysDifference(simpleDate2));
        }

    }
}
