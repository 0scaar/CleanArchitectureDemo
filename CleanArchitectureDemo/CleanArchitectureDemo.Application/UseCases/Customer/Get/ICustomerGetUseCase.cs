namespace CleanArchitectureDemo.Application.UseCases.Customer.Get
{
    public interface ICustomerGetUseCase
    {
        void Execute(CustomerGetRequest request);
    }
}
