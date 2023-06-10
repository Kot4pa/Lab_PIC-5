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
using System.Xml.Linq;

namespace Lab_PIC_5.Views
{
    public partial class OrgEdit : Form
    {
        private string OrgId;
        public OrgEdit()
        {
            InitializeComponent();
        }

        public OrgEdit(string id)
        {
            InitializeComponent();
            OrgId = id;
            FillOrgEdit();
            name.Items.Clear();
            name.Items.Add("МКУ 'ЛесПаркХоз'");
            name.Items.Add("ГосОтлов");
            name.Items.Add("ПРОО 'Общество защиты животных'");

            AdressReg.Items.Clear();
            AdressReg.Items.Add("г. Москва, Ленина 56");
            AdressReg.Items.Add("г. Москва, Абрамцевская 34");
            AdressReg.Items.Add("г. Тюмень, Мельникайте 48");
        }

        private void FillOrgEdit()
        {
            var Idorg = OrgRepository.Organizations.FindIndex(x => x.idOrg == Convert.ToInt32(OrgId));
            Organization org = OrgRepository.Organizations[Idorg];
            name.Text = org.name;
            INN.Text = org.INN;
            KPP.Text = org.KPP;
            AdressReg.Text = org.registrationAdress;
            Type.Text = org.type;
            Status.Text = org.status;
        }

        private void OKorgEdit_Click(object sender, EventArgs e)
        {


            var org = new Organization(Convert.ToInt32(OrgId), name.Text, INN.Text, KPP.Text, AdressReg.Text, Type.Text, Status.Text);
            OrgService.EditOrganization(org);
            this.Close();
        }

        private void CancelOrgEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
