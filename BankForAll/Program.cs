namespace BankForAll;

    public class Program
{
    static void Menu()
    {
        Console.WriteLine("1 - Inserir novo usuário");
        Console.WriteLine("2 - Deletar usuário");
        Console.WriteLine("3 - Detalhes de um usuário");
        Console.WriteLine("4 - Total armazenado no banco");
        Console.WriteLine("0 - Para sair do programa");
        Console.Write("Digite a opção desejada: ");
        // criar um comando par retornar uma ação
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Olá, bem vindo ao Bank For All.");
        Console.Write("Digite a quantidade de usuários: ");
        int qtdDeUsuarios = int.Parse(Console.ReadLine());
        Console.WriteLine();
                
        int escolha, id;

        do
        {
            Menu();
            escolha = int.Parse(Console.ReadLine());
            //if (escolha == 0)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Até mais!");
            //} else {
            //    Console.WriteLine("Selecione uma das opções acima");
            //}
            switch (escolha)
            {
                case 0:
                    Console.WriteLine("Até mais!");
                    break;
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Certo, vamos adicionar algumas informações.\nPreencha os dados solicitados\n");
                    Console.Write("número identificador: "); // cpf,
                    id = int.Parse(Console.ReadLine());
                    Console.Write("idade:");
                    int idade = int.Parse(Console.ReadLine());


                    break;
                case 2: Console.Write("Digite o nome do usuário que deseja deletar: ");
                    string nome = Console.ReadLine();
                    break;
            }

            // ação que a pessoa pediu, provavelmente com if
            Console.WriteLine();
            Console.WriteLine("-/-/-/-/-/-");
            Console.WriteLine();
            

        } while (escolha != 0);


    }
}


