namespace Lab_PIC_5.Views
{
    partial class ContractEdit
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
            this.CancelcontEdit = new System.Windows.Forms.Button();
            this.OKcontAdd = new System.Windows.Forms.Button();
            this.executerText = new System.Windows.Forms.TextBox();
            this.costumerText = new System.Windows.Forms.TextBox();
            this.dateAction = new System.Windows.Forms.DateTimePicker();
            this.dateConclusion = new System.Windows.Forms.DateTimePicker();
            this.cityText = new System.Windows.Forms.TextBox();
            this.costText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelcontEdit
            // 
            this.CancelcontEdit.Location = new System.Drawing.Point(197, 318);
            this.CancelcontEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelcontEdit.Name = "CancelcontEdit";
            this.CancelcontEdit.Size = new System.Drawing.Size(120, 34);
            this.CancelcontEdit.TabIndex = 45;
            this.CancelcontEdit.Text = "Отмена";
            this.CancelcontEdit.UseVisualStyleBackColor = true;
            // 
            // OKcontAdd
            // 
            this.OKcontAdd.Location = new System.Drawing.Point(12, 318);
            this.OKcontAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OKcontAdd.Name = "OKcontAdd";
            this.OKcontAdd.Size = new System.Drawing.Size(120, 34);
            this.OKcontAdd.TabIndex = 44;
            this.OKcontAdd.Text = "OK";
            this.OKcontAdd.UseVisualStyleBackColor = true;
            // 
            // executerText
            // 
            this.executerText.Location = new System.Drawing.Point(117, 211);
            this.executerText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.executerText.Name = "executerText";
            this.executerText.Size = new System.Drawing.Size(200, 22);
            this.executerText.TabIndex = 43;
            // 
            // costumerText
            // 
            this.costumerText.Location = new System.Drawing.Point(117, 265);
            this.costumerText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costumerText.Name = "costumerText";
            this.costumerText.Size = new System.Drawing.Size(200, 22);
            this.costumerText.TabIndex = 42;
            // 
            // dateAction
            // 
            this.dateAction.Location = new System.Drawing.Point(117, 57);
            this.dateAction.Name = "dateAction";
            this.dateAction.Size = new System.Drawing.Size(200, 22);
            this.dateAction.TabIndex = 41;
            // 
            // dateConclusion
            // 
            this.dateConclusion.Location = new System.Drawing.Point(117, 10);
            this.dateConclusion.Name = "dateConclusion";
            this.dateConclusion.Size = new System.Drawing.Size(200, 22);
            this.dateConclusion.TabIndex = 40;
            // 
            // cityText
            // 
            this.cityText.Location = new System.Drawing.Point(117, 108);
            this.cityText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityText.Name = "cityText";
            this.cityText.Size = new System.Drawing.Size(200, 22);
            this.cityText.TabIndex = 39;
            // 
            // costText
            // 
            this.costText.Location = new System.Drawing.Point(117, 156);
            this.costText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.costText.Name = "costText";
            this.costText.Size = new System.Drawing.Size(200, 22);
            this.costText.TabIndex = 38;
            // 
            // ContractEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 391);
            this.Controls.Add(this.CancelcontEdit);
            this.Controls.Add(this.OKcontAdd);
            this.Controls.Add(this.executerText);
            this.Controls.Add(this.costumerText);
            this.Controls.Add(this.dateAction);
            this.Controls.Add(this.dateConclusion);
            this.Controls.Add(this.cityText);
            this.Controls.Add(this.costText);
            this.Name = "ContractEdit";
            this.Text = "CintractEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelcontEdit;
        private System.Windows.Forms.Button OKcontAdd;
        private System.Windows.Forms.TextBox executerText;
        private System.Windows.Forms.TextBox costumerText;
        private System.Windows.Forms.DateTimePicker dateAction;
        private System.Windows.Forms.DateTimePicker dateConclusion;
        private System.Windows.Forms.TextBox cityText;
        private System.Windows.Forms.TextBox costText;
    }
}