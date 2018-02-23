using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace EasyMaths_v0._1
{
    public partial class Submenu_OpBasicas : Form
    {
        public Submenu_OpBasicas()
        {
            InitializeComponent();
            Combobox_1.SelectedIndex = 0;
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

        private void button_solve_Click(object sender, EventArgs e)
        {

            switch (Combobox_1.Text)
            {
                case "Herramientas":
                    label1.Text = "Selecciona herramienta!";
                    break;

                case "Suma/Resta":
                    string input = textBox_input.Text;
                    string input_parsed = input.Replace('+', '\n');
                    input_parsed = input_parsed.Replace('-', '\n');
                    //Expression is mxparser type
                    Expression calculo = new Expression(input);

                    label1.Text = string.Concat(input_parsed, "\n--------\n", (calculo.calculate().ToString()));
                    break;
            }
        }
    }
}
