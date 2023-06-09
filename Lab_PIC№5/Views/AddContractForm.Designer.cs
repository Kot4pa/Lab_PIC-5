namespace Lab_PIC_5.Views
{
    partial class AddContractForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateConclusion = new System.Windows.Forms.DateTimePicker();
            this.dateAction = new System.Windows.Forms.DateTimePicker();
            this.CancelcontEdit = new System.Windows.Forms.Button();
            this.OKcontAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customerCombo = new System.Windows.Forms.ComboBox();
            this.executerCombo = new System.Windows.Forms.ComboBox();
            this.CostText = new System.Windows.Forms.TextBox();
            this.cityCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Дата действия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Город:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Дата заключения:";
            // 
            // dateConclusion
            // 
            this.dateConclusion.Location = new System.Drawing.Point(143, 12);
            this.dateConclusion.Name = "dateConclusion";
            this.dateConclusion.Size = new System.Drawing.Size(200, 22);
            this.dateConclusion.TabIndex = 32;
            // 
            // dateAction
            // 
            this.dateAction.Location = new System.Drawing.Point(143, 40);
            this.dateAction.Name = "dateAction";
            this.dateAction.Size = new System.Drawing.Size(200, 22);
            this.dateAction.TabIndex = 33;
            // 
            // CancelcontEdit
            // 
            this.CancelcontEdit.Location = new System.Drawing.Point(223, 187);
            this.CancelcontEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelcontEdit.Name = "CancelcontEdit";
            this.CancelcontEdit.Size = new System.Drawing.Size(120, 34);
            this.CancelcontEdit.TabIndex = 37;
            this.CancelcontEdit.Text = "Отмена";
            this.CancelcontEdit.UseVisualStyleBackColor = true;
            this.CancelcontEdit.Click += new System.EventHandler(this.CancelcontEdit_Click);
            // 
            // OKcontAdd
            // 
            this.OKcontAdd.Location = new System.Drawing.Point(97, 187);
            this.OKcontAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OKcontAdd.Name = "OKcontAdd";
            this.OKcontAdd.Size = new System.Drawing.Size(120, 34);
            this.OKcontAdd.TabIndex = 36;
            this.OKcontAdd.Text = "OK";
            this.OKcontAdd.UseVisualStyleBackColor = true;
            this.OKcontAdd.Click += new System.EventHandler(this.OKcontAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Заказчик:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Исполнитель:";
            // 
            // customerCombo
            // 
            this.customerCombo.FormattingEnabled = true;
            this.customerCombo.Location = new System.Drawing.Point(143, 158);
            this.customerCombo.Name = "customerCombo";
            this.customerCombo.Size = new System.Drawing.Size(200, 24);
            this.customerCombo.TabIndex = 44;
            // 
            // executerCombo
            // 
            this.executerCombo.FormattingEnabled = true;
            this.executerCombo.Location = new System.Drawing.Point(143, 128);
            this.executerCombo.Name = "executerCombo";
            this.executerCombo.Size = new System.Drawing.Size(200, 24);
            this.executerCombo.TabIndex = 43;
            // 
            // CostText
            // 
            this.CostText.Location = new System.Drawing.Point(143, 100);
            this.CostText.Name = "CostText";
            this.CostText.Size = new System.Drawing.Size(202, 22);
            this.CostText.TabIndex = 45;
            // 
            // cityCombo
            // 
            this.cityCombo.FormattingEnabled = true;
            this.cityCombo.Location = new System.Drawing.Point(143, 68);
            this.cityCombo.Name = "cityCombo";
            this.cityCombo.Size = new System.Drawing.Size(200, 24);
            this.cityCombo.TabIndex = 41;
            // 
            // AddContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 231);
            this.Controls.Add(this.CostText);
            this.Controls.Add(this.customerCombo);
            this.Controls.Add(this.executerCombo);
            this.Controls.Add(this.cityCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelcontEdit);
            this.Controls.Add(this.OKcontAdd);
            this.Controls.Add(this.dateAction);
            this.Controls.Add(this.dateConclusion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddContractForm";
            this.Text = "AddContractForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateConclusion;
        private System.Windows.Forms.DateTimePicker dateAction;
        private System.Windows.Forms.Button CancelcontEdit;
        private System.Windows.Forms.Button OKcontAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox customerCombo;
        private System.Windows.Forms.ComboBox executerCombo;
        private System.Windows.Forms.TextBox CostText;
        private System.Windows.Forms.ComboBox cityCombo;
    }
}