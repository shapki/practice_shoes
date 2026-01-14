namespace shoes.AppForms
{
    partial class ProductForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.addProductButton = new System.Windows.Forms.Button();
            this.advancedPanel = new System.Windows.Forms.Panel();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shapkin_practice_shoesDataSet = new shoes.Shapkin_practice_shoesDataSet();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moreFirst = new System.Windows.Forms.RadioButton();
            this.fewerFirst = new System.Windows.Forms.RadioButton();
            this.ordersButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new shoes.Shapkin_practice_shoesDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new shoes.Shapkin_practice_shoesDataSetTableAdapters.TableAdapterManager();
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new shoes.Shapkin_practice_shoesDataSetTableAdapters.SupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.advancedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_practice_shoesDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.addProductButton);
            this.splitContainer2.Panel1.Controls.Add(this.advancedPanel);
            this.splitContainer2.Panel1.Controls.Add(this.ordersButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 356);
            this.splitContainer2.TabIndex = 0;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(618, 21);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(98, 23);
            this.addProductButton.TabIndex = 3;
            this.addProductButton.Text = "Добавить товар";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // advancedPanel
            // 
            this.advancedPanel.AutoScroll = true;
            this.advancedPanel.Controls.Add(this.supplierComboBox);
            this.advancedPanel.Controls.Add(this.supplierLabel);
            this.advancedPanel.Controls.Add(this.searchLabel);
            this.advancedPanel.Controls.Add(this.search);
            this.advancedPanel.Controls.Add(this.groupBox1);
            this.advancedPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.advancedPanel.Location = new System.Drawing.Point(0, 0);
            this.advancedPanel.Name = "advancedPanel";
            this.advancedPanel.Size = new System.Drawing.Size(541, 50);
            this.advancedPanel.TabIndex = 0;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DataSource = this.supplierBindingSource;
            this.supplierComboBox.DisplayMember = "SupplierName";
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(235, 19);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(117, 22);
            this.supplierComboBox.TabIndex = 0;
            this.supplierComboBox.ValueMember = "IdSupplier";
            this.supplierComboBox.SelectedIndexChanged += new System.EventHandler(this.supplierComboBox_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.shapkin_practice_shoesDataSet;
            // 
            // shapkin_practice_shoesDataSet
            // 
            this.shapkin_practice_shoesDataSet.DataSetName = "Shapkin_practice_shoesDataSet";
            this.shapkin_practice_shoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(169, 24);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(60, 14);
            this.supplierLabel.TabIndex = 5;
            this.supplierLabel.Text = "Поставщик";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(358, 24);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(40, 14);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Поиск:";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(404, 21);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 1;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.moreFirst);
            this.groupBox1.Controls.Add(this.fewerFirst);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Количество на складе";
            // 
            // moreFirst
            // 
            this.moreFirst.AutoSize = true;
            this.moreFirst.Location = new System.Drawing.Point(73, 20);
            this.moreFirst.Name = "moreFirst";
            this.moreFirst.Size = new System.Drawing.Size(61, 18);
            this.moreFirst.TabIndex = 1;
            this.moreFirst.TabStop = true;
            this.moreFirst.Text = "Больше";
            this.moreFirst.UseVisualStyleBackColor = true;
            this.moreFirst.CheckedChanged += new System.EventHandler(this.moreFirst_CheckedChanged);
            // 
            // fewerFirst
            // 
            this.fewerFirst.AutoSize = true;
            this.fewerFirst.Location = new System.Drawing.Point(3, 19);
            this.fewerFirst.Name = "fewerFirst";
            this.fewerFirst.Size = new System.Drawing.Size(64, 18);
            this.fewerFirst.TabIndex = 0;
            this.fewerFirst.TabStop = true;
            this.fewerFirst.Text = "Меньше";
            this.fewerFirst.UseVisualStyleBackColor = true;
            this.fewerFirst.CheckedChanged += new System.EventHandler(this.fewerFirst_CheckedChanged);
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(722, 20);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(75, 23);
            this.ordersButton.TabIndex = 2;
            this.ordersButton.Text = "Заказы";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 302);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.shapkin_practice_shoesDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OfficeTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shoes.Shapkin_practice_shoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataMember = "Supplier";
            this.supplierBindingSource1.DataSource = this.shapkin_practice_shoesDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ProductForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.Shown += new System.EventHandler(this.ProductForm_Shown);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.advancedPanel.ResumeLayout(false);
            this.advancedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_practice_shoesDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel advancedPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton moreFirst;
        private System.Windows.Forms.RadioButton fewerFirst;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button ordersButton;
        private Shapkin_practice_shoesDataSet shapkin_practice_shoesDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Shapkin_practice_shoesDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Shapkin_practice_shoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private Shapkin_practice_shoesDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
    }
}
