
namespace EmergencyService
{
    partial class AdminPage
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAllUser = new System.Windows.Forms.Button();
            this.lnkLblLogOut = new System.Windows.Forms.LinkLabel();
            this.lblSerchBy = new System.Windows.Forms.Label();
            this.cmbBoxSearch = new System.Windows.Forms.ComboBox();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(115, 42);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(215, 25);
            this.lblHeader.TabIndex = 35;
            this.lblHeader.Text = "Emergency Service";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(261, 344);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 40);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(85, 344);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 40);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAllUser
            // 
            this.btnShowAllUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowAllUser.Location = new System.Drawing.Point(165, 127);
            this.btnShowAllUser.Name = "btnShowAllUser";
            this.btnShowAllUser.Size = new System.Drawing.Size(125, 45);
            this.btnShowAllUser.TabIndex = 36;
            this.btnShowAllUser.Text = "Show All Users";
            this.btnShowAllUser.UseVisualStyleBackColor = true;
            this.btnShowAllUser.Click += new System.EventHandler(this.btnShowAllUser_Click);
            // 
            // lnkLblLogOut
            // 
            this.lnkLblLogOut.AutoSize = true;
            this.lnkLblLogOut.LinkColor = System.Drawing.Color.Aqua;
            this.lnkLblLogOut.Location = new System.Drawing.Point(327, 427);
            this.lnkLblLogOut.Name = "lnkLblLogOut";
            this.lnkLblLogOut.Size = new System.Drawing.Size(45, 13);
            this.lnkLblLogOut.TabIndex = 39;
            this.lnkLblLogOut.TabStop = true;
            this.lnkLblLogOut.Text = "Log Out";
            this.lnkLblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblLogOut_LinkClicked);
            // 
            // lblSerchBy
            // 
            this.lblSerchBy.AutoSize = true;
            this.lblSerchBy.Location = new System.Drawing.Point(140, 230);
            this.lblSerchBy.Name = "lblSerchBy";
            this.lblSerchBy.Size = new System.Drawing.Size(56, 13);
            this.lblSerchBy.TabIndex = 40;
            this.lblSerchBy.Text = "Search By";
            // 
            // cmbBoxSearch
            // 
            this.cmbBoxSearch.FormattingEnabled = true;
            this.cmbBoxSearch.Items.AddRange(new object[] {
            "Name",
            "NID Number",
            "Phone Number"});
            this.cmbBoxSearch.Location = new System.Drawing.Point(232, 227);
            this.cmbBoxSearch.Name = "cmbBoxSearch";
            this.cmbBoxSearch.Size = new System.Drawing.Size(98, 21);
            this.cmbBoxSearch.TabIndex = 41;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(85, 278);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(287, 20);
            this.txtSearchBox.TabIndex = 42;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(442, 492);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.cmbBoxSearch);
            this.Controls.Add(this.lblSerchBy);
            this.Controls.Add(this.lnkLblLogOut);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnShowAllUser);
            this.Controls.Add(this.lblHeader);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAllUser;
        private System.Windows.Forms.LinkLabel lnkLblLogOut;
        private System.Windows.Forms.Label lblSerchBy;
        private System.Windows.Forms.ComboBox cmbBoxSearch;
        private System.Windows.Forms.TextBox txtSearchBox;
    }
}