
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
            this.pnlSearchConditions.Location = new System.Drawing.Point(224, 60);
            this.pnlSearchConditions.Name = "pnlSearchConditions";
            this.pnlSearchConditions.Size = new System.Drawing.Size(564, 119);
            this.pnlSearchConditions.TabIndex = 10;
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
            // 
            // radSearchItemType
            // 
            this.radSearchItemType.AutoSize = true;
            this.radSearchItemType.Location = new System.Drawing.Point(3, 72);
            this.radSearchItemType.Name = "radSearchItemType";
            this.radSearchItemType.Size = new System.Drawing.Size(134, 17);
            this.radSearchItemType.TabIndex = 5;
            this.radSearchItemType.TabStop = true;
            this.radSearchItemType.Text = "Search by Return Date";
            this.radSearchItemType.UseVisualStyleBackColor = true;
            // 
            // radSearchSerialNumber
            // 
            this.radSearchSerialNumber.AutoSize = true;
            this.radSearchSerialNumber.Location = new System.Drawing.Point(3, 49);
            this.radSearchSerialNumber.Name = "radSearchSerialNumber";
            this.radSearchSerialNumber.Size = new System.Drawing.Size(148, 17);
            this.radSearchSerialNumber.TabIndex = 4;
            this.radSearchSerialNumber.TabStop = true;
            this.radSearchSerialNumber.Text = "Search by Checkout Date";
            this.radSearchSerialNumber.UseVisualStyleBackColor = true;
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
            this.lstResults.Location = new System.Drawing.Point(12, 185);
            this.lstResults.Name = "lstResults";
            this.lstResults.ScrollAlwaysVisible = true;
            this.lstResults.Size = new System.Drawing.Size(776, 225);
            this.lstResults.TabIndex = 8;
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
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 16;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(52, 20);
            this.menuHome.Text = "Home";
            // 
            // InventorySearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.btnShowCheckedOutItems);
            this.Controls.Add(this.btnShowRemovedItems);
            this.Controls.Add(this.btnShowAvailableItems);
            this.Controls.Add(this.btnShowItemPopularity);
            this.Controls.Add(this.pnlSearchConditions);
            this.Controls.Add(this.pnlSearchChoices);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "InventorySearch";
            this.Text = "InventorySearch";
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