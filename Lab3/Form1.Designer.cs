namespace Lab3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Inventorynum = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Count = new System.Windows.Forms.TextBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.display_Product = new System.Windows.Forms.DataGridView();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventorynumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProviderObjectName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNum = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderInventorynum = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCount = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.AvaialableList = new System.Windows.Forms.CheckedListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbluName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.display_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderObjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInventorynum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(123, 115);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(197, 20);
            this.Num.TabIndex = 1;
            this.Num.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(357, 316);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inventory number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Object name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(354, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            // 
            // Inventorynum
            // 
            this.Inventorynum.Location = new System.Drawing.Point(578, 115);
            this.Inventorynum.Name = "Inventorynum";
            this.Inventorynum.Size = new System.Drawing.Size(197, 20);
            this.Inventorynum.TabIndex = 10;
            this.Inventorynum.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(123, 175);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(431, 20);
            this.Name.TabIndex = 11;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(357, 239);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(197, 20);
            this.Price.TabIndex = 12;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(123, 239);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(197, 20);
            this.Count.TabIndex = 13;
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(482, 316);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 14;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(357, 112);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(200, 20);
            this.Date.TabIndex = 15;
            // 
            // display_Product
            // 
            this.display_Product.AllowUserToOrderColumns = true;
            this.display_Product.AutoGenerateColumns = false;
            this.display_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.display_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.inventorynumberDataGridViewTextBoxColumn,
            this.objectnameDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.display_Product.DataSource = this.productBindingSource;
            this.display_Product.Location = new System.Drawing.Point(123, 350);
            this.display_Product.Name = "display_Product";
            this.display_Product.Size = new System.Drawing.Size(644, 150);
            this.display_Product.TabIndex = 16;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // inventorynumberDataGridViewTextBoxColumn
            // 
            this.inventorynumberDataGridViewTextBoxColumn.DataPropertyName = "Inventory_number";
            this.inventorynumberDataGridViewTextBoxColumn.HeaderText = "Inventory_number";
            this.inventorynumberDataGridViewTextBoxColumn.Name = "inventorynumberDataGridViewTextBoxColumn";
            // 
            // objectnameDataGridViewTextBoxColumn
            // 
            this.objectnameDataGridViewTextBoxColumn.DataPropertyName = "Object_name";
            this.objectnameDataGridViewTextBoxColumn.HeaderText = "Object_name";
            this.objectnameDataGridViewTextBoxColumn.Name = "objectnameDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lab3.Product);
            // 
            // errorProviderObjectName
            // 
            this.errorProviderObjectName.ContainerControl = this;
            // 
            // errorProviderNum
            // 
            this.errorProviderNum.ContainerControl = this;
            // 
            // errorProviderInventorynum
            // 
            this.errorProviderInventorynum.ContainerControl = this;
            // 
            // errorProviderCount
            // 
            this.errorProviderCount.ContainerControl = this;
            // 
            // errorProviderPrice
            // 
            this.errorProviderPrice.ContainerControl = this;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(612, 211);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Available";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // AvaialableList
            // 
            this.AvaialableList.FormattingEnabled = true;
            this.AvaialableList.Items.AddRange(new object[] {
            "Number",
            "Inventory number",
            "Object name",
            "Count",
            "Price"});
            this.AvaialableList.Location = new System.Drawing.Point(612, 239);
            this.AvaialableList.Name = "AvaialableList";
            this.AvaialableList.Size = new System.Drawing.Size(155, 94);
            this.AvaialableList.TabIndex = 18;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Simple Product";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(103, 17);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Variable Product";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(123, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 74);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Type";
            // 
            // lbluName
            // 
            this.lbluName.AutoSize = true;
            this.lbluName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluName.ForeColor = System.Drawing.Color.Lime;
            this.lbluName.Location = new System.Drawing.Point(32, 32);
            this.lbluName.Name = "lbluName";
            this.lbluName.Size = new System.Drawing.Size(0, 19);
            this.lbluName.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(830, 512);
            this.Controls.Add(this.lbluName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AvaialableList);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.display_Product);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Inventorynum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.label1);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.display_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderObjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInventorynum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPrice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Num;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Inventorynum;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Count;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.DataGridView display_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventorynumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ErrorProvider errorProviderObjectName;
        private System.Windows.Forms.ErrorProvider errorProviderNum;
        private System.Windows.Forms.ErrorProvider errorProviderInventorynum;
        private System.Windows.Forms.ErrorProvider errorProviderCount;
        private System.Windows.Forms.ErrorProvider errorProviderPrice;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox AvaialableList;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbluName;
    }
}

