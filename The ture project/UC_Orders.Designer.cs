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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlContent1 = new System.Windows.Forms.Panel();
            this.dgvCurrentOrder = new System.Windows.Forms.DataGridView();
            this.dgvAvailable = new System.Windows.Forms.DataGridView();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtOrderName = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContent1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.pnlContent1.Controls.Add(this.dgvCurrentOrder);
            this.pnlContent1.Controls.Add(this.dgvAvailable);
            this.pnlContent1.Controls.Add(this.txtDescription);
            this.pnlContent1.Controls.Add(this.txtOrderName);
            this.pnlContent1.Controls.Add(this.lblTotal);
            this.pnlContent1.Controls.Add(this.groupBox1);
            this.pnlContent1.Location = new System.Drawing.Point(20, 13);
            this.pnlContent1.Name = "pnlContent1";
            this.pnlContent1.Size = new System.Drawing.Size(1227, 649);
            this.pnlContent1.TabIndex = 5;
            // 
            // dgvCurrentOrder
            // 
            this.dgvCurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentOrder.Location = new System.Drawing.Point(647, 16);
            this.dgvCurrentOrder.Name = "dgvCurrentOrder";
            this.dgvCurrentOrder.Size = new System.Drawing.Size(547, 586);
            this.dgvCurrentOrder.TabIndex = 12;
            // 
            // dgvAvailable
            // 
            this.dgvAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName});
            this.dgvAvailable.Location = new System.Drawing.Point(156, 16);
            this.dgvAvailable.Name = "dgvAvailable";
            this.dgvAvailable.Size = new System.Drawing.Size(450, 570);
            this.dgvAvailable.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(285, 613);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 10;
            // 
            // txtOrderName
            // 
            this.txtOrderName.Location = new System.Drawing.Point(156, 613);
            this.txtOrderName.Name = "txtOrderName";
            this.txtOrderName.Size = new System.Drawing.Size(100, 20);
            this.txtOrderName.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1138, 605);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ProductID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "ProductName";
            this.colName.HeaderText = "Product Name";
            this.colName.Name = "colName";
            // 
            // UC_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlContent1);
            this.Name = "UC_Orders";
            this.Size = new System.Drawing.Size(1262, 665);
            this.pnlContent1.ResumeLayout(false);
            this.pnlContent1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailable)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtOrderName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvAvailable;
        private System.Windows.Forms.DataGridView dgvCurrentOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
    }
}
