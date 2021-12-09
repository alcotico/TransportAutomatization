
namespace TransportAutomatization
{
    partial class MainForm
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
            this.TestConnBtn = new System.Windows.Forms.Button();
            this.TestConnMess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TestConnBtn
            // 
            this.TestConnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TestConnBtn.Location = new System.Drawing.Point(3, 527);
            this.TestConnBtn.Name = "TestConnBtn";
            this.TestConnBtn.Size = new System.Drawing.Size(152, 23);
            this.TestConnBtn.TabIndex = 0;
            this.TestConnBtn.Text = "Проверить соединение";
            this.TestConnBtn.UseVisualStyleBackColor = true;
            this.TestConnBtn.Click += new System.EventHandler(this.TestConnBtn_Click);
            // 
            // TestConnMess
            // 
            this.TestConnMess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TestConnMess.Location = new System.Drawing.Point(161, 527);
            this.TestConnMess.Name = "TestConnMess";
            this.TestConnMess.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TestConnMess.Size = new System.Drawing.Size(811, 23);
            this.TestConnMess.TabIndex = 1;
            this.TestConnMess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 555);
            this.Controls.Add(this.TestConnMess);
            this.Controls.Add(this.TestConnBtn);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestConnBtn;
        private System.Windows.Forms.Label TestConnMess;
    }
}

