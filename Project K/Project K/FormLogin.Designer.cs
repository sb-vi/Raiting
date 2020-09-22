namespace Project_K
{
    partial class FormLogin
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
            this.buttonLoginPupil = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginPupil
            // 
            this.buttonLoginPupil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonLoginPupil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonLoginPupil.FlatAppearance.BorderSize = 0;
            this.buttonLoginPupil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonLoginPupil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonLoginPupil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginPupil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoginPupil.ForeColor = System.Drawing.Color.Violet;
            this.buttonLoginPupil.Location = new System.Drawing.Point(16, 115);
            this.buttonLoginPupil.Name = "buttonLoginPupil";
            this.buttonLoginPupil.Size = new System.Drawing.Size(291, 31);
            this.buttonLoginPupil.TabIndex = 1;
            this.buttonLoginPupil.Text = "Войти";
            this.buttonLoginPupil.UseVisualStyleBackColor = false;
            this.buttonLoginPupil.Click += new System.EventHandler(this.buttonLoginPupil_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.ForeColor = System.Drawing.Color.DarkGray;
            this.LoginBox.Location = new System.Drawing.Point(16, 27);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(291, 26);
            this.LoginBox.TabIndex = 4;
            this.LoginBox.Text = "Введите Логин";
            this.LoginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.ForeColor = System.Drawing.Color.DarkGray;
            this.PasswordBox.Location = new System.Drawing.Point(16, 71);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(291, 26);
            this.PasswordBox.TabIndex = 5;
            this.PasswordBox.Text = "Введите Пароль";
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordBox.Enter += new System.EventHandler(this.PasswordBox_Enter);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.Indigo;
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.LoginBox);
            this.LoginPanel.Controls.Add(this.buttonLoginPupil);
            this.LoginPanel.Controls.Add(this.PasswordBox);
            this.LoginPanel.Location = new System.Drawing.Point(429, 305);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(322, 168);
            this.LoginPanel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::Project_K.Properties.Resources.Без_имени_3;
            this.pictureBox1.Location = new System.Drawing.Point(534, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.WelcomeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial Narrow", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.WelcomeLabel.Image = global::Project_K.Properties.Resources.login;
            this.WelcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(1184, 561);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "WELCOME TO PROJECT K!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.WelcomeLabel);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project K: Login";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button buttonLoginPupil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Panel LoginPanel;
    }
}

