using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numero_may_men
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btncalcular_Click(object sender, EventArgs e)
        {

            string num1 = txtnumero1.Text, num2 = txtnumero2.Text;
           
            int numero1 = int.Parse(num1);
            int numero2 = int.Parse(num2);

            if (numero1 > numero2) {



                lbltotal.Text = numero1.ToString();
                lbltotal2.Text = numero2.ToString();
                lbltotal.Visible = true;
                lbltotal2.Visible = true;
                

            } else {

                if (numero2 > numero1) {

                    lbltotal.Text = numero2.ToString();
                    lbltotal2.Text = numero1.ToString();
                    lbltotal.Visible = true;
                    lbltotal2.Visible = true;


                }
                else {

                    lbltotal.Text = " Son iguales ";
                    lbltotal2.Text = " Son iguales ";
                    lbltotal.Visible = true;
                    lbltotal2.Visible = true;


                }


            }



        }
    }
}
