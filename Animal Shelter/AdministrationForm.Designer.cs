namespace AnimalShelter
{
    partial class AdministrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSpecialAttribute = new System.Windows.Forms.Label();
            this.tbChipRegistrationNumber = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.dtpLastWalkDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBadHabits = new System.Windows.Forms.TextBox();
            this.gbAddAnimal = new System.Windows.Forms.GroupBox();
            this.gbSellAnimal = new System.Windows.Forms.GroupBox();
            this.lblAnimalPrice = new System.Windows.Forms.Label();
            this.btnSellAnimal = new System.Windows.Forms.Button();
            this.lbSellAnimal = new System.Windows.Forms.ListBox();
            this.gbReserveAnimal = new System.Windows.Forms.GroupBox();
            this.btnFree = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.lbNotReservedAnimals = new System.Windows.Forms.ListBox();
            this.lbReservedAnimals = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbAddAnimal.SuspendLayout();
            this.gbSellAnimal.SuspendLayout();
            this.gbReserveAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(76, 28);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.animalTypeComboBox.TabIndex = 0;
            this.animalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.animalTypeComboBox_SelectedIndexChanged);
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(212, 169);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Animal: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chip: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name: ";
            // 
            // lblSpecialAttribute
            // 
            this.lblSpecialAttribute.AutoSize = true;
            this.lblSpecialAttribute.Location = new System.Drawing.Point(6, 149);
            this.lblSpecialAttribute.Name = "lblSpecialAttribute";
            this.lblSpecialAttribute.Size = new System.Drawing.Size(55, 13);
            this.lblSpecialAttribute.TabIndex = 6;
            this.lblSpecialAttribute.Text = "LastWalk:";
            // 
            // tbChipRegistrationNumber
            // 
            this.tbChipRegistrationNumber.Location = new System.Drawing.Point(76, 59);
            this.tbChipRegistrationNumber.Name = "tbChipRegistrationNumber";
            this.tbChipRegistrationNumber.Size = new System.Drawing.Size(200, 20);
            this.tbChipRegistrationNumber.TabIndex = 8;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(76, 91);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 20);
            this.tbName.TabIndex = 9;
            // 
            // dtpLastWalkDate
            // 
            this.dtpLastWalkDate.Location = new System.Drawing.Point(76, 143);
            this.dtpLastWalkDate.Name = "dtpLastWalkDate";
            this.dtpLastWalkDate.Size = new System.Drawing.Size(200, 20);
            this.dtpLastWalkDate.TabIndex = 10;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(76, 117);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Date of Birth:";
            // 
            // tbBadHabits
            // 
            this.tbBadHabits.Location = new System.Drawing.Point(76, 143);
            this.tbBadHabits.Name = "tbBadHabits";
            this.tbBadHabits.Size = new System.Drawing.Size(200, 20);
            this.tbBadHabits.TabIndex = 14;
            this.tbBadHabits.Visible = false;
            // 
            // gbAddAnimal
            // 
            this.gbAddAnimal.Controls.Add(this.label1);
            this.gbAddAnimal.Controls.Add(this.animalTypeComboBox);
            this.gbAddAnimal.Controls.Add(this.tbChipRegistrationNumber);
            this.gbAddAnimal.Controls.Add(this.tbName);
            this.gbAddAnimal.Controls.Add(this.label4);
            this.gbAddAnimal.Controls.Add(this.label2);
            this.gbAddAnimal.Controls.Add(this.label3);
            this.gbAddAnimal.Controls.Add(this.tbBadHabits);
            this.gbAddAnimal.Controls.Add(this.dtpLastWalkDate);
            this.gbAddAnimal.Controls.Add(this.lblSpecialAttribute);
            this.gbAddAnimal.Controls.Add(this.dtpDateOfBirth);
            this.gbAddAnimal.Controls.Add(this.createAnimalButton);
            this.gbAddAnimal.Location = new System.Drawing.Point(12, 11);
            this.gbAddAnimal.Name = "gbAddAnimal";
            this.gbAddAnimal.Size = new System.Drawing.Size(289, 203);
            this.gbAddAnimal.TabIndex = 17;
            this.gbAddAnimal.TabStop = false;
            this.gbAddAnimal.Text = "Add Animal";
            // 
            // gbSellAnimal
            // 
            this.gbSellAnimal.Controls.Add(this.lblAnimalPrice);
            this.gbSellAnimal.Controls.Add(this.btnSellAnimal);
            this.gbSellAnimal.Controls.Add(this.lbSellAnimal);
            this.gbSellAnimal.Location = new System.Drawing.Point(307, 12);
            this.gbSellAnimal.Name = "gbSellAnimal";
            this.gbSellAnimal.Size = new System.Drawing.Size(216, 202);
            this.gbSellAnimal.TabIndex = 18;
            this.gbSellAnimal.TabStop = false;
            this.gbSellAnimal.Text = "Sell Animal";
            // 
            // lblAnimalPrice
            // 
            this.lblAnimalPrice.AutoSize = true;
            this.lblAnimalPrice.Location = new System.Drawing.Point(6, 173);
            this.lblAnimalPrice.Name = "lblAnimalPrice";
            this.lblAnimalPrice.Size = new System.Drawing.Size(34, 13);
            this.lblAnimalPrice.TabIndex = 16;
            this.lblAnimalPrice.Text = "Price:";
            // 
            // btnSellAnimal
            // 
            this.btnSellAnimal.Location = new System.Drawing.Point(142, 168);
            this.btnSellAnimal.Name = "btnSellAnimal";
            this.btnSellAnimal.Size = new System.Drawing.Size(64, 23);
            this.btnSellAnimal.TabIndex = 15;
            this.btnSellAnimal.Text = "Sell";
            this.btnSellAnimal.UseVisualStyleBackColor = true;
            this.btnSellAnimal.Click += new System.EventHandler(this.btnDeleteAnimal_Click);
            // 
            // lbSellAnimal
            // 
            this.lbSellAnimal.FormattingEnabled = true;
            this.lbSellAnimal.Location = new System.Drawing.Point(6, 28);
            this.lbSellAnimal.Name = "lbSellAnimal";
            this.lbSellAnimal.Size = new System.Drawing.Size(181, 134);
            this.lbSellAnimal.TabIndex = 2;
            this.lbSellAnimal.SelectedIndexChanged += new System.EventHandler(this.lbSellAnimal_SelectedIndexChanged);
            // 
            // gbReserveAnimal
            // 
            this.gbReserveAnimal.Controls.Add(this.btnFree);
            this.gbReserveAnimal.Controls.Add(this.btnReserve);
            this.gbReserveAnimal.Controls.Add(this.lbNotReservedAnimals);
            this.gbReserveAnimal.Controls.Add(this.lbReservedAnimals);
            this.gbReserveAnimal.Controls.Add(this.label6);
            this.gbReserveAnimal.Controls.Add(this.label5);
            this.gbReserveAnimal.Location = new System.Drawing.Point(12, 220);
            this.gbReserveAnimal.Name = "gbReserveAnimal";
            this.gbReserveAnimal.Size = new System.Drawing.Size(511, 231);
            this.gbReserveAnimal.TabIndex = 19;
            this.gbReserveAnimal.TabStop = false;
            this.gbReserveAnimal.Text = "Reserve Animal";
            // 
            // btnFree
            // 
            this.btnFree.Location = new System.Drawing.Point(212, 108);
            this.btnFree.Name = "btnFree";
            this.btnFree.Size = new System.Drawing.Size(64, 25);
            this.btnFree.TabIndex = 16;
            this.btnFree.Text = "<- Free";
            this.btnFree.UseVisualStyleBackColor = true;
            this.btnFree.Click += new System.EventHandler(this.btnFree_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(212, 79);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(64, 23);
            this.btnReserve.TabIndex = 15;
            this.btnReserve.Text = "Reserve ->";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // lbNotReservedAnimals
            // 
            this.lbNotReservedAnimals.FormattingEnabled = true;
            this.lbNotReservedAnimals.Location = new System.Drawing.Point(9, 46);
            this.lbNotReservedAnimals.Name = "lbNotReservedAnimals";
            this.lbNotReservedAnimals.Size = new System.Drawing.Size(197, 173);
            this.lbNotReservedAnimals.TabIndex = 10;
            // 
            // lbReservedAnimals
            // 
            this.lbReservedAnimals.FormattingEnabled = true;
            this.lbReservedAnimals.Location = new System.Drawing.Point(282, 46);
            this.lbReservedAnimals.Name = "lbReservedAnimals";
            this.lbReservedAnimals.Size = new System.Drawing.Size(200, 173);
            this.lbReservedAnimals.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Not Reserved";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reserved";
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 462);
            this.Controls.Add(this.gbReserveAnimal);
            this.Controls.Add(this.gbSellAnimal);
            this.Controls.Add(this.gbAddAnimal);
            this.Name = "AdministrationForm";
            this.Text = "Animal Shelter Administration";
            this.gbAddAnimal.ResumeLayout(false);
            this.gbAddAnimal.PerformLayout();
            this.gbSellAnimal.ResumeLayout(false);
            this.gbSellAnimal.PerformLayout();
            this.gbReserveAnimal.ResumeLayout(false);
            this.gbReserveAnimal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSpecialAttribute;
        private System.Windows.Forms.TextBox tbChipRegistrationNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dtpLastWalkDate;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBadHabits;
        private System.Windows.Forms.GroupBox gbAddAnimal;
        private System.Windows.Forms.GroupBox gbSellAnimal;
        private System.Windows.Forms.Button btnSellAnimal;
        private System.Windows.Forms.ListBox lbSellAnimal;
        private System.Windows.Forms.GroupBox gbReserveAnimal;
        private System.Windows.Forms.Button btnFree;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.ListBox lbNotReservedAnimals;
        private System.Windows.Forms.ListBox lbReservedAnimals;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAnimalPrice;
    }
}

