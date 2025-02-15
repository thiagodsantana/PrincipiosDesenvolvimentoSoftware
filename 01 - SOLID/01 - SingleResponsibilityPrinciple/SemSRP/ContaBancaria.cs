namespace PrincipiosDesenvolvimentoSoftware.SOLID.SingleResponsibilityPrinciple.SemSRP
{
    /*
     * SRP - Single Responsibility Principle (Princípio da Responsabilidade Única)
        Uma classe deve ter apenas uma responsabilidade.

        - Violação do princípio
            Aqui, a classe ContaBancaria faz duas coisas:
             - Gerencia saldo
             - Persiste dados no banco
        
        - Problema: Se quisermos mudar a forma de salvar os dados,
            precisamos modificar essa classe.
    */
    public class ContaBancaria
    {
        private decimal saldo;

        public void Depositar(decimal valor)
        {
            saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor > saldo)
                throw new Exception("Saldo insuficiente!");

            saldo -= valor;
        }

        public static void SalvarNoBanco()
        {
            Console.WriteLine("Salvando conta bancária no banco de dados...");
        }
    }
}
