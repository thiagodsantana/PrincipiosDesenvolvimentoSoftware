namespace PrincipiosDesenvolvimentoSoftware.KISS.SemKISS
{
    /*
     * KISS (Keep It Simple, Stupid - Mantenha Simples, Estúpido)
        - Violando KISS (Código mais complicado do que deveria)
        - Problema: Muitas verificações complicam o código.
     */
    public class ContaBancaria
    {
        public required string Titular { get; set; }
        public double Saldo { get; private set; }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Depósito inválido.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0)
            {
                if (Saldo >= valor)
                {
                    Saldo -= valor;
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
            else
            {
                Console.WriteLine("Saque inválido.");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ContaBancaria conta = new() { Titular = "Maria" };
            conta.Depositar(-50); // Não faz sentido
            conta.Sacar(100); // Saldo insuficiente
        }
    }

}
