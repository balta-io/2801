using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Aula15();
        }

        static void Aula0()
        {
            var texto = "Testando " + " ";
            var texto2 = $"Testando {texto}";
            var texto3 = $"Testando {1 + 1}";
            var texto4 = @"\Testando \\";
            Console.WriteLine(texto);
            Console.WriteLine(texto2);
            Console.WriteLine(texto3);
            Console.WriteLine(texto4);
        }

        static void Aula1()
        {
            var texto = "Testando";
            Console.WriteLine(texto.CompareTo("Testando")); // Retorna 1 - Verdadeiro
            Console.WriteLine(texto.CompareTo("testando")); // Retorna 0
            Console.WriteLine(texto.CompareTo("")); // Retorna 0
            Console.WriteLine(texto.CompareTo(null)); // Retorna 0
        }

        static void Aula2()
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Contains("teste")); // true
            Console.WriteLine(texto.Contains("Teste")); // false
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // true
            // Console.WriteLine(texto.Contains(null)); // ERRO
        }

        static void Aula3()
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.StartsWith("Este")); // true
            Console.WriteLine(texto.StartsWith("este")); // false
            Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // true

            Console.WriteLine(texto.EndsWith("Teste")); // false
            Console.WriteLine(texto.EndsWith("teste")); // true
            Console.WriteLine(texto.EndsWith("teste", StringComparison.OrdinalIgnoreCase)); // true
        }

        static void Aula4()
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Equals("Este é um texto de teste")); // true
            Console.WriteLine(texto.Equals("este é um texto de teste")); // false
            Console.WriteLine(texto.Equals("este é um texto de teste", StringComparison.OrdinalIgnoreCase)); // true
        }

        static void Aula5()
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.IndexOf("é"));
            Console.WriteLine(texto.LastIndexOf("s"));
        }

        static void Aula6()
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.ToLower());
            Console.WriteLine(texto.ToUpper());
        }

        static void Aula7()
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Insert(5, "AQUI "));
        }

        static void Aula8()
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Length);
        }

        static void Aula9()
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Remove(0, 5));
        }

        static void Aula10()
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Replace("Este", "Isto"));
            Console.WriteLine(texto.Replace("texto", "exemplo"));
        }

        static void Aula11()
        {
            var texto = "Este é um texto, de teste";
            var divisao = texto.Split(',');
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            // Console.WriteLine(divisao[2]); // ERRO
        }

        static void Aula12()
        {
            var texto = "Este é um texto de teste";
            Console.WriteLine(texto.Substring(0, 5));
            Console.WriteLine(texto.Substring(texto.LastIndexOf(" ") + 1, 5));
        }

        static void Aula13()
        {
            var texto = "Este é           um texto de teste";
            Console.WriteLine(texto.Trim());

            texto = "       Este é um texto de teste             ";
            Console.WriteLine(texto.Trim());
        }

        static void Aula14()
        {
            var texto = new StringBuilder();
            texto.Append("Este");
            texto.Append("é");
            texto.Append("um");
            texto.Append(Environment.NewLine);
            texto.Append("texto");
            Console.WriteLine(texto.ToString());
        }

        static void Aula15()
        {
            // https://regexr.com/
            var regex = new Regex(@"([0-9])\w+");
            Console.WriteLine(regex.IsMatch("Este é um texto de teste"));
            Console.WriteLine(regex.IsMatch("Este 25 um texto de teste"));
        }

        static void Aula16()
        {
            Console.WriteLine(
                string.Compare(
                    "texto",
                    "texto"));

            Console.WriteLine(
                string.Compare(
                    "Isto é um texto",
                    "Isto e um texto",
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreNonSpace));

            Console.WriteLine(
                string.Compare(
                    "Isto é um texto",
                    "isto e um texto",
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreNonSpace));

            Console.WriteLine(
                string.Compare(
                    "Isto é um texto",
                    "isto e um texto",
                    CultureInfo.CurrentCulture,
                    CompareOptions.IgnoreSymbols));
        }
    }
}
