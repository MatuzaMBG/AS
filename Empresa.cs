public class Empresa
{
    private List<Funcionario> funcionarios;
    
    public Empresa()
    {
        funcionarios = new List<Funcionario>();
    }
    public void AdicionarFuncionario(Funcionario funcionario)
    {
        funcionarios.Add(funcionario);
    }
   
    public void RemoverFuncionario(int matricula)
    {
       funcionarios.RemoveAll(f => f.matricula == matricula); 
    }
    public void ExibirFuncionarios()
    {
        foreach(var funcionario in funcionarios)
        {
            funcionario.ExibirInformacoes();
        }
    
    }
    
    public Funcionario BuscarFuncionario(int matricula)
    {
        return funcionarios.Find(f => f.matricula == matricula)!;
    }
}