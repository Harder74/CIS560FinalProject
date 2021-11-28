
namespace ITCheckoutUI
{
    partial class ViewInventoryItem
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
            this.lstResults = new System.Windows.Forms.ListBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.lblCheckedOut = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblOutputItemID = new System.Windows.Forms.Label();
            this.lblOutputItemName = new System.Windows.Forms.Label();
            this.lblOutputSerialNo = new System.Windows.Forms.Label();
            this.lblOutputCheckedOut = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(16, 207);
            this.lstResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstResults.Name = "lstResults";
            this.lstResults.ScrollAlwaysVisible = true;
            this.lstResults.Size = new System.Drawing.Size(1033, 276);
            this.lstResults.TabIndex = 9;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(60, 53);
            this.lblItemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(51, 17);
            this.lblItemID.TabIndex = 10;
            this.lblItemID.Text = "ItemID:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(33, 87);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(79, 17);
            this.lblItemName.TabIndex = 11;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(13, 122);
            this.lblSerialNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(102, 17);
            this.lblSerialNo.TabIndex = 12;
            this.lblSerialNo.Text = "Serial Number:";
            // 
            // lblCheckedOut
            // 
            this.lblCheckedOut.AutoSize = true;
            this.lblCheckedOut.Location = new System.Drawing.Point(17, 156);
            this.lblCheckedOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCheckedOut.Name = "lblCheckedOut";
            this.lblCheckedOut.Size = new System.Drawing.Size(94, 17);
            this.lblCheckedOut.TabIndex = 13;
            this.lblCheckedOut.Text = "Checked Out:";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(64, 24);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.menuHome_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(907, 47);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(144, 28);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblOutputItemID
            // 
            this.lblOutputItemID.AutoSize = true;
            this.lblOutputItemID.Location = new System.Drawing.Point(123, 53);
            this.lblOutputItemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputItemID.Name = "lblOutputItemID";
            this.lblOutputItemID.Size = new System.Drawing.Size(0, 17);
            this.lblOutputItemID.TabIndex = 16;
            // 
            // lblOutputItemName
            // 
            this.lblOutputItemName.AutoSize = true;
            this.lblOutputItemName.Location = new System.Drawing.Point(123, 87);
            this.lblOutputItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputItemName.Name = "lblOutputItemName";
            this.lblOutputItemName.Size = new System.Drawing.Size(0, 17);
            this.lblOutputItemName.TabIndex = 17;
            // 
            // lblOutputSerialNo
            // 
            this.lblOutputSerialNo.AutoSize = true;
            this.lblOutputSerialNo.Location = new System.Drawing.Point(123, 122);
            this.lblOutputSerialNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputSerialNo.Name = "lblOutputSerialNo";
            this.lblOutputSerialNo.Size = new System.Drawing.Size(0, 17);
            this.lblOutputSerialNo.TabIndex = 18;
            // 
            // lblOutputCheckedOut
            // 
            this.lblOutputCheckedOut.AutoSize = true;
            this.lblOutputCheckedOut.Location = new System.Drawing.Point(123, 156);
            this.lblOutputCheckedOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputCheckedOut.Name = "lblOutputCheckedOut";
            this.lblOutputCheckedOut.Size = new System.Drawing.Size(0, 17);
            this.lblOutputCheckedOut.TabIndex = 19;
            // 
            // ViewInventoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 508);
            this.Controls.Add(this.lblOutputCheckedOut);
            this.Controls.Add(this.lblOutputSerialNo);
            this.Controls.Add(this.lblOutputItemName);
            this.Controls.Add(this.lblOutputItemID);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblCheckedOut);
            this.Controls.Add(this.lblSerialNo);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.lstResults);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewInventoryItem";
            this.Text = "View Inventory Item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewInventoryItem_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.Label lblCheckedOut;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblOutputItemID;
        private System.Windows.Forms.Label lblOutputItemName;
        private System.Windows.Forms.Label lblOutputSerialNo;
        private System.Windows.Forms.Label lblOutputCheckedOut;
    }
}