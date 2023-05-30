namespace Lab_PIC_5.Views
{
    partial class OrgAdd
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
            this.CancelOrgEdit = new System.Windows.Forms.Button();
            this.OKorgAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.AdressReg = new System.Windows.Forms.TextBox();
            this.KPP = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.INN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelOrgEdit
            // 
            this.CancelOrgEdit.Location = new System.Drawing.Point(276, 451);
            this.CancelOrgEdit.Name = "CancelOrgEdit";
            this.CancelOrgEdit.Size = new System.Drawing.Size(135, 42);
            this.CancelOrgEdit.TabIndex = 23;
            this.CancelOrgEdit.Text = "Отмена";
            this.CancelOrgEdit.UseVisualStyleBackColor = true;
            this.CancelOrgEdit.Click += new System.EventHandler(this.CancelOrgEdit_Click);
            // 
            // OKorgAdd
            // 
            this.OKorgAdd.Location = new System.Drawing.Point(67, 451);
            this.OKorgAdd.Name = "OKorgAdd";
            this.OKorgAdd.Size = new System.Drawing.Size(135, 42);
            this.OKorgAdd.TabIndex = 22;
            this.OKorgAdd.Text = "OK";
            this.OKorgAdd.UseVisualStyleBackColor = true;
            this.OKorgAdd.Click += new System.EventHandler(this.OKorgAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Статус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Адрес регистрации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "КПП";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Наименование";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(202, 381);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(243, 26);
            this.Status.TabIndex = 16;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(202, 310);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(243, 26);
            this.Type.TabIndex = 15;
            // 
            // AdressReg
            // 
            this.AdressReg.Location = new System.Drawing.Point(202, 245);
            this.AdressReg.Name = "AdressReg";
            this.AdressReg.Size = new System.Drawing.Size(243, 26);
            this.AdressReg.TabIndex = 14;
            // 
            // KPP
            // 
            this.KPP.Location = new System.Drawing.Point(202, 175);
            this.KPP.Name = "KPP";
            this.KPP.Size = new System.Drawing.Size(243, 26);
            this.KPP.TabIndex = 13;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(202, 46);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(243, 26);
            this.name.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "ИНН";
            // 
            // INN
            // 
            this.INN.Location = new System.Drawing.Point(202, 105);
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(243, 26);
            this.INN.TabIndex = 24;
            // 
            // OrgAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 515);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.CancelOrgEdit);
            this.Controls.Add(this.OKorgAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.AdressReg);
            this.Controls.Add(this.KPP);
            this.Controls.Add(this.name);
            this.Name = "OrgAdd";
            this.Text = "Добавление организации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelOrgEdit;
        private System.Windows.Forms.Button OKorgAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.TextBox AdressReg;
        private System.Windows.Forms.TextBox KPP;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox INN;
    }
}