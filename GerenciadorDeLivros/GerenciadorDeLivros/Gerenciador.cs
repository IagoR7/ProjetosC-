using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeLivros
{
    internal class Gerenciador
    {
        
        public Dictionary<string, List<string>> livrosdisp = new Dictionary<string, List<string>>()
        {
            { "machado de assis", new List<string> { "Memórias Póstumas de Brás Cubas\r\n", "O espelho" } },
            { "Miguel de Cervantes", new List<string> { "Dom Quixote de la Mancha" } },
            { "Guilthy333", new List<string> { "Escravo Das Sombras" } }
        };

        public void Adicionar(string autor, string livro)
        {
            if (!livrosdisp.ContainsKey(autor))
            {
                livrosdisp[autor] = new List<string>();
            }

            livrosdisp[autor].Add(livro);
        }
        public void Remover(string autor, string livro)
        {
            if (livrosdisp.ContainsKey(autor))
            {
                livrosdisp[autor].Remove(livro);

                if (livrosdisp[autor].Count == 0)
                {
                    livrosdisp.Remove(autor);
                }
            }
        }
        public void Procurar(string livro)
        {
            foreach (var listaLivros in livrosdisp.Values)
            {
                if (listaLivros.Contains(livro))
                {
                    Console.WriteLine("Possuimos o Livro");
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Não possuimos o livro");
                    break;
                }
            }

        }
    }
}
