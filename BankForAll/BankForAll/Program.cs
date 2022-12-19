namespace BankForAll {

public class Program
{
    static void Menu()
    {
        Console.WriteLine("1 - Criar contar");
        Console.WriteLine("2 - Deletar conta");
        Console.WriteLine("3 - Listar todas as contas registradas");
        Console.WriteLine("4 - Detalhes de um usuário");
        Console.WriteLine("5 - Consultar Saldo");
        Console.WriteLine("6 - Entrar na conta");
        Console.WriteLine("0 - Para sair do programa");
        Console.Write("Digite a opção desejada: ");
        // criar um comando par retornar uma ação
    }

    static void Main(string[] args)
    {

        Console.WriteLine("Olá, bem vindo ao Bank For All.\n");
                    
        List<string> cpfs = new List<string>();
        List<string> titulares = new List<string>();
        List<double> saldos = new List<double>();
        List<string> senhas = new List<string>();
        int escolha;
          
            do
            {
            Menu();
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 0:
                    Console.WriteLine("Até mais!");
                    break;
                case 1:
                        Console.WriteLine();
                    Console.WriteLine(" Precisamos de  algumas informações.\nPreencha os dados solicitados:\n");
                    RegistroNovoUsuario(cpfs, titulares, senhas, saldos);
                    Console.WriteLine();
                    break;
                case 2:
                        Console.WriteLine();
                    DeletarUsuario(cpfs, titulares, senhas, saldos);
                    break;
                case 3:
                        Console.WriteLine();
                    ListarTodasAsContas(cpfs, titulares, saldos);
                    break;
                case 4:
                    Console.WriteLine();
                        DetalhesDeUmUsuario();
                    break;
                case 5:
                     Console.WriteLine();
                        ConsultaSaldo(saldos);
                     break;
                case 6:
                        Console.WriteLine();
                        //criar ideias para a função logar
                 break;

            }


            Console.WriteLine();
            Console.WriteLine("-/-/-/-/-/-");
            Console.WriteLine();


        } while (escolha != 0);

    }

    static void RegistroNovoUsuario(List<string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
    {
        Console.Write("Digite o cpf: ");
        cpfs.Add(Console.ReadLine());
        Console.Write("Digite o nome: ");
        titulares.Add(Console.ReadLine());
        Console.Write("Digite uma senha: ");
        senhas.Add(Console.ReadLine());
        Console.Write("Seu saldo: ");
            double valor = double.Parse(Console.ReadLine());
        saldos.Add(valor);
    }

    static void DeletarUsuario(List <string> cpfs, List<string> titulares, List<string> senhas, List<double> saldos)
        {
            Console.Write("Digite o cpf do titular que deseja deletar: ");
            string cpfParaDeletar = Console.ReadLine();
            int indexParaDeletar = cpfs.FindIndex(d => d== cpfParaDeletar);
           
            if (indexParaDeletar== -1)
            {
                Console.WriteLine("Não foi possível deletar este cpf");
                Console.WriteLine("Conta não encontrada. Confira o cpf digitado");
            }
            else
            {
                cpfs.Remove(cpfParaDeletar);
                titulares.RemoveAt(indexParaDeletar);
                senhas.RemoveAt(indexParaDeletar);
                saldos.RemoveAt(indexParaDeletar);
                Console.WriteLine("Conta deletada com sucesso!");                
            }
        }
    static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
    {
        for (int i = 0; i < cpfs.Count; i++)
            {
                NewMethod(cpfs, titulares, saldos, i);// conferir no console
            }
        }

        private static void NewMethod(List<string> cpfs, List<string> titulares, List<double> saldos, int i)
        {
            Console.WriteLine($"CPF = {cpfs[i]} | Titular = {titulares[i]} | Saldo = R$ {saldos[i]:F2}");//conferir
        }
        private static void DetalhesDeUmUsuario()
        {
            Console.WriteLine();
        }

        static void ConsultaSaldo(List<double> saldos)
        {
            Console.WriteLine($"Seu saldo é de: {saldos.Sum()}");
        }


    }
    

}

