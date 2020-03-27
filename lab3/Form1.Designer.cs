namespace lab3
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
            this.btnFill = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtQueue = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(10, 12);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(290, 32);
            this.btnFill.TabIndex = 0;
            this.btnFill.Text = "Перезаполнить";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.BtnFill_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(10, 50);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(290, 42);
            this.txtInfo.TabIndex = 1;
            this.txtInfo.Text = "";
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(10, 98);
            this.txtOut.Name = "txtOut";
            this.txtOut.ReadOnly = true;
            this.txtOut.Size = new System.Drawing.Size(196, 97);
            this.txtOut.TabIndex = 2;
            this.txtOut.Text = "";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(10, 201);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(196, 70);
            this.btnGet.TabIndex = 3;
            this.btnGet.Text = "Взять";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.BtnGet_Click);
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(212, 98);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.ReadOnly = true;
            this.txtQueue.Size = new System.Drawing.Size(88, 173);
            this.txtQueue.TabIndex = 4;
            this.txtQueue.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 285);
            this.Controls.Add(this.txtQueue);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnFill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.RichTextBox txtInfo;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox txtQueue;
    }
}

