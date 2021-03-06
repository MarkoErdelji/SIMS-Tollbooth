namespace Simsprojekat.View
{
    partial class AdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tolLStationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketGenerationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.tollStationDeleteBtn = new System.Windows.Forms.Button();
            this.tollStationUpdateBtn = new System.Windows.Forms.Button();
            this.tollStationCreateBtn = new System.Windows.Forms.Button();
            this.tollStationGridView = new System.Windows.Forms.DataGridView();
            this.tollstationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollstationCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollstationZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollBooths = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tollStationSections = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userDeleteBtn = new System.Windows.Forms.Button();
            this.userUpdateBtn = new System.Windows.Forms.Button();
            this.userCreateBtn = new System.Windows.Forms.Button();
            this.userDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.ticketGenButton = new System.Windows.Forms.Button();
            this.vehicleRadioGroup = new System.Windows.Forms.GroupBox();
            this.backgroundRadioButton5 = new Simsprojekat.View.BackgroundRadioButton();
            this.backgroundRadioButton4 = new Simsprojekat.View.BackgroundRadioButton();
            this.backgroundRadioButton3 = new Simsprojekat.View.BackgroundRadioButton();
            this.backgroundRadioButton2 = new Simsprojekat.View.BackgroundRadioButton();
            this.backgroundRadioButton1 = new Simsprojekat.View.BackgroundRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tollStationGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.vehicleRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolLStationsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.ticketGenerationToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1125, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // tolLStationsToolStripMenuItem
            // 
            this.tolLStationsToolStripMenuItem.Name = "tolLStationsToolStripMenuItem";
            this.tolLStationsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.tolLStationsToolStripMenuItem.Text = "Toll Stations";
            this.tolLStationsToolStripMenuItem.Click += new System.EventHandler(this.tolLStationsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // ticketGenerationToolStripMenuItem
            // 
            this.ticketGenerationToolStripMenuItem.Name = "ticketGenerationToolStripMenuItem";
            this.ticketGenerationToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.ticketGenerationToolStripMenuItem.Text = "Ticket generation";
            this.ticketGenerationToolStripMenuItem.Click += new System.EventHandler(this.ticketGenerationToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Controls.Add(this.tollStationDeleteBtn);
            this.panel1.Controls.Add(this.tollStationUpdateBtn);
            this.panel1.Controls.Add(this.tollStationCreateBtn);
            this.panel1.Controls.Add(this.tollStationGridView);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 644);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(973, 24);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(142, 43);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // tollStationDeleteBtn
            // 
            this.tollStationDeleteBtn.Location = new System.Drawing.Point(739, 444);
            this.tollStationDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tollStationDeleteBtn.Name = "tollStationDeleteBtn";
            this.tollStationDeleteBtn.Size = new System.Drawing.Size(136, 52);
            this.tollStationDeleteBtn.TabIndex = 3;
            this.tollStationDeleteBtn.Text = "Delete";
            this.tollStationDeleteBtn.UseVisualStyleBackColor = true;
            this.tollStationDeleteBtn.Click += new System.EventHandler(this.tollStationDeleteBtn_Click);
            // 
            // tollStationUpdateBtn
            // 
            this.tollStationUpdateBtn.Location = new System.Drawing.Point(498, 444);
            this.tollStationUpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tollStationUpdateBtn.Name = "tollStationUpdateBtn";
            this.tollStationUpdateBtn.Size = new System.Drawing.Size(121, 52);
            this.tollStationUpdateBtn.TabIndex = 2;
            this.tollStationUpdateBtn.Text = "Update";
            this.tollStationUpdateBtn.UseVisualStyleBackColor = true;
            this.tollStationUpdateBtn.Click += new System.EventHandler(this.tollStationUpdateBtn_Click);
            // 
            // tollStationCreateBtn
            // 
            this.tollStationCreateBtn.Location = new System.Drawing.Point(227, 441);
            this.tollStationCreateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tollStationCreateBtn.Name = "tollStationCreateBtn";
            this.tollStationCreateBtn.Size = new System.Drawing.Size(118, 55);
            this.tollStationCreateBtn.TabIndex = 1;
            this.tollStationCreateBtn.Text = "Create";
            this.tollStationCreateBtn.UseVisualStyleBackColor = true;
            this.tollStationCreateBtn.Click += new System.EventHandler(this.tollStationCreateBtn_Click);
            // 
            // tollStationGridView
            // 
            this.tollStationGridView.AllowUserToAddRows = false;
            this.tollStationGridView.AllowUserToDeleteRows = false;
            this.tollStationGridView.AllowUserToResizeColumns = false;
            this.tollStationGridView.AllowUserToResizeRows = false;
            this.tollStationGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tollStationGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tollstationId,
            this.tollstationCity,
            this.tollstationZipCode,
            this.tollBooths,
            this.tollStationSections});
            this.tollStationGridView.Location = new System.Drawing.Point(227, 44);
            this.tollStationGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tollStationGridView.Name = "tollStationGridView";
            this.tollStationGridView.RowHeadersWidth = 51;
            this.tollStationGridView.RowTemplate.Height = 25;
            this.tollStationGridView.Size = new System.Drawing.Size(648, 376);
            this.tollStationGridView.TabIndex = 0;
            this.tollStationGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tollStationGridView_CellContentClick);
            // 
            // tollstationId
            // 
            this.tollstationId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tollstationId.HeaderText = "Id";
            this.tollstationId.MinimumWidth = 6;
            this.tollstationId.Name = "tollstationId";
            this.tollstationId.ReadOnly = true;
            this.tollstationId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tollstationId.Width = 50;
            // 
            // tollstationCity
            // 
            this.tollstationCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tollstationCity.FillWeight = 78.57143F;
            this.tollstationCity.HeaderText = "City";
            this.tollstationCity.MinimumWidth = 6;
            this.tollstationCity.Name = "tollstationCity";
            this.tollstationCity.ReadOnly = true;
            this.tollstationCity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tollstationZipCode
            // 
            this.tollstationZipCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tollstationZipCode.FillWeight = 78.57143F;
            this.tollstationZipCode.HeaderText = "Zip Code";
            this.tollstationZipCode.MinimumWidth = 6;
            this.tollstationZipCode.Name = "tollstationZipCode";
            this.tollstationZipCode.ReadOnly = true;
            this.tollstationZipCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tollBooths
            // 
            this.tollBooths.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.tollBooths.FillWeight = 1F;
            this.tollBooths.HeaderText = "Toll Booths";
            this.tollBooths.MinimumWidth = 6;
            this.tollBooths.Name = "tollBooths";
            this.tollBooths.ReadOnly = true;
            this.tollBooths.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tollBooths.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tollBooths.Width = 70;
            // 
            // tollStationSections
            // 
            this.tollStationSections.HeaderText = "Section";
            this.tollStationSections.MinimumWidth = 6;
            this.tollStationSections.Name = "tollStationSections";
            this.tollStationSections.ReadOnly = true;
            this.tollStationSections.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tollStationSections.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tollStationSections.Width = 70;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userDeleteBtn);
            this.panel2.Controls.Add(this.userUpdateBtn);
            this.panel2.Controls.Add(this.userCreateBtn);
            this.panel2.Controls.Add(this.userDataGridView);
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1121, 648);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // userDeleteBtn
            // 
            this.userDeleteBtn.Location = new System.Drawing.Point(882, 525);
            this.userDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userDeleteBtn.Name = "userDeleteBtn";
            this.userDeleteBtn.Size = new System.Drawing.Size(114, 53);
            this.userDeleteBtn.TabIndex = 3;
            this.userDeleteBtn.Text = "Delete";
            this.userDeleteBtn.UseVisualStyleBackColor = true;
            this.userDeleteBtn.Click += new System.EventHandler(this.userDeleteBtn_Click);
            // 
            // userUpdateBtn
            // 
            this.userUpdateBtn.Location = new System.Drawing.Point(531, 528);
            this.userUpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userUpdateBtn.Name = "userUpdateBtn";
            this.userUpdateBtn.Size = new System.Drawing.Size(121, 52);
            this.userUpdateBtn.TabIndex = 2;
            this.userUpdateBtn.Text = "Update";
            this.userUpdateBtn.UseVisualStyleBackColor = true;
            this.userUpdateBtn.Click += new System.EventHandler(this.userUpdateBtn_Click);
            // 
            // userCreateBtn
            // 
            this.userCreateBtn.Location = new System.Drawing.Point(171, 525);
            this.userCreateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userCreateBtn.Name = "userCreateBtn";
            this.userCreateBtn.Size = new System.Drawing.Size(118, 55);
            this.userCreateBtn.TabIndex = 1;
            this.userCreateBtn.Text = "Create";
            this.userCreateBtn.UseVisualStyleBackColor = true;
            this.userCreateBtn.Click += new System.EventHandler(this.userCreateBtn_Click);
            // 
            // userDataGridView
            // 
            this.userDataGridView.AllowUserToAddRows = false;
            this.userDataGridView.AllowUserToDeleteRows = false;
            this.userDataGridView.AllowUserToResizeColumns = false;
            this.userDataGridView.AllowUserToResizeRows = false;
            this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.userFirstName,
            this.userLastName,
            this.userUsername,
            this.userPassword,
            this.userEmail,
            this.userType,
            this.userAdress,
            this.userCity});
            this.userDataGridView.Location = new System.Drawing.Point(89, 73);
            this.userDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userDataGridView.Name = "userDataGridView";
            this.userDataGridView.RowHeadersWidth = 51;
            this.userDataGridView.RowTemplate.Height = 25;
            this.userDataGridView.Size = new System.Drawing.Size(952, 383);
            this.userDataGridView.TabIndex = 0;
            this.userDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // userFirstName
            // 
            this.userFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userFirstName.HeaderText = "First Name";
            this.userFirstName.MinimumWidth = 6;
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.ReadOnly = true;
            this.userFirstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userLastName
            // 
            this.userLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userLastName.HeaderText = "Last Name";
            this.userLastName.MinimumWidth = 6;
            this.userLastName.Name = "userLastName";
            this.userLastName.ReadOnly = true;
            this.userLastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userUsername
            // 
            this.userUsername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userUsername.HeaderText = "Username";
            this.userUsername.MinimumWidth = 6;
            this.userUsername.Name = "userUsername";
            this.userUsername.ReadOnly = true;
            this.userUsername.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userPassword
            // 
            this.userPassword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userPassword.HeaderText = "Password";
            this.userPassword.MinimumWidth = 6;
            this.userPassword.Name = "userPassword";
            this.userPassword.ReadOnly = true;
            this.userPassword.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userEmail
            // 
            this.userEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.userEmail.FillWeight = 1F;
            this.userEmail.HeaderText = "Email";
            this.userEmail.MinimumWidth = 6;
            this.userEmail.Name = "userEmail";
            this.userEmail.ReadOnly = true;
            this.userEmail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.userEmail.Width = 150;
            // 
            // userType
            // 
            this.userType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userType.HeaderText = "Type";
            this.userType.MinimumWidth = 6;
            this.userType.Name = "userType";
            this.userType.ReadOnly = true;
            this.userType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // userAdress
            // 
            this.userAdress.HeaderText = "Adress";
            this.userAdress.MinimumWidth = 6;
            this.userAdress.Name = "userAdress";
            this.userAdress.ReadOnly = true;
            this.userAdress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.userAdress.Width = 125;
            // 
            // userCity
            // 
            this.userCity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userCity.HeaderText = "City";
            this.userCity.MinimumWidth = 6;
            this.userCity.Name = "userCity";
            this.userCity.ReadOnly = true;
            this.userCity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.selectLabel);
            this.panel3.Controls.Add(this.ticketGenButton);
            this.panel3.Controls.Add(this.vehicleRadioGroup);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 34);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1121, 644);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(473, 348);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Location = new System.Drawing.Point(519, 300);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(167, 20);
            this.selectLabel.TabIndex = 14;
            this.selectLabel.Text = "Select the entry station :";
            // 
            // ticketGenButton
            // 
            this.ticketGenButton.Location = new System.Drawing.Point(515, 488);
            this.ticketGenButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ticketGenButton.Name = "ticketGenButton";
            this.ticketGenButton.Size = new System.Drawing.Size(152, 52);
            this.ticketGenButton.TabIndex = 13;
            this.ticketGenButton.Text = "Generate ticket";
            this.ticketGenButton.UseVisualStyleBackColor = true;
            this.ticketGenButton.Click += new System.EventHandler(this.ticketGenButton_Click);
            // 
            // vehicleRadioGroup
            // 
            this.vehicleRadioGroup.Controls.Add(this.backgroundRadioButton5);
            this.vehicleRadioGroup.Controls.Add(this.backgroundRadioButton4);
            this.vehicleRadioGroup.Controls.Add(this.backgroundRadioButton3);
            this.vehicleRadioGroup.Controls.Add(this.backgroundRadioButton2);
            this.vehicleRadioGroup.Controls.Add(this.backgroundRadioButton1);
            this.vehicleRadioGroup.Location = new System.Drawing.Point(259, 96);
            this.vehicleRadioGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vehicleRadioGroup.Name = "vehicleRadioGroup";
            this.vehicleRadioGroup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vehicleRadioGroup.Size = new System.Drawing.Size(681, 132);
            this.vehicleRadioGroup.TabIndex = 12;
            this.vehicleRadioGroup.TabStop = false;
            this.vehicleRadioGroup.Enter += new System.EventHandler(this.vehicleRadioGroup_Enter);
            // 
            // backgroundRadioButton5
            // 
            this.backgroundRadioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.backgroundRadioButton5.BackgroundImage = global::Simsprojekat.Properties.Resources.icons8_question_mark_48;
            this.backgroundRadioButton5.Location = new System.Drawing.Point(603, 31);
            this.backgroundRadioButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backgroundRadioButton5.Name = "backgroundRadioButton5";
            this.backgroundRadioButton5.Size = new System.Drawing.Size(55, 64);
            this.backgroundRadioButton5.TabIndex = 12;
            this.backgroundRadioButton5.UseVisualStyleBackColor = true;
            // 
            // backgroundRadioButton4
            // 
            this.backgroundRadioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.backgroundRadioButton4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.backgroundRadioButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundRadioButton4.BackgroundImage")));
            this.backgroundRadioButton4.Location = new System.Drawing.Point(469, 31);
            this.backgroundRadioButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backgroundRadioButton4.Name = "backgroundRadioButton4";
            this.backgroundRadioButton4.Size = new System.Drawing.Size(55, 64);
            this.backgroundRadioButton4.TabIndex = 11;
            this.backgroundRadioButton4.UseVisualStyleBackColor = false;
            // 
            // backgroundRadioButton3
            // 
            this.backgroundRadioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.backgroundRadioButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundRadioButton3.BackgroundImage")));
            this.backgroundRadioButton3.Location = new System.Drawing.Point(319, 29);
            this.backgroundRadioButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backgroundRadioButton3.Name = "backgroundRadioButton3";
            this.backgroundRadioButton3.Size = new System.Drawing.Size(55, 64);
            this.backgroundRadioButton3.TabIndex = 10;
            this.backgroundRadioButton3.UseVisualStyleBackColor = true;
            // 
            // backgroundRadioButton2
            // 
            this.backgroundRadioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.backgroundRadioButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundRadioButton2.BackgroundImage")));
            this.backgroundRadioButton2.Checked = true;
            this.backgroundRadioButton2.Location = new System.Drawing.Point(25, 29);
            this.backgroundRadioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backgroundRadioButton2.Name = "backgroundRadioButton2";
            this.backgroundRadioButton2.Size = new System.Drawing.Size(55, 64);
            this.backgroundRadioButton2.TabIndex = 9;
            this.backgroundRadioButton2.TabStop = true;
            this.backgroundRadioButton2.UseVisualStyleBackColor = true;
            // 
            // backgroundRadioButton1
            // 
            this.backgroundRadioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.backgroundRadioButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backgroundRadioButton1.BackgroundImage")));
            this.backgroundRadioButton1.Location = new System.Drawing.Point(177, 29);
            this.backgroundRadioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.backgroundRadioButton1.Name = "backgroundRadioButton1";
            this.backgroundRadioButton1.Size = new System.Drawing.Size(55, 64);
            this.backgroundRadioButton1.TabIndex = 7;
            this.backgroundRadioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Select the vehicle type :";
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorForm";
            this.Load += new System.EventHandler(this.AdministratorForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tollStationGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.vehicleRadioGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tolLStationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button tollStationDeleteBtn;
        private System.Windows.Forms.Button tollStationUpdateBtn;
        private System.Windows.Forms.Button tollStationCreateBtn;
        private System.Windows.Forms.DataGridView tollStationGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button userUpdateBtn;
        private System.Windows.Forms.Button userCreateBtn;
        private System.Windows.Forms.DataGridView userDataGridView;
        private System.Windows.Forms.Button userDeleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn userEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn userType;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCity;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollstationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollstationCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tollstationZipCode;
        private System.Windows.Forms.DataGridViewButtonColumn tollBooths;
        private System.Windows.Forms.DataGridViewButtonColumn tollStationSections;
        private System.Windows.Forms.ToolStripMenuItem ticketGenerationToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ticketGenButton;
        private System.Windows.Forms.GroupBox vehicleRadioGroup;
        private BackgroundRadioButton backgroundRadioButton5;
        private BackgroundRadioButton backgroundRadioButton4;
        private BackgroundRadioButton backgroundRadioButton3;
        private BackgroundRadioButton backgroundRadioButton2;
        private BackgroundRadioButton backgroundRadioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}