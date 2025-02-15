namespace PrincipiosDesenvolvimentoSoftware.YAGNI.ComYAGNI
{
    /*
     * Seguindo YAGNI (Removendo código desnecessário)
     * Solução: Removemos GerarRelatorioMensal() e CalcularJuros() pois não são necessários agora.
     */
    public class ContaBancaria
    {
        public required string Titular { get; set; }
        public double Saldo { get; private set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            ContaBancaria conta = new() { Titular = "Carlos" };
            conta.Depositar(1000);
            conta.Sacar(200);
            Console.WriteLine($"Saldo final: {conta.Saldo}");
        }
    }
}
