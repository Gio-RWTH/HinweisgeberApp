namespace HinweisgeberApp
{
    partial class partnerhinzufuegenForm
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
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.textServername = new System.Windows.Forms.TextBox();
			this.Servername = new System.Windows.Forms.Label();
			this.Datenbankname = new System.Windows.Forms.Label();
			this.textDatenbankname = new System.Windows.Forms.TextBox();
			this.Anmeldename = new System.Windows.Forms.Label();
			this.textAnmeldename = new System.Windows.Forms.TextBox();
			this.Kennwort = new System.Windows.Forms.Label();
			this.textKennwort = new System.Windows.Forms.TextBox();
			this.AddPartnerBtn = new System.Windows.Forms.Button();
			this.FilialNr = new System.Windows.Forms.Label();
			this.Partner = new System.Windows.Forms.Label();
			this.textAnsichtname = new System.Windows.Forms.TextBox();
			this.comboPartner = new System.Windows.Forms.ComboBox();
			this.Ansichtname = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.Label();
			this.textEmail = new System.Windows.Forms.TextBox();
			this.buttonAddFiliale = new System.Windows.Forms.Button();
			this.numericUpDownFilialnr = new System.Windows.Forms.NumericUpDown();
			this.comboPartnerQr = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboFilialeQr = new System.Windows.Forms.ComboBox();
			this.Filiale = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilialnr)).BeginInit();
			this.SuspendLayout();
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// textServername
			// 
			this.textServername.Location = new System.Drawing.Point(150, 40);
			this.textServername.Name = "textServername";
			this.textServername.Size = new System.Drawing.Size(188, 23);
			this.textServername.TabIndex = 0;
			// 
			// Servername
			// 
			this.Servername.AutoSize = true;
			this.Servername.Enabled = false;
			this.Servername.Location = new System.Drawing.Point(47, 48);
			this.Servername.Name = "Servername";
			this.Servername.Size = new System.Drawing.Size(69, 15);
			this.Servername.TabIndex = 1;
			this.Servername.Text = "Servername";
			// 
			// Datenbankname
			// 
			this.Datenbankname.AutoSize = true;
			this.Datenbankname.Location = new System.Drawing.Point(47, 105);
			this.Datenbankname.Name = "Datenbankname";
			this.Datenbankname.Size = new System.Drawing.Size(94, 15);
			this.Datenbankname.TabIndex = 2;
			this.Datenbankname.Text = "Datenbankname";
			// 
			// textDatenbankname
			// 
			this.textDatenbankname.Location = new System.Drawing.Point(150, 97);
			this.textDatenbankname.Name = "textDatenbankname";
			this.textDatenbankname.Size = new System.Drawing.Size(188, 23);
			this.textDatenbankname.TabIndex = 3;
			// 
			// Anmeldename
			// 
			this.Anmeldename.AutoSize = true;
			this.Anmeldename.Location = new System.Drawing.Point(47, 149);
			this.Anmeldename.Name = "Anmeldename";
			this.Anmeldename.Size = new System.Drawing.Size(85, 15);
			this.Anmeldename.TabIndex = 4;
			this.Anmeldename.Text = "Anmeldename";
			// 
			// textAnmeldename
			// 
			this.textAnmeldename.Location = new System.Drawing.Point(150, 141);
			this.textAnmeldename.Name = "textAnmeldename";
			this.textAnmeldename.Size = new System.Drawing.Size(188, 23);
			this.textAnmeldename.TabIndex = 5;
			// 
			// Kennwort
			// 
			this.Kennwort.AutoSize = true;
			this.Kennwort.Location = new System.Drawing.Point(47, 195);
			this.Kennwort.Name = "Kennwort";
			this.Kennwort.Size = new System.Drawing.Size(58, 15);
			this.Kennwort.TabIndex = 6;
			this.Kennwort.Text = "Kennwort";
			// 
			// textKennwort
			// 
			this.textKennwort.Location = new System.Drawing.Point(150, 187);
			this.textKennwort.Name = "textKennwort";
			this.textKennwort.Size = new System.Drawing.Size(188, 23);
			this.textKennwort.TabIndex = 7;
			// 
			// AddPartnerBtn
			// 
			this.AddPartnerBtn.Location = new System.Drawing.Point(201, 238);
			this.AddPartnerBtn.Name = "AddPartnerBtn";
			this.AddPartnerBtn.Size = new System.Drawing.Size(137, 41);
			this.AddPartnerBtn.TabIndex = 8;
			this.AddPartnerBtn.Text = "AddPartner";
			this.AddPartnerBtn.UseVisualStyleBackColor = true;
			this.AddPartnerBtn.Click += new System.EventHandler(this.AddPartnerBtn_Click);
			// 
			// FilialNr
			// 
			this.FilialNr.AutoSize = true;
			this.FilialNr.Location = new System.Drawing.Point(411, 100);
			this.FilialNr.Name = "FilialNr";
			this.FilialNr.Size = new System.Drawing.Size(44, 15);
			this.FilialNr.TabIndex = 9;
			this.FilialNr.Text = "FilialNr";
			// 
			// Partner
			// 
			this.Partner.AutoSize = true;
			this.Partner.Location = new System.Drawing.Point(411, 43);
			this.Partner.Name = "Partner";
			this.Partner.Size = new System.Drawing.Size(45, 15);
			this.Partner.TabIndex = 11;
			this.Partner.Text = "Partner";
			// 
			// textAnsichtname
			// 
			this.textAnsichtname.Location = new System.Drawing.Point(488, 141);
			this.textAnsichtname.Name = "textAnsichtname";
			this.textAnsichtname.Size = new System.Drawing.Size(168, 23);
			this.textAnsichtname.TabIndex = 12;
			// 
			// comboPartner
			// 
			this.comboPartner.FormattingEnabled = true;
			this.comboPartner.Location = new System.Drawing.Point(488, 43);
			this.comboPartner.Name = "comboPartner";
			this.comboPartner.Size = new System.Drawing.Size(168, 23);
			this.comboPartner.TabIndex = 13;
			// 
			// Ansichtname
			// 
			this.Ansichtname.AutoSize = true;
			this.Ansichtname.Location = new System.Drawing.Point(405, 144);
			this.Ansichtname.Name = "Ansichtname";
			this.Ansichtname.Size = new System.Drawing.Size(77, 15);
			this.Ansichtname.TabIndex = 14;
			this.Ansichtname.Text = "Ansichtname";
			this.Ansichtname.Click += new System.EventHandler(this.Ansichtname_Click);
			// 
			// Email
			// 
			this.Email.AutoSize = true;
			this.Email.Location = new System.Drawing.Point(409, 187);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(36, 15);
			this.Email.TabIndex = 15;
			this.Email.Text = "Email";
			// 
			// textEmail
			// 
			this.textEmail.Location = new System.Drawing.Point(488, 179);
			this.textEmail.Name = "textEmail";
			this.textEmail.Size = new System.Drawing.Size(168, 23);
			this.textEmail.TabIndex = 16;
			// 
			// buttonAddFiliale
			// 
			this.buttonAddFiliale.Location = new System.Drawing.Point(521, 238);
			this.buttonAddFiliale.Name = "buttonAddFiliale";
			this.buttonAddFiliale.Size = new System.Drawing.Size(135, 41);
			this.buttonAddFiliale.TabIndex = 17;
			this.buttonAddFiliale.Text = "AddFiliale";
			this.buttonAddFiliale.UseVisualStyleBackColor = true;
			this.buttonAddFiliale.Click += new System.EventHandler(this.buttonAddFiliale_Click);
			// 
			// numericUpDownFilialnr
			// 
			this.numericUpDownFilialnr.Location = new System.Drawing.Point(488, 97);
			this.numericUpDownFilialnr.Name = "numericUpDownFilialnr";
			this.numericUpDownFilialnr.Size = new System.Drawing.Size(168, 23);
			this.numericUpDownFilialnr.TabIndex = 18;
			// 
			// comboPartnerQr
			// 
			this.comboPartnerQr.FormattingEnabled = true;
			this.comboPartnerQr.Location = new System.Drawing.Point(63, 338);
			this.comboPartnerQr.Name = "comboPartnerQr";
			this.comboPartnerQr.Size = new System.Drawing.Size(131, 23);
			this.comboPartnerQr.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 341);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 15);
			this.label1.TabIndex = 20;
			this.label1.Text = "Partner";
			// 
			// comboFilialeQr
			// 
			this.comboFilialeQr.FormattingEnabled = true;
			this.comboFilialeQr.Location = new System.Drawing.Point(289, 338);
			this.comboFilialeQr.Name = "comboFilialeQr";
			this.comboFilialeQr.Size = new System.Drawing.Size(133, 23);
			this.comboFilialeQr.TabIndex = 21;
			// 
			// Filiale
			// 
			this.Filiale.AutoSize = true;
			this.Filiale.Location = new System.Drawing.Point(232, 341);
			this.Filiale.Name = "Filiale";
			this.Filiale.Size = new System.Drawing.Size(38, 15);
			this.Filiale.TabIndex = 22;
			this.Filiale.Text = "label2";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(469, 337);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(113, 24);
			this.button1.TabIndex = 23;
			this.button1.Text = "GenerateQrCode";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// partnerhinzufuegenForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Filiale);
			this.Controls.Add(this.comboFilialeQr);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboPartnerQr);
			this.Controls.Add(this.numericUpDownFilialnr);
			this.Controls.Add(this.buttonAddFiliale);
			this.Controls.Add(this.textEmail);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.Ansichtname);
			this.Controls.Add(this.comboPartner);
			this.Controls.Add(this.textAnsichtname);
			this.Controls.Add(this.Partner);
			this.Controls.Add(this.FilialNr);
			this.Controls.Add(this.AddPartnerBtn);
			this.Controls.Add(this.textKennwort);
			this.Controls.Add(this.Kennwort);
			this.Controls.Add(this.textAnmeldename);
			this.Controls.Add(this.Anmeldename);
			this.Controls.Add(this.textDatenbankname);
			this.Controls.Add(this.Datenbankname);
			this.Controls.Add(this.Servername);
			this.Controls.Add(this.textServername);
			this.Name = "partnerhinzufuegenForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFilialnr)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label Servername;
        private TextBox textServername;
        private Label Datenbankname;
        private Label Anmeldename;
        private TextBox textDatenbankname;
        private TextBox textKennwort;
        private Label Kennwort;
        private TextBox textAnmeldename;
        private Button AddPartnerBtn;
        private Label FilialNr;
        private TextBox textAnsichtname;
        private Label Partner;
        private ComboBox comboPartner;
        private Label Ansichtname;
        private TextBox textEmail;
        private Label Email;
        private Button buttonAddFiliale;
        private NumericUpDown numericUpDownFilialnr;
		private Button button1;
		private Label Filiale;
		private ComboBox comboFilialeQr;
		private Label label1;
		private ComboBox comboPartnerQr;
	}
}