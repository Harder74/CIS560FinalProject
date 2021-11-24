
namespace ITCheckoutUI
{
    partial class ViewCustomer
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
            this.lblOutputCustomerID = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
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
            this.lblOutputLastName.TabIndex = 36;
            // 
            // lblOutputFirstName
            // 
            this.lblOutputFirstName.AutoSize = true;
            this.lblOutputFirstName.Location = new System.Drawing.Point(93, 69);
            this.lblOutputFirstName.Name = "lblOutputFirstName";
            this.lblOutputFirstName.Size = new System.Drawing.Size(0, 13);
            this.lblOutputFirstName.TabIndex = 35;
            // 
            // lblOutputCustomerID
            // 
            this.lblOutputCustomerID.AutoSize = true;
            this.lblOutputCustomerID.Location = new System.Drawing.Point(93, 41);
            this.lblOutputCustomerID.Name = "lblOutputCustomerID";
            this.lblOutputCustomerID.Size = new System.Drawing.Size(0, 13);
            this.lblOutputCustomerID.TabIndex = 34;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(680, 36);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 23);
            this.btnRemove.TabIndex = 33;
            this.btnRemove.Text = "Remove Employee";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(26, 97);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 32;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(26, 69);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 31;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(18, 41);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 30;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(12, 132);
            this.lstResults.Name = "lstResults";
            this.lstResults.ScrollAlwaysVisible = true;
            this.lstResults.Size = new System.Drawing.Size(776, 225);
            this.lstResults.TabIndex = 29;
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.lblOutputLastName);
            this.Controls.Add(this.lblOutputFirstName);
            this.Controls.Add(this.lblOutputCustomerID);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.menuStrip);
            this.Name = "ViewCustomer";
            this.Text = "ViewCustomer";
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
        private System.Windows.Forms.Label lblOutputCustomerID;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.ListBox lstResults;
    }
}