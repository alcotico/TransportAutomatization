
namespace TransportAutomatization
{
    partial class delTransport
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
            this.delTransportBox = new System.Windows.Forms.ComboBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.vinBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delTransportBox
            // 
            this.delTransportBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.delTransportBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.delTransportBox.FormattingEnabled = true;
            this.delTransportBox.Location = new System.Drawing.Point(105, 31);
            this.delTransportBox.Name = "delTransportBox";
            this.delTransportBox.Size = new System.Drawing.Size(247, 28);
            this.delTransportBox.TabIndex = 0;
            this.delTransportBox.SelectionChangeCommitted += new System.EventHandler(this.delTransportBox_SelectionChangeCommitted);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(145, 113);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(77, 30);
            this.delBtn.TabIndex = 1;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "МОДЕЛЬ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idBox
            // 
            this.idBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idBox.Location = new System.Drawing.Point(105, 73);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(46, 20);
            this.idBox.TabIndex = 3;
            this.idBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // vinBox
            // 
            this.vinBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.vinBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vinBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vinBox.Location = new System.Drawing.Point(211, 73);
            this.vinBox.Name = "vinBox";
            this.vinBox.ReadOnly = true;
            this.vinBox.Size = new System.Drawing.Size(141, 20);
            this.vinBox.TabIndex = 4;
            this.vinBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(163, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "VIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(57, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delTransport
            // 
            this.AcceptButton = this.delBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 149);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vinBox);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.delTransportBox);
            this.Name = "delTransport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление: Транспорт";
            this.Load += new System.EventHandler(this.delTransport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox delTransportBox;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox vinBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}