namespace Lab_PIC_5
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewActs = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Organization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontracts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ContractTable = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.UserButton = new System.Windows.Forms.Button();
            this.dataGridViewApp = new System.Windows.Forms.DataGridView();
            this.AppAdd = new System.Windows.Forms.Button();
            this.AppEdit = new System.Windows.Forms.Button();
            this.AppDelete = new System.Windows.Forms.Button();
            this.OrgAdd = new System.Windows.Forms.Button();
            this.OrgEdit = new System.Windows.Forms.Button();
            this.OrgDelete = new System.Windows.Forms.Button();
            this.dataGridViewOrg = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewActs)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractTable)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrg)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(14, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1382, 715);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddButton);
            this.tabPage1.Controls.Add(this.UpdateButton);
            this.tabPage1.Controls.Add(this.DeleteButton);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DataGridViewActs);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(1374, 682);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Акты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(954, 626);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(132, 45);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(1094, 626);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(132, 45);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(1233, 626);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(132, 45);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 629);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 631);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Акты от:";
            // 
            // DataGridViewActs
            // 
            this.DataGridViewActs.AllowUserToAddRows = false;
            this.DataGridViewActs.AllowUserToDeleteRows = false;
            this.DataGridViewActs.AllowUserToResizeColumns = false;
            this.DataGridViewActs.AllowUserToResizeRows = false;
            this.DataGridViewActs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewActs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewActs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Organization,
            this.Kontracts,
            this.Application,
            this.animalCard});
            this.DataGridViewActs.Location = new System.Drawing.Point(6, 8);
            this.DataGridViewActs.Name = "DataGridViewActs";
            this.DataGridViewActs.ReadOnly = true;
            this.DataGridViewActs.RowHeadersVisible = false;
            this.DataGridViewActs.RowHeadersWidth = 51;
            this.DataGridViewActs.RowTemplate.Height = 24;
            this.DataGridViewActs.Size = new System.Drawing.Size(1359, 594);
            this.DataGridViewActs.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "№ Акта";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Organization
            // 
            this.Organization.HeaderText = "Организация";
            this.Organization.MinimumWidth = 8;
            this.Organization.Name = "Organization";
            this.Organization.ReadOnly = true;
            // 
            // Kontracts
            // 
            this.Kontracts.HeaderText = "Контракты";
            this.Kontracts.MinimumWidth = 8;
            this.Kontracts.Name = "Kontracts";
            this.Kontracts.ReadOnly = true;
            // 
            // Application
            // 
            this.Application.HeaderText = "Заявка";
            this.Application.MinimumWidth = 8;
            this.Application.Name = "Application";
            this.Application.ReadOnly = true;
            // 
            // animalCard
            // 
            this.animalCard.HeaderText = "Карточка животного";
            this.animalCard.MinimumWidth = 8;
            this.animalCard.Name = "animalCard";
            this.animalCard.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(1374, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Реестр организаций";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(954, 626);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 45);
            this.button5.TabIndex = 12;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1094, 626);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(132, 45);
            this.button6.TabIndex = 11;
            this.button6.Text = "Изменить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1233, 626);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(132, 45);
            this.button7.TabIndex = 10;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(218, 631);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(172, 26);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 631);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Реестр организаций от:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 8);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1359, 594);
            this.dataGridView2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.dateTimePicker3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.ContractTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1374, 682);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Муниципальные контракты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(946, 623);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1086, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 45);
            this.button2.TabIndex = 12;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1226, 623);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(258, 623);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(172, 26);
            this.dateTimePicker3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 628);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Муниципальные контракты от:";
            // 
            // ContractTable
            // 
            this.ContractTable.AllowUserToAddRows = false;
            this.ContractTable.AllowUserToDeleteRows = false;
            this.ContractTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractTable.Location = new System.Drawing.Point(6, 8);
            this.ContractTable.Name = "ContractTable";
            this.ContractTable.ReadOnly = true;
            this.ContractTable.RowHeadersWidth = 51;
            this.ContractTable.RowTemplate.Height = 24;
            this.ContractTable.Size = new System.Drawing.Size(1359, 594);
            this.ContractTable.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.AppAdd);
            this.tabPage4.Controls.Add(this.AppEdit);
            this.tabPage4.Controls.Add(this.AppDelete);
            this.tabPage4.Controls.Add(this.dataGridViewApp);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1374, 682);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewOrg);
            this.tabPage5.Controls.Add(this.OrgAdd);
            this.tabPage5.Controls.Add(this.OrgEdit);
            this.tabPage5.Controls.Add(this.OrgDelete);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1374, 682);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // UserButton
            // 
            this.UserButton.Location = new System.Drawing.Point(14, 737);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(231, 45);
            this.UserButton.TabIndex = 3;
            this.UserButton.Text = "Сменить пользователя";
            this.UserButton.UseVisualStyleBackColor = true;
            // 
            // dataGridViewApp
            // 
            this.dataGridViewApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApp.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewApp.Name = "dataGridViewApp";
            this.dataGridViewApp.RowHeadersWidth = 62;
            this.dataGridViewApp.RowTemplate.Height = 28;
            this.dataGridViewApp.Size = new System.Drawing.Size(1368, 599);
            this.dataGridViewApp.TabIndex = 0;
            // 
            // AppAdd
            // 
            this.AppAdd.Location = new System.Drawing.Point(946, 621);
            this.AppAdd.Name = "AppAdd";
            this.AppAdd.Size = new System.Drawing.Size(132, 45);
            this.AppAdd.TabIndex = 16;
            this.AppAdd.Text = "Добавить";
            this.AppAdd.UseVisualStyleBackColor = true;
            // 
            // AppEdit
            // 
            this.AppEdit.Location = new System.Drawing.Point(1086, 621);
            this.AppEdit.Name = "AppEdit";
            this.AppEdit.Size = new System.Drawing.Size(132, 45);
            this.AppEdit.TabIndex = 15;
            this.AppEdit.Text = "Изменить";
            this.AppEdit.UseVisualStyleBackColor = true;
            this.AppEdit.Click += new System.EventHandler(this.AppEdit_Click);
            // 
            // AppDelete
            // 
            this.AppDelete.Location = new System.Drawing.Point(1226, 621);
            this.AppDelete.Name = "AppDelete";
            this.AppDelete.Size = new System.Drawing.Size(132, 45);
            this.AppDelete.TabIndex = 14;
            this.AppDelete.Text = "Удалить";
            this.AppDelete.UseVisualStyleBackColor = true;
            this.AppDelete.Click += new System.EventHandler(this.AppDelete_Click);
            // 
            // OrgAdd
            // 
            this.OrgAdd.Location = new System.Drawing.Point(951, 618);
            this.OrgAdd.Name = "OrgAdd";
            this.OrgAdd.Size = new System.Drawing.Size(132, 45);
            this.OrgAdd.TabIndex = 16;
            this.OrgAdd.Text = "Добавить";
            this.OrgAdd.UseVisualStyleBackColor = true;
            // 
            // OrgEdit
            // 
            this.OrgEdit.Location = new System.Drawing.Point(1091, 618);
            this.OrgEdit.Name = "OrgEdit";
            this.OrgEdit.Size = new System.Drawing.Size(132, 45);
            this.OrgEdit.TabIndex = 15;
            this.OrgEdit.Text = "Изменить";
            this.OrgEdit.UseVisualStyleBackColor = true;
            // 
            // OrgDelete
            // 
            this.OrgDelete.Location = new System.Drawing.Point(1231, 618);
            this.OrgDelete.Name = "OrgDelete";
            this.OrgDelete.Size = new System.Drawing.Size(132, 45);
            this.OrgDelete.TabIndex = 14;
            this.OrgDelete.Text = "Удалить";
            this.OrgDelete.UseVisualStyleBackColor = true;
            this.OrgDelete.Click += new System.EventHandler(this.OrgDelete_Click);
            // 
            // dataGridViewOrg
            // 
            this.dataGridViewOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrg.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOrg.Name = "dataGridViewOrg";
            this.dataGridViewOrg.RowHeadersWidth = 62;
            this.dataGridViewOrg.RowTemplate.Height = 28;
            this.dataGridViewOrg.Size = new System.Drawing.Size(1368, 593);
            this.dataGridViewOrg.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 797);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.UserButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявки на отлов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewActs)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractTable)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewActs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView ContractTable;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Organization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontracts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Application;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalCard;
        private System.Windows.Forms.Button AppAdd;
        private System.Windows.Forms.Button AppEdit;
        private System.Windows.Forms.Button AppDelete;
        private System.Windows.Forms.DataGridView dataGridViewApp;
        private System.Windows.Forms.DataGridView dataGridViewOrg;
        private System.Windows.Forms.Button OrgAdd;
        private System.Windows.Forms.Button OrgEdit;
        private System.Windows.Forms.Button OrgDelete;
    }
}

