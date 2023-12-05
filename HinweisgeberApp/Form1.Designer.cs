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
            this.textPartnername = new System.Windows.Forms.TextBox();
            this.Partnername = new System.Windows.Forms.Label();
            this.Servername = new System.Windows.Forms.Label();
            this.textServername = new System.Windows.Forms.TextBox();
            this.Anmeldename = new System.Windows.Forms.Label();
            this.textAnmeldename = new System.Windows.Forms.TextBox();
            this.Kennwort = new System.Windows.Forms.Label();
            this.textKennwort = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // textPartnername
            // 
            this.textPartnername.Location = new System.Drawing.Point(150, 40);
            this.textPartnername.Name = "textPartnername";
            this.textPartnername.Size = new System.Drawing.Size(188, 23);
            this.textPartnername.TabIndex = 0;
            // 
            // Partnername
            // 
            this.Partnername.AutoSize = true;
            this.Partnername.Enabled = false;
            this.Partnername.Location = new System.Drawing.Point(47, 48);
            this.Partnername.Name = "Partnername";
            this.Partnername.Size = new System.Drawing.Size(75, 15);
            this.Partnername.TabIndex = 1;
            this.Partnername.Text = "Partnername";
            // 
            // Servername
            // 
            this.Servername.AutoSize = true;
            this.Servername.Location = new System.Drawing.Point(47, 105);
            this.Servername.Name = "Servername";
            this.Servername.Size = new System.Drawing.Size(69, 15);
            this.Servername.TabIndex = 2;
            this.Servername.Text = "Servername";
            // 
            // textServername
            // 
            this.textServername.Location = new System.Drawing.Point(150, 97);
            this.textServername.Name = "textServername";
            this.textServername.Size = new System.Drawing.Size(188, 23);
            this.textServername.TabIndex = 3;
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
            // partnerhinzufuegenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textKennwort);
            this.Controls.Add(this.Kennwort);
            this.Controls.Add(this.textAnmeldename);
            this.Controls.Add(this.Anmeldename);
            this.Controls.Add(this.textServername);
            this.Controls.Add(this.Servername);
            this.Controls.Add(this.Partnername);
            this.Controls.Add(this.textPartnername);
            this.Name = "partnerhinzufuegenForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label Partnername;
        private TextBox textPartnername;
        private Label Servername;
        private Label Anmeldename;
        private TextBox textServername;
        private TextBox textKennwort;
        private Label Kennwort;
        private TextBox textAnmeldename;
    }
}