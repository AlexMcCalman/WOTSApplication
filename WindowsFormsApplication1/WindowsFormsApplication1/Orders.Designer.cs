namespace WindowsFormsApplication1
{
    partial class Orders
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.orderIDList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderIDBox = new System.Windows.Forms.TextBox();
            this.orderBox = new System.Windows.Forms.ListBox();
            this.infoBtn = new System.Windows.Forms.Button();
            this.orderIDLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.porouswareLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.productLocationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(12, 30);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click_1);
            // 
            // orderIDList
            // 
            this.orderIDList.FormattingEnabled = true;
            this.orderIDList.Location = new System.Drawing.Point(12, 90);
            this.orderIDList.Name = "orderIDList";
            this.orderIDList.Size = new System.Drawing.Size(347, 134);
            this.orderIDList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order list";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // orderIDBox
            // 
            this.orderIDBox.Location = new System.Drawing.Point(12, 242);
            this.orderIDBox.Name = "orderIDBox";
            this.orderIDBox.Size = new System.Drawing.Size(100, 20);
            this.orderIDBox.TabIndex = 4;
            this.orderIDBox.Text = "Order ID";
            // 
            // orderBox
            // 
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Location = new System.Drawing.Point(10, 343);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(349, 95);
            this.orderBox.TabIndex = 5;
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(12, 270);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(75, 23);
            this.infoBtn.TabIndex = 6;
            this.infoBtn.Text = "Info";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // orderIDLabel
            // 
            this.orderIDLabel.AutoSize = true;
            this.orderIDLabel.Location = new System.Drawing.Point(13, 320);
            this.orderIDLabel.Name = "orderIDLabel";
            this.orderIDLabel.Size = new System.Drawing.Size(47, 13);
            this.orderIDLabel.TabIndex = 7;
            this.orderIDLabel.Text = "Order ID";
            this.orderIDLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(66, 320);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(44, 13);
            this.productNameLabel.TabIndex = 9;
            this.productNameLabel.Text = "Product";
            // 
            // porouswareLabel
            // 
            this.porouswareLabel.AutoSize = true;
            this.porouswareLabel.Location = new System.Drawing.Point(149, 318);
            this.porouswareLabel.Name = "porouswareLabel";
            this.porouswareLabel.Size = new System.Drawing.Size(69, 13);
            this.porouswareLabel.TabIndex = 10;
            this.porouswareLabel.Text = "Porousware?";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(224, 318);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 11;
            this.quantityLabel.Text = "Quantity";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 241);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.Text = "Status";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(152, 269);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(284, 493);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 14;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // productLocationLabel
            // 
            this.productLocationLabel.AutoSize = true;
            this.productLocationLabel.Location = new System.Drawing.Point(277, 317);
            this.productLocationLabel.Name = "productLocationLabel";
            this.productLocationLabel.Size = new System.Drawing.Size(48, 13);
            this.productLocationLabel.TabIndex = 15;
            this.productLocationLabel.Text = "Location";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 576);
            this.Controls.Add(this.productLocationLabel);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.porouswareLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.orderIDLabel);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.orderIDBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderIDList);
            this.Controls.Add(this.searchBtn);
            this.Name = "Orders";
            this.Text = "Orders";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListBox orderIDList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox orderIDBox;
        private System.Windows.Forms.ListBox orderBox;
        private System.Windows.Forms.Button infoBtn;
        private System.Windows.Forms.Label orderIDLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label porouswareLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label productLocationLabel;
    }
}