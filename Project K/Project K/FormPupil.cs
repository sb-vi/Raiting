using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_K
{
    public partial class FormPupil : Form
    {
        public StreamReader sr = new StreamReader("Me.txt");

        public FormPupil()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData() 
        {
            ProfileName.Text = sr.ReadLine();
            ProfileClass.Text = sr.ReadLine();
            ProfileBirthDate.Text = sr.ReadLine();
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin login = new FormLogin();
            login.ShowDialog();
            this.Close();
        }

        private void MyProfile_Click(object sender, EventArgs e)
        {
            panelME.Enabled = true;
            panelME.Visible = true;
            panelRATING.Enabled = false;
            panelRATING.Visible = false;
            panelAchievements.Enabled = false;
            panelAchievements.Visible = false;
        }

        private void Rating_Click(object sender, EventArgs e)
        {        
            panelME.Enabled = false;
            panelME.Visible = false;
            panelRATING.Enabled = true;
            panelRATING.Visible = true;
            panelAchievements.Enabled = false;
            panelAchievements.Visible = false;
        }

        private void Achievements_Click(object sender, EventArgs e)
        {
            panelME.Enabled = false;
            panelME.Visible = false;
            panelRATING.Enabled = false;
            panelRATING.Visible = false;
            panelAchievements.Enabled = true;
            panelAchievements.Visible = true;
        }

        private void FormPupil_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kektoriumDataSet.Рейтинг". При необходимости она может быть перемещена или удалена.
            this.рейтингTableAdapter.Fill(this.kektoriumDataSet.Рейтинг);

        }
    }
}
