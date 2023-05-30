using Lab_PIC_5.Controllers;
using Lab_PIC_5.Data;
using Lab_PIC_5.Models;
using Lab_PIC_5.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_PIC_5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateData();
            SetDataGrid();
            
            SetDataGridApp();
            SetDataGridOrg();
            
        }
        DataSet dsApplication = new DataSet();
        DataSet dsOrganization = new DataSet();
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateData()
        {
            ActRepository.AddTestActs();
        }
        private void SetDataGridOrg()
        {
            /*-Organization-------------------------*/

            dsOrganization.Tables.Clear();
            dsOrganization.Tables.Add("Score");
            dsOrganization.Tables[0].Columns.Add("Наименование");
            dsOrganization.Tables[0].Columns.Add("ИНН");
            dsOrganization.Tables[0].Columns.Add("КПП");
            dsOrganization.Tables[0].Columns.Add("Адрес регистрации");
            dsOrganization.Tables[0].Columns.Add("Тип");
            dsOrganization.Tables[0].Columns.Add("Статус");
            var orgs = OrgService.ShowOrganizations();
            foreach (var org in orgs)
            {
                dsOrganization.Tables[0].Rows.Add(org);
            }
            dataGridViewOrg.DataSource = dsOrganization.Tables[0];
        }
        private void SetDataGridApp()
        {
            /*-Applications-------------------------*/
            dsApplication.Tables.Clear();
            dsApplication.Tables.Add("Score");
            dsApplication.Tables[0].Columns.Add("Дата подачи");
            dsApplication.Tables[0].Columns.Add("Номер");
            dsApplication.Tables[0].Columns.Add("Населенный пункт");
            dsApplication.Tables[0].Columns.Add("Территория");
            dsApplication.Tables[0].Columns.Add("Место обитания");
            dsApplication.Tables[0].Columns.Add("Срочность исполнения");
            dsApplication.Tables[0].Columns.Add("Описание животного");
            dsApplication.Tables[0].Columns.Add("Категория заявителя");
            var apps = AppService.ShowApplication();
            foreach (var app in apps)
            {
                dsApplication.Tables[0].Rows.Add(app);
            }
            dataGridViewApp.DataSource = dsApplication.Tables[0];
        }

        private void SetDataGrid()
        {
            DataGridViewActs.Rows.Clear();
            var actss = ActService.ShowAct();
            foreach (var organization in actss)
            {
                DataGridViewActs.Rows.Add(organization);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ActEdit editWindow = new ActEdit();
            editWindow.ShowDialog();
            SetDataGrid();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ActEdit editWindow = new ActEdit(int.Parse(DataGridViewActs.CurrentRow.Cells[0].Value.ToString()));
            editWindow.ShowDialog();
            SetDataGrid();
        }
        /*------------------------------------------------------------------*/
        private void AppDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewApp.CurrentRow != null)
            {
                int app = Convert.ToInt32(dataGridViewApp.CurrentRow.Cells[1].Value.ToString());
                AppService.DeleteApplication(app);
                SetDataGridApp();
            }
        }

        private void AppEdit_Click(object sender, EventArgs e)
        {
            //AppService.EditApplication(app);
            //SetDataGridApp();
        }

        private void OrgDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrg.CurrentRow != null)
            {
                string org = dataGridViewOrg.CurrentRow.Cells[1].Value.ToString();
                OrgService.DeleteOrganization(org);
                SetDataGridOrg();
            }
        }
    }
}
