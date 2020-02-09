using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDK_05._01._01
{
    public partial class RegFrm : Form
    {
        public RegFrm()
        {
            InitializeComponent();
        }

        private void RegFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CanBtn_Click(object sender, EventArgs e)
        {
            Form frm = new AuhtorizationFrm();
            frm.Show();
            this.Hide();
        }

        private void PassShow_CheckedChanged(object sender, EventArgs e)
        {
            if (PassShow.Checked == true)
            {
                PasswordTxt.PasswordChar = '\0';
                PasswordTxt2.PasswordChar = '\0';
            }
            else
            {
                PasswordTxt.PasswordChar = '*';
                PasswordTxt2.PasswordChar = '*';
            }
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTxt.Text != "" && LoginTxt.Text != "")
            {
                if (PasswordTxt.Text == PasswordTxt2.Text)
                {
                    MessageBox.Show("Да", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Введенные пароли не совпадают", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
