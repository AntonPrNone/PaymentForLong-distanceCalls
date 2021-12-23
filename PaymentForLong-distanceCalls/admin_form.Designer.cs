namespace PaymentForLong_distanceCalls
{
    partial class admin_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_form));
            this.service_button = new System.Windows.Forms.Button();
            this.client_button = new System.Windows.Forms.Button();
            this.receipt_button = new System.Windows.Forms.Button();
            this.localityOfTheInterlocutor_button = new System.Windows.Forms.Button();
            this.clientsСity_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // service_button
            // 
            this.service_button.BackColor = System.Drawing.Color.Black;
            this.service_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.service_button.ForeColor = System.Drawing.Color.White;
            this.service_button.Location = new System.Drawing.Point(50, 42);
            this.service_button.Name = "service_button";
            this.service_button.Size = new System.Drawing.Size(217, 42);
            this.service_button.TabIndex = 0;
            this.service_button.Text = "Услуга";
            this.service_button.UseVisualStyleBackColor = false;
            this.service_button.Click += new System.EventHandler(this.service_button_Click);
            // 
            // client_button
            // 
            this.client_button.BackColor = System.Drawing.Color.Black;
            this.client_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client_button.ForeColor = System.Drawing.Color.White;
            this.client_button.Location = new System.Drawing.Point(285, 184);
            this.client_button.Name = "client_button";
            this.client_button.Size = new System.Drawing.Size(217, 42);
            this.client_button.TabIndex = 1;
            this.client_button.Text = "Клиент";
            this.client_button.UseVisualStyleBackColor = false;
            this.client_button.Click += new System.EventHandler(this.client_button_Click);
            // 
            // receipt_button
            // 
            this.receipt_button.BackColor = System.Drawing.Color.Black;
            this.receipt_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.receipt_button.ForeColor = System.Drawing.Color.White;
            this.receipt_button.Location = new System.Drawing.Point(530, 42);
            this.receipt_button.Name = "receipt_button";
            this.receipt_button.Size = new System.Drawing.Size(217, 42);
            this.receipt_button.TabIndex = 1;
            this.receipt_button.Text = "Квитанция";
            this.receipt_button.UseVisualStyleBackColor = false;
            this.receipt_button.Click += new System.EventHandler(this.receipt_button_Click);
            // 
            // localityOfTheInterlocutor_button
            // 
            this.localityOfTheInterlocutor_button.BackColor = System.Drawing.Color.Black;
            this.localityOfTheInterlocutor_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.localityOfTheInterlocutor_button.ForeColor = System.Drawing.Color.White;
            this.localityOfTheInterlocutor_button.Location = new System.Drawing.Point(530, 335);
            this.localityOfTheInterlocutor_button.Name = "localityOfTheInterlocutor_button";
            this.localityOfTheInterlocutor_button.Size = new System.Drawing.Size(217, 70);
            this.localityOfTheInterlocutor_button.TabIndex = 1;
            this.localityOfTheInterlocutor_button.Text = "Населённый пункт собеседника";
            this.localityOfTheInterlocutor_button.UseVisualStyleBackColor = false;
            this.localityOfTheInterlocutor_button.Click += new System.EventHandler(this.localityOfTheInterlocutor_button_Click);
            // 
            // clientsСity_button
            // 
            this.clientsСity_button.BackColor = System.Drawing.Color.Black;
            this.clientsСity_button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientsСity_button.ForeColor = System.Drawing.Color.White;
            this.clientsСity_button.Location = new System.Drawing.Point(50, 349);
            this.clientsСity_button.Name = "clientsСity_button";
            this.clientsСity_button.Size = new System.Drawing.Size(217, 42);
            this.clientsСity_button.TabIndex = 2;
            this.clientsСity_button.Text = "Город Клиента";
            this.clientsСity_button.UseVisualStyleBackColor = false;
            this.clientsСity_button.Click += new System.EventHandler(this.clientsСity_button_Click);
            // 
            // Initial_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clientsСity_button);
            this.Controls.Add(this.receipt_button);
            this.Controls.Add(this.localityOfTheInterlocutor_button);
            this.Controls.Add(this.client_button);
            this.Controls.Add(this.service_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Initial_form";
            this.Text = "Выбор таблицы";
            this.Load += new System.EventHandler(this.Initial_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button service_button;
        private System.Windows.Forms.Button client_button;
        private System.Windows.Forms.Button receipt_button;
        private System.Windows.Forms.Button localityOfTheInterlocutor_button;
        private System.Windows.Forms.Button clientsСity_button;
    }
}

