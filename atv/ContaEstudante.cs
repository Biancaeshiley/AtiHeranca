public class ContaEstudante : Conta
{
    public double ChequeEspecial { get; set; }
    public string cpf { get; set; }
    public string nomeInstitucao { get; set; }

    public ContaEstudante(int nConta, string agencia, string titular, double saldo, double chequeEspecial)
        : base (nConta, agencia, titular,saldo)
    {
        this.ChequeEspecial = chequeEspecial;
        this.cpf = cpf;
        this.nConta = nConta;
    }
}