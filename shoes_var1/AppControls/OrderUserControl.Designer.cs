namespace shoes.AppControls
{
    partial class OrderUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.orderIdlabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.officeLabel = new System.Windows.Forms.Label();
            this.orderDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deliveryDateLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.deliveryDateLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(635, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(84, 84);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.order_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteButton);
            this.panel2.Controls.Add(this.orderDateLabel);
            this.panel2.Controls.Add(this.officeLabel);
            this.panel2.Controls.Add(this.statusLabel);
            this.panel2.Controls.Add(this.orderIdlabel);
            this.panel2.Location = new System.Drawing.Point(15, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 84);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.order_Click);
            // 
            // orderIdlabel
            // 
            this.orderIdlabel.AutoSize = true;
            this.orderIdlabel.Location = new System.Drawing.Point(16, 6);
            this.orderIdlabel.Name = "orderIdlabel";
            this.orderIdlabel.Size = new System.Drawing.Size(16, 13);
            this.orderIdlabel.TabIndex = 0;
            this.orderIdlabel.Text = "Id";
            this.orderIdlabel.Click += new System.EventHandler(this.order_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(16, 25);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(41, 13);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.Text = "Статус";
            this.statusLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // officeLabel
            // 
            this.officeLabel.AutoSize = true;
            this.officeLabel.Location = new System.Drawing.Point(16, 45);
            this.officeLabel.Name = "officeLabel";
            this.officeLabel.Size = new System.Drawing.Size(115, 13);
            this.officeLabel.TabIndex = 2;
            this.officeLabel.Text = "Адрес пункта выдачи";
            this.officeLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // orderDateLabel
            // 
            this.orderDateLabel.AutoSize = true;
            this.orderDateLabel.Location = new System.Drawing.Point(16, 64);
            this.orderDateLabel.Name = "orderDateLabel";
            this.orderDateLabel.Size = new System.Drawing.Size(72, 13);
            this.orderDateLabel.TabIndex = 3;
            this.orderDateLabel.Text = "Дата заказа";
            this.orderDateLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата заказа";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.order_Click);
            // 
            // deliveryDateLabel
            // 
            this.deliveryDateLabel.Location = new System.Drawing.Point(-1, 24);
            this.deliveryDateLabel.Name = "deliveryDateLabel";
            this.deliveryDateLabel.Size = new System.Drawing.Size(84, 23);
            this.deliveryDateLabel.TabIndex = 1;
            this.deliveryDateLabel.Text = "Дата";
            this.deliveryDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deliveryDateLabel.Click += new System.EventHandler(this.order_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.deleteButton.Location = new System.Drawing.Point(523, 58);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // OrderUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.Name = "OrderUserControl";
            this.Size = new System.Drawing.Size(740, 119);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label orderIdlabel;
        private System.Windows.Forms.Label officeLabel;
        private System.Windows.Forms.Label orderDateLabel;
        private System.Windows.Forms.Label deliveryDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
    }
}
