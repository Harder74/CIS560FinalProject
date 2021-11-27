
namespace ITCheckoutUI
{
    partial class CustomerSearch
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
            this.pnlSearchConditions = new System.Windows.Forms.Panel();
            this.pnlSearchChoices = new System.Windows.Forms.Panel();
            this.radReturnDate = new System.Windows.Forms.RadioButton();
            this.radCheckOutDate = new System.Windows.Forms.RadioButton();
            this.radSearchName = new System.Windows.Forms.RadioButton();
            this.radSearchID = new System.Windows.Forms.RadioButton();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSearchChoices.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearchConditions
            // 
            this.pnlSearchConditions.Location = new System.Drawing.Point(174, 27);
            this.pnlSearchConditions.Name = "pnlSearchConditions";
            this.pnlSearchConditions.Size = new System.Drawing.Size(612, 93);
            this.pnlSearchConditions.TabIndex = 7;
            // 
            // pnlSearchChoices
            // 
            this.pnlSearchChoices.Controls.Add(this.radReturnDate);
            this.pnlSearchChoices.Controls.Add(this.radCheckOutDate);
            this.pnlSearchChoices.Controls.Add(this.radSearchName);
            this.pnlSearchChoices.Controls.Add(this.radSearchID);
            this.pnlSearchChoices.Location = new System.Drawing.Point(10, 27);
            this.pnlSearchChoices.Name = "pnlSearchChoices";
            this.pnlSearchChoices.Size = new System.Drawing.Size(153, 93);
            this.pnlSearchChoices.TabIndex = 6;
            // 
            // radReturnDate
            // 
            this.radReturnDate.AutoSize = true;
            this.radReturnDate.Location = new System.Drawing.Point(3, 72);
            this.radReturnDate.Name = "radReturnDate";
            this.radReturnDate.Size = new System.Drawing.Size(134, 17);
            this.radReturnDate.TabIndex = 5;
            this.radReturnDate.TabStop = true;
            this.radReturnDate.Text = "Search by Return Date";
            this.radReturnDate.UseVisualStyleBackColor = true;
            // 
            // radCheckOutDate
            // 
            this.radCheckOutDate.AutoSize = true;
            this.radCheckOutDate.Location = new System.Drawing.Point(3, 49);
            this.radCheckOutDate.Name = "radCheckOutDate";
            this.radCheckOutDate.Size = new System.Drawing.Size(148, 17);
            this.radCheckOutDate.TabIndex = 4;
            this.radCheckOutDate.TabStop = true;
            this.radCheckOutDate.Text = "Search by Checkout Date";
            this.radCheckOutDate.UseVisualStyleBackColor = true;
            // 
            // radSearchName
            // 
            this.radSearchName.AutoSize = true;
            this.radSearchName.Location = new System.Drawing.Point(3, 26);
            this.radSearchName.Name = "radSearchName";
            this.radSearchName.Size = new System.Drawing.Size(104, 17);
            this.radSearchName.TabIndex = 3;
            this.radSearchName.TabStop = true;
            this.radSearchName.Text = "Search by Name";
            this.radSearchName.UseVisualStyleBackColor = true;
            // 
            // radSearchID
            // 
            this.radSearchID.AutoSize = true;
            this.radSearchID.Location = new System.Drawing.Point(3, 3);
            this.radSearchID.Name = "radSearchID";
            this.radSearchID.Size = new System.Drawing.Size(87, 17);
            this.radSearchID.TabIndex = 2;
            this.radSearchID.TabStop = true;
            this.radSearchID.Text = "Search by ID";
            this.radSearchID.UseVisualStyleBackColor = true;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(10, 126);
            this.lstResults.Name = "lstResults";
            this.lstResults.ScrollAlwaysVisible = true;
            this.lstResults.Size = new System.Drawing.Size(776, 225);
            this.lstResults.TabIndex = 5;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(52, 20);
            this.menuHome.Text = "Home";
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.pnlSearchConditions);
            this.Controls.Add(this.pnlSearchChoices);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "CustomerSearch";
            this.Text = "CustomerSearch";
            this.pnlSearchChoices.ResumeLayout(false);
            this.pnlSearchChoices.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchConditions;
        private System.Windows.Forms.Panel pnlSearchChoices;
        private System.Windows.Forms.RadioButton radReturnDate;
        private System.Windows.Forms.RadioButton radCheckOutDate;
        private System.Windows.Forms.RadioButton radSearchName;
        private System.Windows.Forms.RadioButton radSearchID;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
    }
}