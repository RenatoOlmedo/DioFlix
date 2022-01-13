using System;

namespace DIO.Series
{
    class Program
    {
        
		
        static void Main(string[] args)
        {
			string opcaoUsuario = "";
			Menu m = new Menu();
			System.Console.WriteLine("\nSeja Bem-Vindo ao DioFlix!\nPrepare a pipoca e divirta-se\n");
			
			
			while (opcaoUsuario.ToUpper() != "X")
			{
				System.Console.WriteLine("O que você deseja assistir nesse momento?");
				System.Console.WriteLine("1- Séries\n2- Filmes\nX- Sair");
				int escolhaG = int.Parse(Console.ReadLine());
				if(escolhaG == 1){
					opcaoUsuario = m.ObterOpcaoUsuarioSerie();
					while (opcaoUsuario.ToUpper() != "V")
					{
						switch (opcaoUsuario)
						{
							case "1":
								m.ListarSeries();
								break;
							case "2":
								m.InserirSerie();
								break;
							case "3":
								m.AtualizarSerie();
								break;
							case "4":
								m.ExcluirSerie();
								break;
							case "5":
								m.VisualizarSerie();
								break;
							case "C":
								Console.Clear();
								break;

							default:
								throw new ArgumentOutOfRangeException();
						}
						opcaoUsuario = m.ObterOpcaoUsuarioSerie();
					}
				}
				else if(escolhaG == 2){
					opcaoUsuario = m.ObterOpcaoUsuarioFilme();
					while (opcaoUsuario.ToUpper() != "V")
					{
						switch (opcaoUsuario)
						{
							case "1":
								m.ListarFilmes();
								break;
							case "2":
								m.InserirFilme();
								break;
							case "3":
								m.AtualizarFilme();
								break;
							case "4":
								m.ExcluirFilme();
								break;
							case "5":
								m.VisualizarFilme();
								break;
							case "C":
								Console.Clear();
								break;

							default:
								throw new ArgumentOutOfRangeException();
						}
						opcaoUsuario = m.ObterOpcaoUsuarioFilme();
					}
				}
				else{
					System.Console.WriteLine("Opção inexistente, tente novamente");
				}	
				 
			}
			Console.WriteLine("Obrigado por utilizar nossos serviços.");
        }
    }
}
