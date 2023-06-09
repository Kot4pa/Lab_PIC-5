using Lab_PIC_5.Controllers;
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

namespace Lab_PIC_5.Views
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            GenereteReport();
        }

        public void GenereteReport()
        {
            var reports = ReportService.GenereteReport(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            foreach (var rep in reports)
                dataGridViewR.Rows.Add(rep);
        }
    }
}
