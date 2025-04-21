using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularNumeros1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexecutar_Click(object sender, EventArgs e)
        {
            #region TryParse
            //int num1 = int.Parse("1700");
            //int num;
            //bool res = int.TryParse("1711WOW", out num);

            //if (int.TryParse("1711", out num))
            //{
            //lblresultado.Text = num.ToString();
            //}
            //else
            //{
            //lblresultado.Text = "Erro Na conversão";
            //}
            #endregion

            #region ToString
            //int num = 777;
            //lblresultado.Text = num.ToString("00000.00");
            //lblresultado.Text = num.ToString("#.00");

            //int num = 11;
            //lblresultado.Text = num.ToString("x");// hexadecimal
            //lblresultado.Text = num.ToString("x2");// hexadecimal min 2 digitos
            //lblresultado.Text = num.ToString("D");// decimal
            //lblresultado.Text = num.ToString("D5");// decimal min  5 digitos
            //lblresultado.Text = num.ToString("C");// Monetario
            //lblresultado.Text = Convert.ToString(num, 16);//base 16
            #endregion

            #region Math
            /*double pi  = Math.PI;
            double E = Math.E;
            double Seno = Math.Sin(3);
            double Conseno = Math.Cos(3);
            double Potencia = Math.Pow(3,2);
            double RaizQuadrada = Math.Sqrt(8);
            double arrendonda = Math.Round(12.17);
            double Inteiro = Math.Truncate(101.18);
            double Floor = Math.Floor(150.70); arrendonda para baixo
            double Ceil = Math.Ceiling(150.20); arredonda para cima


            lblresultado.Text = pi.ToString("#.00");*/

            #endregion
        }

    }
}
