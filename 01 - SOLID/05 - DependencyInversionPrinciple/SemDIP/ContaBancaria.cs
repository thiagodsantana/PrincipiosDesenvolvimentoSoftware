namespace PrincipiosDesenvolvimentoSoftware.SOLID.DependencyInversionPrinciple.SemDIP
{
    /*
     * DIP - Dependency Inversion Principle (Princípio da Inversão de Dependência)
        O código deve depender de abstrações, e não de implementações concretas.

        - Violação do princípio
        Aqui, ServicoBancario depende diretamente de ContaRepository.
        
        - Problema: Se quisermos salvar contas em um serviço externo, 
            precisaremos modificar ServicoBancario.
     */
    public class ContaRepository
    {
        public void SalvarConta() { /* ... */ }
    }

    public class ServicoBancario
    {
        private readonly ContaRepository _repository = new ContaRepository();

        public void ExecutarOperacao()
        {
            _repository.SalvarConta();
        }
    }

}
