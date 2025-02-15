namespace PrincipiosDesenvolvimentoSoftware.SOLID.OpenClosedPrinciple.SemOCP
{
    /*
     * OCP - Open/Closed Principle (Princípio Aberto/Fechado)
        O código deve estar aberto para extensão, mas fechado para modificação.

        - Violação do princípio
            Aqui, se quisermos adicionar um novo tipo de conta bancária (ex.: conta investimento), 
            teremos que modificar a classe.
        
        - Problema: Se adicionarmos "Conta Investimento", precisamos modificar essa classe.
     */
    public class ContaBancaria
    {
        public static void CalcularJuros(string tipoConta)
        {
            if (tipoConta == "Corrente")
            {
                Console.WriteLine("Conta corrente não tem juros.");
            }
            else if (tipoConta == "Poupanca")
            {
                Console.WriteLine("Aplicando juros de 0.5%.");
            }
            else
            {
                throw new Exception("Tipo de conta inválido!");
            }
        }
    }
}
