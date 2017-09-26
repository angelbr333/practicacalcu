using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadora
{
    public partial class MainPage : ContentPage
    {

        float variable1;
        float variable2;
        string borrado;
        string operacion;
        float resultado;
        bool secuencia, punto=true;
        
        public MainPage(
            )
        {
            InitializeComponent();
        }

        private void ce_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "Ce";
        }
        private void c_Clicked(object sender, EventArgs e)
        {
            //caja.Text = caja.Text + "C";
            caja.Text = "";
            variable1 = 0;
            variable2 = 0;
            resultado =0;
        }
        private void borrar_clicked(object sender, EventArgs e)
        {
            //caja.Text = caja.Text + "0";
            int x = 0;
            borrado = caja.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            caja.Text = borrado;
            if (caja.Text == "")
            {
                caja.Text = "0";
                secuencia = true;
            }
            if (caja.Text == "-")
            {
                caja.Text = "0";
                secuencia = true;
            }
        }
        private void sqrt_Clicked(object sender, EventArgs e)
        {
            //caja.Text = caja.Text + "√";
          
              
        }
        private void potencia_Clicked(object sender, EventArgs e)
        {
            //caja.Text = caja.Text + "㎡";
            variable1 = float.Parse(caja.Text);
            resultado = variable1 * variable1;
            caja.Text = resultado.ToString();
        }
        private void porcentaje_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "%";
        }
        private void divicion_Clicked(object sender, EventArgs e)
        {
            if(caja2.Text != "")
                {
                caja2.Text = "/";
            }
            else
            {
                caja2.Text = "/";
            }
            if(caja.Text !="")
            {
                caja3.Text = caja.Text;
                caja.Text = "";
            }
        }
        private void siete_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "7";
        }
        private void ocho_clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "8";
        }
        private void nueve_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "9";
        }
        private void resta_Clicked(object sender, EventArgs e)
        {
            if(caja2.Text != "")
            {
                caja2.Text = "-";
            }
            else
            {
                caja2.Text = "-";
            }
            if(caja2.Text != "")
            {
                caja3.Text = caja.Text;
                caja.Text = "";
            }
        }
        private void cuatro_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "4";
        }
        private void cinco_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "5";
        }
        private void seis_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "6";
        }
        private void suma_Clicked(object sender, EventArgs e)
        {
            if(caja2.Text != "")
            {
                caja2.Text = "+";
            }
            else
            {
                caja2.Text = "+";
            }
            if(caja2.Text != "")
            {
                caja3.Text = caja.Text;
                caja.Text = "";
            }
        }
        private void uno_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "1";
        }
        private void dos_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "2";
        }
        private void tres_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "3";
        }
        private void multip_Clicked(object sender, EventArgs e)
        {
            //caja.Text = caja.Text + "*";
            if (caja2.Text != "")
            {
                caja2.Text = "*";
            }
            else
            {
                caja2.Text = "*";
            }
            if (caja.Text != "")
            {
                caja3.Text = caja.Text;
                caja.Text = "";
            }
        }
        private void cero_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "0";
        }
        private void punto_Clicked(object sender, EventArgs e)
        {
            //caja.Text = caja.Text + ".";
            if (punto == true)
            {
                caja.Text = caja.Text + ".";
                punto = false;
            }
            else
            {
                return;
            }
        }
        private void exp_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "e";
        }
        private void igual_Clicked(object sender, EventArgs e)
        {
            if (caja2.Text == "*")
            {
                variable1 = float.Parse(caja3.Text);
                variable2 = float.Parse(caja.Text);
                resultado = variable1 * variable2;
                caja3.Text = resultado.ToString();

            }
            if (caja2.Text == "/")
            {
                variable1 = float.Parse(caja3.Text);
                variable2 = float.Parse(caja.Text);
                resultado = variable1 / variable2;
                caja3.Text = resultado.ToString();
            }
            if (caja2.Text == "+")
            {
                variable1 = float.Parse(caja3.Text);
                variable2 = float.Parse(caja.Text);
                resultado = variable1 + variable2;
                caja3.Text = resultado.ToString();
            }
            if (caja2.Text == "-")
            {
                variable1 = float.Parse(caja3.Text);
                variable2 = float.Parse(caja.Text);
                resultado = variable1 - variable2;
                caja3.Text = resultado.ToString();
            }

        }


    
        
    }
}
