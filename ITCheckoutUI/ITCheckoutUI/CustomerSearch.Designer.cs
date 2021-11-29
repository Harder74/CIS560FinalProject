
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
            this.pnlSearchChoices = new System.Windows.Forms.Panel();
            this.radReturnDate = new System.Windows.Forms.RadioButton();
            this.radCheckOutDate = new System.Windows.Forms.RadioButton();
            this.radSearchName = new System.Windows.Forms.RadioButton();
            this.radSearchID = new System.Windows.Forms.RadioButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSearchConditions1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearchConditions2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.pnlSearchChoices.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
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
            this.radReturnDate.CheckedChanged += new System.EventHandler(this.radReturnDate_CheckedChanged);
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
            this.radCheckOutDate.CheckedChanged += new System.EventHandler(this.radCheckOutDate_CheckedChanged);
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
            this.radSearchName.CheckedChanged += new System.EventHandler(this.radSearchName_CheckedChanged);
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
            this.radSearchID.CheckedChanged += new System.EventHandler(this.radSearchID_CheckedChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(52, 20);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.menuHome_Click);
            // 
            // pnlSearchConditions1
            // 
            this.pnlSearchConditions1.Location = new System.Drawing.Point(169, 27);
            this.pnlSearchConditions1.Name = "pnlSearchConditions1";
            this.pnlSearchConditions1.Size = new System.Drawing.Size(121, 93);
            this.pnlSearchConditions1.TabIndex = 10;
            // 
            // pnlSearchConditions2
            // 
            this.pnlSearchConditions2.Location = new System.Drawing.Point(296, 27);
            this.pnlSearchConditions2.Name = "pnlSearchConditions2";
            this.pnlSearchConditions2.Size = new System.Drawing.Size(244, 93);
            this.pnlSearchConditions2.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(635, 61);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 32);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(10, 126);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(778, 231);
            this.dgvResults.TabIndex = 13;
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlSearchConditions2);
            this.Controls.Add(this.pnlSearchConditions1);
            this.Controls.Add(this.pnlSearchChoices);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "CustomerSearch";
            this.Text = "Customer Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerSearch_FormClosed);
            this.pnlSearchChoices.ResumeLayout(false);
            this.pnlSearchChoices.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlSearchChoices;
        private System.Windows.Forms.RadioButton radReturnDate;
        private System.Windows.Forms.RadioButton radCheckOutDate;
        private System.Windows.Forms.RadioButton radSearchName;
        private System.Windows.Forms.RadioButton radSearchID;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.FlowLayoutPanel pnlSearchConditions1;
        private System.Windows.Forms.FlowLayoutPanel pnlSearchConditions2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvResults;
    }
}