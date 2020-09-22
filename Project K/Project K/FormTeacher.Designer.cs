namespace Project_K
{
    partial class FormTeacher
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
            this.panelClass = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Adder = new System.Windows.Forms.Button();
            this.StudentOnLesson = new System.Windows.Forms.ListBox();
            this.panelME = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelProfileInfo = new System.Windows.Forms.Panel();
            this.ProfileBirthDate = new System.Windows.Forms.Label();
            this.ProfileName = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.panelMenuHolder = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.Class = new System.Windows.Forms.Button();
            this.MyProfile = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelClass.SuspendLayout();
            this.panelME.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelProfileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.panelMenuHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelClass
            // 
            this.panelClass.BackColor = System.Drawing.Color.CadetBlue;
            this.panelClass.BackgroundImage = global::Project_K.Properties.Resources.bg;
            this.panelClass.Controls.Add(this.label4);
            this.panelClass.Controls.Add(this.label2);
            this.panelClass.Controls.Add(this.label1);
            this.panelClass.Controls.Add(this.comboBox1);
            this.panelClass.Controls.Add(this.textBox1);
            this.panelClass.Controls.Add(this.Adder);
            this.panelClass.Controls.Add(this.StudentOnLesson);
            this.panelClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClass.Location = new System.Drawing.Point(97, 0);
            this.panelClass.Name = "panelClass";
            this.panelClass.Size = new System.Drawing.Size(1087, 561);
            this.panelClass.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(430, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 26);
            this.textBox1.TabIndex = 2;
            // 
            // Adder
            // 
            this.Adder.Location = new System.Drawing.Point(430, 287);
            this.Adder.Name = "Adder";
            this.Adder.Size = new System.Drawing.Size(160, 35);
            this.Adder.TabIndex = 1;
            this.Adder.Text = "Добавить баллы";
            this.Adder.UseVisualStyleBackColor = true;
            // 
            // StudentOnLesson
            // 
            this.StudentOnLesson.FormattingEnabled = true;
            this.StudentOnLesson.Items.AddRange(new object[] {
            "Иванов И.И.",
            "Козлов К.К."});
            this.StudentOnLesson.Location = new System.Drawing.Point(607, 74);
            this.StudentOnLesson.Name = "StudentOnLesson";
            this.StudentOnLesson.Size = new System.Drawing.Size(400, 433);
            this.StudentOnLesson.TabIndex = 0;
            // 
            // panelME
            // 
            this.panelME.BackColor = System.Drawing.Color.CadetBlue;
            this.panelME.BackgroundImage = global::Project_K.Properties.Resources.bg;
            this.panelME.Controls.Add(this.panel1);
            this.panelME.Controls.Add(this.panelProfileInfo);
            this.panelME.Controls.Add(this.Avatar);
            this.panelME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelME.Location = new System.Drawing.Point(97, 0);
            this.panelME.Name = "panelME";
            this.panelME.Size = new System.Drawing.Size(1087, 561);
            this.panelME.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(182, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 272);
            this.panel1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Иванов И.И.",
            "Козлов К.К.",
            "Мясников М.М.",
            "Петров П.П.",
            "Булочка Б.Б."});
            this.listBox1.Location = new System.Drawing.Point(29, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(663, 199);
            this.listBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Список учеников:";
            // 
            // panelProfileInfo
            // 
            this.panelProfileInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelProfileInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfileInfo.Controls.Add(this.ProfileBirthDate);
            this.panelProfileInfo.Controls.Add(this.ProfileName);
            this.panelProfileInfo.Location = new System.Drawing.Point(368, 70);
            this.panelProfileInfo.Name = "panelProfileInfo";
            this.panelProfileInfo.Size = new System.Drawing.Size(531, 180);
            this.panelProfileInfo.TabIndex = 3;
            // 
            // ProfileBirthDate
            // 
            this.ProfileBirthDate.AutoSize = true;
            this.ProfileBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileBirthDate.Location = new System.Drawing.Point(25, 65);
            this.ProfileBirthDate.Name = "ProfileBirthDate";
            this.ProfileBirthDate.Size = new System.Drawing.Size(109, 20);
            this.ProfileBirthDate.TabIndex = 3;
            this.ProfileBirthDate.Text = "No birth found";
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileName.Location = new System.Drawing.Point(25, 19);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(152, 24);
            this.ProfileName.TabIndex = 1;
            this.ProfileName.Text = "No Name Found";
            // 
            // Avatar
            // 
            this.Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Avatar.Image = global::Project_K.Properties.Resources.Без_имени_3;
            this.Avatar.Location = new System.Drawing.Point(182, 70);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(180, 180);
            this.Avatar.TabIndex = 2;
            this.Avatar.TabStop = false;
            // 
            // panelMenuHolder
            // 
            this.panelMenuHolder.BackgroundImage = global::Project_K.Properties.Resources.sidemenu;
            this.panelMenuHolder.Controls.Add(this.LogOut);
            this.panelMenuHolder.Controls.Add(this.Class);
            this.panelMenuHolder.Controls.Add(this.MyProfile);
            this.panelMenuHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuHolder.Location = new System.Drawing.Point(0, 0);
            this.panelMenuHolder.Name = "panelMenuHolder";
            this.panelMenuHolder.Size = new System.Drawing.Size(97, 561);
            this.panelMenuHolder.TabIndex = 1;
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.White;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOut.Location = new System.Drawing.Point(0, 495);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(97, 54);
            this.LogOut.TabIndex = 0;
            this.LogOut.Text = "Выйти";
            this.LogOut.UseVisualStyleBackColor = false;
            // 
            // Class
            // 
            this.Class.BackColor = System.Drawing.Color.White;
            this.Class.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Class.Location = new System.Drawing.Point(0, 136);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(97, 54);
            this.Class.TabIndex = 0;
            this.Class.Text = "Занятие";
            this.Class.UseVisualStyleBackColor = false;
            this.Class.Click += new System.EventHandler(this.Class_Click);
            // 
            // MyProfile
            // 
            this.MyProfile.BackColor = System.Drawing.Color.White;
            this.MyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyProfile.Location = new System.Drawing.Point(0, 76);
            this.MyProfile.Name = "MyProfile";
            this.MyProfile.Size = new System.Drawing.Size(97, 54);
            this.MyProfile.TabIndex = 0;
            this.MyProfile.Text = "Мой профиль";
            this.MyProfile.UseVisualStyleBackColor = false;
            this.MyProfile.Click += new System.EventHandler(this.MyProfile_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Активничал",
            "Проводил",
            "Бездельничал",
            "Задирался",
            "Опаздал"});
            this.comboBox1.Location = new System.Drawing.Point(430, 229);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(264, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество баллов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(349, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Причина";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(726, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Присутствующие:";
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelClass);
            this.Controls.Add(this.panelME);
            this.Controls.Add(this.panelMenuHolder);
            this.Name = "FormTeacher";
            this.Text = "Project K: Teacher screen";
            this.panelClass.ResumeLayout(false);
            this.panelClass.PerformLayout();
            this.panelME.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelProfileInfo.ResumeLayout(false);
            this.panelProfileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.panelMenuHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuHolder;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button Class;
        private System.Windows.Forms.Button MyProfile;
        private System.Windows.Forms.Panel panelME;
        private System.Windows.Forms.Panel panelProfileInfo;
        private System.Windows.Forms.Label ProfileBirthDate;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Panel panelClass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Adder;
        private System.Windows.Forms.ListBox StudentOnLesson;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}