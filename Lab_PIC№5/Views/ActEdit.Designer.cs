
namespace Lab_PIC_5.Views
{
    partial class ActEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateAct = new System.Windows.Forms.DateTimePicker();
            this.comboBoxOrganization = new System.Windows.Forms.ComboBox();
            this.comboBoxContract = new System.Windows.Forms.ComboBox();
            this.comboBoxApp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Isus = new System.Windows.Forms.Label();
            this.numericUpDownDog = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(174, 215);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(93, 215);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Организация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Контракты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Заявка";
            // 
            // dateAct
            // 
            this.dateAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAct.Location = new System.Drawing.Point(172, 109);
            this.dateAct.Name = "dateAct";
            this.dateAct.Size = new System.Drawing.Size(76, 20);
            this.dateAct.TabIndex = 11;
            this.dateAct.Value = new System.DateTime(2023, 5, 29, 1, 20, 48, 0);
            // 
            // comboBoxOrganization
            // 
            this.comboBoxOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrganization.FormattingEnabled = true;
            this.comboBoxOrganization.Location = new System.Drawing.Point(131, 82);
            this.comboBoxOrganization.Name = "comboBoxOrganization";
            this.comboBoxOrganization.Size = new System.Drawing.Size(117, 21);
            this.comboBoxOrganization.TabIndex = 13;
            // 
            // comboBoxContract
            // 
            this.comboBoxContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxContract.FormattingEnabled = true;
            this.comboBoxContract.Location = new System.Drawing.Point(131, 188);
            this.comboBoxContract.Name = "comboBoxContract";
            this.comboBoxContract.Size = new System.Drawing.Size(118, 21);
            this.comboBoxContract.TabIndex = 14;
            // 
            // comboBoxApp
            // 
            this.comboBoxApp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApp.FormattingEnabled = true;
            this.comboBoxApp.Location = new System.Drawing.Point(131, 161);
            this.comboBoxApp.Name = "comboBoxApp";
            this.comboBoxApp.Size = new System.Drawing.Size(118, 21);
            this.comboBoxApp.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Цель отлова";
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(131, 135);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(118, 20);
            this.textBoxTarget.TabIndex = 17;
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Location = new System.Drawing.Point(12, 59);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(101, 13);
            this.R.TabIndex = 20;
            this.R.Text = "Количество кошек";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Количество собак";
            // 
            // Isus
            // 
            this.Isus.AutoSize = true;
            this.Isus.Location = new System.Drawing.Point(61, 9);
            this.Isus.Name = "Isus";
            this.Isus.Size = new System.Drawing.Size(25, 13);
            this.Isus.TabIndex = 22;
            this.Isus.Text = "Акт";
            // 
            // numericUpDownDog
            // 
            this.numericUpDownDog.Location = new System.Drawing.Point(186, 32);
            this.numericUpDownDog.Name = "numericUpDownDog";
            this.numericUpDownDog.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownDog.TabIndex = 23;
            // 
            // numericUpDownCat
            // 
            this.numericUpDownCat.Location = new System.Drawing.Point(185, 56);
            this.numericUpDownCat.Name = "numericUpDownCat";
            this.numericUpDownCat.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownCat.TabIndex = 24;
            // 
            // ActEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 246);
            this.Controls.Add(this.numericUpDownCat);
            this.Controls.Add(this.numericUpDownDog);
            this.Controls.Add(this.Isus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.R);
            this.Controls.Add(this.textBoxTarget);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxApp);
            this.Controls.Add(this.comboBoxContract);
            this.Controls.Add(this.comboBoxOrganization);
            this.Controls.Add(this.dateAct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "ActEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Акт";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateAct;
        private System.Windows.Forms.ComboBox comboBoxOrganization;
        private System.Windows.Forms.ComboBox comboBoxContract;
        private System.Windows.Forms.ComboBox comboBoxApp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTarget;
        private System.Windows.Forms.Label R;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Isus;
        private System.Windows.Forms.NumericUpDown numericUpDownDog;
        private System.Windows.Forms.NumericUpDown numericUpDownCat;
    }
}