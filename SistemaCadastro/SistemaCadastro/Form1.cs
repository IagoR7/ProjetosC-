using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form

    {
        List<Pessoa> pessoas;
        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            txtcivil.Items.Add("Casado");
            txtcivil.Items.Add("Solteiro");
            txtcivil.Items.Add("Viuvo");
            txtcivil.Items.Add("Separado");

            txtcivil.SelectedIndex = 0;
        }

       

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int index =  - 1;

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == txtnome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }

            if (txtnome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome. ");
                txtnome.Focus();
                return;
            }

            if (txttelefone.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo Telefone. ");
                txttelefone.Focus();
                return;
            }

            char sexo;

            if (radiomasc.Checked)
            {
                sexo = 'M';
            }
            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            Pessoa p = new Pessoa();
            p.Nome = txtnome.Text;
            p.DataNascimento = txtnasc.Text;
            p.EstadoCivil = txtcivil.SelectedItem.ToString();
            p.Telefone = txttelefone.Text;
            p.CasaPropia = checkcasa.Checked;
            p.Veiculo = checkveiculo.Checked;
            p.Sexo = sexo;

            if (index < 0)

            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }

            btnlimpar_Click(btnlimpar, EventArgs.Empty);
            Listar();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            int indice = lista.SelectedIndex;
            pessoas.RemoveAt(indice);
            Listar();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Text = "";
            txtnasc.Text = "";
            txtcivil.SelectedIndex = 0;
            txttelefone.Text = "";
            checkcasa.Checked = false;
            checkveiculo.Checked = false;
            radiomasc.Checked = true;
            radioF.Checked = false;
            radioO.Checked = false;
            txtnome.Focus();
        }

        private void Listar()
        {
            lista.Items.Clear();
            foreach (Pessoa p in pessoas)
            {
                lista.Items.Add(p.Nome);
            }
        }

        private void lista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indice = lista.SelectedIndex;
            Pessoa p = pessoas[indice];

            txtnome.Text = p.Nome;
            txtnasc.Text = p.DataNascimento;
            txtcivil.SelectedItem = p.EstadoCivil;
            txttelefone.Text= p.Telefone;
            checkcasa.Checked = p.CasaPropia;
            checkveiculo.Checked = p.Veiculo;

            switch (p.Sexo)
            {
                case 'M':
                    radiomasc.Checked = true;
                    break;
                case 'F':
                    radioF.Checked = true;
                    break;
                default:
                    radioO.Checked = true;
                    break;
            }
        }
    }
}
