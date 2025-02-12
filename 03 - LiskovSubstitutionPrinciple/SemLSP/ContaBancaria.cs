namespace Solid.LiskovSubstitutionPrinciple.SemLSP
{
    /*
     * LSP - Liskov Substitution Principle (Princípio da Substituição de Liskov)
        Subclasses devem poder substituir suas classes base sem causar erros.

        - Violação do princípio
            Aqui, ContaSalario não permite saque livre, mas herda de ContaBancaria, que permite. 
                Isso pode confundir o usuário.

        - Problema: Quem usa ContaBancaria espera que saques sejam permitidos, mas ContaSalario quebra 
            esse comportamento.
     */
    public class ContaBancaria
    {
        protected decimal saldo;

        public virtual void Sacar(decimal valor)
        {
            if (valor > saldo)
                throw new Exception("Saldo insuficiente!");

            saldo -= valor;
        }
    }

    public class ContaSalario : ContaBancaria
    {
        public override void Sacar(decimal valor)
        {
            throw new Exception("Conta salário só permite saque na folha de pagamento!");
        }
    }
}
