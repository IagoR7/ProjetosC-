using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace threadForms
{
    public partial class Form1 : Form
    {

        private delegate void  AtulizarControle(Control controle, string propriedade, object valor);

        Thread t;

        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;
        }

        private void btnprincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btncontador_Click(object sender, EventArgs e)
        {
            if (!t.IsAlive)
            {
                t.Start();
            }  
        }

        private void Tarefa()
        {
            while (true)
            {
                //lblresultado.Text = DateTime.Now.Second.ToString();
                //DefinirValorPropiedade(lblresultado, "Text", DateTime.Now.Second.ToString());
                lblresultado.Invoke(new Action(() => lblresultado.Text = DateTime.Now.Second.ToString()));
            }
            //DefinirValorPropiedade(lblresultado, "BackColor", Color.Red);
        }

        private void DefinirValorPropiedade(Control controle, string propriedade, object valor)
        {
            if (controle.InvokeRequired)
            {
                AtulizarControle d = new AtulizarControle(DefinirValorPropiedade);
                controle.Invoke(d, new object[]{controle, propriedade, valor });

            }
            else
            {
                Type t = controle.GetType();
                PropertyInfo[] props = t.GetProperties();

                foreach (PropertyInfo p in props)
                {
                    if (p.Name.ToUpper() == propriedade.ToUpper())
                    {
                        p.SetValue(controle, valor, null);
                    }
                }
            }
        }
    }
}
