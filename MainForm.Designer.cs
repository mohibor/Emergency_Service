
namespace EmergencyService
{
    partial class MainForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lnkLogOut = new System.Windows.Forms.LinkLabel();
            this.btnFireService = new System.Windows.Forms.Button();
            this.btnPolice = new System.Windows.Forms.Button();
            this.btnAmbulance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(137, 54);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(116, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to the Home ";
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.AutoSize = true;
            this.lnkLogOut.Location = new System.Drawing.Point(332, 54);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(45, 13);
            this.lnkLogOut.TabIndex = 1;
            this.lnkLogOut.TabStop = true;
            this.lnkLogOut.Text = "Log Out";
            this.lnkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogOut_LinkClicked);
            // 
            // btnFireService
            // 
            this.btnFireService.Location = new System.Drawing.Point(157, 128);
            this.btnFireService.Name = "btnFireService";
            this.btnFireService.Size = new System.Drawing.Size(75, 23);
            this.btnFireService.TabIndex = 2;
            this.btnFireService.Text = "Fire Service";
            this.btnFireService.UseVisualStyleBackColor = true;
            this.btnFireService.Click += new System.EventHandler(this.btnFireService_Click);
            // 
            // btnPolice
            // 
            this.btnPolice.Location = new System.Drawing.Point(157, 195);
            this.btnPolice.Name = "btnPolice";
            this.btnPolice.Size = new System.Drawing.Size(75, 23);
            this.btnPolice.TabIndex = 3;
            this.btnPolice.Text = "Police";
            this.btnPolice.UseVisualStyleBackColor = true;
            this.btnPolice.Click += new System.EventHandler(this.btnPolice_Click);
            // 
            // btnAmbulance
            // 
            this.btnAmbulance.Location = new System.Drawing.Point(157, 262);
            this.btnAmbulance.Name = "btnAmbulance";
            this.btnAmbulance.Size = new System.Drawing.Size(75, 23);
            this.btnAmbulance.TabIndex = 4;
            this.btnAmbulance.Text = "Ambulance";
            this.btnAmbulance.UseVisualStyleBackColor = true;
            this.btnAmbulance.Click += new System.EventHandler(this.btnAmbulance_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.btnAmbulance);
            this.Controls.Add(this.btnPolice);
            this.Controls.Add(this.btnFireService);
            this.Controls.Add(this.lnkLogOut);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.LinkLabel lnkLogOut;
        private System.Windows.Forms.Button btnFireService;
        private System.Windows.Forms.Button btnPolice;
        private System.Windows.Forms.Button btnAmbulance;
    }
}