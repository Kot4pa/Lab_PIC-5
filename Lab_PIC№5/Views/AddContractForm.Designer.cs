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
            this.cityText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costText = new System.Windows.Forms.TextBox();
            this.dateConclusion = new System.Windows.Forms.DateTimePicker();
            this.dateAction = new System.Windows.Forms.DateTimePicker();
            this.executerText = new System.Windows.Forms.TextBox();
            this.costumerText = new System.Windows.Forms.TextBox();
            this.CancelcontEdit = new System.Windows.Forms.Button();
            this.OKcontAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "ИНН";
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(185, 131);
            this.cityText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(200, 22);
            this.cityText.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "КПП";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Наименование";
            // 
            // costText
            // 
            this.costText.Location = new System.Drawing.Point(185, 179);
            this.costText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costText.Name = "costText";
            this.costText.Size = new System.Drawing.Size(200, 22);
            this.costText.TabIndex = 27;
            // 
            // dateConclusion
            // 
            this.dateConclusion.Location = new System.Drawing.Point(185, 33);
            this.dateConclusion.Name = "dateConclusion";
            this.dateConclusion.Size = new System.Drawing.Size(200, 22);
            this.dateConclusion.TabIndex = 32;
            // 
            // dateAction
            // 
            this.dateAction.Location = new System.Drawing.Point(185, 80);
            this.dateAction.Name = "dateAction";
            this.dateAction.Size = new System.Drawing.Size(200, 22);
            this.dateAction.TabIndex = 33;
            // 
            // executerText
            // 
            this.executerText.Location = new System.Drawing.Point(185, 234);
            this.executerText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.executerText.Name = "executerText";
            this.executerText.Size = new System.Drawing.Size(200, 22);
            this.executerText.TabIndex = 35;
            // 
            // costumerText
            // 
            this.costumerText.Location = new System.Drawing.Point(185, 288);
            this.costumerText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costumerText.Name = "costumerText";
            this.costumerText.Size = new System.Drawing.Size(200, 22);
            this.costumerText.TabIndex = 34;
            // 
            // CancelcontEdit
            // 
            this.CancelcontEdit.Location = new System.Drawing.Point(265, 341);
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
            this.OKcontAdd.Location = new System.Drawing.Point(80, 341);
            this.OKcontAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OKcontAdd.Name = "OKcontAdd";
            this.OKcontAdd.Size = new System.Drawing.Size(120, 34);
            this.OKcontAdd.TabIndex = 36;
            this.OKcontAdd.Text = "OK";
            this.OKcontAdd.UseVisualStyleBackColor = true;
            this.OKcontAdd.Click += new System.EventHandler(this.OKcontAdd_Click);
            // 
            // AddContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 393);
            this.Controls.Add(this.CancelcontEdit);
            this.Controls.Add(this.OKcontAdd);
            this.Controls.Add(this.executerText);
            this.Controls.Add(this.costumerText);
            this.Controls.Add(this.dateAction);
            this.Controls.Add(this.dateConclusion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costText);
            this.Name = "AddContractForm";
            this.Text = "AddContractForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costText;
        private System.Windows.Forms.DateTimePicker dateConclusion;
        private System.Windows.Forms.DateTimePicker dateAction;
        private System.Windows.Forms.TextBox executerText;
        private System.Windows.Forms.TextBox costumerText;
        private System.Windows.Forms.Button CancelcontEdit;
        private System.Windows.Forms.Button OKcontAdd;
    }
}