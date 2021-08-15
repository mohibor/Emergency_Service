
namespace EmergencyService
{
    partial class Home
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
            this.lnkLblLogOut = new System.Windows.Forms.LinkLabel();
            this.btnFireService = new System.Windows.Forms.Button();
            this.btnPolice = new System.Windows.Forms.Button();
            this.btnAmbulance = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkLblLogOut
            // 
            this.lnkLblLogOut.AutoSize = true;
            this.lnkLblLogOut.LinkColor = System.Drawing.Color.Aqua;
            this.lnkLblLogOut.Location = new System.Drawing.Point(330, 433);
            this.lnkLblLogOut.Name = "lnkLblLogOut";
            this.lnkLblLogOut.Size = new System.Drawing.Size(45, 13);
            this.lnkLblLogOut.TabIndex = 1;
            this.lnkLblLogOut.TabStop = true;
            this.lnkLblLogOut.Text = "Log Out";
            this.lnkLblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblLogOut_LinkClicked);
            // 
            // btnFireService
            // 
            this.btnFireService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFireService.Location = new System.Drawing.Point(164, 166);
            this.btnFireService.Name = "btnFireService";
            this.btnFireService.Size = new System.Drawing.Size(111, 40);
            this.btnFireService.TabIndex = 2;
            this.btnFireService.Text = "Fire Service";
            this.btnFireService.UseVisualStyleBackColor = true;
            this.btnFireService.Click += new System.EventHandler(this.btnFireService_Click);
            // 
            // btnPolice
            // 
            this.btnPolice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPolice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPolice.Location = new System.Drawing.Point(164, 233);
            this.btnPolice.Name = "btnPolice";
            this.btnPolice.Size = new System.Drawing.Size(111, 40);
            this.btnPolice.TabIndex = 3;
            this.btnPolice.Text = "Police";
            this.btnPolice.UseVisualStyleBackColor = true;
            this.btnPolice.Click += new System.EventHandler(this.btnPolice_Click);
            // 
            // btnAmbulance
            // 
            this.btnAmbulance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmbulance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAmbulance.Location = new System.Drawing.Point(164, 300);
            this.btnAmbulance.Name = "btnAmbulance";
            this.btnAmbulance.Size = new System.Drawing.Size(111, 40);
            this.btnAmbulance.TabIndex = 4;
            this.btnAmbulance.Text = "Ambulance";
            this.btnAmbulance.UseVisualStyleBackColor = true;
            this.btnAmbulance.Click += new System.EventHandler(this.btnAmbulance_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(116, 62);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(215, 25);
            this.lblHeader.TabIndex = 34;
            this.lblHeader.Text = "Emergency Service";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(442, 492);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnAmbulance);
            this.Controls.Add(this.btnPolice);
            this.Controls.Add(this.btnFireService);
            this.Controls.Add(this.lnkLblLogOut);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkLblLogOut;
        private System.Windows.Forms.Button btnFireService;
        private System.Windows.Forms.Button btnPolice;
        private System.Windows.Forms.Button btnAmbulance;
        private System.Windows.Forms.Label lblHeader;
    }
}