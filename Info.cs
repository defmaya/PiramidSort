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
    public partial class Info : Form
    {
        public Info()
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


    }
}
