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
    public partial class AuhtorizationFrm : Form
    {
        public AuhtorizationFrm()
        {
            InitializeComponent();
        }
              
        private void PassShow_CheckedChanged(object sender, EventArgs e)
        {
            if (PassShow.Checked==true)
            {
                PasswordTxt.PasswordChar = '\0';
            }
            else
            {
                PasswordTxt.PasswordChar = '*';
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Предположим, что данные отправились на сервер, и авторизация прошла успешно. Честно честно", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            Form frm = new RegFrm();
            frm.Show();
            this.Hide();
        }

        private void AuhtorizationFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
