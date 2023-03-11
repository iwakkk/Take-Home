using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Take_Home_W2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string umur = "";
            if (Convert.ToInt16(txt_Age.Text) < 18)
            {
                umur = "minor";
            }
            else
            {
                umur = "adult";
            }
            MessageBox.Show("Name : " + txt_Name.Text + "\nEmail : " + txt_Email.Text + "\nPhone Number : " + txt_Phone.Text + "\nYou are an " + umur);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            txt_Phone.Clear();
            txt_Email.Clear();
            txt_Age.Clear();
        }
    }
}
