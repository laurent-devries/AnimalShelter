﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Cat : Animal
    {
        // Backing field for property, see actual properties for their description.
        private string badHabits;
        private int price;
        /// <summary>
        /// Description of the bad habits that the cat shows (e.g. "Scratches the couch").
        /// or null if the cat shows no bad habits.
        /// </summary>
        public string BadHabits
        {
            get { return badHabits; }
            set { badHabits = value; }
        }

        /// <summary>
        /// Creates a cat.
        /// </summary>
        /// <param name="chipRegistrationNumber">A five digit number containing the chip registration 
        /// number of the animal. If the given number contains less than 5 digits, then it will be
        /// stuffed with zero's from the left. So "5" becomes "00005". If the given number contains
        /// more than 5 digits, then the number is truncated after the 5th position. So "1234567"
        /// becomes "12345"</param>
        /// <param name="dateOfBirth">The date of birth of the animal or null if unknown</param>
        /// <param name="name">The name of the animal or null if unknown</param>
        /// <param name="badHabits">The nasty habbits of the cat (e.g. "scratches the couch")
        ///                           or null if none.</param>
        public Cat(string chipRegistrationNumber, SimpleDate dateOfBirth,
            string name, string badHabits) : base(chipRegistrationNumber, dateOfBirth, name)
        {
            BadHabits = badHabits;
            price = 60 - BadHabits.Length;
            
        }


        /// <summary>
        /// Retrieve information about this cat
        /// 
        /// Note: Every class inherits (automagically) from the 'Object' class,
        /// which contains the virtual ToString() method which you can override.
        /// </summary>
        /// <returns>A string containing the information of this animal.
        ///          The format of the returned string is
        ///          "Cat: <ChipRegistrationNumber>, <DateOfBirth>, <Name>, <IsReserved>, <BadHabits>"
        ///          Where: DateOfBirth will be "00-00-0000" if unknown or the actual date otherwise.
        ///                 Name will be "noname" if unknown or the actual name otherwise.
        ///                 IsReserved will be "reserved" if reserved or "not reserved" otherwise.
        ///                 BadHabits will be "none" if none present or a description of the actual habits otherwise.
        /// </returns>
        /// 
        public override string ToString()
        {
            if (BadHabits == "")
            {
                return base.ToString() + ", badhabits: " + "none";
            }
            return base.ToString() + ", badhabits: " + BadHabits.ToString();
        }

        public override int Price
        {
            get
            {
                if (price < 20)
                {
                    return 20;
                }
                return price;
            }
        }
        
    }
}
