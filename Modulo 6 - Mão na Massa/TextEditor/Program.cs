using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo");
            Console.WriteLine("2 - Criar novo arquivo");
            Console.WriteLine("0 - Sair");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: AbrirArquivo(); break;
                case 2: EditorMode(); break;
                default: Menu(); break;
            }
        }

        public static void AbrirArquivo()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string filePath = Console.ReadLine();

            using (var file = new StreamReader(filePath))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
        }

        public static void EditorMode()
        {
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo (ESC para sair)");
            Console.WriteLine("-----------------------");
            string text = "";
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);


            SaveFile(text);
        }

        public static void SaveFile(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Menu();
        }
    }
}
