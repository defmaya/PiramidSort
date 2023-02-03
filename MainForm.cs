using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Пирамидальная_сортировка
{
    public partial class MainForm : Form
    {
        public MainForm()
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

        private void buttonGen_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBoxGen.Clear();
            textBoxSort.Clear();
            for (int i = 0; i < Convert.ToInt32(numericArray.Value); i++)
            {
                int r = rand.Next(-100, 100);

                int[] array = new int[Convert.ToInt32(numericArray.Value)];

                array[i] = r;

                textBoxGen.Text += Convert.ToString(r) + " ";
            }
        }

        private void labelInfo_Click(object sender, EventArgs e)
        {
            Info mf = new Info();
            
            mf.Show();
        }

        private void labelInfo_MouseEnter(object sender, EventArgs e)
        {
            labelInfo.ForeColor = Color.White;
        }

        private void labelInfo_MouseLeave(object sender, EventArgs e)
        {
            labelInfo.ForeColor = Color.Black;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            textBoxSort.Clear();
            string ass = textBoxGen.Text;
            string[] mas = ass.Split(' ');
           
            int n = mas.Length-1;
            int[] sas = new int[n];

            HeapSort g = new HeapSort();

            for (int i = 0; i < n; i++)
                sas[i] = Convert.ToInt32(mas[i]);

            g.sort(sas);

            for (int i = 0; i < n; i++)
                textBoxSort.Text += Convert.ToString(sas[i]) + " ";
        }


    }
}
