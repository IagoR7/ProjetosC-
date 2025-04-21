using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokenPO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnpedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnpapel_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void btntesoura_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void StartGame(int opcao)
        {
            lblresultado.Visible = false;
            Game Jogo = new Game();

            switch (Jogo.jogar(opcao))
            {
                case Game.Resultado.Ganhar:
                    pictResul.BackgroundImage = Image.FromFile("imagens/Ganhar.png");
                    goto default;
                case Game.Resultado.Perder:
                    pictResul.BackgroundImage = Image.FromFile("imagens/Perder.png");
                    goto default;
                case Game.Resultado.Empatar:
                    pictResul.BackgroundImage = Image.FromFile("imagens/Empatar.png");
                    goto default;
                default:
                    pictureBox1.Image = Jogo.imgjogador;
                    pictureBox2.Image = Jogo.imgPC;
                    break;
            }
        }
    }
}
