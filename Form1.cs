using Calculate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        ICalculate Calcu;
        public Form1()
        {
            InitializeComponent();
            Calcu = new Calculate();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void plus_Click(object sender, EventArgs e)
        {
            if (ValidateInputes())
            {
                int plus = Calcu.Plus((int)num1.Value, (int)num2.Value);
                MessageBox.Show(plus.ToString());
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (ValidateInputes())
            {
                int minus = Calcu.Minus((int)num1.Value, (int)num2.Value);
                MessageBox.Show(minus.ToString());
            }
        }

        private void Multiple_Click(object sender, EventArgs e)
        {
            if (ValidateInputes())
            {
                int multiple = Calcu.Multiple((int)num1.Value, (int)num2.Value);
                MessageBox.Show(multiple.ToString());
            }
        }

        private void Divid_Click(object sender, EventArgs e)
        {
            if (ValidateInputes())
            {
                int divide = Calcu.Divide((int)num1.Value, (int)num2.Value);
                MessageBox.Show(divide.ToString());
            }
        }

        bool ValidateInputes()
        {
            bool Validated = true;

            if (num1.Value == 0)
            {
                MessageBox.Show("enter number one");
                Validated = false;

            }
            else
            {
                if (num2.Value == 0)
                {
                    MessageBox.Show("enter number two");
                    Validated = false;
                }

            }

            return Validated;
        }
    }
}
