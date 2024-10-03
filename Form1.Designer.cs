namespace LastAccessLogger
{
    partial class Form1
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
            this.btnShowLastAccess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowLastAccess
            // 
            this.btnShowLastAccess.Location = new System.Drawing.Point(278, 170);
            this.btnShowLastAccess.Name = "btnShowLastAccess";
            this.btnShowLastAccess.Size = new System.Drawing.Size(218, 93);
            this.btnShowLastAccess.TabIndex = 0;
            this.btnShowLastAccess.Text = "ShowLastAccess";
            this.btnShowLastAccess.UseVisualStyleBackColor = true;
            this.btnShowLastAccess.Click += new System.EventHandler(this.btnShowLastAccess_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowLastAccess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowLastAccess;
    }
}

