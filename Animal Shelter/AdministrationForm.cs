using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        Administration administration = new Administration();
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;

            loadPremades();           
        }

        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            SimpleDate DateOfBirth = new SimpleDate(dtpDateOfBirth.Value.Day, dtpDateOfBirth.Value.Month, dtpDateOfBirth.Value.Year);

            int chipNumber;
            bool result = Int32.TryParse(tbChipRegistrationNumber.Text, out chipNumber);
            if (result)
            {
                if (animalTypeComboBox.Text == "Dog")
                {
                    SimpleDate LastWalkDate = new SimpleDate(dtpLastWalkDate.Value.Day, dtpLastWalkDate.Value.Month, dtpLastWalkDate.Value.Year);
                    bool addControle = administration.Add(new Dog(tbChipRegistrationNumber.Text, DateOfBirth, tbName.Text, LastWalkDate));
                    if (addControle)
                    {
                        MessageBox.Show("Dog has been added succesfully");
                    }
                    else
                    {
                        MessageBox.Show("Please use a unique Chipnumber");
                    }                    
                }
                else if(animalTypeComboBox.Text == "Cat")
                {
                    bool addControle = administration.Add(new Cat(tbChipRegistrationNumber.Text, DateOfBirth, tbName.Text, tbBadHabits.Text));
                    if (addControle)
                    {
                        MessageBox.Show("Cat has been added succesfully");
                    }
                    else
                    {
                        MessageBox.Show("Please use a unique Chipnumber");
                    }
                }
            }
            reloadLists();
        }
        
        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (animalTypeComboBox.Text == "Cat")
            {
                tbBadHabits.Visible = true;
                dtpLastWalkDate.Visible = false;
                lblSpecialAttribute.Text = "Bad Habits:";
            }
            else
            {
                tbBadHabits.Visible = false;
                dtpLastWalkDate.Visible = true;
                lblSpecialAttribute.Text = "Last Walk :";
            }
        }

        public void reloadLists()
        {
            //sorteer op prijs
            administration.Animallist.Sort();

            lbSellAnimal.Items.Clear();
            lbNotReservedAnimals.Items.Clear();
            lbReservedAnimals.Items.Clear();            
            
            foreach(Animal a in administration.Animallist)
            {
                
                if (a.IsReserved)
                {
                    lbReservedAnimals.Items.Add(a);
                }
                else
                {
                    lbNotReservedAnimals.Items.Add(a);
                }
                lbSellAnimal.Items.Add(a);
            }            
        }

        private void btnDeleteAnimal_Click(object sender, EventArgs e)
        {
            Animal animal = lbSellAnimal.SelectedItem as Animal;
            if (animal != null)
            {
                foreach (Animal a in administration.Animallist)
                {
                    if (a.ChipRegistrationNumber == animal.ChipRegistrationNumber)
                    {
                        bool removeControle = administration.RemoveAnimal(a.ChipRegistrationNumber);
                        if (removeControle)
                        {
                            MessageBox.Show("Animal has been removed");
                            reloadLists();
                            lblAnimalPrice.Text = "Price: ";
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Something went wrong");
                        }
                    }
                }
            }                
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Animal animal = lbNotReservedAnimals.SelectedItem as Animal;
            if (animal != null)
            {
                animal.IsReserved = true;
                reloadLists();
            }            
        }

        private void btnFree_Click(object sender, EventArgs e)
        {
            Animal animal = lbReservedAnimals.SelectedItem as Animal;
            if (animal != null)
            {
                animal.IsReserved = false;
                reloadLists();
            }            
        }

        private void lbSellAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal animal = lbSellAnimal.SelectedItem as Animal;
            if (animal != null)
            {
                lblAnimalPrice.Text = "Price: $" + animal.Price.ToString();
            }
        }

        public void loadPremades()
        {

            SimpleDate premadeBirth1 = new SimpleDate(06, 11, 1996);
            SimpleDate premadeLWD1 = new SimpleDate(22, 09, 2015);
            SimpleDate premadeBirth2 = new SimpleDate(22, 08, 2002);
            SimpleDate premadeLWD2 = new SimpleDate(15, 08, 2015);

            //Dogs
            administration.Add(new Dog("00001", premadeBirth1, "Piet", premadeLWD1));
            administration.Add(new Dog("00002", premadeBirth2, "Jan", premadeLWD1));
            administration.Add(new Dog("50003", premadeBirth1, "Bert", premadeLWD2));
            administration.Add(new Dog("50004", premadeBirth2, "Kees", premadeLWD2));

            //Cats
            administration.Add(new Cat("00005", premadeBirth1, "Maarten", "Hates children"));
            administration.Add(new Cat("00006", premadeBirth2, "Arjan", "Attacks virgins"));
            administration.Add(new Cat("00007", premadeBirth1, "Robin", "Opens your browserhistory"));
            administration.Add(new Cat("00008", premadeBirth2, "Luigi", "Destroys your furniture"));

            reloadLists();

        }
    }
}
