namespace Autocad
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
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnCaption = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRadius.Location = new System.Drawing.Point(85, 50);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(110, 26);
            this.txtRadius.TabIndex = 0;
            // 
            // btnLine
            // 
            this.btnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLine.Location = new System.Drawing.Point(238, 152);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(206, 34);
            this.btnLine.TabIndex = 1;
            this.btnLine.Text = "Створити лінію";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnCaption
            // 
            this.btnCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCaption.Location = new System.Drawing.Point(238, 101);
            this.btnCaption.Name = "btnCaption";
            this.btnCaption.Size = new System.Drawing.Size(206, 34);
            this.btnCaption.TabIndex = 2;
            this.btnCaption.Text = "Добавити надпис";
            this.btnCaption.UseVisualStyleBackColor = true;
            this.btnCaption.Click += new System.EventHandler(this.btnCaption_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCircle.Location = new System.Drawing.Point(238, 50);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(206, 35);
            this.btnCircle.TabIndex = 3;
            this.btnCircle.Text = "Створити коло";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.btnCaption);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.txtRadius);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autocad Profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnCaption;
        private System.Windows.Forms.Button btnCircle;
    }
}

