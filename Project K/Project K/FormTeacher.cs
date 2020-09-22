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
    public partial class FormTeacher : Form
    {
        public StreamReader sr = new StreamReader("Teacher.txt");
        public FormTeacher()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            ProfileName.Text = sr.ReadLine();
            ProfileBirthDate.Text = sr.ReadLine();
        }

        private void MyProfile_Click(object sender, EventArgs e)
        {
            panelME.Enabled = true;
            panelME.Visible = true;
            panelClass.Enabled = false;
            panelClass.Visible = false;
        }

        private void Class_Click(object sender, EventArgs e)
        {
            panelME.Enabled = false;
            panelME.Visible = false;
            panelClass.Enabled = true;
            panelClass.Visible = true;
        }
    }
}
