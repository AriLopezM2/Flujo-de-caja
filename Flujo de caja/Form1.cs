using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flujo_de_caja
{
    public partial class Form1 : Form
    {
        public int Ingreso = 0, Egreso =0 , cambio=0;
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            
            if (maskedIngreso.Text == "") 
            {
                MessageBox.Show("Ingresar los ingresos para calcular");
            }
            else 
            {
                
                Ingreso = Convert.ToInt32(maskedIngreso.Text);
                label4.Text = Convert.ToString(Ingreso);
                maskedIngreso.Clear();
            }

            if(cambio > 0) 
            {
                cambio += Ingreso;
                label10.Text = cambio.ToString();
            }
           
           
           
       
        }

        private void btnEgreso_Click(object sender, EventArgs e)
        {

            if (maskedEgreso.Text == "")
            {
                MessageBox.Show("Ingresar los egresos para calcular");
            }
            else
            {

                Egreso = Convert.ToInt32(maskedEgreso.Text);
                label5.Text = Convert.ToString(Egreso);
                maskedEgreso.Clear();
            }

            if (cambio > 0)
            {
                cambio -= Egreso;
                label10.Text = cambio.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al programa de calculacion de flujo de caja");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            maskedIngreso.Clear();
            maskedEgreso.Clear();

            label4.Text= String.Empty;
            label5.Text= String.Empty;
            label9.Text= String.Empty;

            MessageBox.Show("Todos los valores han sido limpiados");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;
            

            if (Ingreso > 0 && Ingreso <= 1000000)
            {
                if (Ingreso > Egreso)
                {
                    resultado = Ingreso - Egreso;
                    cambio = resultado;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Text = cambio.ToString();
                    label9.Text = Convert.ToString(resultado);

                }
                else
                {
                    MessageBox.Show(" Los egresos no pueden ser mayores que los ingresos");
                    label9.Text = string.Empty; 
                    maskedIngreso.Clear();     
                    maskedEgreso.Clear();
                }
                
                
            }
            else 
            {
                MessageBox.Show(" No puede ser 0 o mayor que un millon");
                maskedIngreso.Clear();         
                maskedEgreso.Clear();


            }
           
            




        }
    }
}
