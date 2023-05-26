using System;
using System.Collections.Generic;
using System.Threading;
using System.Collections;

namespace MiniRedeSocial
{
    class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();
        static Usuario usuarioLogado;
        static Postagens postagens1;
        static ArrayList arrayList;

        static void Main(string[] args)
        {
            arrayList = new ArrayList();
            Console.Clear();
            bool sair = false;

            Postagens postagem1 = new Postagens("João", "Olá, mundo!");
            Postagens postagem2 = new Postagens("Maria", "Estou animada com o novo projeto.");
            Postagens postagem3 = new Postagens("Carlos", "Compartilhando uma foto incrível.");

            arrayList.Add(postagem1);
            arrayList.Add(postagem2);
            arrayList.Add(postagem3);

            while (!sair)
            {
                Menu.Draw();
                Console.SetCursorPosition(9, 2);
                Console.WriteLine("MENU PRINCIPAL");
                Console.SetCursorPosition(1, 4);
                Console.WriteLine("1. Cadastro");
                Console.SetCursorPosition(1, 5);
                Console.WriteLine("2. Login");
                Console.SetCursorPosition(1, 6);
                Console.WriteLine("3. Sair");
                Console.SetCursorPosition(1, 7);
                Console.WriteLine("Escolha uma opção: ");
                Console.SetCursorPosition(20, 7);
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RealizarCadastro();
                        break;
                    case "2":
                        RealizarLogin();
                        break;
                    case "3":
                        sair = true;
                        Console.WriteLine("Obrigado por utilizar a Mini Rede Social. Até mais!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void RealizarCadastro()
        {
            Menu.Draw();
            Console.SetCursorPosition(11, 2);
            Console.WriteLine("CADASTRA");
            Console.SetCursorPosition(9, 5);
            Console.WriteLine("Usuario: ");
            Console.SetCursorPosition(9, 7);
            Console.WriteLine("Senha: ");

            Console.SetCursorPosition(18, 5);
            string nomeUsuario = Console.ReadLine();

            Console.SetCursorPosition(16, 7);
            // Mascara senha 
            ConsoleKeyInfo key;
            string senha = string.Empty;
            do
            {
                key = Console.ReadKey(true);

                if (char.IsLetterOrDigit(key.KeyChar))
                {
                    senha += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter);

            Usuario usuario = new Usuario(nomeUsuario, senha);
            usuarios.Add(usuario);
            Console.Clear();
            Console.WriteLine("Usuário cadastrado com sucesso!");
            Thread.Sleep(1500);
            Console.WriteLine();
        }

        static void RealizarLogin()
        {
            Menu.DrawScreen();
            Console.SetCursorPosition(13, 2);
            Console.WriteLine("LOGIN");
            Console.SetCursorPosition(9, 5);
            Console.WriteLine("Usuario: ");
            Console.SetCursorPosition(9, 7);
            Console.WriteLine("Senha: ");
            Console.SetCursorPosition(18, 5);
            string nomeUsuario = Console.ReadLine();

            Console.SetCursorPosition(16, 7);
            //Mascara senha
            ConsoleKeyInfo key;
            string senha = string.Empty;
            do
            {
                key = Console.ReadKey(true);

                if (char.IsLetterOrDigit(key.KeyChar))
                {
                    senha += key.KeyChar;
                    Console.Write("*");
                }
            } while (key.Key != ConsoleKey.Enter);

            usuarioLogado = usuarios.Find(u => u.NomeUsuario == nomeUsuario && u.Senha == senha);

            if (usuarioLogado != null)
            {
                Console.Clear();
                Console.WriteLine($"Bem-vindo(a) a RedeCodeCeuma, {usuarioLogado.NomeUsuario}!");
                Thread.Sleep(1500);
                ExibirMenuSecundario();
            }
            else
            {
                Console.WriteLine("Nome de usuário ou senha inválidos.");
            }

            Console.WriteLine();
        }

        static void ExibirMenuSecundario()
        {
            Console.Clear();
            bool voltar = false;

            while (!voltar)
            {
                Menu.Draw();
                Console.SetCursorPosition(8, 2);
                Console.WriteLine("MENU SEGUNDÁRIO");
                Console.SetCursorPosition(1, 4);
                Console.WriteLine("1) Adicionar Postagem");
                Console.SetCursorPosition(1, 5);
                Console.WriteLine("2) Visualizar Postagens");
                Console.SetCursorPosition(1, 6);
                Console.WriteLine("3) Voltar");
                Console.SetCursorPosition(1, 7);
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        AdicionarPostagem();
                        break;
                    case "2":
                        VisualizarPostagens();
                        break;
                    case "3":
                        voltar = true;
                        usuarioLogado = null;
                        Console.WriteLine("Desconectado.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
        static void AdicionarPostagem()
        {
            Menu.Screen();
            Console.SetCursorPosition(7, 2);
            Console.WriteLine("Adicionar Postagem");
            Console.SetCursorPosition(1, 4);
            Console.Write("Digite o conteúdo da postagem: ");
            Console.SetCursorPosition(1, 5);
            string conteudo = Console.ReadLine();
            usuarioLogado.AdicionarPostagem(conteudo);

            Console.WriteLine("Postagem adicionada com sucesso!");
            Console.WriteLine();
        }

        static void VisualizarPostagens()
        {
            Menu.Screen();
            Console.SetCursorPosition(6, 4);
            Console.WriteLine("Postagens do Usuário");
            if (usuarioLogado.Postagens.Count == 0)
            {
                Console.SetCursorPosition(1, 4);
                Console.WriteLine("Nenhuma postagem encontrada.");
                Console.ReadLine();
            }
            else
            {
                foreach (Postagens postagens in usuarioLogado.Postagens)
                {
                    Console.WriteLine($"{postagens.Autor}: {postagens.Conteudo}");

                }
            }
            Console.ReadLine();
        }
    }
}