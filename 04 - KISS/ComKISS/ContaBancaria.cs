namespace PrincipiosDesenvolvimentoSoftware.KISS.ComKISS
{
    /*
     * Seguindo KISS (Código simples e direto)
     * Solução: Mantemos as validações essenciais e removemos prints desnecessários.
     */
    public class ContaBancaria
    {
        public required string Titular { get; set; }
        public double Saldo { get; private set; }

        public void Depositar(double valor)
        {
            if (valor <= 0) 
                return; // Apenas evita valores inválidos
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= 0 || Saldo < valor) 
                return; // Evita verificações desnecessárias
            Saldo -= valor;
        }
    }

    public class Program
    {
        static void Main()
        {
            ContaBancaria conta = new() { Titular = "Maria" };
            conta.Depositar(500);
            conta.Sacar(100);
            Console.WriteLine($"Saldo final: {conta.Saldo}");
        }
    }
}
