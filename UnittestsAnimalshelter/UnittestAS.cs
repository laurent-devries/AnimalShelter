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
        public void Test()
        {
            
        }
    }
}
