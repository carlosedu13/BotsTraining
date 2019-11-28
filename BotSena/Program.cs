using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Linq;

namespace BotSena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o número do concurso: ");
            string numeroDoConcurso = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(numeroDoConcurso))
            {
                numeroDoConcurso = "2103";
            }

            string url = $@"http://www1.caixa.gov.br/loterias/megasena/megasena_pesquisa_new.asp?submeteu=sim&opcao=concurso&txtConcurso={numeroDoConcurso}";
            string html;

            using (WebClient client = new WebClient())
            {
                client.Headers["Cookie"] = "security=true";
                html = client.DownloadString(url);
            }

            html = html.Replace("<span class=\"num_sorteio\"><ul>", "");
            html = html.Replace("</ul></span>", "");
            html = html.Replace("</li>", "");

            string[] vetor = Regex.Split(html, "<li>");
            List<int> resultado = new List<int>();

            resultado.Add(int.Parse(vetor[1]));
            resultado.Add(int.Parse(vetor[2]));
            resultado.Add(int.Parse(vetor[3]));
            resultado.Add(int.Parse(vetor[4]));
            resultado.Add(int.Parse(vetor[5]));
            resultado.Add(int.Parse(vetor[6].Substring(0, 2)));

            Console.WriteLine($"O Concurso selecionado foi: {numeroDoConcurso}");
            Console.WriteLine("Os resultados foram: ");
            resultado.OrderBy(x => x).ToList().ForEach(num => {
                Console.WriteLine(num);
            });

            Console.ReadKey();
        }
    }
}
