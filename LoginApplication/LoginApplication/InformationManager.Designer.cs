namespace LoginApplication
{
    partial class InformationManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonItems = new System.Windows.Forms.Button();
            this.buttonAgents = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonOrderDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose one of the databases below to manage:";
            // 
            // buttonItems
            // 
            this.buttonItems.Location = new System.Drawing.Point(43, 75);
            this.buttonItems.Name = "buttonItems";
            this.buttonItems.Size = new System.Drawing.Size(94, 29);
            this.buttonItems.TabIndex = 1;
            this.buttonItems.Text = "Items";
            this.buttonItems.UseVisualStyleBackColor = true;
            this.buttonItems.Click += new System.EventHandler(this.ButtonItems_Click);
            // 
            // buttonAgents
            // 
            this.buttonAgents.Location = new System.Drawing.Point(243, 75);
            this.buttonAgents.Name = "buttonAgents";
            this.buttonAgents.Size = new System.Drawing.Size(94, 29);
            this.buttonAgents.TabIndex = 2;
            this.buttonAgents.Text = "Agents";
            this.buttonAgents.UseVisualStyleBackColor = true;
            this.buttonAgents.Click += new System.EventHandler(this.ButtonAgents_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(441, 75);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(94, 29);
            this.buttonOrders.TabIndex = 3;
            this.buttonOrders.Text = "Orders";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.ButtonOrders_Click);
            // 
            // buttonOrderDetails
            // 
            this.buttonOrderDetails.Location = new System.Drawing.Point(631, 75);
            this.buttonOrderDetails.Name = "buttonOrderDetails";
            this.buttonOrderDetails.Size = new System.Drawing.Size(108, 29);
            this.buttonOrderDetails.TabIndex = 4;
            this.buttonOrderDetails.Text = "Order Details";
            this.buttonOrderDetails.UseVisualStyleBackColor = true;
            this.buttonOrderDetails.Click += new System.EventHandler(this.ButtonOrderDetails_Click);
            // 
            // InformationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 128);
            this.Controls.Add(this.buttonOrderDetails);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonAgents);
            this.Controls.Add(this.buttonItems);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "InformationManager";
            this.Text = "Database Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonItems;
        private Button buttonAgents;
        private Button buttonOrders;
        private Button buttonOrderDetails;
    }
}