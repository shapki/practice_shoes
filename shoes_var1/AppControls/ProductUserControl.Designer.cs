namespace shoes.AppControls
{
    partial class ProductUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.categoryLaabel = new System.Windows.Forms.Label();
            this.categoryProductName = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.supplier = new System.Windows.Forms.Label();
            this.manufacturer = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.unitOfMeasurement = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.photo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.oldPrice = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.oldPrice);
            this.mainPanel.Controls.Add(this.deleteButton);
            this.mainPanel.Controls.Add(this.stock);
            this.mainPanel.Controls.Add(this.unitOfMeasurement);
            this.mainPanel.Controls.Add(this.price);
            this.mainPanel.Controls.Add(this.manufacturer);
            this.mainPanel.Controls.Add(this.supplier);
            this.mainPanel.Controls.Add(this.description);
            this.mainPanel.Controls.Add(this.categoryProductName);
            this.mainPanel.Controls.Add(this.categoryLaabel);
            this.mainPanel.Location = new System.Drawing.Point(140, 20);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(444, 100);
            this.mainPanel.TabIndex = 1;
            // 
            // categoryLaabel
            // 
            this.categoryLaabel.AutoSize = true;
            this.categoryLaabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.categoryLaabel.Location = new System.Drawing.Point(3, 0);
            this.categoryLaabel.Name = "categoryLaabel";
            this.categoryLaabel.Size = new System.Drawing.Size(101, 13);
            this.categoryLaabel.TabIndex = 0;
            this.categoryLaabel.Text = "Категория товара";
            // 
            // categoryProductName
            // 
            this.categoryProductName.AutoSize = true;
            this.categoryProductName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold);
            this.categoryProductName.Location = new System.Drawing.Point(110, 0);
            this.categoryProductName.Name = "categoryProductName";
            this.categoryProductName.Size = new System.Drawing.Size(123, 13);
            this.categoryProductName.TabIndex = 1;
            this.categoryProductName.Text = "Наименование товара";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.description.Location = new System.Drawing.Point(3, 13);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(54, 14);
            this.description.TabIndex = 2;
            this.description.Text = "Описание";
            // 
            // supplier
            // 
            this.supplier.AutoSize = true;
            this.supplier.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.supplier.Location = new System.Drawing.Point(3, 27);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(79, 14);
            this.supplier.TabIndex = 3;
            this.supplier.Text = "Производитель";
            // 
            // manufacturer
            // 
            this.manufacturer.AutoSize = true;
            this.manufacturer.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.manufacturer.Location = new System.Drawing.Point(3, 41);
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Size = new System.Drawing.Size(60, 14);
            this.manufacturer.TabIndex = 4;
            this.manufacturer.Text = "Поставщик";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.price.Location = new System.Drawing.Point(3, 55);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(31, 14);
            this.price.TabIndex = 5;
            this.price.Text = "Цена";
            // 
            // unitOfMeasurement
            // 
            this.unitOfMeasurement.AccessibleName = "unitOfMeasurement";
            this.unitOfMeasurement.AutoSize = true;
            this.unitOfMeasurement.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.unitOfMeasurement.Location = new System.Drawing.Point(3, 69);
            this.unitOfMeasurement.Name = "unitOfMeasurement";
            this.unitOfMeasurement.Size = new System.Drawing.Size(101, 14);
            this.unitOfMeasurement.TabIndex = 6;
            this.unitOfMeasurement.Text = "Единица измерения";
            // 
            // stock
            // 
            this.stock.AutoSize = true;
            this.stock.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.stock.Location = new System.Drawing.Point(3, 83);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(109, 14);
            this.stock.TabIndex = 7;
            this.stock.Text = "Количество на складе";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.deleteButton.Location = new System.Drawing.Point(364, 72);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // photo
            // 
            this.photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photo.Location = new System.Drawing.Point(20, 20);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(100, 100);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 0;
            this.photo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.discount);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(604, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 100);
            this.panel1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(-4, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 40);
            this.label7.TabIndex = 0;
            this.label7.Text = "Действующая скидка";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // discount
            // 
            this.discount.Location = new System.Drawing.Point(-4, 55);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(100, 28);
            this.discount.TabIndex = 2;
            this.discount.Text = "Скидка";
            this.discount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(606, 124);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(15, 14);
            this.id.TabIndex = 3;
            this.id.Text = "id";
            // 
            // oldPrice
            // 
            this.oldPrice.AutoSize = true;
            this.oldPrice.BackColor = System.Drawing.Color.White;
            this.oldPrice.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPrice.ForeColor = System.Drawing.Color.Red;
            this.oldPrice.Location = new System.Drawing.Point(90, 55);
            this.oldPrice.Name = "oldPrice";
            this.oldPrice.Size = new System.Drawing.Size(65, 14);
            this.oldPrice.TabIndex = 9;
            this.oldPrice.Text = "Старая цена";
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.id);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.photo);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(30, 0, 29, 31);
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(724, 138);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label categoryLaabel;
        private System.Windows.Forms.Label categoryProductName;
        private System.Windows.Forms.Label stock;
        private System.Windows.Forms.Label unitOfMeasurement;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label manufacturer;
        private System.Windows.Forms.Label supplier;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label oldPrice;
    }
}
