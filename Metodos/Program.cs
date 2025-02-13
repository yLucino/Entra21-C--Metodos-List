using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static List<List<string>> playlists  = new List<List<string>>();
        static List<string> namePlalists = new List<string>();

        static void Main(string[] args)
        {
            playlists.Add(new List<string>());
            playlists.Add(new List<string>());
            playlists.Add(new List<string>());
            namePlalists.Add("Pop");
            namePlalists.Add("Rock");
            namePlalists.Add("Rap");


            while (true)
            {
                Console.WriteLine("--------- Menu ----------");
                Console.WriteLine("( 1 ) - Cadastrar música.");
                Console.WriteLine("( 2 ) - Ver músicas cadastradas.");
                Console.WriteLine("( 3 ) - Editar música.");
                Console.WriteLine("( 4 ) - Remover música.");
                Console.WriteLine("( 5 ) - Cadastrar PlayList.");
                Console.WriteLine("( 6 ) - Ver as PlayLists.");
                Console.WriteLine("( 7 ) - Remover PlayLists.");
                Console.WriteLine("( 8 ) - Editar PlayLists.");
                Console.WriteLine("( 0 ) - Sair.");
                Console.WriteLine("--------- **** ----------\n");

                Console.Write("Digite sua opção: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                Console.Clear();

                switch (choice)
                {
                    case 1:
                        RegisterMusic();
                        break;
                    case 2:
                        ShowMusic();
                        break;
                    case 3:
                        Edit();
                        break;
                    case 4:
                        Remove();
                        break;
                    case 5:
                        RegisterPlaylist();
                        break;
                    case 6:
                        ShowPlayList();
                        break;
                    case 7:
                        RemovePlayList();
                        break;
                    case 8:
                        EditPlayList();
                        break;

                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void RegisterMusic()
        {
            ShowPlayList();
            Console.WriteLine("---------- Cadastrar Música ----------");
            Console.Write("Digite o ID da playlist: PL0");
            int index = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Digite o nome da música: ");
            playlists[index].Add(Console.ReadLine());

            Console.WriteLine("\nMúsica adicionada com sucesso!\n");
        }

        static void ShowMusic()
        {
            Console.WriteLine("---------- Todas Músicas Cadastradas -----------");
            int count = 1;
            for (int i = 0; i < playlists.Count; i++)
            {
                for (int j = 0; j < playlists[i].Count; j++)
                {
                    Console.WriteLine($"{count}ª - PlayList: {namePlalists[i]} (ID : PL0{i + 1}) \n     Music: {playlists[i][j]} (ID: MC0{j + 1}) \n");
                    count++;
                }
            }
            Console.WriteLine("--------------------*--------------------\n");
        }

        static void Edit()
        {
            ShowMusic();
            Console.WriteLine("---------- Editar Música ----------");
            Console.Write("Digite o ID da playlist: PL0");
            int indexPL = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Digite o index da música: MC0");
            int indexMSC = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Novo nome: ");
            playlists[indexPL][indexMSC] = Console.ReadLine();

            Console.WriteLine("\nMúsica editada com sucesso!\n");
        }   
        
        static void Remove()
        {
            ShowMusic();
            Console.WriteLine("---------- Remover Música ----------");
            Console.Write("Digite o ID da playlist: PL0");
            int indexPL = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Digite o ID da música: MC0");
            int indexMSC = int.Parse(Console.ReadLine()) - 1;

            playlists[indexPL].RemoveAt(indexMSC);

            Console.WriteLine("\nMúsica removida com sucesso!\n");
        }

        static void RegisterPlaylist()
        {
            Console.WriteLine("-------------- Cadastrar PlayList -------------");
            Console.Write("Digite o nome para a nova playlist: ");
            string name = Console.ReadLine();

            if (namePlalists.Contains(name))
            {
                Console.WriteLine("\nPlaylist já existe.\n");
            }
            else
            {
                playlists.Add(new List<string>());
                namePlalists.Add(name);
                Console.WriteLine("\nPlaylist criada com sucesso!\n");
            }
        }
        static void ShowPlayList()
        {
            Console.WriteLine("------------- PlayLists -----------------");
            for (int i = 0;i < playlists.Count;i++)
            {
                Console.WriteLine($"{i + 1}ª - {namePlalists[i]} (ID: PL0{i+1})");
            }
            Console.WriteLine("--------------------*--------------------\n");
        }

        static void RemovePlayList()
        {
            ShowPlayList();
            Console.WriteLine("---------- Remover Playlist ----------");
            Console.Write("Digite o ID da playlist: PL0");
            int indexPL = int.Parse(Console.ReadLine()) - 1;

            playlists[indexPL].Clear();
            playlists.RemoveAt(indexPL);
            namePlalists.RemoveAt(indexPL);

            Console.WriteLine("\n** Musicas da playlist removida com sucesso! **");
            Console.WriteLine("** Playlist removida com sucesso! **\n");
        }

        static void EditPlayList()
        {
            ShowPlayList();
            Console.WriteLine("---------- Editar Playlist ----------");
            Console.Write("Digite o ID da playlist: PL0");
            int indexPL = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Novo nome: ");
            namePlalists[indexPL] = Console.ReadLine();

            Console.WriteLine("\nPlaylist editada com sucesso!\n");
        }
    }
}
