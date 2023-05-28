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

namespace Lab_PIC_5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateData();
            SetDataGrid();
        }

        private void CreateData()
        {
            ActRepository.AddTestActs();
        }

        private void SetDataGrid()
        {
            var actss = ActService.ShowAct();
            foreach (var organization in actss)
            {
                actsGridView.Rows.Add(organization);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }
    }
}
