public class FuncionarioTempoIntegral : Funcionario, IBonus
{
    private double salarioMensal;
    public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) :base(nome, matricula)
    {
        this.salarioMensal = salarioMensal;
    }
    public override double CalcularSalario()
    {
        return salarioMensal;
    }
    public override void ExibirInformacoes()
    {
        Console.WriteLine($"Nome do Funcionario: {nome}");
        Console.WriteLine($"Número da matricula: {matricula}");
        Console.WriteLine($"Sálario Mensal: {salarioMensal}");
    }
    public double calcularBonus()
    {
        return salarioMensal * 10 / 100;
    }
    
}