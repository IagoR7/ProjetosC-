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
    public partial class FormLogin : Form
    {
        public static bool cancelar = false;
        
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnsenha_Click(object sender, EventArgs e)
        {
            string nome = txtusario.Text;
            string senha = txtsenha.Text;
            if (CadastroUsarios.Login(nome,senha))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado! ");
                txtusario.Text = "";
                txtsenha.Text = "";
                txtusario.Focus();
                this.Close();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            cancelar = true;
            Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
