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
            this.advancedPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fewerFirst = new System.Windows.Forms.RadioButton();
            this.moreFirst = new System.Windows.Forms.RadioButton();
            this.search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.shapkin_practice_shoesDataSet = new shoes.Shapkin_practice_shoesDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new shoes.Shapkin_practice_shoesDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new shoes.Shapkin_practice_shoesDataSetTableAdapters.TableAdapterManager();
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.advancedPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_practice_shoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
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
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.advancedPanel);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 356);
            this.splitContainer2.TabIndex = 0;
            // 
            // advancedPanel
            // 
            this.advancedPanel.AutoScroll = true;
            this.advancedPanel.Controls.Add(this.supplierLabel);
            this.advancedPanel.Controls.Add(this.searchLabel);
            this.advancedPanel.Controls.Add(this.supplierIdComboBox);
            this.advancedPanel.Controls.Add(this.search);
            this.advancedPanel.Controls.Add(this.groupBox1);
            this.advancedPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.advancedPanel.Location = new System.Drawing.Point(0, 0);
            this.advancedPanel.Name = "advancedPanel";
            this.advancedPanel.Size = new System.Drawing.Size(541, 50);
            this.advancedPanel.TabIndex = 0;
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
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(404, 21);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Заказы";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Добавить товар";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // shapkin_practice_shoesDataSet
            // 
            this.shapkin_practice_shoesDataSet.DataSetName = "Shapkin_practice_shoesDataSet";
            this.shapkin_practice_shoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "SupplierId", true));
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(230, 20);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(121, 22);
            this.supplierIdComboBox.TabIndex = 3;
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
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(169, 24);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(60, 14);
            this.supplierLabel.TabIndex = 5;
            this.supplierLabel.Text = "Поставщик";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "ProductForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.Shown += new System.EventHandler(this.ProductForm_Shown);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.advancedPanel.ResumeLayout(false);
            this.advancedPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_practice_shoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel advancedPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton moreFirst;
        private System.Windows.Forms.RadioButton fewerFirst;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Shapkin_practice_shoesDataSet shapkin_practice_shoesDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Shapkin_practice_shoesDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private Shapkin_practice_shoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label supplierLabel;
    }
}
