using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пирамидальная_сортировка
{
    public partial class RegForm : Form
    {
        public RegForm()
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

        private void buttonAut_Click(object sender, EventArgs e)
        {
            //стираем пустые введенные символы
            textBoxLogin.Text = textBoxLogin.Text.Trim();
            textBoxPassword.Text = textBoxPassword.Text.Trim();
            try
            {
                var user = new User(textBoxLogin.Text, textBoxPassword.Text);
                if (user.CorrectUser() && !user.UsernameExist())
                {
                    user.CreateUser();
                    this.Hide();
                    MainForm mf = new MainForm();
                    mf.FormClosed += (s, args) => this.Close();
                    mf.Show();
                }
                else
                {
                    MessageBox.Show("Имя пользователя уже занято", "Ошибка регистрации",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }


    }
}
