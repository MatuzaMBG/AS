Empresa empresa = new Empresa();

bool sair = true;

while (sair)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1 - Adicionar funcionário de tempo integral");
    Console.WriteLine("2 - Adicionar funcionário de meio período");
    Console.WriteLine("3 - Remover funcionário");
    Console.WriteLine("4 - Exibir informações de todos os funcionários");
    Console.WriteLine("5 - Adicionar projeto(s) a um funcionário");
    Console.WriteLine("6 - Sair");
    Console.Write("Selecione uma opção: ");

    int opcao = Convert.ToInt32(Console.ReadLine()!);
    Console.ReadKey();
    switch (opcao)
    {
        case 1:
            AdicionarFuncionarioTempoIntegral(empresa);
            break;
        case 2:
            AdicionarFuncionarioMeioPeriodo(empresa);
            break;
        case 3:
            RemoverFuncionario(empresa);
            break;
        case 4:
            empresa.ExibirFuncionarios();
            break;
        case 5:
            AdicionarProjetos(empresa);
            break;
        case 6:
            sair = false;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

static void AdicionarFuncionarioTempoIntegral(Empresa empresa)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine()!;
    Console.Write("Matrícula: ");
    int matricula = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("Salário Mensal: ");
    double salarioMensal = Convert.ToDouble(Console.ReadLine()!);

    FuncionarioTempoIntegral funcionario = new FuncionarioTempoIntegral(nome, matricula, salarioMensal);
    empresa.AdicionarFuncionario(funcionario);
}

static void AdicionarFuncionarioMeioPeriodo(Empresa empresa)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine()!;
    Console.Write("Matrícula: ");
    int matricula = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("Salário por Hora: ");
    double salarioPorHora = Convert.ToDouble(Console.ReadLine()!);
    Console.Write("Horas Trabalhadas: ");
    int horasTrabalhadas = Convert.ToInt32(Console.ReadLine()!);

    FuncionarioMeioPeriodo funcionario = new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, horasTrabalhadas);
    empresa.AdicionarFuncionario(funcionario);
}

static void RemoverFuncionario(Empresa empresa)
{
    Console.Write("Matrícula do funcionário a ser removido: ");
    int matricula = Convert.ToInt32(Console.ReadLine()!);
    empresa.RemoverFuncionario(matricula);
}

static void AdicionarProjetos(Empresa empresa)
{
    Console.Write("Matrícula do funcionário: ");
    int matricula = Convert.ToInt32(Console.ReadLine()!);
    Funcionario funcionario = empresa.BuscarFuncionario(matricula);

    if (funcionario != null)
    {
        Console.Write("Digite o número de projetos a serem adicionados: ");
        int numeroProjetos = Convert.ToInt32(Console.ReadLine()!);

        for (int i = 0; i < numeroProjetos; i++)
        {
            Console.Write($"Nome do Projeto {i + 1}: ");
            string projeto = Console.ReadLine()!;
            funcionario.AdicionarProjeto(projeto);
        }
    }
    else
    {
        Console.WriteLine("Funcionário não encontrado!");
    }
}
