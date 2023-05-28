using Lab_PIC_5.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_PIC_5.Views
{
    public partial class ActEdit : Form
    {
        private bool actToEdit;
        private int actId;
        
        public ActEdit()
        {
            InitializeComponent();
            actToEdit = false;
            FillEditor();
        }
        public ActEdit(int id)
        {
            InitializeComponent();
            actToEdit = true;
            actId = id;
            FillEditor();
        }

        private void FillEditor()
        {
            if (actToEdit)
            {
                var index = ActRepository.acts.FindIndex(x => x.ActNumber == actId);
                Act act = ActRepository.acts[index];
                dateAct.Value = act.Date;
                organizationTextBox.Text = act.Organization;
                contractsTextBox.Text = act.Contracts;
                applicationTextBox.Text = act.Application;
                animalCardComboBox.DataSource = new BindingSource(
                        ActRepository.animalCards, null);
                animalCardComboBox.DisplayMember = "Kind";
                animalCardComboBox.ValueMember = "IdAnimalCard";
                animalCardComboBox.Text = act.AnimalCard.Kind;
            }
            else
            {
                animalCardComboBox.DataSource = new BindingSource(
                        ActRepository.animalCards, null);
                animalCardComboBox.DisplayMember = "Kind";
                animalCardComboBox.ValueMember = "IdAnimalCard";
            }
        }
    }
}
