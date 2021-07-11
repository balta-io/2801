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
            Aula1();
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
            Console.WriteLine("string.CompareTo(Object/String)");
            // Documentação
            // https://docs.microsoft.com/pt-br/dotnet/api/system.string.compareto?view=net-5.0
            // Retornos 
            //  -> 0 string passada por parâmetro tem a mesma classificação que a comparada.
            //  -> 1 string passada por parâmetro precede a comparada na classificação.
            //  -> -1 string passada por parâmetro vem depois da comparada na classificação.
            var texto = "Testando";
            Console.WriteLine("var texto = Testando");
            Console.WriteLine($"texto.CompareTo(\"Testando\") Retorno -> {texto.CompareTo("Testando")} (\"Testando\" mesma classificação que \"{texto}\" em ordem alfabética)\n"); 
            Console.WriteLine($"texto.CompareTo(\"testando\") Retorno -> {texto.CompareTo("testando")} (\"testando\" precede \"{texto}\" em ordem alfabética)\n"); // Retorna 1 - 'testando' precede var texto.
            Console.WriteLine($"texto.CompareTo(\"\") Retorno -> {texto.CompareTo("")} (\"\" precede \"{texto}\" em ordem alfabética)\n"); // Retorna 1 - "" precede var texto.
            Console.WriteLine($"texto.CompareTo(null) Retorno -> {texto.CompareTo(null)} (null precede \"{texto}\" em ordem alfabética)\n"); // Retorna 1 - null precede var texto.
            Console.WriteLine($"\"b\".CompareTo(\"a\") Retorno -> {"b".CompareTo("a")} (\"a\" precede \"b\" em ordem alfabética)\n"); // Retorna 1 - null precede var texto.
            Console.WriteLine($"\"a\".CompareTo(\"b\") Retorno -> {"a".CompareTo("b")} (\"b\" sucede \"a\" em ordem alfabética\n");
            Console.WriteLine("Deseja usar mais comparações?");
            Console.WriteLine("[1] Sim.\n[2] Não.");
            string resposta = Console.ReadLine();
            if(resposta == "1"){
                Console.Write("String base -> ");
                string stringBase = Console.ReadLine();
                Console.Write("String parâmetro -> ");
                string stringParametro = Console.ReadLine();
                CompareTo(stringBase,stringParametro);
            }
            static void CompareTo(string stringBase, string stringParametro){
                int resultado = stringBase.CompareTo(stringParametro);
                if(resultado == 0){
                    Console.WriteLine("A String passada por parâmetro tem a mesma classificação que a comparada.");
                }
                else if(resultado < 0){
                    Console.WriteLine("A String passada por parâmetro sucede na classificação a String comparada.");
                }
                else{
                    Console.WriteLine("A String passada por paraâmetro precede na classificação a string comparada.");
                }
            }
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
