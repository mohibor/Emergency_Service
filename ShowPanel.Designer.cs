
namespace EmergencyService
{
    partial class ShowPanel
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
            this.dGVShow = new System.Windows.Forms.DataGridView();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lnklblBack = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dGVShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVShow
            // 
            this.dGVShow.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dGVShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVShow.Location = new System.Drawing.Point(18, 74);
            this.dGVShow.Name = "dGVShow";
            this.dGVShow.Size = new System.Drawing.Size(407, 382);
            this.dGVShow.TabIndex = 0;
            this.dGVShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVShow_CellContentClick);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(102, 29);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(215, 25);
            this.lblHeader.TabIndex = 36;
            this.lblHeader.Text = "Emergency Service";
            // 
            // lnklblBack
            // 
            this.lnklblBack.AutoSize = true;
            this.lnklblBack.LinkColor = System.Drawing.Color.Aqua;
            this.lnklblBack.Location = new System.Drawing.Point(368, 38);
            this.lnklblBack.Name = "lnklblBack";
            this.lnklblBack.Size = new System.Drawing.Size(32, 13);
            this.lnklblBack.TabIndex = 40;
            this.lnklblBack.TabStop = true;
            this.lnklblBack.Text = "Back";
            this.lnklblBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblBack_LinkClicked);
            // 
            // ShowPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(442, 492);
            this.Controls.Add(this.lnklblBack);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.dGVShow);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "ShowPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dGVShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVShow;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.LinkLabel lnklblBack;
    }
}