public class Conta
{
    public int nConta { get; set; }
    public string agencia { get; set; }
    public string titular { get; set; }
    public double saldo { get; set; }

    public Conta (int nConta, string agencia, string titular, double saldo)
    {
        this.nConta = nConta;
        this.agencia = agencia;
        this.titular = titular;
        this.saldo = saldo;
    }

    public void Sacar(double valor)
    {
        if (valor < this.saldo)
        {
            this.saldo = this.saldo - valor;
        }

        else
        {
            Console.WriteLine("Saque realizado com sucesso!!");
        }

    }

    public void Deposito(double deposito)
    {
       saldo = saldo + deposito;
    }

}
