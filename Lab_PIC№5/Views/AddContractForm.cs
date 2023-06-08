﻿using Lab_PIC_5.Controllers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Lab_PIC_5.Views
{
    public partial class AddContractForm : Form
    {
        private bool ContToEdit;
        private int ContId;
        public AddContractForm()
        {
            InitializeComponent();
            ContToEdit = false;
            FillEditor();
        }
        public AddContractForm(int id)
        {
            InitializeComponent();
            ContToEdit = true;
            ContId = id;
            FillEditor();
        }
        private void FillEditor()
        {
            if (ContToEdit)
            {
                var index = ContractRepository.contract.FindIndex(x => x.IdContract == ContId);
                Contract cont = ContractRepository.contract[index];
                dateConclusion.Value = cont.DateConclusion;
                dateAction.Value = cont.ActionDate;
                FullComboBox();
                cityCombo.Text = cont.LocationCost.City;
                CostText.Text = cont.Cost.ToString();
                customerCombo.Text = cont.Costumer.ToString();
                executerCombo.Text = cont.Executer.ToString();
            }
            else
            {
                FullComboBox();
            }
        }

        private void FullComboBox()
        {
            cityCombo.DataSource = new BindingSource(
                                    LocationCostReposiroty.locationCosts, null);
            cityCombo.DisplayMember = "City";
            cityCombo.ValueMember = "IdLocation";

            

            executerCombo.DataSource = new BindingSource(
                                    OrgRepository.Organizations, null);
            executerCombo.DisplayMember = "name";
            executerCombo.ValueMember = "idOrg";

            customerCombo.DataSource = new BindingSource(
                                     OrgRepository.Organizations, null);
            customerCombo.DisplayMember = "name";
            customerCombo.ValueMember = "idOrg";
        }

        private void CancelcontEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKcontAdd_Click(object sender, EventArgs e)
        {
            if (ContToEdit)
            {
                var cont = new string[] {ContId.ToString(), dateConclusion.Value.ToString(), 
                                    dateAction.Value.ToString(), cityCombo.SelectedValue.ToString(),
                                    CostText.Text, executerCombo.SelectedValue.ToString(),
                                    customerCombo.SelectedValue.ToString() };
                ContractService.EditCont(cont);
            }
            else
            {
                //var loc = new LocationCost(LocationCostReposiroty.locationCosts.Max(x => x.IdLocation) + 1,
                //                            cityCombo.SelectedValue.ToString());
                var id = ContractRepository.contract.Max(x => x.IdContract) + 1;
                var cont = new Contract(id,
                                    dateConclusion.Value, dateAction.Value,
                                    LocationCostReposiroty.locationCosts[int.Parse(cityCombo.SelectedValue.ToString()) - 1],
                                    int.Parse(CostText.Text),
                                    OrgRepository.Organizations[int.Parse(executerCombo.SelectedValue.ToString())- 1],
                                    OrgRepository.Organizations[int.Parse(customerCombo.SelectedValue.ToString()) - 1]);
                ContractService.AddContract(cont);
            }
            this.Close();
        }
    }
}
