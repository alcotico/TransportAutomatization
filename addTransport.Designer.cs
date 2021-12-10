
namespace TransportAutomatization
{
    partial class addTransport
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
            this.transportVIN = new System.Windows.Forms.TextBox();
            this.transportRegNumber = new System.Windows.Forms.TextBox();
            this.transportModel = new System.Windows.Forms.TextBox();
            this.transportType = new System.Windows.Forms.ComboBox();
            this.transportYear = new System.Windows.Forms.TextBox();
            this.transportRun = new System.Windows.Forms.TextBox();
            this.transportPlaces = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.transportExep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // transportVIN
            // 
            this.transportVIN.BackColor = System.Drawing.SystemColors.Control;
            this.transportVIN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportVIN.Location = new System.Drawing.Point(112, 22);
            this.transportVIN.MaxLength = 17;
            this.transportVIN.Name = "transportVIN";
            this.transportVIN.Size = new System.Drawing.Size(283, 29);
            this.transportVIN.TabIndex = 0;
            this.transportVIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transportRegNumber
            // 
            this.transportRegNumber.BackColor = System.Drawing.SystemColors.Control;
            this.transportRegNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.transportRegNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportRegNumber.Location = new System.Drawing.Point(112, 67);
            this.transportRegNumber.MaxLength = 9;
            this.transportRegNumber.Name = "transportRegNumber";
            this.transportRegNumber.Size = new System.Drawing.Size(98, 29);
            this.transportRegNumber.TabIndex = 1;
            this.transportRegNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transportModel
            // 
            this.transportModel.BackColor = System.Drawing.SystemColors.Control;
            this.transportModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportModel.Location = new System.Drawing.Point(112, 112);
            this.transportModel.Name = "transportModel";
            this.transportModel.Size = new System.Drawing.Size(283, 29);
            this.transportModel.TabIndex = 2;
            // 
            // transportType
            // 
            this.transportType.BackColor = System.Drawing.SystemColors.Control;
            this.transportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transportType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.transportType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportType.FormattingEnabled = true;
            this.transportType.Items.AddRange(new object[] {
            "вахтовый автобус",
            "грузовой транспорт",
            "строительный транспорт"});
            this.transportType.Location = new System.Drawing.Point(181, 204);
            this.transportType.Name = "transportType";
            this.transportType.Size = new System.Drawing.Size(214, 29);
            this.transportType.TabIndex = 3;
            // 
            // transportYear
            // 
            this.transportYear.BackColor = System.Drawing.SystemColors.Control;
            this.transportYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportYear.Location = new System.Drawing.Point(181, 155);
            this.transportYear.MaxLength = 4;
            this.transportYear.Name = "transportYear";
            this.transportYear.Size = new System.Drawing.Size(51, 29);
            this.transportYear.TabIndex = 4;
            this.transportYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transportRun
            // 
            this.transportRun.BackColor = System.Drawing.SystemColors.Control;
            this.transportRun.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportRun.Location = new System.Drawing.Point(317, 67);
            this.transportRun.Name = "transportRun";
            this.transportRun.Size = new System.Drawing.Size(78, 29);
            this.transportRun.TabIndex = 5;
            this.transportRun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transportPlaces
            // 
            this.transportPlaces.BackColor = System.Drawing.SystemColors.Control;
            this.transportPlaces.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportPlaces.Location = new System.Drawing.Point(353, 155);
            this.transportPlaces.Name = "transportPlaces";
            this.transportPlaces.Size = new System.Drawing.Size(42, 29);
            this.transportPlaces.TabIndex = 6;
            this.transportPlaces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Гос. номер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Модель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(243, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Пробег";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Год производства";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(247, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Число мест";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Назначение";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.submit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.submit.Location = new System.Drawing.Point(151, 282);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(119, 31);
            this.submit.TabIndex = 14;
            this.submit.Text = "Добавить";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // transportExep
            // 
            this.transportExep.BackColor = System.Drawing.SystemColors.Control;
            this.transportExep.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transportExep.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transportExep.Location = new System.Drawing.Point(3, 242);
            this.transportExep.Name = "transportExep";
            this.transportExep.Size = new System.Drawing.Size(405, 34);
            this.transportExep.TabIndex = 15;
            this.transportExep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 319);
            this.Controls.Add(this.transportExep);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transportPlaces);
            this.Controls.Add(this.transportRun);
            this.Controls.Add(this.transportYear);
            this.Controls.Add(this.transportType);
            this.Controls.Add(this.transportModel);
            this.Controls.Add(this.transportRegNumber);
            this.Controls.Add(this.transportVIN);
            this.Name = "addTransport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление: Транспорт";
            this.Load += new System.EventHandler(this.addTransport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox transportVIN;
        private System.Windows.Forms.TextBox transportRegNumber;
        private System.Windows.Forms.TextBox transportModel;
        private System.Windows.Forms.ComboBox transportType;
        private System.Windows.Forms.TextBox transportYear;
        private System.Windows.Forms.TextBox transportRun;
        private System.Windows.Forms.TextBox transportPlaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label transportExep;
    }
}