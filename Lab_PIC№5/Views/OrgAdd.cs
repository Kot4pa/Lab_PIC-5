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
            name.Items.Add("МКУ 'ЛесПаркХоз'");
            name.Items.Add("ГосОтлов");
            name.Items.Add("ПРОО 'Общество защиты животных'");

            AdressReg.Items.Clear();
            AdressReg.Items.Add("г. Москва, Ленина 56");
            AdressReg.Items.Add("г. Москва, Абрамцевская 34");
            AdressReg.Items.Add("г. Тюмень, Мельникайте 48");
        }

        private void OKorgAdd_Click(object sender, EventArgs e)
        {
            var org = new Organization(OrgRepository.Organizations.Max(x => x.idOrg) + 1, name.Text, INN.Text, KPP.Text, AdressReg.Text, Type.Text, Status.Text);
            OrgService.AddOrganization(org);
            this.Close();
        }

        private void CancelOrgEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
