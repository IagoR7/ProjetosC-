using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JokenPO
{
    internal class Game
    {
        public enum Resultado
        {
            Ganhar, Perder , Empatar
        }
        public static Image[] imagens =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Papel.png")
        };

        public Image imgPC { get; private set; }
        public Image imgjogador { get; private set; }

        public Resultado jogar (int jogador)
        {
            int PC = JogadaPC();

            imgjogador = imagens[jogador];
            imgPC = imagens[PC];

            if (jogador == PC)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 0 && PC == 1) || (jogador == 1 && PC == 2) || (jogador == 2 && PC == 0))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }

            return Resultado.Empatar;
        }
   
        private int JogadaPC()
        {
            int mill = DateTime.Now.Millisecond;

            if (mill < 333)
            {
                return  0;
            }
            else if (mill >= 333 && mill < 667)
            {
                return 1;
            }
            else
            {
                return 2; 
            }
        }
    }
}
