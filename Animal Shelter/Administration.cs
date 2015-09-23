using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    public class Administration
    {
        private List<Animal> animalList = new List<Animal>();
        public List<Animal> Animallist
        {
            get { return animalList; }
            private set { animalList = value; }
        }

        public Administration()
        {

        }

        public bool Add(Animal animal)
        {
            if (animal != null)
            {
                if (FindAnimal(animal.ChipRegistrationNumber) == null)
                {
                    animalList.Add(animal);
                    return true;
                }
            }
            return false;
        }

        public bool RemoveAnimal(string chipRegistrationNumber)
        {
            if (FindAnimal(chipRegistrationNumber) != null)
            {
                animalList.Remove(FindAnimal(chipRegistrationNumber));
                return true;
            }
            return false;
        }

        public Animal FindAnimal(string chipRegistrationNumber)
        {
            foreach (Animal a in animalList)
            {
                if (chipRegistrationNumber == a.ChipRegistrationNumber)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
