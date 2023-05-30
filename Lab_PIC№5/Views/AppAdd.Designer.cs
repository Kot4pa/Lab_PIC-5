namespace Lab_PIC_5.Views
{
    partial class AppAdd
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
            this.Cancel = new System.Windows.Forms.Button();
            this.OkAppAdd = new System.Windows.Forms.Button();
            this.categoryApp = new System.Windows.Forms.TextBox();
            this.descrip = new System.Windows.Forms.TextBox();
            this.urgency = new System.Windows.Forms.TextBox();
            this.animalHabbiat = new System.Windows.Forms.TextBox();
            this.territory = new System.Windows.Forms.TextBox();
            this.loc = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(597, 588);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(132, 53);
            this.Cancel.TabIndex = 31;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OkAppAdd
            // 
            this.OkAppAdd.Location = new System.Drawing.Point(145, 588);
            this.OkAppAdd.Name = "OkAppAdd";
            this.OkAppAdd.Size = new System.Drawing.Size(132, 53);
            this.OkAppAdd.TabIndex = 30;
            this.OkAppAdd.Text = "OK";
            this.OkAppAdd.UseVisualStyleBackColor = true;
            this.OkAppAdd.Click += new System.EventHandler(this.OkAppAdd_Click);
            // 
            // categoryApp
            // 
            this.categoryApp.Location = new System.Drawing.Point(375, 485);
            this.categoryApp.Name = "categoryApp";
            this.categoryApp.Size = new System.Drawing.Size(354, 26);
            this.categoryApp.TabIndex = 29;
            // 
            // descrip
            // 
            this.descrip.Location = new System.Drawing.Point(375, 343);
            this.descrip.Multiline = true;
            this.descrip.Name = "descrip";
            this.descrip.Size = new System.Drawing.Size(354, 120);
            this.descrip.TabIndex = 28;
            // 
            // urgency
            // 
            this.urgency.Location = new System.Drawing.Point(375, 287);
            this.urgency.Name = "urgency";
            this.urgency.Size = new System.Drawing.Size(354, 26);
            this.urgency.TabIndex = 27;
            // 
            // animalHabbiat
            // 
            this.animalHabbiat.Location = new System.Drawing.Point(375, 226);
            this.animalHabbiat.Name = "animalHabbiat";
            this.animalHabbiat.Size = new System.Drawing.Size(354, 26);
            this.animalHabbiat.TabIndex = 26;
            // 
            // territory
            // 
            this.territory.Location = new System.Drawing.Point(375, 174);
            this.territory.Name = "territory";
            this.territory.Size = new System.Drawing.Size(354, 26);
            this.territory.TabIndex = 25;
            // 
            // loc
            // 
            this.loc.Location = new System.Drawing.Point(375, 120);
            this.loc.Name = "loc";
            this.loc.Size = new System.Drawing.Size(354, 26);
            this.loc.TabIndex = 24;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(375, 61);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(354, 26);
            this.date.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Категория заявителя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Описание животного";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Срочность исполнения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Место обитания животного";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Территория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Населенный пункт";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Дата подачи";
            // 
            // AppAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 702);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OkAppAdd);
            this.Controls.Add(this.categoryApp);
            this.Controls.Add(this.descrip);
            this.Controls.Add(this.urgency);
            this.Controls.Add(this.animalHabbiat);
            this.Controls.Add(this.territory);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AppAdd";
            this.Text = "Добавление заявки на отлов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OkAppAdd;
        private System.Windows.Forms.TextBox categoryApp;
        private System.Windows.Forms.TextBox descrip;
        private System.Windows.Forms.TextBox urgency;
        private System.Windows.Forms.TextBox animalHabbiat;
        private System.Windows.Forms.TextBox territory;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}