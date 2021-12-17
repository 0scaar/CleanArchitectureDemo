namespace CleanArchitectureDemo.Application.UseCases.Customer.Delete
{
    public interface ICustomerDeleteUseCase
    {
        void Execute(CustomerDeleteRequest request);
    }
}
