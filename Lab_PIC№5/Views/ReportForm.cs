﻿using Lab_PIC_5.Controllers;
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            GenereteReport();
        }

        public void GenereteReport()
        {
            dataGridViewR.Rows.Clear();
            var reports = ReportService.GenereteReport(dateTimePickerStart.Value, dateTimePickerEnd.Value);
            int sum = 0;
            foreach (var rep in reports)
            {
                dataGridViewR.Rows.Add(rep);
                sum += int.Parse(rep[3]);
            }
            textBoxSum.Text = sum.ToString();
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            GenereteReport();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
