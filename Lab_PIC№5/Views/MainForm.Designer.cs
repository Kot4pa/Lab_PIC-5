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
            this.AddActButton = new System.Windows.Forms.Button();
            this.UpdateActButton = new System.Windows.Forms.Button();
            this.DeleteActButton = new System.Windows.Forms.Button();
            this.dateTimePickerAct = new System.Windows.Forms.DateTimePicker();
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.AppAdd = new System.Windows.Forms.Button();
            this.AppEdit = new System.Windows.Forms.Button();
            this.AppDelete = new System.Windows.Forms.Button();
            this.dataGridViewApp = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewOrg = new System.Windows.Forms.DataGridView();
            this.OrgAdd = new System.Windows.Forms.Button();
            this.OrgEdit = new System.Windows.Forms.Button();
            this.OrgDelete = new System.Windows.Forms.Button();
            this.UserButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewActs)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractTable)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApp)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(9, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 465);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddActButton);
            this.tabPage1.Controls.Add(this.UpdateActButton);
            this.tabPage1.Controls.Add(this.DeleteActButton);
            this.tabPage1.Controls.Add(this.dateTimePickerAct);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.DataGridViewActs);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(913, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Акты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddActButton
            // 
            this.AddActButton.Location = new System.Drawing.Point(636, 407);
            this.AddActButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddActButton.Name = "AddActButton";
            this.AddActButton.Size = new System.Drawing.Size(88, 29);
            this.AddActButton.TabIndex = 6;
            this.AddActButton.Text = "Добавить";
            this.AddActButton.UseVisualStyleBackColor = true;
            this.AddActButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // UpdateActButton
            // 
            this.UpdateActButton.Location = new System.Drawing.Point(729, 407);
            this.UpdateActButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateActButton.Name = "UpdateActButton";
            this.UpdateActButton.Size = new System.Drawing.Size(88, 29);
            this.UpdateActButton.TabIndex = 5;
            this.UpdateActButton.Text = "Изменить";
            this.UpdateActButton.UseVisualStyleBackColor = true;
            this.UpdateActButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteActButton
            // 
            this.DeleteActButton.Location = new System.Drawing.Point(822, 407);
            this.DeleteActButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteActButton.Name = "DeleteActButton";
            this.DeleteActButton.Size = new System.Drawing.Size(88, 29);
            this.DeleteActButton.TabIndex = 4;
            this.DeleteActButton.Text = "Удалить";
            this.DeleteActButton.UseVisualStyleBackColor = true;
            this.DeleteActButton.Click += new System.EventHandler(this.DeleteActButton_Click);
            // 
            // dateTimePickerAct
            // 
            this.dateTimePickerAct.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAct.Location = new System.Drawing.Point(80, 409);
            this.dateTimePickerAct.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerAct.Name = "dateTimePickerAct";
            this.dateTimePickerAct.Size = new System.Drawing.Size(96, 20);
            this.dateTimePickerAct.TabIndex = 2;
            this.dateTimePickerAct.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAct.ValueChanged += new System.EventHandler(this.dateTimePickerAct_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 410);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
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
            this.DataGridViewActs.Location = new System.Drawing.Point(4, 5);
            this.DataGridViewActs.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridViewActs.MultiSelect = false;
            this.DataGridViewActs.Name = "DataGridViewActs";
            this.DataGridViewActs.ReadOnly = true;
            this.DataGridViewActs.RowHeadersVisible = false;
            this.DataGridViewActs.RowHeadersWidth = 51;
            this.DataGridViewActs.RowTemplate.Height = 24;
            this.DataGridViewActs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewActs.Size = new System.Drawing.Size(906, 386);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(913, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Реестр организаций";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(636, 407);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 29);
            this.button5.TabIndex = 12;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(729, 407);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 29);
            this.button6.TabIndex = 11;
            this.button6.Text = "Изменить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(822, 407);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 29);
            this.button7.TabIndex = 10;
            this.button7.Text = "Удалить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(146, 410);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 410);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Реестр организаций от:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 5);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(906, 386);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(913, 439);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Муниципальные контракты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(631, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(724, 405);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(818, 405);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(172, 405);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker3.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 408);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Муниципальные контракты от:";
            // 
            // ContractTable
            // 
            this.ContractTable.AllowUserToAddRows = false;
            this.ContractTable.AllowUserToDeleteRows = false;
            this.ContractTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.ContractTable.Location = new System.Drawing.Point(4, 5);
            this.ContractTable.Margin = new System.Windows.Forms.Padding(2);
            this.ContractTable.Name = "ContractTable";
            this.ContractTable.ReadOnly = true;
            this.ContractTable.RowHeadersWidth = 51;
            this.ContractTable.RowTemplate.Height = 24;
            this.ContractTable.Size = new System.Drawing.Size(906, 386);
            this.ContractTable.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер контракта";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата заключения";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата действия";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Город";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Цена";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Заказчик";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Исполнитель";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.AppAdd);
            this.tabPage4.Controls.Add(this.AppEdit);
            this.tabPage4.Controls.Add(this.AppDelete);
            this.tabPage4.Controls.Add(this.dataGridViewApp);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(913, 439);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // AppAdd
            // 
            this.AppAdd.Location = new System.Drawing.Point(631, 404);
            this.AppAdd.Margin = new System.Windows.Forms.Padding(2);
            this.AppAdd.Name = "AppAdd";
            this.AppAdd.Size = new System.Drawing.Size(88, 29);
            this.AppAdd.TabIndex = 16;
            this.AppAdd.Text = "Добавить";
            this.AppAdd.UseVisualStyleBackColor = true;
            this.AppAdd.Click += new System.EventHandler(this.AppAdd_Click);
            // 
            // AppEdit
            // 
            this.AppEdit.Location = new System.Drawing.Point(724, 404);
            this.AppEdit.Margin = new System.Windows.Forms.Padding(2);
            this.AppEdit.Name = "AppEdit";
            this.AppEdit.Size = new System.Drawing.Size(88, 29);
            this.AppEdit.TabIndex = 15;
            this.AppEdit.Text = "Изменить";
            this.AppEdit.UseVisualStyleBackColor = true;
            this.AppEdit.Click += new System.EventHandler(this.AppEdit_Click);
            // 
            // AppDelete
            // 
            this.AppDelete.Location = new System.Drawing.Point(818, 404);
            this.AppDelete.Margin = new System.Windows.Forms.Padding(2);
            this.AppDelete.Name = "AppDelete";
            this.AppDelete.Size = new System.Drawing.Size(88, 29);
            this.AppDelete.TabIndex = 14;
            this.AppDelete.Text = "Удалить";
            this.AppDelete.UseVisualStyleBackColor = true;
            this.AppDelete.Click += new System.EventHandler(this.AppDelete_Click);
            // 
            // dataGridViewApp
            // 
            this.dataGridViewApp.AllowUserToAddRows = false;
            this.dataGridViewApp.AllowUserToDeleteRows = false;
            this.dataGridViewApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApp.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewApp.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewApp.Name = "dataGridViewApp";
            this.dataGridViewApp.ReadOnly = true;
            this.dataGridViewApp.RowHeadersWidth = 62;
            this.dataGridViewApp.RowTemplate.Height = 28;
            this.dataGridViewApp.Size = new System.Drawing.Size(912, 389);
            this.dataGridViewApp.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewOrg);
            this.tabPage5.Controls.Add(this.OrgAdd);
            this.tabPage5.Controls.Add(this.OrgEdit);
            this.tabPage5.Controls.Add(this.OrgDelete);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(913, 439);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrg
            // 
            this.dataGridViewOrg.AllowUserToAddRows = false;
            this.dataGridViewOrg.AllowUserToDeleteRows = false;
            this.dataGridViewOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrg.Location = new System.Drawing.Point(2, 2);
            this.dataGridViewOrg.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOrg.Name = "dataGridViewOrg";
            this.dataGridViewOrg.ReadOnly = true;
            this.dataGridViewOrg.RowHeadersWidth = 62;
            this.dataGridViewOrg.RowTemplate.Height = 28;
            this.dataGridViewOrg.Size = new System.Drawing.Size(912, 385);
            this.dataGridViewOrg.TabIndex = 17;
            // 
            // OrgAdd
            // 
            this.OrgAdd.Location = new System.Drawing.Point(634, 401);
            this.OrgAdd.Margin = new System.Windows.Forms.Padding(2);
            this.OrgAdd.Name = "OrgAdd";
            this.OrgAdd.Size = new System.Drawing.Size(88, 29);
            this.OrgAdd.TabIndex = 16;
            this.OrgAdd.Text = "Добавить";
            this.OrgAdd.UseVisualStyleBackColor = true;
            this.OrgAdd.Click += new System.EventHandler(this.OrgAdd_Click);
            // 
            // OrgEdit
            // 
            this.OrgEdit.Location = new System.Drawing.Point(728, 401);
            this.OrgEdit.Margin = new System.Windows.Forms.Padding(2);
            this.OrgEdit.Name = "OrgEdit";
            this.OrgEdit.Size = new System.Drawing.Size(88, 29);
            this.OrgEdit.TabIndex = 15;
            this.OrgEdit.Text = "Изменить";
            this.OrgEdit.UseVisualStyleBackColor = true;
            this.OrgEdit.Click += new System.EventHandler(this.OrgEdit_Click);
            // 
            // OrgDelete
            // 
            this.OrgDelete.Location = new System.Drawing.Point(820, 401);
            this.OrgDelete.Margin = new System.Windows.Forms.Padding(2);
            this.OrgDelete.Name = "OrgDelete";
            this.OrgDelete.Size = new System.Drawing.Size(88, 29);
            this.OrgDelete.TabIndex = 14;
            this.OrgDelete.Text = "Удалить";
            this.OrgDelete.UseVisualStyleBackColor = true;
            this.OrgDelete.Click += new System.EventHandler(this.OrgDelete_Click);
            // 
            // UserButton
            // 
            this.UserButton.Location = new System.Drawing.Point(9, 479);
            this.UserButton.Margin = new System.Windows.Forms.Padding(2);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(154, 29);
            this.UserButton.TabIndex = 3;
            this.UserButton.Text = "Сменить пользователя";
            this.UserButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(908, 391);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 518);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.UserButton);
            this.Margin = new System.Windows.Forms.Padding(2);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApp)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button AddActButton;
        private System.Windows.Forms.Button UpdateActButton;
        private System.Windows.Forms.Button DeleteActButton;
        private System.Windows.Forms.DateTimePicker dateTimePickerAct;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

