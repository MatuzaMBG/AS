public abstract class Funcionario
{
    public string nome;
    public int matricula;
    List<string> projetos = new List<string>();
    public Funcionario(string nome, int matricula)
    {
        this.nome = nome;
        this.matricula = matricula;
    }

    public abstract double CalcularSalario();
    public abstract void ExibirInformacoes();
    public void AdicionarProjeto(string projeto)
    {
        projetos.Add(projeto);
    }
    public void AdicionarProjeto(List<string>projetos)
    {
        projetos.AddRange(projetos);
    }
}
