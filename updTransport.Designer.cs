
namespace TransportAutomatization
{
    partial class updTransport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vinBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updBtn = new System.Windows.Forms.Button();
            this.updTransportBox = new System.Windows.Forms.ComboBox();
            this.runBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(51, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(157, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "VIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vinBox
            // 
            this.vinBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vinBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vinBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vinBox.Location = new System.Drawing.Point(205, 74);
            this.vinBox.Name = "vinBox";
            this.vinBox.ReadOnly = true;
            this.vinBox.Size = new System.Drawing.Size(141, 20);
            this.vinBox.TabIndex = 11;
            this.vinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idBox.Location = new System.Drawing.Point(99, 74);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(46, 20);
            this.idBox.TabIndex = 10;
            this.idBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "МОДЕЛЬ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updBtn
            // 
            this.updBtn.Location = new System.Drawing.Point(141, 154);
            this.updBtn.Name = "updBtn";
            this.updBtn.Size = new System.Drawing.Size(77, 31);
            this.updBtn.TabIndex = 8;
            this.updBtn.Text = "ОК";
            this.updBtn.UseVisualStyleBackColor = true;
            this.updBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // updTransportBox
            // 
            this.updTransportBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updTransportBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.updTransportBox.FormattingEnabled = true;
            this.updTransportBox.Location = new System.Drawing.Point(99, 32);
            this.updTransportBox.Name = "updTransportBox";
            this.updTransportBox.Size = new System.Drawing.Size(247, 28);
            this.updTransportBox.TabIndex = 7;
            this.updTransportBox.SelectionChangeCommitted += new System.EventHandler(this.updTransportBox_SelectionChangeCommitted);
            // 
            // runBox
            // 
            this.runBox.BackColor = System.Drawing.SystemColors.Control;
            this.runBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.runBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.runBox.Location = new System.Drawing.Point(213, 113);
            this.runBox.Name = "runBox";
            this.runBox.Size = new System.Drawing.Size(100, 23);
            this.runBox.TabIndex = 14;
            this.runBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "УВЕЛИЧИТЬ ПРОБЕГ НА";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(319, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "км";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updTransport
            // 
            this.AcceptButton = this.updBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 192);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.runBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vinBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updBtn);
            this.Controls.Add(this.updTransportBox);
            this.Name = "updTransport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обновление: Транспорт";
            this.Load += new System.EventHandler(this.updTransport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vinBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updBtn;
        private System.Windows.Forms.ComboBox updTransportBox;
        private System.Windows.Forms.TextBox runBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}