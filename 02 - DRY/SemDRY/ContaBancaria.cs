namespace PrincipiosDesenvolvimentoSoftware.DRY.SemDRY
{
    using System;

    /*
     * DRY (Don't Repeat Yourself - Não se repita)
        - Violando DRY (Código repetitivo)
        - Problema: Os métodos SacarContaCorrente e SacarContaPoupanca têm lógica idêntica.
     */
    public class ContaBancaria
    {
        public required string Titular { get; set; }
        public double Saldo { get; private set; }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void SacarContaCorrente(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
        }

        public void SacarContaPoupanca(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ContaBancaria conta = new() { Titular = "João" };
            conta.Depositar(1000);
            conta.SacarContaCorrente(200);
            conta.SacarContaPoupanca(200);
            Console.WriteLine($"Saldo final: {conta.Saldo}");
        }
    }
}
