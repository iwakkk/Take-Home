using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHomeW3Edward
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void check_Agree_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Agree.Checked == true && check_Choice.Checked == true)
            {
                btn_Magic.Enabled = true;
            }
            else
            {
                btn_Magic.Enabled = false;
            }
        }

        private void check_Choice_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Agree.Checked == true && check_Choice.Checked == true)
            {
                btn_Magic.Enabled = true;
            }
            else
            {
                btn_Magic.Enabled = false;
            }
        }

        private void labelperkenalan_Click(object sender, EventArgs e)
        {

        }

        public string Labelperkenalan
        {
            get { return labelperkenalan.Text; }
            set { labelperkenalan.Text = value; }
        }

        private void btn_Magic_Click(object sender, EventArgs e)
        {
            Form1 frm1 = (Form1)this.Owner;
            if ((radio_NavyBlue.Checked == true || radio_Purple.Checked == true || radio_Grey.Checked == true || radio_Brown.Checked == true || radio_Green.Checked == true) &&
                (radio_Orange.Checked == true || radio_Yellow.Checked == true || radio_Black.Checked == true))
            {
                pictureBox1.Visible = true;
                frm1.PictureBox1.Visible = true;


                if (radio_NavyBlue.Checked == true)
                {
                    frm1.BackColor = Color.Navy;
                }
                else if (radio_Purple.Checked == true)
                {
                    frm1.BackColor = Color.Purple;
                }
                else if (radio_Grey.Checked == true)
                {
                    frm1.BackColor = Color.Gray;
                }
                else if (radio_Brown.Checked == true)
                {
                    frm1.BackColor = Color.Brown;
                }
                else if (radio_Green.Checked == true)
                {
                    frm1.BackColor = Color.Green;
                }

                if (radio_Orange.Checked == true)
                {
                    frm1.ForeColor = Color.Orange;
                }
                else if (radio_Yellow.Checked == true)
                {
                    frm1.ForeColor = Color.Yellow;
                }
                else if (radio_Black.Checked == true)
                {
                    frm1.ForeColor = Color.Black;
                }
            }
            else
            {
                    MessageBox.Show("Please pick your color choice", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
           
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm1 = (Form1)this.Owner;
            frm1.Button1.Enabled = false;
        }
    }
}
