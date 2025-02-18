namespace PrincipiosDesenvolvimentoSoftware.SOLID.LiskovSubstitutionPrinciple.ComLSP
{
    /*
     * Com LSP
            Aqui, garantimos que ContaPoupanca permite saques, mas adicionamos uma restrição realista 
                sem alterar o comportamento esperado da classe base.
        
        - Benefício: ContaSalario não quebra a substituição porque não promete um comportamento 
            que não pode cumprir.
     */
    class ContaBancaria
    {
        public decimal Saldo { get; protected set; }

        public ContaBancaria(decimal saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente");
            }
            Saldo -= valor;
        }
    }

    class ContaPoupanca : ContaBancaria
    {
        private readonly int limiteSaques = 3;
        private int saquesRealizados = 0;

        public ContaPoupanca(decimal saldoInicial) : base(saldoInicial) { }

        public override void Sacar(decimal valor)
        {
            if (saquesRealizados >= limiteSaques)
            {
                throw new InvalidOperationException("Limite de saques atingido");
            }

            base.Sacar(valor);
            saquesRealizados++;
        }
    }
}
