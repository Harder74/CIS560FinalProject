
namespace ITCheckoutUI
{
    partial class Landing
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
            this.btnSearchCustomers = new System.Windows.Forms.Button();
            this.btnSearchEmployees = new System.Windows.Forms.Button();
            this.btnSearchInventoryItems = new System.Windows.Forms.Button();
            this.btnCheckoutItem = new System.Windows.Forms.Button();
            this.btnReturnItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSearchCustomers
            // 
            this.btnSearchCustomers.Location = new System.Drawing.Point(72, 46);
            this.btnSearchCustomers.Name = "btnSearchCustomers";
            this.btnSearchCustomers.Size = new System.Drawing.Size(148, 23);
            this.btnSearchCustomers.TabIndex = 0;
            this.btnSearchCustomers.Text = "Search Customers";
            this.btnSearchCustomers.UseVisualStyleBackColor = true;
            // 
            // btnSearchEmployees
            // 
            this.btnSearchEmployees.Location = new System.Drawing.Point(72, 84);
            this.btnSearchEmployees.Name = "btnSearchEmployees";
            this.btnSearchEmployees.Size = new System.Drawing.Size(148, 23);
            this.btnSearchEmployees.TabIndex = 1;
            this.btnSearchEmployees.Text = "Search Employees";
            this.btnSearchEmployees.UseVisualStyleBackColor = true;
            // 
            // btnSearchInventoryItems
            // 
            this.btnSearchInventoryItems.Location = new System.Drawing.Point(72, 122);
            this.btnSearchInventoryItems.Name = "btnSearchInventoryItems";
            this.btnSearchInventoryItems.Size = new System.Drawing.Size(148, 23);
            this.btnSearchInventoryItems.TabIndex = 2;
            this.btnSearchInventoryItems.Text = "Search Inventory Items";
            this.btnSearchInventoryItems.UseVisualStyleBackColor = true;
            // 
            // btnCheckoutItem
            // 
            this.btnCheckoutItem.Location = new System.Drawing.Point(72, 160);
            this.btnCheckoutItem.Name = "btnCheckoutItem";
            this.btnCheckoutItem.Size = new System.Drawing.Size(148, 23);
            this.btnCheckoutItem.TabIndex = 3;
            this.btnCheckoutItem.Text = "Checkout an Item";
            this.btnCheckoutItem.UseVisualStyleBackColor = true;
            // 
            // btnReturnItem
            // 
            this.btnReturnItem.Location = new System.Drawing.Point(72, 198);
            this.btnReturnItem.Name = "btnReturnItem";
            this.btnReturnItem.Size = new System.Drawing.Size(148, 23);
            this.btnReturnItem.TabIndex = 4;
            this.btnReturnItem.Text = "Return an Item";
            this.btnReturnItem.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(72, 234);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(148, 23);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add an Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(72, 272);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(148, 23);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add a Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(72, 310);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(148, 23);
            this.btnAddEmployee.TabIndex = 7;
            this.btnAddEmployee.Text = "Add an Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose any option:";
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnReturnItem);
            this.Controls.Add(this.btnCheckoutItem);
            this.Controls.Add(this.btnSearchInventoryItems);
            this.Controls.Add(this.btnSearchEmployees);
            this.Controls.Add(this.btnSearchCustomers);
            this.Name = "Landing";
            this.Text = "Landing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchCustomers;
        private System.Windows.Forms.Button btnSearchEmployees;
        private System.Windows.Forms.Button btnSearchInventoryItems;
        private System.Windows.Forms.Button btnCheckoutItem;
        private System.Windows.Forms.Button btnReturnItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label label1;
    }
}