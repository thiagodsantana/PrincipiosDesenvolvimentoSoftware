namespace Solid.SingleResponsibilityPrinciple.ComSRP
{
    /*
     * Com SRP
            Agora, temos duas classes separadas:
                - ContaBancaria lida apenas com transações.
                - ContaRepository cuida da persistência no banco.

        - Benefício: Se precisarmos salvar os dados na nuvem, basta modificar ContaRepository, 
            sem tocar na ContaBancaria.
     */
    public class ContaBancaria
    {
        private decimal saldo;

        public void Depositar(decimal valor) => saldo += valor;

        public void Sacar(decimal valor)
        {
            if (valor > saldo)
                throw new Exception("Saldo insuficiente!");

            saldo -= valor;
        }
    }

    public class ContaRepository
    {
        public static void Salvar(ContaBancaria conta)
        {
            Console.WriteLine("Conta salva no banco de dados.");
        }
    }
}
