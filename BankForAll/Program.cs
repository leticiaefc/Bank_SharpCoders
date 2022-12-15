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
                    Console.Write("Digite o cpf do usuário que deseja deletar: ");
                    string nome = Console.ReadLine();
                        break;
                case 3:
                        Console.WriteLine();
                        ListarTodasAsContas(cpfs, titulares, saldos);
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
        saldos.Add(0);
    }

    static void ListarTodasAsContas(List<string> cpfs, List<string> titulares, List<double> saldos)
    {
        for (int i = 0; i < cpfs.Count; i++)
        {
            Console.WriteLine($"CPF = {cpfs[i]} | Titular = {titulares[i]} | Saldo = R$ {saldos[i]:F2}");
        }
    }

}

}

