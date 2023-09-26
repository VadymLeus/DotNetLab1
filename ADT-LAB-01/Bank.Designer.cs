namespace ADT_LAB_01
{
    partial class Bank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bank));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitBTN = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnrollmentBTN = new System.Windows.Forms.Button();
            this.BreedingBTN = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.Button();
            this.EnumerationBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EnumerationNTBX = new System.Windows.Forms.TextBox();
            this.EnumerationBTBX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.ExitBTN);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 60);
            this.panel1.TabIndex = 15;
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.Color.Red;
            this.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBTN.Image = ((System.Drawing.Image)(resources.GetObject("ExitBTN.Image")));
            this.ExitBTN.Location = new System.Drawing.Point(6, 8);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(45, 45);
            this.ExitBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitBTN.TabIndex = 25;
            this.ExitBTN.TabStop = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(179, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(254, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Капіталіс-Банк";
            // 
            // EnrollmentBTN
            // 
            this.EnrollmentBTN.BackColor = System.Drawing.Color.CadetBlue;
            this.EnrollmentBTN.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnrollmentBTN.ForeColor = System.Drawing.Color.White;
            this.EnrollmentBTN.Location = new System.Drawing.Point(230, 179);
            this.EnrollmentBTN.Name = "EnrollmentBTN";
            this.EnrollmentBTN.Size = new System.Drawing.Size(217, 75);
            this.EnrollmentBTN.TabIndex = 16;
            this.EnrollmentBTN.Text = "Зарахування коштів на карту";
            this.EnrollmentBTN.UseVisualStyleBackColor = false;
            this.EnrollmentBTN.Click += new System.EventHandler(this.EnrollmentBTN_Click);
            // 
            // BreedingBTN
            // 
            this.BreedingBTN.BackColor = System.Drawing.Color.CadetBlue;
            this.BreedingBTN.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BreedingBTN.ForeColor = System.Drawing.Color.White;
            this.BreedingBTN.Location = new System.Drawing.Point(455, 179);
            this.BreedingBTN.Name = "BreedingBTN";
            this.BreedingBTN.Size = new System.Drawing.Size(217, 75);
            this.BreedingBTN.TabIndex = 17;
            this.BreedingBTN.Text = "Зняття коштів";
            this.BreedingBTN.UseVisualStyleBackColor = false;
            this.BreedingBTN.Click += new System.EventHandler(this.BreedingBTN_Click);
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.CadetBlue;
            this.Information.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Information.ForeColor = System.Drawing.Color.White;
            this.Information.Location = new System.Drawing.Point(6, 179);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(217, 75);
            this.Information.TabIndex = 18;
            this.Information.Text = "Перегляд інформації";
            this.Information.UseVisualStyleBackColor = false;
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // EnumerationBTN
            // 
            this.EnumerationBTN.BackColor = System.Drawing.Color.CadetBlue;
            this.EnumerationBTN.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnumerationBTN.ForeColor = System.Drawing.Color.White;
            this.EnumerationBTN.Location = new System.Drawing.Point(464, 293);
            this.EnumerationBTN.Name = "EnumerationBTN";
            this.EnumerationBTN.Size = new System.Drawing.Size(195, 75);
            this.EnumerationBTN.TabIndex = 19;
            this.EnumerationBTN.Text = "Перерахування коштів";
            this.EnumerationBTN.UseVisualStyleBackColor = false;
            this.EnumerationBTN.Click += new System.EventHandler(this.EnumerationBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Виберіть потрібну опцію:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(419, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(0, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "0";
            // 
            // EnumerationNTBX
            // 
            this.EnumerationNTBX.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnumerationNTBX.Location = new System.Drawing.Point(230, 293);
            this.EnumerationNTBX.Name = "EnumerationNTBX";
            this.EnumerationNTBX.Size = new System.Drawing.Size(183, 32);
            this.EnumerationNTBX.TabIndex = 25;
            // 
            // EnumerationBTBX
            // 
            this.EnumerationBTBX.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnumerationBTBX.Location = new System.Drawing.Point(230, 336);
            this.EnumerationBTBX.Name = "EnumerationBTBX";
            this.EnumerationBTBX.Size = new System.Drawing.Size(183, 32);
            this.EnumerationBTBX.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "Номер карти:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 31);
            this.label4.TabIndex = 28;
            this.label4.Text = "Кількість коштів:";
            // 
            // Bank
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnumerationBTBX);
            this.Controls.Add(this.EnumerationNTBX);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnumerationBTN);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.BreedingBTN);
            this.Controls.Add(this.EnrollmentBTN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Bank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EnrollmentBTN;
        private System.Windows.Forms.Button BreedingBTN;
        private System.Windows.Forms.Button Information;
        private System.Windows.Forms.Button EnumerationBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ExitBTN;
        private System.Windows.Forms.TextBox EnumerationNTBX;
        private System.Windows.Forms.TextBox EnumerationBTBX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

