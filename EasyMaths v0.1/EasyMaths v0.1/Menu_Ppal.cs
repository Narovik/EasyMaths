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
    public partial class Menu_Ppal : Form
    {
        private int id_menu = 0;//1-aritmetica 2-algebra 3-geometria 4-calculo 5-estadistica 6-trigonometria
        public Menu_Ppal()
        {
            InitializeComponent();
            int x = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            int y = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            this.ClientSize = new System.Drawing.Size(x, y);
            double X=  1.5*(x / 800);
            double Y = 1.5*(y / 600);
            this.picture1.Location = new System.Drawing.Point((int)(30*X), (int)(154*Y));
            this.picture1.Size = new System.Drawing.Size((int)(239 * X), (int)(156 * Y));

            this.picture2.Location = new System.Drawing.Point((int)(277 * X), (int)(154 * Y));
            this.picture2.Size = new System.Drawing.Size((int)(239 * X), (int)(156 * Y));

            this.picture3.Location = new System.Drawing.Point((int)(523 * X), (int)(154 * Y));
            this.picture3.Size = new System.Drawing.Size((int)(239 * X), (int)(156 * Y));

            this.picture4.Location = new System.Drawing.Point((int)(147 * X), (int)(319 * Y));
            this.picture4.Size = new System.Drawing.Size((int)(239 * X), (int)(155 * Y));

            this.picture5.Location = new System.Drawing.Point((int)(394 * X), (int)(318 * Y));
            this.picture5.Size = new System.Drawing.Size((int)(239 * X), (int)(156 * Y));
        }

        private void button_aritmetica_Click(object sender, EventArgs e)
        {
            picture1.Visible = true;
            picture2.Visible = true;
            picture3.Visible = true;
            picture4.Visible = true;
            picture5.Visible = true;
            id_menu = 1;
        }

        private void button_estadistica_Click(object sender, EventArgs e)
        {
            picture1.Visible = true;
            picture2.Visible = false;
            picture3.Visible = false;
            picture4.Visible = false;
            picture5.Visible = false;
            id_menu = 5;
        }

        private void button_calculo_Click(object sender, EventArgs e)
        {
            picture1.Visible = true;
            picture2.Visible = true;
            picture3.Visible = false;
            picture4.Visible = false;
            picture5.Visible = false;
            id_menu = 4;
        }

        private void button_geometria_Click(object sender, EventArgs e)
        {
            picture1.Visible = true;
            picture2.Visible = true;
            picture3.Visible = true;
            picture4.Visible = true;
            picture5.Visible = true;
            id_menu = 3;
        }

        private void button_algebra_Click(object sender, EventArgs e)
        {
            picture1.Visible = true;
            picture2.Visible = true;
            picture3.Visible = false;
            picture4.Visible = true;
            picture5.Visible = true;
            id_menu = 2;
        }

        private void button_trigonometria_Click(object sender, EventArgs e)
        {
            picture1.Visible = true;
            picture2.Visible = true;
            picture3.Visible = false;
            picture4.Visible = false;
            picture5.Visible = false;
            id_menu = 6;
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(null,"Desea salir de EasyMaths?","Salir",MessageBoxButtons.YesNo)==DialogResult.Yes){
                this.Close();
            }
        }

        private void picture2_Click(object sender, EventArgs e)
        {

        }

        private void picture1_Click(object sender, EventArgs e)
        {
            switch(id_menu)
            {
                case 1:
                    Aritmetica_op op = new Aritmetica_op();
                    op.Show();
                    break;
                
            }
        }

        private void picture3_Click(object sender, EventArgs e)
        {

        }

        private void picture4_Click(object sender, EventArgs e)
        {

        }

        private void picture5_Click(object sender, EventArgs e)
        {

        }

        private void button_inicio_Click(object sender, EventArgs e)
        {
            picture1.Visible = false;
            picture2.Visible = false;
            picture3.Visible = false;
            picture4.Visible = false;
            picture5.Visible = false;
        }

        private void button_contacta_Click(object sender, EventArgs e)
        {
            contacto ventana = new contacto();
            ventana.Show();
        }

        private void Menu_Ppal_Load(object sender, EventArgs e)
        {

        }

        private void button_aritmetica_Resize(object sender, EventArgs e)
        {

        }

        private void Menu_Ppal_Resize(object sender, EventArgs e)
        {
            

        }
    }
}
