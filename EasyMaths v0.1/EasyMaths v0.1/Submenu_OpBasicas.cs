using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Combobox_1.Text != "Herramientas")
                label1.Text = "Introduce operación";
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            string input = textBox_input.Text;
            int cont = 1;
            string input_parsed;
            Expression calculo;

            switch (Combobox_1.Text)
            {
                case "Suma/Resta":
                    /*Implementación inicial
                     input = textBox_input.Text;
                     cont = 1;

                    for(int i=0; i < input.Length; i++)
                    {
                        if (input.Substring(i, 1) == "+" || input.Substring(i, 1) == "-") cont++;

                    }
                    label1.Font = new Font("Calibri", 96/cont, FontStyle.Regular, GraphicsUnit.Pixel);
                     input_parsed = input.Replace('+', '\n');
                    input_parsed = input_parsed.Replace('-', '\n');
                    //Expression is mxparser type
                     calculo = new Expression(input);

                    label1.Text = string.Concat(input_parsed, "\n--------\n", (calculo.calculate().ToString()));
                    break;
                    */
                    //Nueva implementación 
                    input = textBox_input.Text;
                    cont = 1;
                    int inicio = 0;
                    ArrayList operandoreal, operandodecimal;
                    operandoreal = new ArrayList();
                    operandodecimal = new ArrayList();
                    bool deci = false;
                    int i ;
                    for ( i=0; i < input.Length; i++)
                    {   if (input.Substring(i, 1) == "+" || input.Substring(i, 1) == "-" || input.Substring(i, 1) == ".")
                        {   
                            if(input.Substring(i, 1) == ".")
                            {
                                operandoreal.Add(input.Substring(inicio, (i - inicio) - 1));
                                deci = true;
                            }
                            else if (input.Substring(i, 1) == "+" || input.Substring(i, 1) == "-")
                            {
                                cont++;
                                if (deci) {
                                    operandodecimal.Add(input.Substring(inicio, (i - inicio) - 1));
                                    deci = false;
                                }
                            }
                            inicio = i+1;
                        }
                       
                    }
                    if (deci)
                    {
                        operandodecimal.Add(input.Substring(inicio, (i - inicio)));
                    }

                    String muestrareal, muestradecimal;

                    for(int j=0;j< operandoreal.Count; j++)
                    {   

                    }
                    for (int j = 0; j < operandodecimal.Count; j++)
                    {

                    }
                    break;

                case "Multiplicación":
                    input = textBox_input.Text;
                    cont = 1;
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input.Substring(i, 1) == "*" ) cont++;
                    }
                    label1.Font = new Font("Calibri", 96 / cont, FontStyle.Regular, GraphicsUnit.Pixel);
                    input_parsed = input.Replace('*', '\n');
                    input_parsed = input_parsed.Replace('x', '\n');

                    //Expression is mxparser type
                    calculo = new Expression(input);

                    label1.Text = string.Concat(input_parsed, "\n--------\n", (calculo.calculate().ToString()));
                    break;

            }
        }

        private void Submenu_OpBasicas_Load(object sender, EventArgs e)
        {

        }
    }
}
