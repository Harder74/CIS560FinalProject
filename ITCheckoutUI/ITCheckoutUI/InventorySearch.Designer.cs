
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
            this.pnlSearchConditions = new System.Windows.Forms.Panel();
            this.pnlSearchChoices = new System.Windows.Forms.Panel();
            this.radSearchCustomerID = new System.Windows.Forms.RadioButton();
            this.radSearchItemType = new System.Windows.Forms.RadioButton();
            this.radSearchSerialNumber = new System.Windows.Forms.RadioButton();
            this.radSearchItemName = new System.Windows.Forms.RadioButton();
            this.radSearchID = new System.Windows.Forms.RadioButton();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnShowItemPopularity = new System.Windows.Forms.Button();
            this.btnShowAvailableItems = new System.Windows.Forms.Button();
            this.btnShowCheckedOutItems = new System.Windows.Forms.Button();
            this.btnShowRemovedItems = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSearchChoices.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearchConditions
            // 
            this.pnlSearchConditions.Location = new System.Drawing.Point(299, 74);
            this.pnlSearchConditions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSearchConditions.Name = "pnlSearchConditions";
            this.pnlSearchConditions.Size = new System.Drawing.Size(752, 146);
            this.pnlSearchConditions.TabIndex = 10;
            // 
            // pnlSearchChoices
            // 
            this.pnlSearchChoices.Controls.Add(this.radSearchCustomerID);
            this.pnlSearchChoices.Controls.Add(this.radSearchItemType);
            this.pnlSearchChoices.Controls.Add(this.radSearchSerialNumber);
            this.pnlSearchChoices.Controls.Add(this.radSearchItemName);
            this.pnlSearchChoices.Controls.Add(this.radSearchID);
            this.pnlSearchChoices.Location = new System.Drawing.Point(16, 74);
            this.pnlSearchChoices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSearchChoices.Name = "pnlSearchChoices";
            this.pnlSearchChoices.Size = new System.Drawing.Size(275, 146);
            this.pnlSearchChoices.TabIndex = 9;
            // 
            // radSearchCustomerID
            // 
            this.radSearchCustomerID.AutoSize = true;
            this.radSearchCustomerID.Location = new System.Drawing.Point(4, 117);
            this.radSearchCustomerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSearchCustomerID.Name = "radSearchCustomerID";
            this.radSearchCustomerID.Size = new System.Drawing.Size(263, 21);
            this.radSearchCustomerID.TabIndex = 6;
            this.radSearchCustomerID.TabStop = true;
            this.radSearchCustomerID.Text = "Search by Customer ID Checking Out";
            this.radSearchCustomerID.UseVisualStyleBackColor = true;
            // 
            // radSearchItemType
            // 
            this.radSearchItemType.AutoSize = true;
            this.radSearchItemType.Location = new System.Drawing.Point(4, 89);
            this.radSearchItemType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSearchItemType.Name = "radSearchItemType";
            this.radSearchItemType.Size = new System.Drawing.Size(174, 21);
            this.radSearchItemType.TabIndex = 5;
            this.radSearchItemType.TabStop = true;
            this.radSearchItemType.Text = "Search by Return Date";
            this.radSearchItemType.UseVisualStyleBackColor = true;
            // 
            // radSearchSerialNumber
            // 
            this.radSearchSerialNumber.AutoSize = true;
            this.radSearchSerialNumber.Location = new System.Drawing.Point(4, 60);
            this.radSearchSerialNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSearchSerialNumber.Name = "radSearchSerialNumber";
            this.radSearchSerialNumber.Size = new System.Drawing.Size(190, 21);
            this.radSearchSerialNumber.TabIndex = 4;
            this.radSearchSerialNumber.TabStop = true;
            this.radSearchSerialNumber.Text = "Search by Checkout Date";
            this.radSearchSerialNumber.UseVisualStyleBackColor = true;
            // 
            // radSearchItemName
            // 
            this.radSearchItemName.AutoSize = true;
            this.radSearchItemName.Location = new System.Drawing.Point(4, 32);
            this.radSearchItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radSearchItemName.Name = "radSearchItemName";
            this.radSearchItemName.Size = new System.Drawing.Size(164, 21);
            this.radSearchItemName.TabIndex = 3;
            this.radSearchItemName.TabStop = true;
            this.radSearchItemName.Text = "Search by Item Name";
            this.radSearchItemName.UseVisualStyleBackColor = true;
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
            this.lstResults.Location = new System.Drawing.Point(16, 228);
            this.lstResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstResults.Name = "lstResults";
            this.lstResults.ScrollAlwaysVisible = true;
            this.lstResults.Size = new System.Drawing.Size(1033, 276);
            this.lstResults.TabIndex = 8;
            // 
            // btnShowItemPopularity
            // 
            this.btnShowItemPopularity.Location = new System.Drawing.Point(11, 33);
            this.btnShowItemPopularity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowItemPopularity.Name = "btnShowItemPopularity";
            this.btnShowItemPopularity.Size = new System.Drawing.Size(179, 33);
            this.btnShowItemPopularity.TabIndex = 11;
            this.btnShowItemPopularity.Text = "Show Popularity of Items";
            this.btnShowItemPopularity.UseVisualStyleBackColor = true;
            // 
            // btnShowAvailableItems
            // 
            this.btnShowAvailableItems.Location = new System.Drawing.Point(261, 33);
            this.btnShowAvailableItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowAvailableItems.Name = "btnShowAvailableItems";
            this.btnShowAvailableItems.Size = new System.Drawing.Size(185, 33);
            this.btnShowAvailableItems.TabIndex = 12;
            this.btnShowAvailableItems.Text = "Show All Available Items";
            this.btnShowAvailableItems.UseVisualStyleBackColor = true;
            // 
            // btnShowCheckedOutItems
            // 
            this.btnShowCheckedOutItems.Location = new System.Drawing.Point(540, 33);
            this.btnShowCheckedOutItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowCheckedOutItems.Name = "btnShowCheckedOutItems";
            this.btnShowCheckedOutItems.Size = new System.Drawing.Size(219, 33);
            this.btnShowCheckedOutItems.TabIndex = 13;
            this.btnShowCheckedOutItems.Text = "Show All Checked Out Items";
            this.btnShowCheckedOutItems.UseVisualStyleBackColor = true;
            // 
            // btnShowRemovedItems
            // 
            this.btnShowRemovedItems.Location = new System.Drawing.Point(853, 33);
            this.btnShowRemovedItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowRemovedItems.Name = "btnShowRemovedItems";
            this.btnShowRemovedItems.Size = new System.Drawing.Size(197, 33);
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
            this.menuStrip.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(64, 24);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.menuHome_Click);
            // 
            // InventorySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 524);
            this.Controls.Add(this.btnShowCheckedOutItems);
            this.Controls.Add(this.btnShowRemovedItems);
            this.Controls.Add(this.btnShowAvailableItems);
            this.Controls.Add(this.btnShowItemPopularity);
            this.Controls.Add(this.pnlSearchConditions);
            this.Controls.Add(this.pnlSearchChoices);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InventorySearch";
            this.Text = "Inventory Search";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventorySearch_FormClosed);
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
        private System.Windows.Forms.RadioButton radSearchItemType;
        private System.Windows.Forms.RadioButton radSearchSerialNumber;
        private System.Windows.Forms.RadioButton radSearchItemName;
        private System.Windows.Forms.RadioButton radSearchID;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.RadioButton radSearchCustomerID;
        private System.Windows.Forms.Button btnShowItemPopularity;
        private System.Windows.Forms.Button btnShowAvailableItems;
        private System.Windows.Forms.Button btnShowCheckedOutItems;
        private System.Windows.Forms.Button btnShowRemovedItems;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
    }
}