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

namespace Lab_PIC_5.Views
{
    public partial class AppAdd : Form
    {
        public AppAdd()
        {
            InitializeComponent();
        }

        private void OkAppAdd_Click(object sender, EventArgs e)
        {
            var app = new App(date.Text, (AppRepository.Applicatiions.Count + 1).ToString(), loc.Text, territory.Text, animalHabbiat.Text, urgency.Text, descrip.Text, categoryApp.Text);
            AppService.AddApplication(app);
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
