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

        private void FillEditor()
        {
            if (actToEdit)
            {
                var index = ActRepository.acts.FindIndex(x => x.ActNumber == actId);
                Act act = ActRepository.acts[index];
                dateAct.Value = act.Date;
                FullComboBox();
                comboBoxOrganization.Text = act.Organization.name;
                comboBoxContract.Text = act.Contracts.Executer;
                comboBoxApp.Text = act.Application.animalHabiat;
                ComboBoxAnimalCard.Text = act.AnimalCard.Kind;
            }
            else
            {
                FullComboBox();
            }
        }

        private void FullComboBox()
        {
            comboBoxOrganization.DataSource = new BindingSource(
                                    OrgRepository.Organizations, null);
            comboBoxOrganization.DisplayMember = "name";
            comboBoxOrganization.ValueMember = "idOrg";

            comboBoxContract.DataSource = new BindingSource(
                    ContractRepository.contract, null);
            comboBoxContract.DisplayMember = "Executer";
            comboBoxContract.ValueMember = "IdContract";

            comboBoxApp.DataSource = new BindingSource(
                    AppRepository.Applicatiions, null);
            comboBoxApp.DisplayMember = "animalHabiat";
            comboBoxApp.ValueMember = "number";

            ComboBoxAnimalCard.DataSource = new BindingSource(
                    ActRepository.animalCards, null);
            ComboBoxAnimalCard.DisplayMember = "Kind";
            ComboBoxAnimalCard.ValueMember = "IdAnimalCard";
        }

        private void OK_Click(object sender, EventArgs e)
        { 
            if (actToEdit)
            {
                var act = new string[] {actId.ToString(), dateAct.Value.ToString(), comboBoxOrganization.SelectedValue.ToString(), 
                                    comboBoxContract.SelectedValue.ToString(), comboBoxApp.SelectedValue.ToString(), ComboBoxAnimalCard.SelectedValue.ToString() };
                ActService.EditAct(act);
            }
            else
                MessageBox.Show("Кнопка в доработке", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
