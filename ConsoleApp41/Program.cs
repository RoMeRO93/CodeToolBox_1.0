using System;
using System.IO;

namespace CodeUtilityApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bun venit in aplicatia utilitara pentru cod!");

            while (true)
            {
                Console.WriteLine("\nAlegeti una dintre urmatoarele optiuni:");
                Console.WriteLine("1. Generati un nou fisier C#");
                Console.WriteLine("2. Deschideti un fisier C# existent");
                Console.WriteLine("3. Modificati un fisier C# existent");
                Console.WriteLine("4. Compilati si rulati un fisier C#");
                Console.WriteLine("5. Adaugati un sablon de cod");
                Console.WriteLine("6. Verificati sintaxa codului");
                Console.WriteLine("7. Formatati codul");
                Console.WriteLine("8. Gestionati structura de proiect");
                Console.WriteLine("9. Integrati cu sistemul de control al versiunilor");
                Console.WriteLine("10. Iesiti din aplicatie");

                Console.Write("Optiune: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    CreateNewFile();
                }
                else if (input == "2")
                {
                    OpenExistingFile();
                }
                else if (input == "3")
                {
                    ModifyExistingFile();
                }
                else if (input == "4")
                {
                    CompileAndRunFile();
                }
                else if (input == "5")
                {
                    AddCodeTemplate();
                }
                else if (input == "6")
                {
                    CheckSyntax();
                }
                else if (input == "7")
                {
                    FormatCode();
                }
                else if (input == "8")
                {
                    ManageProjectStructure();
                }
                else if (input == "9")
                {
                    IntegrateVersionControl();
                }
                else if (input == "10")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Optiune invalida. Va rugam sa introduceti un numar de optiune valid.");
                }
            }
        }

        static void CreateNewFile()
        {
            Console.Write("Introduceti numele fisierului (fara extensie): ");
            string fileName = Console.ReadLine();

            string filePath = $"{fileName}.cs";

            if (File.Exists(filePath))
            {
                Console.WriteLine($"Fisierul {fileName} exista deja.");
                return;
            }

            try
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    writer.WriteLine("using System;");
                    writer.WriteLine();
                    writer.WriteLine("namespace MyNamespace");
                    writer.WriteLine("{");
                    writer.WriteLine("\tclass MyClass");
                    writer.WriteLine("\t{");
                    writer.WriteLine("\t\tstatic void Main(string[] args)");
                    writer.WriteLine("\t\t{");
                    writer.WriteLine("\t\t\tConsole.WriteLine(\"Hello, world!\");");
                    writer.WriteLine("\t\t}");
                    writer.WriteLine("\t}");
                    writer.WriteLine("}");
                }

                Console.WriteLine($"Fisierul {fileName} a fost creat cu succes.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"A aparut o eroare la crearea fisierului: {ex.Message}");
            }
        }

        static void OpenExistingFile()
        {
            Console.Write("Introduceti calea fisierului: ");
            string filePath = Console.ReadLine();
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Fisierul {filePath} nu exista.");
                return;
            }

            try
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"A aparut o eroare la deschiderea fisierului: {ex.Message}");
            }
        }

        static void ModifyExistingFile()
        {
            Console.Write("Introduceti calea fisierului: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Fisierul {filePath} nu exista.");
                return;
            }

            try
            {
                Console.WriteLine("Introduceti noile linii de cod. Pentru a salva si a iesi, tastati 'exit' pe o linie noua.");

                using (StreamWriter writer = File.AppendText(filePath))
                {
                    string line;
                    while ((line = Console.ReadLine()) != "exit")
                    {
                        writer.WriteLine(line);
                    }
                }

                Console.WriteLine($"Fisierul {filePath} a fost modificat cu succes.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"A aparut o eroare la modificarea fisierului: {ex.Message}");
            }
        }

        static void CompileAndRunFile()
        {
            Console.Write("Introduceti calea fisierului: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Fisierul {filePath} nu exista.");
                return;
            }

            try
            {
                // TODO: Implementati logica de compilare si rulare a fisierului C#
                Console.WriteLine("Compilarea si rularea fisierului C# se afla in dezvoltare.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"A aparut o eroare la compilarea si rularea fisierului: {ex.Message}");
            }
        }

        static void AddCodeTemplate()
        {
            // TODO: Implementati logica de adaugare a unui sablon de cod
            Console.WriteLine("Adaugarea de sabloane de cod se afla in dezvoltare.");
        }

        static void CheckSyntax()
        {
            Console.Write("Introduceti calea fisierului: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Fisierul {filePath} nu exista.");
                return;
            }

            try
            {
                // TODO: Implementati logica de verificare a sintaxei fisierului C#
                Console.WriteLine("Verificarea sintaxei codului se afla in dezvoltare.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"A aparut o eroare la verificarea sintaxei fisierului: {ex.Message}");
            }
        }

        static void FormatCode()
        {
            Console.Write("Introduceti calea fisierului: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Fisierul {filePath} nu exista.");
                return;
            }

            try
            {
                // TODO: Implementati logica de formatare a codului din fisierul C#
                Console.WriteLine("Formatarea codului se afla in dezvoltare.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"A aparut o eroare la formatarea codului: {ex.Message}");
            }
        }

        static void ManageProjectStructure()
        {
            // TODO: Implementati logica de gestionare a structurii de proiect
            Console.WriteLine("Gestionarea structurii de proiect se afla in dezvoltare.");
        }

        static void IntegrateVersionControl()
        {
            // TODO: Implementati logica de integrare cu sistemul de control al versiunilor
            Console.WriteLine("Integrarea cu sistemul de control al versiunilor se afla in dezvoltare.");
        }
    }
}




