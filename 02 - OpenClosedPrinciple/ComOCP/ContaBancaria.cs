namespace Solid.OpenClosedPrinciple.ComOCP
{
    /*
     * Com OCP
            Agora podemos adicionar novos tipos de conta sem modificar código existente.
        ✔ Benefício: Sem precisar modificar código existente, apenas adicionamos novas classes.
     */
    public interface IConta
    {
        void CalcularJuros();
    }

    public class ContaCorrente : IConta
    {
        public void CalcularJuros() => Console.WriteLine("Conta corrente não tem juros.");
    }

    public class ContaPoupanca : IConta
    {
        public void CalcularJuros() => Console.WriteLine("Aplicando juros de 0.5%.");
    }

    public class ProcessadorDeJuros
    {
        public static void ProcessarJuros(IConta conta)
        {
            conta.CalcularJuros();
        }
    }
}
