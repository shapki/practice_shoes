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
            this.clientIdComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.officeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officeTableAdapter = new shoes.Shapkin_practice_shoesDataSetTableAdapters.OfficeTableAdapter();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new shoes.Shapkin_practice_shoesDataSetTableAdapters.UserTableAdapter();
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
            idOrderLabel.Location = new System.Drawing.Point(269, 78);
            idOrderLabel.Name = "idOrderLabel";
            idOrderLabel.Size = new System.Drawing.Size(48, 14);
            idOrderLabel.TabIndex = 0;
            idOrderLabel.Text = "Id Order:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(269, 108);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(32, 14);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Date:";
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(269, 134);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(75, 14);
            deliveryDateLabel.TabIndex = 4;
            deliveryDateLabel.Text = "Delivery Date:";
            // 
            // officeIdLabel
            // 
            officeIdLabel.AutoSize = true;
            officeIdLabel.Location = new System.Drawing.Point(269, 159);
            officeIdLabel.Name = "officeIdLabel";
            officeIdLabel.Size = new System.Drawing.Size(51, 14);
            officeIdLabel.TabIndex = 6;
            officeIdLabel.Text = "Office Id:";
            // 
            // clientIdLabel
            // 
            clientIdLabel.AutoSize = true;
            clientIdLabel.Location = new System.Drawing.Point(269, 187);
            clientIdLabel.Name = "clientIdLabel";
            clientIdLabel.Size = new System.Drawing.Size(50, 14);
            clientIdLabel.TabIndex = 8;
            clientIdLabel.Text = "Client Id:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(269, 215);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(37, 14);
            statusLabel.TabIndex = 10;
            statusLabel.Text = "Status:";
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
            this.idOrderLabel1.Location = new System.Drawing.Point(350, 78);
            this.idOrderLabel1.Name = "idOrderLabel1";
            this.idOrderLabel1.Size = new System.Drawing.Size(200, 23);
            this.idOrderLabel1.TabIndex = 1;
            this.idOrderLabel1.Text = "--";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "Date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(350, 104);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateDateTimePicker.TabIndex = 3;
            // 
            // deliveryDateDateTimePicker
            // 
            this.deliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "DeliveryDate", true));
            this.deliveryDateDateTimePicker.Location = new System.Drawing.Point(350, 130);
            this.deliveryDateDateTimePicker.Name = "deliveryDateDateTimePicker";
            this.deliveryDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.deliveryDateDateTimePicker.TabIndex = 5;
            // 
            // officeIdComboBox
            // 
            this.officeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OfficeId", true));
            this.officeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "OfficeId", true));
            this.officeIdComboBox.DataSource = this.officeBindingSource;
            this.officeIdComboBox.DisplayMember = "Address";
            this.officeIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.officeIdComboBox.FormattingEnabled = true;
            this.officeIdComboBox.Location = new System.Drawing.Point(350, 156);
            this.officeIdComboBox.Name = "officeIdComboBox";
            this.officeIdComboBox.Size = new System.Drawing.Size(200, 22);
            this.officeIdComboBox.TabIndex = 7;
            this.officeIdComboBox.ValueMember = "IdOffice";
            // 
            // clientIdComboBox
            // 
            this.clientIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ClientId", true));
            this.clientIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.orderBindingSource, "ClientId", true));
            this.clientIdComboBox.DataSource = this.userBindingSource;
            this.clientIdComboBox.DisplayMember = "FullName";
            this.clientIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientIdComboBox.FormattingEnabled = true;
            this.clientIdComboBox.Location = new System.Drawing.Point(350, 184);
            this.clientIdComboBox.Name = "clientIdComboBox";
            this.clientIdComboBox.Size = new System.Drawing.Size(200, 22);
            this.clientIdComboBox.TabIndex = 9;
            this.clientIdComboBox.ValueMember = "IdUser";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Status", true));
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Новый",
            "Завершен"});
            this.statusComboBox.Location = new System.Drawing.Point(350, 212);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(200, 22);
            this.statusComboBox.TabIndex = 11;
            // 
            // officeBindingSource
            // 
            this.officeBindingSource.DataMember = "Office";
            this.officeBindingSource.DataSource = this.shapkin_practice_shoesDataSet;
            // 
            // officeTableAdapter
            // 
            this.officeTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.shapkin_practice_shoesDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // CreateUpdateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "CreateUpdateOrderForm";
            this.Load += new System.EventHandler(this.CreateUpdateOrderForm_Load);
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
    }
}
