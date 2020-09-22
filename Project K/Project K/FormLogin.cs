using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Project_K
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLoginPupil_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "" && PasswordBox.Text == "") 
            {

            }
            else if(LoginBox.Text == "student")
            {
                this.Hide();
                FormPupil pupil = new FormPupil();
                pupil.ShowDialog();
                this.Close();
            }
            else if (LoginBox.Text == "teacher")
            {
                this.Hide();
                FormTeacher teacher = new FormTeacher();
                teacher.ShowDialog();
                this.Close();
            }

        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Введите Логин") 
            {
                LoginBox.Text = null;
                LoginBox.ForeColor = Color.Black;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Введите Пароль")
            {
                LoginBox.Text = null;
                LoginBox.ForeColor = Color.Black;
            }
        }
    }
}
