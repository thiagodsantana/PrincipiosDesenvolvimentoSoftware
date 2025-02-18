namespace PrincipiosDesenvolvimentoSoftware.SOLID.LiskovSubstitutionPrinciple.SemLSP
{
    /*
     * LSP - Liskov Substitution Principle (Princípio da Substituição de Liskov)
        Subclasses devem poder substituir suas classes base sem causar erros.

        - Violação do princípio
            Aqui, ContaPoupanca não permite saque, mas herda de ContaBancaria, que permite. 
                Isso pode confundir o usuário.

        - Problema: Se o código espera que todas as contas bancárias possam sacar dinheiro, 
                        a ContaPoupanca viola esse princípio, quebrando o fluxo normal do programa.
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
        public ContaPoupanca(decimal saldoInicial) : base(saldoInicial) { }

        public override void Sacar(decimal valor)
        {
            throw new NotImplementedException("Conta poupança não permite saques diretos");
        }
    }
}