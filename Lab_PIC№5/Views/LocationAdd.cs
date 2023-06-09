using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab_PIC_5.Controllers;
using Lab_PIC_5.Data;
using Lab_PIC_5.Models;

namespace Lab_PIC_5.Views
{
    public partial class LocationAdd : Form
    {
        public LocationAdd()
        {
            InitializeComponent();
        }

        private void OKcontAdd_Click(object sender, EventArgs e)
        {
            var loc = new Location(LocationCostReposiroty.locationCosts.Max(x => x.IdLocation) + 1, CityText.Text);
            LocationCostReposiroty.locationCosts.Add(loc);
            this.Close();
        }

        private void CancelcontEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
