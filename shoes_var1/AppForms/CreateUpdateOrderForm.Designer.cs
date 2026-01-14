namespace shoes.AppForms
{
    partial class CreateUpdateOrderForm
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
            System.Windows.Forms.Label idOrderLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label officeIdLabel;
            System.Windows.Forms.Label clientIdLabel;
            System.Windows.Forms.Label statusLabel;
            this.shapkin_practice_shoesDataSet = new shoes.Shapkin_practice_shoesDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new shoes.Shapkin_practice_shoesDataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new shoes.Shapkin_practice_shoesDataSetTableAdapters.TableAdapterManager();
            this.idOrderLabel1 = new System.Windows.Forms.Label();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.officeIdComboBox = new System.Windows.Forms.ComboBox();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientIdComboBox = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.officeTableAdapter = new shoes.Shapkin_practice_shoesDataSetTableAdapters.OfficeTableAdapter();
            this.userTableAdapter = new shoes.Shapkin_practice_shoesDataSetTableAdapters.UserTableAdapter();
            this.saveButton = new System.Windows.Forms.Button();
            idOrderLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            officeIdLabel = new System.Windows.Forms.Label();
            clientIdLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_practice_shoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Panel2.Controls.Add(idOrderLabel);
            this.splitContainer1.Panel2.Controls.Add(this.idOrderLabel1);
            this.splitContainer1.Panel2.Controls.Add(dateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.dateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(deliveryDateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.deliveryDateDateTimePicker);
            this.splitContainer1.Panel2.Controls.Add(officeIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.officeIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(clientIdLabel);
            this.splitContainer1.Panel2.Controls.Add(this.clientIdComboBox);
            this.splitContainer1.Panel2.Controls.Add(statusLabel);
            this.splitContainer1.Panel2.Controls.Add(this.statusComboBox);
            // 
            // idOrderLabel
            // 
            idOrderLabel.AutoSize = true;
            idOrderLabel.Location = new System.Drawing.Point(237, 39);
            idOrderLabel.Name = "idOrderLabel";
            idOrderLabel.Size = new System.Drawing.Size(16, 14);
            idOrderLabel.TabIndex = 0;
            idOrderLabel.Text = "Id";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(237, 69);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(61, 14);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Дата заказа";
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(237, 95);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(67, 14);
            deliveryDateLabel.TabIndex = 4;
            deliveryDateLabel.Text = "Дата выдачи";
            // 
            // officeIdLabel
            // 
            officeIdLabel.AutoSize = true;
            officeIdLabel.Location = new System.Drawing.Point(237, 120);
            officeIdLabel.Name = "officeIdLabel";
            officeIdLabel.Size = new System.Drawing.Size(109, 14);
            officeIdLabel.TabIndex = 6;
            officeIdLabel.Text = "Адрес пункта выдачи";
            // 
            // clientIdLabel
            // 
            clientIdLabel.AutoSize = true;
            clientIdLabel.Location = new System.Drawing.Point(237, 148);
            clientIdLabel.Name = "clientIdLabel";
            clientIdLabel.Size = new System.Drawing.Size(41, 14);
            clientIdLabel.TabIndex = 8;
            clientIdLabel.Text = "Клиент";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(237, 176);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 14);
            statusLabel.TabIndex = 10;
            statusLabel.Text = "Статус";
            // 
            // shapkin_practice_shoesDataSet
            // 
            this.shapkin_practice_shoesDataSet.DataSetName = "Shapkin_practice_shoesDataSet";
            this.shapkin_practice_shoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.shapkin_practice_shoesDataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OfficeTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = shoes.Shapkin_practice_shoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // idOrderLabel1
            // 
            this.idOrderLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "IdOrder", true));
            this.idOrderLabel1.Location = new System.Drawing.Point(352, 39);
            this.idOrderLabel1.Name = "idOrderLabel1";
            this.idOrderLabel1.Size = new System.Drawing.Size(244, 23);
            this.idOrderLabel1.TabIndex = 1;
            this.idOrderLabel1.Text = "--";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(352, 65);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(244, 20);
            this.dateDateTimePicker.TabIndex = 3;
            // 
            // deliveryDateDateTimePicker
            // 
            this.deliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "DeliveryDate", true));
            this.deliveryDateDateTimePicker.Location = new System.Drawing.Point(352, 91);
            this.deliveryDateDateTimePicker.Name = "deliveryDateDateTimePicker";
            this.deliveryDateDateTimePicker.Size = new System.Drawing.Size(244, 20);
            this.deliveryDateDateTimePicker.TabIndex = 5;
            this.deliveryDateDateTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.deliveryDateDateTimePicker_Validating);
            // 
            // officeIdComboBox
            // 
            this.officeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OfficeId", true));
            this.officeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "OfficeId", true));
            this.officeIdComboBox.DataSource = this.officeBindingSource;
            this.officeIdComboBox.DisplayMember = "Address";
            this.officeIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeIdComboBox.FormattingEnabled = true;
            this.officeIdComboBox.Location = new System.Drawing.Point(352, 117);
            this.officeIdComboBox.Name = "officeIdComboBox";
            this.officeIdComboBox.Size = new System.Drawing.Size(244, 22);
            this.officeIdComboBox.TabIndex = 7;
            this.officeIdComboBox.ValueMember = "IdOffice";
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataMember = "Office";
            this.officeBindingSource.DataSource = this.shapkin_practice_shoesDataSet;
            // 
            // clientIdComboBox
            // 
            this.clientIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ClientId", true));
            this.clientIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "ClientId", true));
            this.clientIdComboBox.DataSource = this.userBindingSource;
            this.clientIdComboBox.DisplayMember = "FullName";
            this.clientIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientIdComboBox.FormattingEnabled = true;
            this.clientIdComboBox.Location = new System.Drawing.Point(352, 145);
            this.clientIdComboBox.Name = "clientIdComboBox";
            this.clientIdComboBox.Size = new System.Drawing.Size(244, 22);
            this.clientIdComboBox.TabIndex = 9;
            this.clientIdComboBox.ValueMember = "IdUser";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.shapkin_practice_shoesDataSet;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Status", true));
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Новый",
            "Завершен"});
            this.statusComboBox.Location = new System.Drawing.Point(352, 173);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(244, 22);
            this.statusComboBox.TabIndex = 11;
            // 
            // officeTableAdapter
            // 
            this.officeTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.saveButton.Location = new System.Drawing.Point(240, 201);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(356, 23);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CreateUpdateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CreateUpdateOrderForm";
            this.Load += new System.EventHandler(this.CreateUpdateOrderForm_Load);
            this.Shown += new System.EventHandler(this.CreateUpdateOrderForm_Shown);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shapkin_practice_shoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Shapkin_practice_shoesDataSet shapkin_practice_shoesDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private Shapkin_practice_shoesDataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private Shapkin_practice_shoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label idOrderLabel1;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker deliveryDateDateTimePicker;
        private System.Windows.Forms.ComboBox officeIdComboBox;
        private System.Windows.Forms.ComboBox clientIdComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.BindingSource officeBindingSource;
        private Shapkin_practice_shoesDataSetTableAdapters.OfficeTableAdapter officeTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Shapkin_practice_shoesDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Button saveButton;
    }
}
