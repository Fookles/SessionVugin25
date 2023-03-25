namespace WindowsFormsApp1
{
    partial class fmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 100);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(119, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Компания \"Мегадрайв\"";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(37)))), ((int)(((byte)(181)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 100);
            this.panel2.TabIndex = 1;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(327, 174);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(100, 20);
            this.LoginBox.TabIndex = 2;
            this.LoginBox.Text = "7efwqtub80i5@outlook.com";
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(327, 255);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(100, 20);
            this.PassBox.TabIndex = 3;
            this.PassBox.Tag = "";
            this.PassBox.Text = "54zxr3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(347, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(347, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // AuthButton
            // 
            this.AuthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(192)))), ((int)(((byte)(190)))));
            this.AuthButton.Location = new System.Drawing.Point(342, 314);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(75, 23);
            this.AuthButton.TabIndex = 6;
            this.AuthButton.Text = "Вход";
            this.AuthButton.UseVisualStyleBackColor = false;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.логотип;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 465);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmLogin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AuthButton;
    }
}

