namespace Prakticum
{
    partial class Task1Form
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
            this.textBoxInputNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInputNumber
            // 
            this.textBoxInputNumber.Location = new System.Drawing.Point(20, 114);
            this.textBoxInputNumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInputNumber.MaxLength = 11;
            this.textBoxInputNumber.Name = "textBoxInputNumber";
            this.textBoxInputNumber.Size = new System.Drawing.Size(395, 22);
            this.textBoxInputNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "результат";
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(20, 203);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(397, 75);
            this.buttonResult.TabIndex = 6;
            this.buttonResult.Text = "Вывести результат";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(20, 173);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(396, 22);
            this.textBoxResult.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(395, 75);
            this.button1.TabIndex = 8;
            this.button1.Text = "Читать из файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Task1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 291);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInputNumber);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Task1Form";
            this.Text = "Задание №1.2";
            this.Load += new System.EventHandler(this.Task1Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInputNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button button1;
    }
}

