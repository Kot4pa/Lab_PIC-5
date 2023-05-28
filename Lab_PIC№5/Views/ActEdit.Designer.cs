
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
            this.organizationTextBox = new System.Windows.Forms.TextBox();
            this.contractsTextBox = new System.Windows.Forms.TextBox();
            this.applicationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateAct = new System.Windows.Forms.DateTimePicker();
            this.animalCardComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(177, 178);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(96, 177);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            // 
            // organizationTextBox
            // 
            this.organizationTextBox.Location = new System.Drawing.Point(131, 46);
            this.organizationTextBox.Name = "organizationTextBox";
            this.organizationTextBox.Size = new System.Drawing.Size(121, 20);
            this.organizationTextBox.TabIndex = 4;
            // 
            // contractsTextBox
            // 
            this.contractsTextBox.Location = new System.Drawing.Point(131, 74);
            this.contractsTextBox.Name = "contractsTextBox";
            this.contractsTextBox.Size = new System.Drawing.Size(121, 20);
            this.contractsTextBox.TabIndex = 5;
            // 
            // applicationTextBox
            // 
            this.applicationTextBox.Location = new System.Drawing.Point(131, 100);
            this.applicationTextBox.Name = "applicationTextBox";
            this.applicationTextBox.Size = new System.Drawing.Size(121, 20);
            this.applicationTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Организация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Контракты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Заявка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Карточка животного";
            // 
            // dateAct
            // 
            this.dateAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAct.Location = new System.Drawing.Point(131, 20);
            this.dateAct.Name = "dateAct";
            this.dateAct.Size = new System.Drawing.Size(121, 20);
            this.dateAct.TabIndex = 11;
            this.dateAct.Value = new System.DateTime(2023, 5, 29, 1, 20, 48, 0);
            // 
            // animalCardComboBox
            // 
            this.animalCardComboBox.FormattingEnabled = true;
            this.animalCardComboBox.Location = new System.Drawing.Point(131, 127);
            this.animalCardComboBox.Name = "animalCardComboBox";
            this.animalCardComboBox.Size = new System.Drawing.Size(121, 21);
            this.animalCardComboBox.TabIndex = 12;
            // 
            // ActEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 210);
            this.Controls.Add(this.animalCardComboBox);
            this.Controls.Add(this.dateAct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.applicationTextBox);
            this.Controls.Add(this.contractsTextBox);
            this.Controls.Add(this.organizationTextBox);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "ActEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Акт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox organizationTextBox;
        private System.Windows.Forms.TextBox contractsTextBox;
        private System.Windows.Forms.TextBox applicationTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateAct;
        private System.Windows.Forms.ComboBox animalCardComboBox;
    }
}