namespace The_ture_project
{
    partial class UC_Orders
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlContent1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Order = new System.Windows.Forms.DataGridView();
            this.OrderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderItem = new System.Windows.Forms.DataGridView();
            this.pnlContent1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItem)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add to order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 544);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 80);
            this.button3.TabIndex = 2;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(5, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 82);
            this.button4.TabIndex = 3;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 393);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 90);
            this.button5.TabIndex = 4;
            this.button5.Text = "Load order";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pnlContent1
            // 
            this.pnlContent1.Controls.Add(this.groupBox1);
            this.pnlContent1.Controls.Add(this.Order);
            this.pnlContent1.Controls.Add(this.OrderItem);
            this.pnlContent1.Location = new System.Drawing.Point(20, 13);
            this.pnlContent1.Name = "pnlContent1";
            this.pnlContent1.Size = new System.Drawing.Size(1227, 649);
            this.pnlContent1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(3, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 630);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Order
            // 
            this.Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderName,
            this.Description,
            this.OrderDate,
            this.Items,
            this.TotalAmount});
            this.Order.Location = new System.Drawing.Point(682, 16);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(530, 630);
            this.Order.TabIndex = 6;
            // 
            // OrderName
            // 
            this.OrderName.HeaderText = "Name of order";
            this.OrderName.Name = "OrderName";
            // 
            // Description
            // 
            this.Description.HeaderText = "Brand";
            this.Description.Name = "Description";
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Date";
            this.OrderDate.Name = "OrderDate";
            // 
            // Items
            // 
            this.Items.HeaderText = "Items";
            this.Items.Name = "Items";
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // OrderItem
            // 
            this.OrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderItem.Location = new System.Drawing.Point(133, 16);
            this.OrderItem.Name = "OrderItem";
            this.OrderItem.Size = new System.Drawing.Size(543, 630);
            this.OrderItem.TabIndex = 5;
            this.OrderItem.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAvailable_MouseDown);
            this.OrderItem.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvCurrentOrder_DragDrop);
            this.OrderItem.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvCurrentOrder_DragDrop);
            // 
            // UC_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent1);
            this.Name = "UC_Orders";
            this.Size = new System.Drawing.Size(1262, 665);
            this.pnlContent1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel pnlContent1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Order;
        private System.Windows.Forms.DataGridView OrderItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
    }
}
