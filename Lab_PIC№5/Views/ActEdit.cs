using Lab_PIC_5.Data;
using Lab_PIC_5.Models;
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

        private AnimalCard FindAnimalCard(int idAnimalCard)
        {
            var index = ActRepository.animalCards.FindIndex(x => x.IdAnimalCard == idAnimalCard);
            return ActRepository.animalCards[index];
        }

        private void FillEditor()
        {
            if (actToEdit)
            {
                var index = ActRepository.acts.FindIndex(x => x.ActNumber == actId);
                Act act = ActRepository.acts[index];
                dateAct.Value = act.Date;
                TextBoxContracts.Text = act.Contracts;
                TextBoxApplication.Text = act.Application;

                comboBoxOrganization.DataSource = new BindingSource(
                        OrgRepository.Organizations, null);
                comboBoxOrganization.DisplayMember = "name";
                comboBoxOrganization.ValueMember = "idOrg";
                comboBoxOrganization.Text = act.Organization.name;
                
                ComboBoxAnimalCard.DataSource = new BindingSource(
                        ActRepository.animalCards, null);
                ComboBoxAnimalCard.DisplayMember = "Kind";
                ComboBoxAnimalCard.ValueMember = "IdAnimalCard";
                ComboBoxAnimalCard.Text = act.AnimalCard.Kind;
            }
            else
            {
                comboBoxOrganization.DataSource = new BindingSource(
                        OrgRepository.Organizations, null);
                comboBoxOrganization.DisplayMember = "name";
                comboBoxOrganization.ValueMember = "idOrg";

                ComboBoxAnimalCard.DataSource = new BindingSource(
                        ActRepository.animalCards, null);
                ComboBoxAnimalCard.DisplayMember = "Kind";
                ComboBoxAnimalCard.ValueMember = "IdAnimalCard";
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка в доработке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //if (actToEdit)
            //{
            //    var act = new Act(actId, dateAct.Value, TextBoxOrganization.Text, TextBoxContracts.Text, 
            //                      TextBoxApplication.Text, FindAnimalCard((int)ComboBoxAnimalCard.SelectedValue));
            //    ActService.EditAct(act);
            //}
        }
    }
}
