using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Пирамидальная_сортировка
{
    public partial class AutForm : Form
    {
        public AutForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            buttonExit.ForeColor = Color.White;
        }

        private void buttonExit_MouseLeave(object sender, EventArgs e)
        {
            buttonExit.ForeColor = Color.Black;
        }

        private void buttonReg_MouseEnter(object sender, EventArgs e)
        {
            buttonReg.ForeColor = Color.White;
        }

        private void buttonReg_MouseLeave(object sender, EventArgs e)
        {
            buttonReg.ForeColor = Color.Black;
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            RegForm sf = new RegForm();
            sf.FormClosed += (s, args) => this.Close();
            this.Hide();
            sf.Show();
        }

        private void buttonAut_Click(object sender, EventArgs e)
        {
            textBoxLogin.Text = textBoxLogin.Text.Trim();
            textBoxPassword.Text = textBoxPassword.Text.Trim();
            try
            {
                User user = new User(textBoxLogin.Text, textBoxPassword.Text);
                if (user.CorrectUser() && user.UserValid())
                {
                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.FormClosed += (s, args) => this.Close();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль", "Ошибкаавторизации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка авторизации", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                return;
            }
        }


    }
}
