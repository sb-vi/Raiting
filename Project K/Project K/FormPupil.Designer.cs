namespace Project_K
{
    partial class FormPupil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPupil));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Полученные", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Доступные", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Первые Шаги", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("То что не убивает", 3);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("На Вершине", 3);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Гиперактивность", "Activity");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Добро пожаловать", 2);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelME = new System.Windows.Forms.Panel();
            this.panelLatestActivity = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Activitylabel = new System.Windows.Forms.Label();
            this.panelProfileInfo = new System.Windows.Forms.Panel();
            this.ProfileBirthDate = new System.Windows.Forms.Label();
            this.ProfileClass = new System.Windows.Forms.Label();
            this.ProfileName = new System.Windows.Forms.Label();
            this.Avatar = new System.Windows.Forms.PictureBox();
            this.panelAchievements = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listAchievements = new System.Windows.Forms.ListView();
            this.panelRATING = new System.Windows.Forms.Panel();
            this.dataTopStudents = new System.Windows.Forms.DataGridView();
            this.panelMenuHolder = new System.Windows.Forms.Panel();
            this.Achievements = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.Rating = new System.Windows.Forms.Button();
            this.MyProfile = new System.Windows.Forms.Button();
            this.kektoriumDataSet = new Project_K.KektoriumDataSet();
            this.рейтингBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рейтингTableAdapter = new Project_K.KektoriumDataSetTableAdapters.РейтингTableAdapter();
            this.местоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоБалловDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panelME.SuspendLayout();
            this.panelLatestActivity.SuspendLayout();
            this.panelProfileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
            this.panelAchievements.SuspendLayout();
            this.panelRATING.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTopStudents)).BeginInit();
            this.panelMenuHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kektoriumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейтингBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Foot");
            this.imageList1.Images.SetKeyName(1, "Activity");
            this.imageList1.Images.SetKeyName(2, "Welcome");
            this.imageList1.Images.SetKeyName(3, "Lock");
            // 
            // panelME
            // 
            this.panelME.BackColor = System.Drawing.Color.CadetBlue;
            this.panelME.BackgroundImage = global::Project_K.Properties.Resources.bg;
            this.panelME.Controls.Add(this.panelLatestActivity);
            this.panelME.Controls.Add(this.panelProfileInfo);
            this.panelME.Controls.Add(this.Avatar);
            this.panelME.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelME.Location = new System.Drawing.Point(97, 0);
            this.panelME.Name = "panelME";
            this.panelME.Size = new System.Drawing.Size(1087, 561);
            this.panelME.TabIndex = 1;
            // 
            // panelLatestActivity
            // 
            this.panelLatestActivity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLatestActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLatestActivity.Controls.Add(this.listBox1);
            this.panelLatestActivity.Controls.Add(this.Activitylabel);
            this.panelLatestActivity.Location = new System.Drawing.Point(182, 256);
            this.panelLatestActivity.Name = "panelLatestActivity";
            this.panelLatestActivity.Size = new System.Drawing.Size(717, 293);
            this.panelLatestActivity.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "Активничал (+2)",
            "Активничал (+2)",
            "Пропустил (-1)",
            "Задирал (-5)",
            "Активничал (+2)"});
            this.listBox1.Location = new System.Drawing.Point(18, 45);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(679, 224);
            this.listBox1.TabIndex = 2;
            // 
            // Activitylabel
            // 
            this.Activitylabel.AutoSize = true;
            this.Activitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Activitylabel.Location = new System.Drawing.Point(14, 9);
            this.Activitylabel.Name = "Activitylabel";
            this.Activitylabel.Size = new System.Drawing.Size(191, 20);
            this.Activitylabel.TabIndex = 1;
            this.Activitylabel.Text = "Последняя активность:";
            // 
            // panelProfileInfo
            // 
            this.panelProfileInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelProfileInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfileInfo.Controls.Add(this.ProfileBirthDate);
            this.panelProfileInfo.Controls.Add(this.ProfileClass);
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
            this.ProfileBirthDate.Location = new System.Drawing.Point(25, 91);
            this.ProfileBirthDate.Name = "ProfileBirthDate";
            this.ProfileBirthDate.Size = new System.Drawing.Size(109, 20);
            this.ProfileBirthDate.TabIndex = 3;
            this.ProfileBirthDate.Text = "No birth found";
            // 
            // ProfileClass
            // 
            this.ProfileClass.AutoSize = true;
            this.ProfileClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfileClass.Location = new System.Drawing.Point(25, 56);
            this.ProfileClass.Name = "ProfileClass";
            this.ProfileClass.Size = new System.Drawing.Size(120, 20);
            this.ProfileClass.TabIndex = 2;
            this.ProfileClass.Text = "Class not found";
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
            this.Avatar.BackgroundImage = global::Project_K.Properties.Resources.logotip;
            this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Avatar.Location = new System.Drawing.Point(182, 70);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(180, 180);
            this.Avatar.TabIndex = 2;
            this.Avatar.TabStop = false;
            // 
            // panelAchievements
            // 
            this.panelAchievements.BackColor = System.Drawing.Color.YellowGreen;
            this.panelAchievements.BackgroundImage = global::Project_K.Properties.Resources.bg;
            this.panelAchievements.Controls.Add(this.label1);
            this.panelAchievements.Controls.Add(this.listAchievements);
            this.panelAchievements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAchievements.Enabled = false;
            this.panelAchievements.Location = new System.Drawing.Point(97, 0);
            this.panelAchievements.Name = "panelAchievements";
            this.panelAchievements.Size = new System.Drawing.Size(1087, 561);
            this.panelAchievements.TabIndex = 2;
            this.panelAchievements.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(449, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мои Достижения";
            // 
            // listAchievements
            // 
            this.listAchievements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            listViewGroup1.Header = "Полученные";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "Unlocked";
            listViewGroup2.Header = "Доступные";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "Locked";
            this.listAchievements.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listAchievements.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup2;
            listViewItem3.Group = listViewGroup2;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup1;
            this.listAchievements.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listAchievements.LargeImageList = this.imageList1;
            this.listAchievements.Location = new System.Drawing.Point(55, 76);
            this.listAchievements.Name = "listAchievements";
            this.listAchievements.Size = new System.Drawing.Size(977, 449);
            this.listAchievements.TabIndex = 0;
            this.listAchievements.TileSize = new System.Drawing.Size(150, 150);
            this.listAchievements.UseCompatibleStateImageBehavior = false;
            // 
            // panelRATING
            // 
            this.panelRATING.BackColor = System.Drawing.Color.Chocolate;
            this.panelRATING.BackgroundImage = global::Project_K.Properties.Resources.bg;
            this.panelRATING.Controls.Add(this.label2);
            this.panelRATING.Controls.Add(this.dataTopStudents);
            this.panelRATING.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRATING.Enabled = false;
            this.panelRATING.Location = new System.Drawing.Point(97, 0);
            this.panelRATING.Name = "panelRATING";
            this.panelRATING.Size = new System.Drawing.Size(1087, 561);
            this.panelRATING.TabIndex = 0;
            this.panelRATING.Visible = false;
            // 
            // dataTopStudents
            // 
            this.dataTopStudents.AutoGenerateColumns = false;
            this.dataTopStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTopStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.местоDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.количествоБалловDataGridViewTextBoxColumn});
            this.dataTopStudents.DataSource = this.рейтингBindingSource;
            this.dataTopStudents.Location = new System.Drawing.Point(335, 50);
            this.dataTopStudents.Name = "dataTopStudents";
            this.dataTopStudents.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataTopStudents.Size = new System.Drawing.Size(443, 476);
            this.dataTopStudents.TabIndex = 0;
            // 
            // panelMenuHolder
            // 
            this.panelMenuHolder.BackgroundImage = global::Project_K.Properties.Resources.sidemenu;
            this.panelMenuHolder.Controls.Add(this.Achievements);
            this.panelMenuHolder.Controls.Add(this.LogOut);
            this.panelMenuHolder.Controls.Add(this.Rating);
            this.panelMenuHolder.Controls.Add(this.MyProfile);
            this.panelMenuHolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuHolder.Location = new System.Drawing.Point(0, 0);
            this.panelMenuHolder.Name = "panelMenuHolder";
            this.panelMenuHolder.Size = new System.Drawing.Size(97, 561);
            this.panelMenuHolder.TabIndex = 0;
            // 
            // Achievements
            // 
            this.Achievements.BackColor = System.Drawing.Color.White;
            this.Achievements.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Achievements.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Achievements.Location = new System.Drawing.Point(0, 196);
            this.Achievements.Name = "Achievements";
            this.Achievements.Size = new System.Drawing.Size(97, 54);
            this.Achievements.TabIndex = 1;
            this.Achievements.Text = "Достижения";
            this.Achievements.UseVisualStyleBackColor = false;
            this.Achievements.Click += new System.EventHandler(this.Achievements_Click);
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
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Rating
            // 
            this.Rating.BackColor = System.Drawing.Color.White;
            this.Rating.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rating.ForeColor = System.Drawing.Color.Black;
            this.Rating.Location = new System.Drawing.Point(0, 136);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(97, 54);
            this.Rating.TabIndex = 0;
            this.Rating.Text = "Рейтинг";
            this.Rating.UseVisualStyleBackColor = false;
            this.Rating.Click += new System.EventHandler(this.Rating_Click);
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
            // kektoriumDataSet
            // 
            this.kektoriumDataSet.DataSetName = "KektoriumDataSet";
            this.kektoriumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // рейтингBindingSource
            // 
            this.рейтингBindingSource.DataMember = "Рейтинг";
            this.рейтингBindingSource.DataSource = this.kektoriumDataSet;
            // 
            // рейтингTableAdapter
            // 
            this.рейтингTableAdapter.ClearBeforeFill = true;
            // 
            // местоDataGridViewTextBoxColumn
            // 
            this.местоDataGridViewTextBoxColumn.DataPropertyName = "Место";
            this.местоDataGridViewTextBoxColumn.HeaderText = "Место";
            this.местоDataGridViewTextBoxColumn.Name = "местоDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "группа";
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            // 
            // количествоБалловDataGridViewTextBoxColumn
            // 
            this.количествоБалловDataGridViewTextBoxColumn.DataPropertyName = "Количество баллов";
            this.количествоБалловDataGridViewTextBoxColumn.HeaderText = "Количество баллов";
            this.количествоБалловDataGridViewTextBoxColumn.Name = "количествоБалловDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(481, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Топ 20 Учеников";
            // 
            // FormPupil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panelAchievements);
            this.Controls.Add(this.panelRATING);
            this.Controls.Add(this.panelME);
            this.Controls.Add(this.panelMenuHolder);
            this.Name = "FormPupil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project K: Pupil screen";
            this.Load += new System.EventHandler(this.FormPupil_Load);
            this.panelME.ResumeLayout(false);
            this.panelLatestActivity.ResumeLayout(false);
            this.panelLatestActivity.PerformLayout();
            this.panelProfileInfo.ResumeLayout(false);
            this.panelProfileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
            this.panelAchievements.ResumeLayout(false);
            this.panelAchievements.PerformLayout();
            this.panelRATING.ResumeLayout(false);
            this.panelRATING.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTopStudents)).EndInit();
            this.panelMenuHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kektoriumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рейтингBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuHolder;
        private System.Windows.Forms.Button Rating;
        private System.Windows.Forms.Button MyProfile;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Panel panelME;
        private System.Windows.Forms.Panel panelRATING;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.Panel panelProfileInfo;
        private System.Windows.Forms.Label ProfileBirthDate;
        private System.Windows.Forms.Label ProfileClass;
        private System.Windows.Forms.PictureBox Avatar;
        private System.Windows.Forms.Panel panelAchievements;
        private System.Windows.Forms.Button Achievements;
        private System.Windows.Forms.Panel panelLatestActivity;
        private System.Windows.Forms.Label Activitylabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataTopStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listAchievements;
        private System.Windows.Forms.ImageList imageList1;
        private KektoriumDataSet kektoriumDataSet;
        private System.Windows.Forms.BindingSource рейтингBindingSource;
        private KektoriumDataSetTableAdapters.РейтингTableAdapter рейтингTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn местоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоБалловDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
    }
}