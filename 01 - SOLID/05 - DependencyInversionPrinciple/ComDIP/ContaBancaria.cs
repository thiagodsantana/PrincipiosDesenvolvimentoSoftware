namespace PrincipiosDesenvolvimentoSoftware.SOLID.DependencyInversionPrinciple.ComDIP
{
    /*
     * Com DIP
        Agora ServicoBancario depende de uma abstração.

        - Benefício: Podemos trocar o repositório sem alterar ServicoBancario.
     */
    public interface IContaRepository
    {
        void SalvarConta();
    }

    public class ContaRepository : IContaRepository
    {
        public void SalvarConta() { /* ... */ }
    }

    public class ServicoBancario
    {
        private readonly IContaRepository _repository;

        public ServicoBancario(IContaRepository repository)
        {
            _repository = repository;
        }

        public void ExecutarOperacao()
        {
            _repository.SalvarConta();
        }
    }

}
