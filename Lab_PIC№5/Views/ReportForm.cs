using Lab_PIC_5.Controllers;
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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            GenereteReport();
        }

        private void GenereteReport()
        {
            ReportService.GenereteReport(dateTimePickerStart.Value, dateTimePickerEnd.Value);
        }
    }
}
