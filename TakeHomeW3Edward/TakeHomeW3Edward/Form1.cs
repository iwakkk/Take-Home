using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHomeW3Edward
{
    public partial class Form1 : Form
    {

        Form2 frm2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string valuenama = txt_Name.Text;
            string valueartis = txt_Artist.Text;

            if (!string.IsNullOrEmpty(txt_Name.Text) && !string.IsNullOrEmpty(txt_Artist.Text))
            {
                frm2.Labelperkenalan = "Hi, my name is " + valuenama + " and my favorite artist is " + valueartis;
            }
            else
            {
                MessageBox.Show("please input your name and your favorite artist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public Button Button1
        {
            get { return button1; }
            set { button1 = value; }
        }
        private void check_tnc_CheckedChanged(object sender, EventArgs e)
        {
                if (check_tnc.Checked == true && Application.OpenForms.OfType<Form2>().Any())
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
        }
 
        private void btn_NextForm_Click(object sender, EventArgs e)
        {
            if (frm2.IsDisposed == true)
            {
                frm2 = new Form2();
            }
            frm2.Show(this);


            if (check_tnc.Checked == true && Application.OpenForms.OfType<Form2>().Any())
            {
                button1.Enabled = true;
            }
            else if (frm2 == null)
            {
                button1.Enabled = false;
            }
            else
            {
               button1.Enabled = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public PictureBox PictureBox1
        {
            get { return pictureBox1; }
            set { pictureBox1 = value; }
        }
    }
}
