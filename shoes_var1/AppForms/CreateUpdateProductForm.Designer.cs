namespace shoes.AppForms
{
    partial class CreateUpdateProductForm
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
            System.Windows.Forms.Label skuLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label unitOfMeasurementLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label manufacturerIdLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label photoLabel;
            this.shapkin_practice_shoesDataSet = new shoes.Shapkin_practice_shoesDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new shoes.Shapkin_practice_shoesDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new shoes.Shapkin_practice_shoesDataSetTableAdapters.TableAdapterManager();
            this.saveProductButton = new System.Windows.Forms.Button();
            this.skuTextBox = new System.Windows.Forms.TextBox();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.unitOfMeasurementListBox = new System.Windows.Forms.ListBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.supplierIdComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerIdComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.discountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.supplierTableAdapter = new shoes.Shapkin_practice_shoesDataSetTableAdapters.SupplierTableAdapter();
            this.manufacturerTableAdapter = new shoes.Shapkin_practice_shoesDataSetTableAdapters.ManufacturerTableAdapter();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            skuLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            unitOfMeasurementLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            manufacturerIdLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_practice_shoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.openFileDialogButton);
            this.splitContainer1.Panel2.Controls.Add(skuLabel);
            this.splitContainer1.Panel2.Controls.Add(this.skuTextBox);
            this.splitContainer1.Panel2.Controls.Add(productNameLabel);
            this.splitContainer1.Panel2.Controls.Add(this.productNameComboBox);
            this.splitContainer1.Panel2.Controls.Add(unitOfMeasurementLabel);
            this.splitContainer1.Panel2.Controls.Add(this.unitOfMeasurementListBox);
            this.splitContainer1.Panel2.Controls.Add(priceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.priceTextBox);
            this.splitContainer1.Panel2.Controls.Add(supplierIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.supplierIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(manufacturerIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.manufacturerIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(categoryLabel);
            this.splitContainer1.Panel2.Controls.Add(this.categoryComboBox);
            this.splitContainer1.Panel2.Controls.Add(discountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.discountNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(stockLabel);
            this.splitContainer1.Panel2.Controls.Add(this.stockNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(photoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.photoTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.saveProductButton);
            this.splitContainer1.Size = new System.Drawing.Size(800, 485);
            this.splitContainer1.SplitterDistance = 97;
            // 
            // skuLabel
            // 
            skuLabel.AutoSize = true;
            skuLabel.Location = new System.Drawing.Point(237, 22);
            skuLabel.Name = "skuLabel";
            skuLabel.Size = new System.Drawing.Size(48, 14);
            skuLabel.TabIndex = 22;
            skuLabel.Text = "Артикул";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(237, 48);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(77, 14);
            productNameLabel.TabIndex = 24;
            productNameLabel.Text = "Наименование";
            // 
            // unitOfMeasurementLabel
            // 
            unitOfMeasurementLabel.AutoSize = true;
            unitOfMeasurementLabel.Location = new System.Drawing.Point(237, 73);
            unitOfMeasurementLabel.Name = "unitOfMeasurementLabel";
            unitOfMeasurementLabel.Size = new System.Drawing.Size(101, 14);
            unitOfMeasurementLabel.TabIndex = 26;
            unitOfMeasurementLabel.Text = "Единица измерения";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(237, 100);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(31, 14);
            priceLabel.TabIndex = 28;
            priceLabel.Text = "Цена";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(237, 126);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(60, 14);
            supplierIdLabel.TabIndex = 30;
            supplierIdLabel.Text = "Поставщик";
            // 
            // manufacturerIdLabel
            // 
            manufacturerIdLabel.AutoSize = true;
            manufacturerIdLabel.Location = new System.Drawing.Point(237, 154);
            manufacturerIdLabel.Name = "manufacturerIdLabel";
            manufacturerIdLabel.Size = new System.Drawing.Size(79, 14);
            manufacturerIdLabel.TabIndex = 32;
            manufacturerIdLabel.Text = "Производитель";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(237, 182);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(57, 14);
            categoryLabel.TabIndex = 34;
            categoryLabel.Text = "Категория";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(237, 210);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(40, 14);
            discountLabel.TabIndex = 36;
            discountLabel.Text = "Скидка";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(237, 235);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(86, 14);
            stockLabel.TabIndex = 38;
            stockLabel.Text = "Кол-во на складе";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(237, 264);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(89, 14);
            descriptionLabel.TabIndex = 40;
            descriptionLabel.Text = "Описание товара";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(237, 290);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(32, 14);
            photoLabel.TabIndex = 42;
            photoLabel.Text = "Фото";
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
            // saveProductButton
            // 
            this.saveProductButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.saveProductButton.Location = new System.Drawing.Point(234, 319);
            this.saveProductButton.Name = "saveProductButton";
            this.saveProductButton.Size = new System.Drawing.Size(356, 23);
            this.saveProductButton.TabIndex = 22;
            this.saveProductButton.Text = "Сохранить";
            this.saveProductButton.UseVisualStyleBackColor = false;
            this.saveProductButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // skuTextBox
            // 
            this.skuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Sku", true));
            this.skuTextBox.Location = new System.Drawing.Point(354, 19);
            this.skuTextBox.Name = "skuTextBox";
            this.skuTextBox.Size = new System.Drawing.Size(236, 20);
            this.skuTextBox.TabIndex = 23;
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Items.AddRange(new object[] {
            "Ботинки",
            "Кеды",
            "Кроссовки",
            "Полуботинки",
            "Сапоги",
            "Тапочки",
            "Туфли"});
            this.productNameComboBox.Location = new System.Drawing.Point(354, 45);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(236, 22);
            this.productNameComboBox.TabIndex = 25;
            // 
            // unitOfMeasurementListBox
            // 
            this.unitOfMeasurementListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "UnitOfMeasurement", true));
            this.unitOfMeasurementListBox.FormattingEnabled = true;
            this.unitOfMeasurementListBox.ItemHeight = 14;
            this.unitOfMeasurementListBox.Items.AddRange(new object[] {
            "шт."});
            this.unitOfMeasurementListBox.Location = new System.Drawing.Point(354, 73);
            this.unitOfMeasurementListBox.Name = "unitOfMeasurementListBox";
            this.unitOfMeasurementListBox.Size = new System.Drawing.Size(236, 18);
            this.unitOfMeasurementListBox.TabIndex = 27;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(354, 97);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(236, 20);
            this.priceTextBox.TabIndex = 29;
            // 
            // supplierIdComboBox
            // 
            this.supplierIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "SupplierId", true));
            this.supplierIdComboBox.DataSource = this.supplierBindingSource;
            this.supplierIdComboBox.DisplayMember = "SupplierName";
            this.supplierIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierIdComboBox.FormattingEnabled = true;
            this.supplierIdComboBox.Location = new System.Drawing.Point(354, 123);
            this.supplierIdComboBox.Name = "supplierIdComboBox";
            this.supplierIdComboBox.Size = new System.Drawing.Size(236, 22);
            this.supplierIdComboBox.TabIndex = 31;
            this.supplierIdComboBox.ValueMember = "IdSupplier";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.shapkin_practice_shoesDataSet;
            // 
            // manufacturerIdComboBox
            // 
            this.manufacturerIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ManufacturerId", true));
            this.manufacturerIdComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerIdComboBox.DisplayMember = "ManufacturerName";
            this.manufacturerIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerIdComboBox.FormattingEnabled = true;
            this.manufacturerIdComboBox.Location = new System.Drawing.Point(354, 151);
            this.manufacturerIdComboBox.Name = "manufacturerIdComboBox";
            this.manufacturerIdComboBox.Size = new System.Drawing.Size(236, 22);
            this.manufacturerIdComboBox.TabIndex = 33;
            this.manufacturerIdComboBox.ValueMember = "Idmanufacturer";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.shapkin_practice_shoesDataSet;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Category", true));
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Женская обувь",
            "Мужская обувь"});
            this.categoryComboBox.Location = new System.Drawing.Point(354, 179);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(236, 22);
            this.categoryComboBox.TabIndex = 35;
            // 
            // discountNumericUpDown
            // 
            this.discountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Discount", true));
            this.discountNumericUpDown.Location = new System.Drawing.Point(354, 207);
            this.discountNumericUpDown.Name = "discountNumericUpDown";
            this.discountNumericUpDown.Size = new System.Drawing.Size(236, 20);
            this.discountNumericUpDown.TabIndex = 37;
            // 
            // stockNumericUpDown
            // 
            this.stockNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Stock", true));
            this.stockNumericUpDown.Location = new System.Drawing.Point(354, 235);
            this.stockNumericUpDown.Name = "stockNumericUpDown";
            this.stockNumericUpDown.Size = new System.Drawing.Size(236, 20);
            this.stockNumericUpDown.TabIndex = 39;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(354, 261);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(236, 20);
            this.descriptionTextBox.TabIndex = 41;
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Photo", true));
            this.photoTextBox.Enabled = false;
            this.photoTextBox.Location = new System.Drawing.Point(354, 287);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(156, 20);
            this.photoTextBox.TabIndex = 43;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(516, 286);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(75, 23);
            this.openFileDialogButton.TabIndex = 44;
            this.openFileDialogButton.Text = "Файл";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // CreateUpdateProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Name = "CreateUpdateProductForm";
            this.Text = "CreateUpdateProductForm";
            this.Load += new System.EventHandler(this.CreateUpdateProductForm_Load_1);
            this.Shown += new System.EventHandler(this.CreateUpdateProductForm_Shown);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_practice_shoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Shapkin_practice_shoesDataSet shapkin_practice_shoesDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Shapkin_practice_shoesDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private Shapkin_practice_shoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button saveProductButton;
        private System.Windows.Forms.TextBox skuTextBox;
        private System.Windows.Forms.ComboBox productNameComboBox;
        private System.Windows.Forms.ListBox unitOfMeasurementListBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox supplierIdComboBox;
        private System.Windows.Forms.ComboBox manufacturerIdComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown;
        private System.Windows.Forms.NumericUpDown stockNumericUpDown;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private Shapkin_practice_shoesDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private Shapkin_practice_shoesDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.Button openFileDialogButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}