using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyMaths_v0._1
{
    public partial class Submenu_OpBasicas : Form
    {
        public Submenu_OpBasicas()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        unsafe private void button_solve_Click(object sender, EventArgs e)
        {
            //Pointers require unsafe compile
            string input = textBox_input.Text, resultado;
            

            int i = 0, inicio;
                while (i < input.Length)
                {

                    {
                        inicio = i;
                        
                    }
                    i++;
                }



            

            label1.Text = input;
        }
    }
}
