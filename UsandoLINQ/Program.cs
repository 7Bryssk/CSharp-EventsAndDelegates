using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = CarregarListaPessoas();

            // + de 2 imrão
            IEnumerable<Pessoa> consulta1 = from pessoa in pessoas
                                            where pessoa.irmaos > 2
                                            select pessoa;

            foreach (Pessoa p in consulta1)
            {
                Console.WriteLine("{0}, {1}, {2}", p.nome, p.idade, p.irmaos);
            }

            // - de 30 anos
            var consulta2 = from pessoa in pessoas
                                            where pessoa.idade < 30
                                            orderby pessoa.idade descending
                                            select new { pessoa.nome, pessoa.idade };

            foreach (var p in consulta2)
            {
                Console.WriteLine("{0}, {1}", p.nome, p.idade);
            }

            // + de 2 imaos mais correto
            IEnumerable<Pessoa> consulta3 = pessoas.Where(p => p.irmaos > 2);
            foreach (Pessoa p in consulta3)
            {
                Console.WriteLine("{0}, {1}, {2}", p.nome, p.idade, p.irmaos);
            }

            // - de 30 anos mais correto
            var consulta4 = pessoas.Where(p => p.idade < 30)
                .OrderByDescending(o => o.nome.Length)
                .ThenBy(i => i.idade)
                .Select(pe => new { pe.nome, pe.idade });

            foreach (var p in consulta4)
            {
                Console.WriteLine("{0}, {1}", p.nome, p.idade);
            }

            Console.ReadKey();
        }

        static List<Pessoa> CarregarListaPessoas()
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa
            {
                nome = "João",
                idade = 15,
                irmaos = 2
            });
            pessoas.Add(new Pessoa
            {
                nome = "Augusto",
                idade = 25,
                irmaos = 4
            });
            pessoas.Add(new Pessoa
            {
                nome = "Antonio",
                idade = 35,
                irmaos = 8
            });

            return pessoas;
        }
    }
}
