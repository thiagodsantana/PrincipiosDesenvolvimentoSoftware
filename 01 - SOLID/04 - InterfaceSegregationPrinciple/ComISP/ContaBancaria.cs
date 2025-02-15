namespace PrincipiosDesenvolvimentoSoftware.SOLID.InterfaceSegregationPrinciple.ComISP
{
    /*
     * - Com ISP
        Agora temos interfaces específicas para cada tipo de funcionalidade.
            - Benefício: ContaSalario não precisa implementar empréstimo, pois não faz sentido para ela.
     */
    public interface IConta
    {
        void Depositar(decimal valor);
        void Sacar(decimal valor);
    }

    public interface IContaComEmprestimo
    {
        void Emprestimo(decimal valor);
    }

    public class ContaCorrente : IConta, IContaComEmprestimo
    {
        public void Depositar(decimal valor) { /* ... */ }
        public void Sacar(decimal valor) { /* ... */ }
        public void Emprestimo(decimal valor) { /* ... */ }
    }

    public class ContaSalario : IConta
    {
        public void Depositar(decimal valor) { /* ... */ }
        public void Sacar(decimal valor) { /* ... */ }
    }

}
