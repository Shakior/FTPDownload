namespace WindowsFormsApplication1
{
    partial class FtpDownloadForm
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
            this.buttonDownload = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarDownload = new System.Windows.Forms.ProgressBar();
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLoaded = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(12, 77);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(247, 32);
            this.buttonDownload.TabIndex = 0;
            this.buttonDownload.Text = "Загрузить";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(15, 35);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(244, 20);
            this.textBoxAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите адрес ftp";
            // 
            // progressBarDownload
            // 
            this.progressBarDownload.Location = new System.Drawing.Point(12, 126);
            this.progressBarDownload.Name = "progressBarDownload";
            this.progressBarDownload.Size = new System.Drawing.Size(247, 23);
            this.progressBarDownload.TabIndex = 3;
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Enabled = false;
            this.textBoxSpeed.Location = new System.Drawing.Point(159, 163);
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(100, 20);
            this.textBoxSpeed.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Скорость передачи Kb/s";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Осталось секунд";
            // 
            // textBoxRest
            // 
            this.textBoxRest.Enabled = false;
            this.textBoxRest.Location = new System.Drawing.Point(159, 194);
            this.textBoxRest.Name = "textBoxRest";
            this.textBoxRest.Size = new System.Drawing.Size(100, 20);
            this.textBoxRest.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Загружено байт";
            // 
            // textBoxLoaded
            // 
            this.textBoxLoaded.Enabled = false;
            this.textBoxLoaded.Location = new System.Drawing.Point(159, 224);
            this.textBoxLoaded.Name = "textBoxLoaded";
            this.textBoxLoaded.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoaded.TabIndex = 9;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 253);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(247, 33);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 299);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxLoaded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxRest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSpeed);
            this.Controls.Add(this.progressBarDownload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.buttonDownload);
            this.Name = "Form1";
            this.Text = "Скачать ftp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarDownload;
        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLoaded;
        private System.Windows.Forms.Button buttonCancel;
    }
}

