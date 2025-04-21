using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_De_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();

            while (CadastroUsarios.UsuarioLogado == null)
            {
                Visible = false;
                f.ShowDialog();

                if (FormLogin.cancelar == true)
                {
                    Application.Exit();
                    return;
                }
            }

            lblBoas_Vindas.Text = $"Bem Vindo(a)\n {CadastroUsarios.UsuarioLogado.Nome}";
            Visible = true;
        }
    }
}
