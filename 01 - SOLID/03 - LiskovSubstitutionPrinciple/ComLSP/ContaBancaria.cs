namespace PrincipiosDesenvolvimentoSoftware.SOLID.LiskovSubstitutionPrinciple.ComLSP
{
    /*
     * Com LSP
            Agora, ContaSalario não herda de ContaBancaria, mas define seu próprio comportamento.
        
        - Benefício: ContaSalario não quebra a substituição porque não promete um comportamento 
            que não pode cumprir.
     */
    public abstract class ContaBancaria
    {
        protected decimal saldo;
        public abstract void Sacar(decimal valor);
    }

    public class ContaCorrente : ContaBancaria
    {
        public override void Sacar(decimal valor)
        {
            if (valor > saldo)
                throw new Exception("Saldo insuficiente!");

            saldo -= valor;
        }
    }

    public class ContaSalario
    {
        public static void SacarFolhaPagamento()
        {
            Console.WriteLine("Saque permitido apenas na data de pagamento.");
        }
    }
}
