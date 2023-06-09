namespace Lab_PIC_5.Views
{
    partial class LocationAdd
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
            this.CityText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CancelcontEdit = new System.Windows.Forms.Button();
            this.OKcontAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CityText
            // 
            this.CityText.Location = new System.Drawing.Point(67, 12);
            this.CityText.Name = "CityText";
            this.CityText.Size = new System.Drawing.Size(136, 22);
            this.CityText.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Город:";
            // 
            // CancelcontEdit
            // 
            this.CancelcontEdit.Location = new System.Drawing.Point(109, 39);
            this.CancelcontEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelcontEdit.Name = "CancelcontEdit";
            this.CancelcontEdit.Size = new System.Drawing.Size(94, 34);
            this.CancelcontEdit.TabIndex = 47;
            this.CancelcontEdit.Text = "Отмена";
            this.CancelcontEdit.UseVisualStyleBackColor = true;
            this.CancelcontEdit.Click += new System.EventHandler(this.CancelcontEdit_Click);
            // 
            // OKcontAdd
            // 
            this.OKcontAdd.Location = new System.Drawing.Point(9, 39);
            this.OKcontAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OKcontAdd.Name = "OKcontAdd";
            this.OKcontAdd.Size = new System.Drawing.Size(94, 34);
            this.OKcontAdd.TabIndex = 46;
            this.OKcontAdd.Text = "OK";
            this.OKcontAdd.UseVisualStyleBackColor = true;
            this.OKcontAdd.Click += new System.EventHandler(this.OKcontAdd_Click);
            // 
            // LocationAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 83);
            this.Controls.Add(this.CityText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelcontEdit);
            this.Controls.Add(this.OKcontAdd);
            this.Name = "LocationAdd";
            this.Text = "LocationAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CityText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CancelcontEdit;
        private System.Windows.Forms.Button OKcontAdd;
    }
}