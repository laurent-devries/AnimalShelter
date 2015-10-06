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

            administration.Add(cat);
            Assert.AreEqual(cat, administration.Animallist[0]);
        }

        [TestMethod]
        public void RemoveAnimalFromAdministration()
        {
            SimpleDate simpleDate = new SimpleDate(06, 11, 1996);
            Administration administration = new Administration();
            Cat cat = new Cat("12345", simpleDate, "testAnimal", "badHabits");
            administration.Add(cat);
            Assert.IsTrue(administration.RemoveAnimal("12345"));
        }
    }
}
