using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;

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
        public List<string> loadAnimals()
        {
            string readPath = @"C:\Users\Laurent\Desktop\Animals.txt";
            List<string> file_contents = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(readPath))
                {
                    while (!sr.EndOfStream)
                    {
                        file_contents.Add(sr.ReadLine());
                    }
                }
                return file_contents;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("FileNotFoundException: " + e.Message);
            }
            catch (FileLoadException e)
            {
                Console.WriteLine("FileLoadException: " + e.Message);
            }
            return null;
        }

        public bool saveAnimals()
        {
            string savePath = @"C:\Users\Laurent\Desktop\Animals.txt";
            try
            {
                using (StreamWriter sw = File.CreateText(savePath))
                {
                    foreach (Animal a in animalList)
                    {
                        sw.WriteLine(a.ToString());
                    }
                }
                return true;
            }
            catch (IOException e)
            {
                Console.WriteLine("IOException: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occured: " + e.Message);
            }
            return false;
        }

        public void objectWriter()
        {
            DataContractSerializer dcs = new DataContractSerializer(typeof(Dog));

            using (FileStream f = new FileStream(@"C:\Users\Laurent\Desktop\file.xml",
                   FileMode.Create, FileAccess.Write))
            {
                foreach (Dog d in animalList)
                {
                    dcs.WriteObject(f, d);
                }                            // Wegschrijven
            }

            using (FileStream f = new FileStream("file.xml",
                   FileMode.Open, FileAccess.Read))
            {
                Dog dog = dcs.ReadObject(f) as Dog; // Uitlezen
            }

        }
    }
}
