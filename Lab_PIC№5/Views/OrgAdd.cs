using Lab_PIC_5.Controllers;
using Lab_PIC_5.Data;
using Lab_PIC_5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_PIC_5.Views
{
    public partial class OrgAdd : Form
    {
        public OrgAdd()
        {
            InitializeComponent();
        }

        private void OKorgAdd_Click(object sender, EventArgs e)
        {
            var org = new Organization(OrgRepository.Organizations.Count+1, name.Text, INN.Text, KPP.Text, AdressReg.Text, Type.Text, Status.Text);
            OrgService.AddOrganization(org);
            this.Close();
        }

        private void CancelOrgEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
