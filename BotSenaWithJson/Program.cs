using System;
using System.Net;
using Newtonsoft.Json;

namespace BotSenaWithJson
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

            string url = $@"URL do JSON";
            string json;

            using (WebClient client = new WebClient())
            {
                client.Headers["Cookie"] = "security=true";
                json = client.DownloadString(url);
            }

            Resultado ResultadoDaMegaSena = JsonConvert.DeserializeObject<Resultado>(json);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
