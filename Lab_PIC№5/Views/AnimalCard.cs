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
    public partial class AnimalCardForm : Form
    {
        private string[] allAct;
        public AnimalCardForm(string[] act)
        {
            InitializeComponent();
            allAct = act;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            ActService.Save(allAct);

        }
    }
}
