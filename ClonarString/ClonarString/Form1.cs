using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClonarString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexecutar_Click(object sender, EventArgs e)
        {
            #region contains/Tostring
            /*string texto = "Este de Variavel é alfa numerica. ";
            if (texto.Contains("Var"))
            {
                label1.Text = "Contém";
            }
            else
            {
                label1.Text = "Não Contém";
            }*/

            /*int num = 5400;
            bool res = true;

            /*label1.Text = num.ToString();
            label1.Text = res.ToString();*/
            #endregion

            #region Toupper / Tolower
            /*string nome = "iago";

            nome = nome.ToUpper();
            string nomeMai = nome.ToUpper();
            string nomeMin = nome.ToLower();

            label1.Text = nome; */

            #endregion

            #region IndexOF
            //string nome = "iago ribeiro ";

            //int indice = nome.IndexOf('o');// primeira ocorrencia
            // int indice = nome.IndexOf('o',5);//vai percorrer a partir do
            // int indice = nome.IndexOf('o',5,4);//vai percorrer apenas 4 caracteres

            //int indice = nome.LastIndexOf('a');//ultima ocorrencia
            //label1.Text  = "Indice: " + indice;
            #endregion

            #region Insert / replace
            /* string nome = "Iago Ribeiro ";

             //string nomeFinal = nome.Insert(4, " Ribeiro ");
             //string nomeFinal = nome.Replace('o','X');
             string nomeFinal = nome.Replace("Ribeiro", "Santos");
             label1.Text = nomeFinal;*/
            #endregion

            #region Length / Substring 

            //string nome = "Iago Ribeiro";

            //int tamanho = nome.Length;
            //label1.Text = " o nome " + nome + " contem " + tamanho + " Letras";

            //for (int i = 0; i < nome.Length; i++)
            //{
            //    label1.Text += nome[i] + "\n";
            //}

            //string parte = nome.Substring(0, 4);
            //string parte = nome.Substring(5);
            //string parte = nome.Substring(nome.IndexOf(" "));
            //label1.Text = parte;
            #endregion

            #region split
            /*string nomes = "Iago+_+Arthur+_+Sunny+_+Kimdokja";

            //char[] separador1 = { ' ', ' - ', ' _ ' }; 
            string[] separador2 = {"+_+"};
            //string[] resultado = nomes.Split(separador1);
            string[] resultado = nomes.Split(separador2, StringSplitOptions.None);

            foreach (string nome in resultado) {

                label1.Text += nome + "\n";
            }*/
            #endregion

            #region StartsWith / EndsWith
            /*string nome = "Iago";
            //bool res = nome.StartsWith("I");
            bool res = nome.StartsWith("i", StringComparison.OrdinalIgnoreCase);
            bool res = nome.EndsWith("GO", StringComparison.OrdinalIgnoreCase );

            if (res) 
            {
                label1.Text = "Positivo";
            }
            else
            {
                label1.Text = "Negativo";
            }*/

            #endregion

            #region Trim - TrimStart - TrimEnd
            //string mensagem = "      Olá Iago        ";

            //char[] c = { ' ' , '-' , '_', '+'};

            //string nova = mensagem.Trim(c);
            //mensagem.TrimStart()


            //label1.Text = ">" + mensagem.TrimEnd() + "<";



            #endregion

            #region CompareTo - Equals
            // fazer comparações entre as strings

            //string nome = "Iago";
            //string nome2 = "iago";
            /*if (nome.Equals(nome2, StringComparison.OrdinalIgnoreCase))
            {
                label1.Text = "positivo";
            }
            else
            {
                label1.Text = "Negativo";
            }*/

            //label1.Text = nome.CompareTo(nome2).ToString();//0 para igual, 1 para anterior, -1 para posterior



            #endregion

            #region Format
            decimal valor = 19.95m;

            //string s = String.Format("O valor do Produto é {0:C2}",valor);
            string s = String.Format($"Hoje é {DateTime.Now:D} e são {DateTime.Now:T} ");

            label1.Text = s;

            #endregion

        }
    }
}
