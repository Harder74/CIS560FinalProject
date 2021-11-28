
namespace ITCheckoutUI
{
    partial class EmployeeSearch
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
            this.pnlSearchChoices = new System.Windows.Forms.Panel();
            this.radSearchReturnDate = new System.Windows.Forms.RadioButton();
            this.radSearchCheckOutDate = new System.Windows.Forms.RadioButton();
            this.radSearchName = new System.Windows.Forms.RadioButton();
            this.radSearchID = new System.Windows.Forms.RadioButton();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.pnlSearchConditions = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSearchChoices.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearchChoices
            // 
            this.pnlSearchChoices.Controls.Add(this.radSearchReturnDate);
            this.pnlSearchChoices.Controls.Add(this.radSearchCheckOutDate);
            this.pnlSearchChoices.Controls.Add(this.radSearchName);
            this.pnlSearchChoices.Controls.Add(this.radSearchID);
            this.pnlSearchChoices.Location = new System.Drawing.Point(13, 33);
            this.pnlSearchChoices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSearchChoices.Name = "pnlSearchChoices";
            this.pnlSearchChoices.Size = new System.Drawing.Size(204, 114);
            this.pnlSearchChoices.TabIndex = 3;
            // 
            // radSearchReturnDate
            // 
            this.radSearchReturnDate.AutoSize = true;
            this.radSearchReturnDate.Location = new System.Drawing.Point(4, 89);
            this.radSearchReturnDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSearchReturnDate.Name = "radSearchReturnDate";
            this.radSearchReturnDate.Size = new System.Drawing.Size(174, 21);
            this.radSearchReturnDate.TabIndex = 5;
            this.radSearchReturnDate.TabStop = true;
            this.radSearchReturnDate.Text = "Search by Return Date";
            this.radSearchReturnDate.UseVisualStyleBackColor = true;
            // 
            // radSearchCheckOutDate
            // 
            this.radSearchCheckOutDate.AutoSize = true;
            this.radSearchCheckOutDate.Location = new System.Drawing.Point(4, 60);
            this.radSearchCheckOutDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSearchCheckOutDate.Name = "radSearchCheckOutDate";
            this.radSearchCheckOutDate.Size = new System.Drawing.Size(190, 21);
            this.radSearchCheckOutDate.TabIndex = 4;
            this.radSearchCheckOutDate.TabStop = true;
            this.radSearchCheckOutDate.Text = "Search by Checkout Date";
            this.radSearchCheckOutDate.UseVisualStyleBackColor = true;
            // 
            // radSearchName
            // 
            this.radSearchName.AutoSize = true;
            this.radSearchName.Location = new System.Drawing.Point(4, 32);
            this.radSearchName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSearchName.Name = "radSearchName";
            this.radSearchName.Size = new System.Drawing.Size(134, 21);
            this.radSearchName.TabIndex = 3;
            this.radSearchName.TabStop = true;
            this.radSearchName.Text = "Search by Name";
            this.radSearchName.UseVisualStyleBackColor = true;
            // 
            // radSearchID
            // 
            this.radSearchID.AutoSize = true;
            this.radSearchID.Location = new System.Drawing.Point(4, 4);
            this.radSearchID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSearchID.Name = "radSearchID";
            this.radSearchID.Size = new System.Drawing.Size(110, 21);
            this.radSearchID.TabIndex = 2;
            this.radSearchID.TabStop = true;
            this.radSearchID.Text = "Search by ID";
            this.radSearchID.UseVisualStyleBackColor = true;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(13, 155);
            this.lstResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstResults.Name = "lstResults";
            this.lstResults.ScrollAlwaysVisible = true;
            this.lstResults.Size = new System.Drawing.Size(1033, 276);
            this.lstResults.TabIndex = 2;
            // 
            // pnlSearchConditions
            // 
            this.pnlSearchConditions.Location = new System.Drawing.Point(232, 33);
            this.pnlSearchConditions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSearchConditions.Name = "pnlSearchConditions";
            this.pnlSearchConditions.Size = new System.Drawing.Size(816, 114);
            this.pnlSearchConditions.TabIndex = 4;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(64, 24);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.menuHome_Click);
            // 
            // EmployeeSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 454);
            this.Controls.Add(this.pnlSearchConditions);
            this.Controls.Add(this.pnlSearchChoices);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeSearch";
            this.Text = "Employee Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeSearch_FormClosed);
            this.pnlSearchChoices.ResumeLayout(false);
            this.pnlSearchChoices.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchChoices;
        private System.Windows.Forms.RadioButton radSearchReturnDate;
        private System.Windows.Forms.RadioButton radSearchCheckOutDate;
        private System.Windows.Forms.RadioButton radSearchName;
        private System.Windows.Forms.RadioButton radSearchID;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Panel pnlSearchConditions;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
    }
}