
namespace ITCheckoutUI
{
    partial class ReturnItem
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
            this.txtCheckoutID = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblCheckoutID = new System.Windows.Forms.Label();
            this.lblEmployeeID = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHome});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(309, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(52, 20);
            this.menuHome.Text = "Home";
            // 
            // txtCheckoutID
            // 
            this.txtCheckoutID.Location = new System.Drawing.Point(120, 68);
            this.txtCheckoutID.Name = "txtCheckoutID";
            this.txtCheckoutID.Size = new System.Drawing.Size(162, 20);
            this.txtCheckoutID.TabIndex = 2;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(120, 111);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(162, 20);
            this.txtEmployeeID.TabIndex = 3;
            // 
            // lblCheckoutID
            // 
            this.lblCheckoutID.AutoSize = true;
            this.lblCheckoutID.Location = new System.Drawing.Point(44, 71);
            this.lblCheckoutID.Name = "lblCheckoutID";
            this.lblCheckoutID.Size = new System.Drawing.Size(70, 13);
            this.lblCheckoutID.TabIndex = 4;
            this.lblCheckoutID.Text = "Checkout ID:";
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.AutoSize = true;
            this.lblEmployeeID.Location = new System.Drawing.Point(19, 114);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(95, 13);
            this.lblEmployeeID.TabIndex = 5;
            this.lblEmployeeID.Text = "Your Employee ID:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(95, 35);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(125, 13);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Enter Return Information:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(120, 154);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // ReturnItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 211);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblEmployeeID);
            this.Controls.Add(this.lblCheckoutID);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.txtCheckoutID);
            this.Controls.Add(this.menuStrip);
            this.Name = "ReturnItem";
            this.Text = "ReturnItem";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.TextBox txtCheckoutID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblCheckoutID;
        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnSubmit;
    }
}