
namespace ITCheckoutUI
{
    partial class InventorySearch
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
            this.radSearchCustomerID = new System.Windows.Forms.RadioButton();
            this.radSearchItemType = new System.Windows.Forms.RadioButton();
            this.radSearchSerialNumber = new System.Windows.Forms.RadioButton();
            this.radSearchItemName = new System.Windows.Forms.RadioButton();
            this.radSearchID = new System.Windows.Forms.RadioButton();
            this.btnShowItemPopularity = new System.Windows.Forms.Button();
            this.btnShowAvailableItems = new System.Windows.Forms.Button();
            this.btnShowCheckedOutItems = new System.Windows.Forms.Button();
            this.btnShowRemovedItems = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.pnlSearchConditions2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSearchConditions1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSearchChoices.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearchChoices
            // 
            this.pnlSearchChoices.Controls.Add(this.radSearchCustomerID);
            this.pnlSearchChoices.Controls.Add(this.radSearchItemType);
            this.pnlSearchChoices.Controls.Add(this.radSearchSerialNumber);
            this.pnlSearchChoices.Controls.Add(this.radSearchItemName);
            this.pnlSearchChoices.Controls.Add(this.radSearchID);
            this.pnlSearchChoices.Location = new System.Drawing.Point(12, 60);
            this.pnlSearchChoices.Name = "pnlSearchChoices";
            this.pnlSearchChoices.Size = new System.Drawing.Size(206, 119);
            this.pnlSearchChoices.TabIndex = 9;
            // 
            // radSearchCustomerID
            // 
            this.radSearchCustomerID.AutoSize = true;
            this.radSearchCustomerID.Location = new System.Drawing.Point(3, 95);
            this.radSearchCustomerID.Name = "radSearchCustomerID";
            this.radSearchCustomerID.Size = new System.Drawing.Size(202, 17);
            this.radSearchCustomerID.TabIndex = 6;
            this.radSearchCustomerID.TabStop = true;
            this.radSearchCustomerID.Text = "Search by Customer ID Checking Out";
            this.radSearchCustomerID.UseVisualStyleBackColor = true;
            this.radSearchCustomerID.CheckedChanged += new System.EventHandler(this.radSearchCustomerID_CheckedChanged);
            // 
            // radSearchItemType
            // 
            this.radSearchItemType.AutoSize = true;
            this.radSearchItemType.Location = new System.Drawing.Point(3, 72);
            this.radSearchItemType.Name = "radSearchItemType";
            this.radSearchItemType.Size = new System.Drawing.Size(123, 17);
            this.radSearchItemType.TabIndex = 5;
            this.radSearchItemType.TabStop = true;
            this.radSearchItemType.Text = "Search by Item Type";
            this.radSearchItemType.UseVisualStyleBackColor = true;
            this.radSearchItemType.CheckedChanged += new System.EventHandler(this.radSearchItemType_CheckedChanged);
            // 
            // radSearchSerialNumber
            // 
            this.radSearchSerialNumber.AutoSize = true;
            this.radSearchSerialNumber.Location = new System.Drawing.Point(3, 49);
            this.radSearchSerialNumber.Name = "radSearchSerialNumber";
            this.radSearchSerialNumber.Size = new System.Drawing.Size(142, 17);
            this.radSearchSerialNumber.TabIndex = 4;
            this.radSearchSerialNumber.TabStop = true;
            this.radSearchSerialNumber.Text = "Search by Serial Number";
            this.radSearchSerialNumber.UseVisualStyleBackColor = true;
            this.radSearchSerialNumber.CheckedChanged += new System.EventHandler(this.radSearchSerialNumber_CheckedChanged);
            // 
            // radSearchItemName
            // 
            this.radSearchItemName.AutoSize = true;
            this.radSearchItemName.Location = new System.Drawing.Point(3, 26);
            this.radSearchItemName.Name = "radSearchItemName";
            this.radSearchItemName.Size = new System.Drawing.Size(127, 17);
            this.radSearchItemName.TabIndex = 3;
            this.radSearchItemName.TabStop = true;
            this.radSearchItemName.Text = "Search by Item Name";
            this.radSearchItemName.UseVisualStyleBackColor = true;
            this.radSearchItemName.CheckedChanged += new System.EventHandler(this.radSearchItemName_CheckedChanged);
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
            // btnShowItemPopularity
            // 
            this.btnShowItemPopularity.Location = new System.Drawing.Point(8, 27);
            this.btnShowItemPopularity.Name = "btnShowItemPopularity";
            this.btnShowItemPopularity.Size = new System.Drawing.Size(134, 27);
            this.btnShowItemPopularity.TabIndex = 11;
            this.btnShowItemPopularity.Text = "Show Popularity of Items";
            this.btnShowItemPopularity.UseVisualStyleBackColor = true;
            // 
            // btnShowAvailableItems
            // 
            this.btnShowAvailableItems.Location = new System.Drawing.Point(196, 27);
            this.btnShowAvailableItems.Name = "btnShowAvailableItems";
            this.btnShowAvailableItems.Size = new System.Drawing.Size(139, 27);
            this.btnShowAvailableItems.TabIndex = 12;
            this.btnShowAvailableItems.Text = "Show All Available Items";
            this.btnShowAvailableItems.UseVisualStyleBackColor = true;
            // 
            // btnShowCheckedOutItems
            // 
            this.btnShowCheckedOutItems.Location = new System.Drawing.Point(405, 27);
            this.btnShowCheckedOutItems.Name = "btnShowCheckedOutItems";
            this.btnShowCheckedOutItems.Size = new System.Drawing.Size(164, 27);
            this.btnShowCheckedOutItems.TabIndex = 13;
            this.btnShowCheckedOutItems.Text = "Show All Checked Out Items";
            this.btnShowCheckedOutItems.UseVisualStyleBackColor = true;
            // 
            // btnShowRemovedItems
            // 
            this.btnShowRemovedItems.Location = new System.Drawing.Point(640, 27);
            this.btnShowRemovedItems.Name = "btnShowRemovedItems";
            this.btnShowRemovedItems.Size = new System.Drawing.Size(148, 27);
            this.btnShowRemovedItems.TabIndex = 15;
            this.btnShowRemovedItems.Text = "Show All Removed Items";
            this.btnShowRemovedItems.UseVisualStyleBackColor = true;
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
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(52, 20);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.menuHome_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(10, 185);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(778, 231);
            this.dgvResults.TabIndex = 17;
            // 
            // pnlSearchConditions2
            // 
            this.pnlSearchConditions2.Location = new System.Drawing.Point(351, 60);
            this.pnlSearchConditions2.Name = "pnlSearchConditions2";
            this.pnlSearchConditions2.Size = new System.Drawing.Size(254, 119);
            this.pnlSearchConditions2.TabIndex = 19;
            // 
            // pnlSearchConditions1
            // 
            this.pnlSearchConditions1.Location = new System.Drawing.Point(224, 60);
            this.pnlSearchConditions1.Name = "pnlSearchConditions1";
            this.pnlSearchConditions1.Size = new System.Drawing.Size(121, 119);
            this.pnlSearchConditions1.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(654, 101);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 32);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // InventorySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlSearchConditions2);
            this.Controls.Add(this.pnlSearchConditions1);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnShowCheckedOutItems);
            this.Controls.Add(this.btnShowRemovedItems);
            this.Controls.Add(this.btnShowAvailableItems);
            this.Controls.Add(this.btnShowItemPopularity);
            this.Controls.Add(this.pnlSearchChoices);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "InventorySearch";
            this.Text = "Inventory Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventorySearch_FormClosed);
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
        private System.Windows.Forms.RadioButton radSearchItemType;
        private System.Windows.Forms.RadioButton radSearchSerialNumber;
        private System.Windows.Forms.RadioButton radSearchItemName;
        private System.Windows.Forms.RadioButton radSearchID;
        private System.Windows.Forms.RadioButton radSearchCustomerID;
        private System.Windows.Forms.Button btnShowItemPopularity;
        private System.Windows.Forms.Button btnShowAvailableItems;
        private System.Windows.Forms.Button btnShowCheckedOutItems;
        private System.Windows.Forms.Button btnShowRemovedItems;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.FlowLayoutPanel pnlSearchConditions2;
        private System.Windows.Forms.FlowLayoutPanel pnlSearchConditions1;
        private System.Windows.Forms.Button btnSearch;
    }
}