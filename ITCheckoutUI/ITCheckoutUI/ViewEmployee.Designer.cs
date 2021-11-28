
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
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(64, 24);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.menuHome_Click);
            // 
            // lblOutputLastName
            // 
            this.lblOutputLastName.AutoSize = true;
            this.lblOutputLastName.Location = new System.Drawing.Point(124, 119);
            this.lblOutputLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputLastName.Name = "lblOutputLastName";
            this.lblOutputLastName.Size = new System.Drawing.Size(0, 17);
            this.lblOutputLastName.TabIndex = 28;
            // 
            // lblOutputFirstName
            // 
            this.lblOutputFirstName.AutoSize = true;
            this.lblOutputFirstName.Location = new System.Drawing.Point(124, 85);
            this.lblOutputFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputFirstName.Name = "lblOutputFirstName";
            this.lblOutputFirstName.Size = new System.Drawing.Size(0, 17);
            this.lblOutputFirstName.TabIndex = 27;
            // 
            // lblOutputEmployeeID
            // 
            this.lblOutputEmployeeID.AutoSize = true;
            this.lblOutputEmployeeID.Location = new System.Drawing.Point(124, 50);
            this.lblOutputEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputEmployeeID.Name = "lblOutputEmployeeID";
            this.lblOutputEmployeeID.Size = new System.Drawing.Size(0, 17);
            this.lblOutputEmployeeID.TabIndex = 26;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(907, 44);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(144, 28);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Remove Employee";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(35, 119);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 17);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(35, 85);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 17);
            this.lblFirstName.TabIndex = 22;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(21, 50);
            this.lblEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(91, 17);
            this.lblEmployeeID.TabIndex = 21;
            this.lblEmployeeID.Text = "Employee ID:";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(16, 162);
            this.lstResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstResults.Name = "lstResults";
            this.lstResults.ScrollAlwaysVisible = true;
            this.lstResults.Size = new System.Drawing.Size(1033, 276);
            this.lstResults.TabIndex = 20;
            // 
            // ViewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 455);
            this.Controls.Add(this.lblOutputLastName);
            this.Controls.Add(this.lblOutputFirstName);
            this.Controls.Add(this.lblOutputEmployeeID);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.menuStrip);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewEmployee";
            this.Text = "View Employee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewEmployee_FormClosed);
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