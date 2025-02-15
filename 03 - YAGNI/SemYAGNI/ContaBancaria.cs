namespace PrincipiosDesenvolvimentoSoftware.DRY.ComDRY.SemYAGNI
{
    /*
     * YAGNI (You Ain't Gonna Need It - Você não vai precisar disso)
        - Violando YAGNI (Código com funcionalidades desnecessárias)
        - Problema: Criamos um relatório mensal e um cálculo de juros que ninguém pediu ainda.
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

        public string GerarRelatorioMensal()
        {
            return $"Relatório Mensal: Titular: {Titular}, Saldo: {Saldo}, Juros: {CalcularJuros()}";
        }

        private double CalcularJuros()
        {
            return Saldo * 0.05; // Supondo um juros fixo, mas que ninguém pediu ainda
        }
    }

    public class Program
    {
        static void Main()
        {
            ContaBancaria conta = new ContaBancaria { Titular = "Carlos" };
            conta.Depositar(1000);
            Console.WriteLine(conta.GerarRelatorioMensal()); // Esta funcionalidade não era necessária
        }
    }
}
