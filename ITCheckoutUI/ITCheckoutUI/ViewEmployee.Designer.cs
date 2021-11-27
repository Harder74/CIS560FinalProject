
namespace ITCheckoutUI
{
    partial class ViewEmployee
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOutputLastName = new System.Windows.Forms.Label();
            this.lblOutputFirstName = new System.Windows.Forms.Label();
            this.lblOutputEmployeeID = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(52, 20);
            this.menuHome.Text = "Home";
            // 
            // lblOutputLastName
            // 
            this.lblOutputLastName.AutoSize = true;
            this.lblOutputLastName.Location = new System.Drawing.Point(93, 97);
            this.lblOutputLastName.Name = "lblOutputLastName";
            this.lblOutputLastName.Size = new System.Drawing.Size(0, 13);
            this.lblOutputLastName.TabIndex = 28;
            // 
            // lblOutputFirstName
            // 
            this.lblOutputFirstName.AutoSize = true;
            this.lblOutputFirstName.Location = new System.Drawing.Point(93, 69);
            this.lblOutputFirstName.Name = "lblOutputFirstName";
            this.lblOutputFirstName.Size = new System.Drawing.Size(0, 13);
            this.lblOutputFirstName.TabIndex = 27;
            // 
            // lblOutputEmployeeID
            // 
            this.lblOutputEmployeeID.AutoSize = true;
            this.lblOutputEmployeeID.Location = new System.Drawing.Point(93, 41);
            this.lblOutputEmployeeID.Name = "lblOutputEmployeeID";
            this.lblOutputEmployeeID.Size = new System.Drawing.Size(0, 13);
            this.lblOutputEmployeeID.TabIndex = 26;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(680, 36);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 23);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Remove Employee";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(26, 97);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(26, 69);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(16, 41);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeID.TabIndex = 21;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(12, 132);
            this.lstResults.Name = "lstResults";
            this.lstResults.ScrollAlwaysVisible = true;
            this.lstResults.Size = new System.Drawing.Size(776, 225);
            this.lstResults.TabIndex = 20;
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.lblOutputLastName);
            this.Controls.Add(this.lblOutputFirstName);
            this.Controls.Add(this.lblOutputEmployeeID);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.menuStrip);
            this.Name = "ViewEmployee";
            this.Text = "ViewEmployee";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.Label lblOutputLastName;
        private System.Windows.Forms.Label lblOutputFirstName;
        private System.Windows.Forms.Label lblOutputEmployeeID;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.ListBox lstResults;
    }
}