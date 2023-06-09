
namespace Lab_PIC_5.Views
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.НС = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ЗЗ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ОЖ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.С = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(15, 34);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(119, 20);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(140, 34);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(119, 20);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // comboBoxSity
            // 
            this.comboBoxSity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSity.FormattingEnabled = true;
            this.comboBoxSity.Location = new System.Drawing.Point(520, 142);
            this.comboBoxSity.Name = "comboBoxSity";
            this.comboBoxSity.Size = new System.Drawing.Size(119, 21);
            this.comboBoxSity.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата конца";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Город";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата начала";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.НС,
            this.ЗЗ,
            this.ОЖ,
            this.С});
            this.dataGridView.Location = new System.Drawing.Point(12, 60);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(477, 222);
            this.dataGridView.TabIndex = 7;
            // 
            // НС
            // 
            this.НС.HeaderText = "Населённый пункт";
            this.НС.Name = "НС";
            this.НС.ReadOnly = true;
            // 
            // ЗЗ
            // 
            this.ЗЗ.HeaderText = "Закрытые заявки";
            this.ЗЗ.Name = "ЗЗ";
            this.ЗЗ.ReadOnly = true;
            // 
            // ОЖ
            // 
            this.ОЖ.HeaderText = "Отловленные животные";
            this.ОЖ.Name = "ОЖ";
            this.ОЖ.ReadOnly = true;
            // 
            // С
            // 
            this.С.HeaderText = "Стоимость";
            this.С.Name = "С";
            this.С.ReadOnly = true;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(382, 300);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum.TabIndex = 8;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 332);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSity);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёт";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox comboBoxSity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn НС;
        private System.Windows.Forms.DataGridViewTextBoxColumn ЗЗ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ОЖ;
        private System.Windows.Forms.DataGridViewTextBoxColumn С;
        private System.Windows.Forms.TextBox textBoxSum;
    }
}