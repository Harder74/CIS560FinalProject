
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
            this.lstResults.Location = new System.Drawing.Point(12, 168);
            this.lstResults.Name = "lstResults";
            this.lstResults.ScrollAlwaysVisible = true;
            this.lstResults.Size = new System.Drawing.Size(776, 225);
            this.lstResults.TabIndex = 9;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(45, 43);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(41, 13);
            this.lblItemID.TabIndex = 10;
            this.lblItemID.Text = "ItemID:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(25, 71);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(61, 13);
            this.lblItemName.TabIndex = 11;
            this.lblItemName.Text = "Item Name:";
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(10, 99);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(76, 13);
            this.lblSerialNo.TabIndex = 12;
            this.lblSerialNo.Text = "Serial Number:";
            // 
            // lblCheckedOut
            // 
            this.lblCheckedOut.AutoSize = true;
            this.lblCheckedOut.Location = new System.Drawing.Point(13, 127);
            this.lblCheckedOut.Name = "lblCheckedOut";
            this.lblCheckedOut.Size = new System.Drawing.Size(73, 13);
            this.lblCheckedOut.TabIndex = 13;
            this.lblCheckedOut.Text = "Checked Out:";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(52, 20);
            this.menuHome.Text = "Home";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(680, 38);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(108, 23);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblOutputItemID
            // 
            this.lblOutputItemID.AutoSize = true;
            this.lblOutputItemID.Location = new System.Drawing.Point(92, 43);
            this.lblOutputItemID.Name = "lblOutputItemID";
            this.lblOutputItemID.Size = new System.Drawing.Size(0, 13);
            this.lblOutputItemID.TabIndex = 16;
            // 
            // lblOutputItemName
            // 
            this.lblOutputItemName.AutoSize = true;
            this.lblOutputItemName.Location = new System.Drawing.Point(92, 71);
            this.lblOutputItemName.Name = "lblOutputItemName";
            this.lblOutputItemName.Size = new System.Drawing.Size(0, 13);
            this.lblOutputItemName.TabIndex = 17;
            // 
            // lblOutputSerialNo
            // 
            this.lblOutputSerialNo.AutoSize = true;
            this.lblOutputSerialNo.Location = new System.Drawing.Point(92, 99);
            this.lblOutputSerialNo.Name = "lblOutputSerialNo";
            this.lblOutputSerialNo.Size = new System.Drawing.Size(0, 13);
            this.lblOutputSerialNo.TabIndex = 18;
            // 
            // lblOutputCheckedOut
            // 
            this.lblOutputCheckedOut.AutoSize = true;
            this.lblOutputCheckedOut.Location = new System.Drawing.Point(92, 127);
            this.lblOutputCheckedOut.Name = "lblOutputCheckedOut";
            this.lblOutputCheckedOut.Size = new System.Drawing.Size(0, 13);
            this.lblOutputCheckedOut.TabIndex = 19;
            // 
            // ViewInventoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 413);
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
            this.Name = "ViewInventoryItem";
            this.Text = "ViewInventoryItem";
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