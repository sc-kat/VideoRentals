namespace CassetteRentals
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControlMain = new TabControl();
            clientsTab = new TabPage();
            groupBoxClients = new GroupBox();
            btnDeleteClient = new Button();
            listViewClients = new ListView();
            ID = new ColumnHeader();
            firstName = new ColumnHeader();
            lastName = new ColumnHeader();
            email = new ColumnHeader();
            phone = new ColumnHeader();
            btnEditClient = new Button();
            btnAddClient = new Button();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelLn = new Label();
            textBoxLn = new TextBox();
            textBoxFn = new TextBox();
            labelEmail = new Label();
            labelFn = new Label();
            textBoxEmail = new TextBox();
            moviesTab = new TabPage();
            groupBoxMovies = new GroupBox();
            chkBoxAvailable = new CheckBox();
            btnDeleteMve = new Button();
            btnEditMve = new Button();
            brnAddMve = new Button();
            listViewMovies = new ListView();
            movieId = new ColumnHeader();
            title = new ColumnHeader();
            genre = new ColumnHeader();
            year = new ColumnHeader();
            available = new ColumnHeader();
            lblGenre = new Label();
            textBoxGenre = new TextBox();
            textBoxTitle = new TextBox();
            lblYear = new Label();
            lblTitle = new Label();
            textBoxYear = new TextBox();
            rentalsTsb = new TabPage();
            groupBoxRentals = new GroupBox();
            checkBox1 = new CheckBox();
            btnReturnRental = new Button();
            btnAddRental = new Button();
            lblDtpRental = new Label();
            dateTimeRental = new DateTimePicker();
            lblCbMovie = new Label();
            lblCbClient = new Label();
            comboBoxMovies = new ComboBox();
            comboBoxClients = new ComboBox();
            listViewRentals = new ListView();
            rentalId = new ColumnHeader();
            client = new ColumnHeader();
            movie = new ColumnHeader();
            rentalDate = new ColumnHeader();
            returnDate = new ColumnHeader();
            statistics = new TabPage();
            errorProvider = new ErrorProvider(components);
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printRentalsListToolStripMenuItem = new ToolStripMenuItem();
            printDocumentToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exportClientsListToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            closeFormToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            tabControlMain.SuspendLayout();
            clientsTab.SuspendLayout();
            groupBoxClients.SuspendLayout();
            moviesTab.SuspendLayout();
            groupBoxMovies.SuspendLayout();
            rentalsTsb.SuspendLayout();
            groupBoxRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(clientsTab);
            tabControlMain.Controls.Add(moviesTab);
            tabControlMain.Controls.Add(rentalsTsb);
            tabControlMain.Controls.Add(statistics);
            tabControlMain.Location = new Point(1, 75);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(2417, 1394);
            tabControlMain.TabIndex = 0;
            // 
            // clientsTab
            // 
            clientsTab.Controls.Add(groupBoxClients);
            clientsTab.Location = new Point(10, 58);
            clientsTab.Name = "clientsTab";
            clientsTab.Padding = new Padding(3);
            clientsTab.Size = new Size(2397, 1326);
            clientsTab.TabIndex = 0;
            clientsTab.Text = "Clients";
            clientsTab.UseVisualStyleBackColor = true;
            // 
            // groupBoxClients
            // 
            groupBoxClients.Controls.Add(btnDeleteClient);
            groupBoxClients.Controls.Add(listViewClients);
            groupBoxClients.Controls.Add(btnEditClient);
            groupBoxClients.Controls.Add(btnAddClient);
            groupBoxClients.Controls.Add(labelPhone);
            groupBoxClients.Controls.Add(textBoxPhone);
            groupBoxClients.Controls.Add(labelLn);
            groupBoxClients.Controls.Add(textBoxLn);
            groupBoxClients.Controls.Add(textBoxFn);
            groupBoxClients.Controls.Add(labelEmail);
            groupBoxClients.Controls.Add(labelFn);
            groupBoxClients.Controls.Add(textBoxEmail);
            groupBoxClients.Location = new Point(6, 6);
            groupBoxClients.Name = "groupBoxClients";
            groupBoxClients.Size = new Size(2366, 1308);
            groupBoxClients.TabIndex = 9;
            groupBoxClients.TabStop = false;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.Location = new Point(771, 1193);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(188, 58);
            btnDeleteClient.TabIndex = 12;
            btnDeleteClient.Text = "Delete";
            btnDeleteClient.UseVisualStyleBackColor = true;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // listViewClients
            // 
            listViewClients.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listViewClients.Columns.AddRange(new ColumnHeader[] { ID, firstName, lastName, email, phone });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(6, 15);
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(2354, 967);
            listViewClients.TabIndex = 0;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            listViewClients.SelectedIndexChanged += listViewClients_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            // 
            // firstName
            // 
            firstName.Text = "First Name";
            // 
            // lastName
            // 
            lastName.Text = "Last Name";
            // 
            // email
            // 
            email.Text = "Email";
            // 
            // phone
            // 
            phone.Text = "Phone";
            // 
            // btnEditClient
            // 
            btnEditClient.Location = new Point(771, 1107);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(188, 58);
            btnEditClient.TabIndex = 11;
            btnEditClient.Text = "&Edit";
            btnEditClient.UseVisualStyleBackColor = true;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // btnAddClient
            // 
            btnAddClient.BackColor = Color.Transparent;
            btnAddClient.Location = new Point(771, 1019);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(188, 58);
            btnAddClient.TabIndex = 9;
            btnAddClient.Text = "&Add Client";
            btnAddClient.UseVisualStyleBackColor = false;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(45, 1224);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(103, 41);
            labelPhone.TabIndex = 8;
            labelPhone.Text = "Phone";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(211, 1218);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(250, 47);
            textBoxPhone.TabIndex = 3;
            // 
            // labelLn
            // 
            labelLn.AutoSize = true;
            labelLn.Location = new Point(45, 1090);
            labelLn.Name = "labelLn";
            labelLn.Size = new Size(157, 41);
            labelLn.TabIndex = 6;
            labelLn.Text = "Last Name";
            // 
            // textBoxLn
            // 
            textBoxLn.Location = new Point(211, 1084);
            textBoxLn.Name = "textBoxLn";
            textBoxLn.Size = new Size(250, 47);
            textBoxLn.TabIndex = 1;
            // 
            // textBoxFn
            // 
            textBoxFn.Location = new Point(211, 1014);
            textBoxFn.Name = "textBoxFn";
            textBoxFn.Size = new Size(250, 47);
            textBoxFn.TabIndex = 0;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(45, 1158);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(88, 41);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Email";
            // 
            // labelFn
            // 
            labelFn.AutoSize = true;
            labelFn.Location = new Point(45, 1020);
            labelFn.Name = "labelFn";
            labelFn.Size = new Size(160, 41);
            labelFn.TabIndex = 4;
            labelFn.Text = "First Name";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(211, 1152);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(250, 47);
            textBoxEmail.TabIndex = 2;
            // 
            // moviesTab
            // 
            moviesTab.Controls.Add(groupBoxMovies);
            moviesTab.Location = new Point(10, 58);
            moviesTab.Name = "moviesTab";
            moviesTab.Padding = new Padding(3);
            moviesTab.Size = new Size(2397, 1326);
            moviesTab.TabIndex = 1;
            moviesTab.Text = "Movies";
            moviesTab.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovies
            // 
            groupBoxMovies.Controls.Add(chkBoxAvailable);
            groupBoxMovies.Controls.Add(btnDeleteMve);
            groupBoxMovies.Controls.Add(btnEditMve);
            groupBoxMovies.Controls.Add(brnAddMve);
            groupBoxMovies.Controls.Add(listViewMovies);
            groupBoxMovies.Controls.Add(lblGenre);
            groupBoxMovies.Controls.Add(textBoxGenre);
            groupBoxMovies.Controls.Add(textBoxTitle);
            groupBoxMovies.Controls.Add(lblYear);
            groupBoxMovies.Controls.Add(lblTitle);
            groupBoxMovies.Controls.Add(textBoxYear);
            groupBoxMovies.Location = new Point(0, 6);
            groupBoxMovies.Name = "groupBoxMovies";
            groupBoxMovies.Size = new Size(2148, 1157);
            groupBoxMovies.TabIndex = 10;
            groupBoxMovies.TabStop = false;
            // 
            // chkBoxAvailable
            // 
            chkBoxAvailable.AutoSize = true;
            chkBoxAvailable.Location = new Point(220, 1080);
            chkBoxAvailable.Name = "chkBoxAvailable";
            chkBoxAvailable.Size = new Size(173, 45);
            chkBoxAvailable.TabIndex = 13;
            chkBoxAvailable.Text = "Available";
            chkBoxAvailable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMve
            // 
            btnDeleteMve.Location = new Point(780, 1051);
            btnDeleteMve.Name = "btnDeleteMve";
            btnDeleteMve.Size = new Size(188, 58);
            btnDeleteMve.TabIndex = 12;
            btnDeleteMve.Text = "Delete";
            btnDeleteMve.UseVisualStyleBackColor = true;
            btnDeleteMve.Click += btnDeleteMve_Click;
            // 
            // btnEditMve
            // 
            btnEditMve.Location = new Point(780, 965);
            btnEditMve.Name = "btnEditMve";
            btnEditMve.Size = new Size(188, 58);
            btnEditMve.TabIndex = 11;
            btnEditMve.Text = "Edit";
            btnEditMve.UseVisualStyleBackColor = true;
            btnEditMve.Click += btnEditMve_Click;
            // 
            // brnAddMve
            // 
            brnAddMve.BackColor = Color.Transparent;
            brnAddMve.Location = new Point(780, 877);
            brnAddMve.Name = "brnAddMve";
            brnAddMve.Size = new Size(188, 58);
            brnAddMve.TabIndex = 9;
            brnAddMve.Text = "Add";
            brnAddMve.UseVisualStyleBackColor = false;
            brnAddMve.Click += brnAddMve_Click;
            // 
            // listViewMovies
            // 
            listViewMovies.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listViewMovies.Columns.AddRange(new ColumnHeader[] { movieId, title, genre, year, available });
            listViewMovies.FullRowSelect = true;
            listViewMovies.GridLines = true;
            listViewMovies.Location = new Point(30, 24);
            listViewMovies.Name = "listViewMovies";
            listViewMovies.Size = new Size(2077, 790);
            listViewMovies.TabIndex = 0;
            listViewMovies.UseCompatibleStateImageBehavior = false;
            listViewMovies.View = View.Details;
            listViewMovies.SelectedIndexChanged += listViewMovies_SelectedIndexChanged;
            // 
            // movieId
            // 
            movieId.Text = "ID";
            // 
            // title
            // 
            title.Text = "Title";
            // 
            // genre
            // 
            genre.Text = "Genre";
            // 
            // year
            // 
            year.Text = "Year";
            // 
            // available
            // 
            available.Text = "Available";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(54, 948);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(98, 41);
            lblGenre.TabIndex = 6;
            lblGenre.Text = "Genre";
            // 
            // textBoxGenre
            // 
            textBoxGenre.Location = new Point(220, 942);
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.Size = new Size(250, 47);
            textBoxGenre.TabIndex = 5;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(220, 872);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(250, 47);
            textBoxTitle.TabIndex = 3;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(54, 1016);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(73, 41);
            lblYear.TabIndex = 2;
            lblYear.Text = "Year";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(54, 878);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(74, 41);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Title";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(220, 1010);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(250, 47);
            textBoxYear.TabIndex = 1;
            // 
            // rentalsTsb
            // 
            rentalsTsb.Controls.Add(groupBoxRentals);
            rentalsTsb.Location = new Point(10, 58);
            rentalsTsb.Name = "rentalsTsb";
            rentalsTsb.Size = new Size(2397, 1326);
            rentalsTsb.TabIndex = 2;
            rentalsTsb.Text = "Rentals";
            rentalsTsb.UseVisualStyleBackColor = true;
            // 
            // groupBoxRentals
            // 
            groupBoxRentals.Controls.Add(checkBox1);
            groupBoxRentals.Controls.Add(btnReturnRental);
            groupBoxRentals.Controls.Add(btnAddRental);
            groupBoxRentals.Controls.Add(lblDtpRental);
            groupBoxRentals.Controls.Add(dateTimeRental);
            groupBoxRentals.Controls.Add(lblCbMovie);
            groupBoxRentals.Controls.Add(lblCbClient);
            groupBoxRentals.Controls.Add(comboBoxMovies);
            groupBoxRentals.Controls.Add(comboBoxClients);
            groupBoxRentals.Controls.Add(listViewRentals);
            groupBoxRentals.Location = new Point(3, 3);
            groupBoxRentals.Name = "groupBoxRentals";
            groupBoxRentals.Size = new Size(2138, 1166);
            groupBoxRentals.TabIndex = 0;
            groupBoxRentals.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(1454, 917);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(197, 45);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnReturnRental
            // 
            btnReturnRental.Location = new Point(235, 1053);
            btnReturnRental.Name = "btnReturnRental";
            btnReturnRental.Size = new Size(188, 58);
            btnReturnRental.TabIndex = 11;
            btnReturnRental.Text = "Add Return";
            btnReturnRental.UseVisualStyleBackColor = true;
            btnReturnRental.Click += btnReturnRental_Click;
            // 
            // btnAddRental
            // 
            btnAddRental.Location = new Point(722, 959);
            btnAddRental.Name = "btnAddRental";
            btnAddRental.Size = new Size(188, 58);
            btnAddRental.TabIndex = 10;
            btnAddRental.Text = "Add Rental";
            btnAddRental.UseVisualStyleBackColor = true;
            btnAddRental.Click += btnAddRental_Click;
            // 
            // lblDtpRental
            // 
            lblDtpRental.AutoSize = true;
            lblDtpRental.Location = new Point(114, 976);
            lblDtpRental.Name = "lblDtpRental";
            lblDtpRental.Size = new Size(170, 41);
            lblDtpRental.TabIndex = 8;
            lblDtpRental.Text = "Rental Date";
            // 
            // dateTimeRental
            // 
            dateTimeRental.ImeMode = ImeMode.NoControl;
            dateTimeRental.Location = new Point(369, 970);
            dateTimeRental.Name = "dateTimeRental";
            dateTimeRental.Size = new Size(302, 47);
            dateTimeRental.TabIndex = 6;
            // 
            // lblCbMovie
            // 
            lblCbMovie.AutoSize = true;
            lblCbMovie.Location = new Point(114, 910);
            lblCbMovie.Name = "lblCbMovie";
            lblCbMovie.Size = new Size(100, 41);
            lblCbMovie.TabIndex = 5;
            lblCbMovie.Text = "Movie";
            // 
            // lblCbClient
            // 
            lblCbClient.AutoSize = true;
            lblCbClient.Location = new Point(114, 837);
            lblCbClient.Name = "lblCbClient";
            lblCbClient.Size = new Size(94, 41);
            lblCbClient.TabIndex = 4;
            lblCbClient.Text = "Client";
            // 
            // comboBoxMovies
            // 
            comboBoxMovies.FormattingEnabled = true;
            comboBoxMovies.Location = new Point(369, 902);
            comboBoxMovies.Name = "comboBoxMovies";
            comboBoxMovies.Size = new Size(302, 49);
            comboBoxMovies.TabIndex = 3;
            // 
            // comboBoxClients
            // 
            comboBoxClients.FormattingEnabled = true;
            comboBoxClients.Location = new Point(369, 829);
            comboBoxClients.Name = "comboBoxClients";
            comboBoxClients.Size = new Size(302, 49);
            comboBoxClients.TabIndex = 2;
            // 
            // listViewRentals
            // 
            listViewRentals.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listViewRentals.Columns.AddRange(new ColumnHeader[] { rentalId, client, movie, rentalDate, returnDate });
            listViewRentals.FullRowSelect = true;
            listViewRentals.GridLines = true;
            listViewRentals.Location = new Point(25, 12);
            listViewRentals.Name = "listViewRentals";
            listViewRentals.Size = new Size(2083, 762);
            listViewRentals.TabIndex = 1;
            listViewRentals.UseCompatibleStateImageBehavior = false;
            listViewRentals.View = View.Details;
            // 
            // rentalId
            // 
            rentalId.Text = "Rental ID";
            // 
            // client
            // 
            client.Text = "Client";
            // 
            // movie
            // 
            movie.Text = "Movie";
            // 
            // rentalDate
            // 
            rentalDate.Text = "Rental Date";
            // 
            // returnDate
            // 
            returnDate.Text = "Return Date";
            // 
            // statistics
            // 
            statistics.Location = new Point(10, 58);
            statistics.Name = "statistics";
            statistics.Size = new Size(2397, 1326);
            statistics.TabIndex = 3;
            statistics.Text = "Statistics";
            statistics.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, exitToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2977, 49);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1, printRentalsListToolStripMenuItem, toolStripSeparator2, exportClientsListToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(87, 45);
            fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(445, 6);
            // 
            // printRentalsListToolStripMenuItem
            // 
            printRentalsListToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { printDocumentToolStripMenuItem });
            printRentalsListToolStripMenuItem.Name = "printRentalsListToolStripMenuItem";
            printRentalsListToolStripMenuItem.Size = new Size(448, 54);
            printRentalsListToolStripMenuItem.Text = "Print Rentals List";
            // 
            // printDocumentToolStripMenuItem
            // 
            printDocumentToolStripMenuItem.Name = "printDocumentToolStripMenuItem";
            printDocumentToolStripMenuItem.Size = new Size(448, 54);
            printDocumentToolStripMenuItem.Text = "Print Document";
            printDocumentToolStripMenuItem.Click += printDocumentToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(445, 6);
            // 
            // exportClientsListToolStripMenuItem
            // 
            exportClientsListToolStripMenuItem.Name = "exportClientsListToolStripMenuItem";
            exportClientsListToolStripMenuItem.Size = new Size(448, 54);
            exportClientsListToolStripMenuItem.Text = "Export Clients List";
            exportClientsListToolStripMenuItem.Click += exportClientsListToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeFormToolStripMenuItem });
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(88, 45);
            exitToolStripMenuItem.Text = "&Exit";
            // 
            // closeFormToolStripMenuItem
            // 
            closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            closeFormToolStripMenuItem.Size = new Size(334, 54);
            closeFormToolStripMenuItem.Text = "Close Form";
            closeFormToolStripMenuItem.Click += closeFormToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(124, 45);
            aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2977, 1535);
            Controls.Add(tabControlMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            tabControlMain.ResumeLayout(false);
            clientsTab.ResumeLayout(false);
            groupBoxClients.ResumeLayout(false);
            groupBoxClients.PerformLayout();
            moviesTab.ResumeLayout(false);
            groupBoxMovies.ResumeLayout(false);
            groupBoxMovies.PerformLayout();
            rentalsTsb.ResumeLayout(false);
            groupBoxRentals.ResumeLayout(false);
            groupBoxRentals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage clientsTab;
        private TabPage moviesTab;
        private TabPage rentalsTsb;
        private ListView listViewClients;
        private ColumnHeader ID;
        private ColumnHeader firstName;
        private ColumnHeader lastName;
        private ColumnHeader email;
        private CheckBox chkBoxAvailable;
        private GroupBox groupBoxRentals;
        private ListView listViewRentals;
        private ColumnHeader rentalId;
        private ColumnHeader client;
        private ColumnHeader movie;
        private ColumnHeader rentalDate;
        private ColumnHeader returnDate;
        private ComboBox comboBoxMovies;
        private ComboBox comboBoxClients;
        private Label lblCbMovie;
        private Label lblCbClient;
        private DateTimePicker dateTimeRental;
        private Button btnReturnRental;
        private Button btnAddRental;
        private Label lblDtpRental;
        private ColumnHeader phone;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelLn;
        private TextBox textBoxLn;
        private Label labelFn;
        private TextBox textBoxFn;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private GroupBox groupBoxClients;
        private Button btnDeleteClient;
        private Button btnEditClient;
        private Button btnAddClient;
        private GroupBox groupBoxMovies;
        private Button btnDeleteMve;
        private Button btnEditMve;
        private Button brnAddMve;
        private ListView listViewMovies;
        private ColumnHeader movieId;
        private ColumnHeader title;
        private ColumnHeader genre;
        private ColumnHeader year;
        private ColumnHeader available;
        private Label lblGenre;
        private TextBox textBoxGenre;
        private TextBox textBoxTitle;
        private Label lblYear;
        private Label lblTitle;
        private TextBox textBoxYear;
        private ErrorProvider errorProvider;
        private CheckBox checkBox1;
        private TabPage statistics;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printRentalsListToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exportClientsListToolStripMenuItem;
        private ToolStripMenuItem closeFormToolStripMenuItem;
        private ToolStripMenuItem printDocumentToolStripMenuItem;
    }
}
