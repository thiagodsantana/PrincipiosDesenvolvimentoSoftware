namespace PrincipiosDesenvolvimentoSoftware.SOLID.InterfaceSegregationPrinciple.SemISP
{
    /*
     * ISP - Interface Segregation Principle (Princípio da Segregação de Interface)
        Uma interface não deve forçar uma classe a implementar métodos que ela não usa.

        - Violação do princípio
            Aqui, ContaBancaria precisa implementar Emprestimo(), mesmo que contas salário 
                não tenham empréstimo.
        - Problema: ContaSalario é forçada a implementar um método que não faz sentido.
     */
    public interface IConta
    {
        void Depositar(decimal valor);
        void Sacar(decimal valor);
        void Emprestimo(decimal valor);
    }

    public class ContaSalario : IConta
    {
        public void Depositar(decimal valor) { /* ... */ }
        public void Sacar(decimal valor) { /* ... */ }

        public void Emprestimo(decimal valor)
        {
            throw new Exception("Conta salário não permite empréstimo!");
        }
    }

}
