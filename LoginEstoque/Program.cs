using System;
using System.Globalization;
using System.IO;
using LoginEstoque.Entities;

namespace LoginEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string caminho = @"C:\Windows\Temp\estoque.txt";
                Console.Write("Insira seu usuário: "); //Solicita credenciais
                string usuario = Console.ReadLine();
                Console.Write("Insira sua senha: ");
                int senha = int.Parse(Console.ReadLine());
                if (usuario == "Gustavo" && senha == 1234) //Verifica
                {
                    Console.WriteLine("Você está logado " + usuario); //Login autorizado
                    Console.WriteLine("");
                    Console.WriteLine("Qual função você deseja? (1/2/3)");
                    Console.WriteLine("1 - Adicionar, 2 - mostrar e 3 - remover.");
                    int func = int.Parse(Console.ReadLine());
                    if (func == 1)
                    {
                        StreamWriter func1;
                        func1 = File.CreateText(caminho);
                        Console.Write("Quantos dispositivos você quer adicionar? ");
                        int n = int.Parse(Console.ReadLine());
                        func1.WriteLine("Empresa fictícia, CNPJ:00.000.000/0001-00");
                        func1.WriteLine("");
                        for (int i = 0; i < n; i++)
                        {
                            string[] disp = Console.ReadLine().Split(',');
                            string nome = disp[0];
                            double preco = double.Parse(disp[1], CultureInfo.InvariantCulture);
                            int quantidade = int.Parse(disp[2]);
                            Produto produto = new Produto(nome, preco, quantidade);
                            func1.WriteLine(produto.Nome + "," + produto.Total().ToString("F2", CultureInfo.InvariantCulture)); //Escreve no arquivo de saída os dados
                        }
                        func1.Close();

                    }
                    else if (func == 2)
                    {
                        StreamReader func2;
                        func2 = File.OpenText(caminho);
                        string[] linhas = File.ReadAllLines(caminho); //Separa os dados em vetores
                        foreach (string linha in linhas) //Le e imprime cada vetor
                        {
                            Console.WriteLine(linha);
                        }
                        func2.Close();
                    }
                    else if (func == 3)
                    {
                        Console.WriteLine("ATENÇÃO");
                        Console.WriteLine("DIGITAR SIM NA PRÓXIMA LINHA FARÁ COM QUE TODO O ARQUIVO SEJA APAGADO.");
                        Console.WriteLine("VOCÊ TEM CERTEZA?");
                        string pergunta = Console.ReadLine();
                        if (pergunta == "SIM" || pergunta == "sim")
                        {
                            File.Delete(caminho);
                            Console.WriteLine("Arquivo apagado. " + "Caminho: " + caminho);
                        }
                        else
                        {
                            Console.WriteLine("O arquivo não foi apagado.");
                        }

                        Console.WriteLine("");

                        string caminho1 = @"C:\Windows\Temp\estoqueAtualizado.txt";
                        File.Copy(caminho, caminho1);
                        Console.WriteLine("Qual produto deve ser apagado? ");
                        string apagar = Console.ReadLine();

                        string line = null;
                        string line_to_delete = apagar;

                        using (StreamReader reader = new StreamReader(caminho))
                        {
                            using (StreamWriter writer = new StreamWriter(caminho1))
                            {
                                while ((line = reader.ReadLine()) != null)
                                {
                                    if (String.Compare(line, line_to_delete) == 0)
                                        continue;

                                    writer.WriteLine(line);
                                }
                            }
                        }

                    }
                    Console.WriteLine("");
                    Console.WriteLine("Sistema de estoque encerrado.");
                    Console.WriteLine("");
                    Console.WriteLine("Você deseja iniciar novamente o programa? (SIM/NÃO)");
                    string confsn = Console.ReadLine();
                    if (confsn == "sim" || confsn == "SIM")
                    {
                        Console.WriteLine("Reiniciando programa.");
                        Main(args);
                    }
                    Console.WriteLine("Encerrando programa. ");
                }
                else
                {
                    Console.WriteLine("O usuário/senha inserido está incorreto, encerrando programa. "); //Login recusado
                    StreamWriter x; //Inicia escrita em arquivo
                    string erro = @"C:\Windows\Temp\erro1.txt"; //Define o caminho e o nome do arquivo
                    x = File.CreateText(erro); //Cria o arquivo no caminho especificado
                    x.WriteLine("Erro 1");
                    x.WriteLine("");
                    x.WriteLine("Erro causado devido a inserção de credenciais inválidas.");
                    x.WriteLine("Credenciais inseridas:");
                    x.WriteLine("Usuário: " + usuario + ", Senha: " + senha);
                    x.WriteLine("Solução: " + "Abrir novamente o programa e inserir a credencial correta."); //Adiciona informações do erro
                    x.Close(); //Encerra o arquivo
                    Console.WriteLine("Para consultar o erro, verifique o arquivo debug.");
                    Console.ReadKey();
                    Environment.Exit(1); //Encerra o programa com um código de erro
                }


                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro!");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
