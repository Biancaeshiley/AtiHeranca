

public class ContaEmpresarial : Conta
{
    public double Anuidade { get; set; }
    public double LimiteEmprestimo { get; set; }
    public double TotalEmprestimo {get; set;}

    public ContaEmpresarial(int nConta, string agencia, string titular, double saldo, double Anuidade, double LimiteEmprestimo, double TotalEmprestimo)
        : base (nConta, agencia, titular,saldo)
    {
        this.Anuidade = Anuidade;
        this.LimiteEmprestimo = LimiteEmprestimo;
        this.TotalEmprestimo = TotalEmprestimo;
    }

    public void FazerEmpretimo(double valoremp)
    {
        if(valoremp > LimiteEmprestimo)
        {
            
        }

        else
        {
            valoremp = saldo + TotalEmprestimo;
            Console.WriteLine("Empréstimo foi realizado com sucesso!");
        }
    }

    public void Sacar()
    {

    }

}
