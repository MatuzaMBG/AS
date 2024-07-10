public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    private double salarioPorHora;
    private int nHorasTrabalhadas;
    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, int nHorasTrabalhadas) :base(nome,matricula)
    {
        this.salarioPorHora = salarioPorHora;
        this.nHorasTrabalhadas = nHorasTrabalhadas;
    }
    public override double CalcularSalario()
    {
        return salarioPorHora * nHorasTrabalhadas;
    }
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Funcionario em tempo integral: {nome}");
        Console.WriteLine($"Número da matricula: {matricula}");
        Console.WriteLine($"Salario por hora: {CalcularSalario()}.");
        Console.WriteLine($"Número de horas trabalhadas {nHorasTrabalhadas}");
        
    }
    public double calcularBonus()
    {
        return CalcularSalario() * 5 / 100;
    }
}