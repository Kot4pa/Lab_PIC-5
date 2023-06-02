using Lab_PIC_5.Controllers;
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
        public AddContractForm()
        {
            InitializeComponent();
        }

        private void CancelcontEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OKcontAdd_Click(object sender, EventArgs e)
        {
            var nloc = new LocationCost(ContractRepository.locationCost.Count + 1, cityText.Text, costText.Text);
            var ncont = new Contract(ContractRepository.contract.Count + 1, dateConclusion.Value, dateAction.Value, nloc, nloc, executerText.Text, costumerText.Text);
            ContractService.AddContract(ncont);
            this.Close();
        }
    }
}
