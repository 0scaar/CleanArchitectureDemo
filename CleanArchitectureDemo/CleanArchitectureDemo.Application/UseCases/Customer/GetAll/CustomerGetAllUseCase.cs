using CleanArchitectureDemo.Application.Boundaries.Customer;
using CleanArchitectureDemo.Application.Repositories;
using System;

namespace CleanArchitectureDemo.Application.UseCases.Customer.GetAll
{
    public class CustomerGetAllUseCase : ICustomerGetAllUseCase
    {
        private readonly ICustomerReadOnlyRepository customerReadOnlyRepository;
        private readonly IOutputPort outputPort;

        public CustomerGetAllUseCase(
            ICustomerReadOnlyRepository customerReadOnlyRepository, 
            IOutputPort outputPort)
        {
            this.customerReadOnlyRepository = customerReadOnlyRepository;
            this.outputPort = outputPort;
        }

        public void Execute()
        {
            try
            {
                var customers = customerReadOnlyRepository.GetAll();
                outputPort.Standard(customers);
            }
            catch (Exception ex)
            {
                outputPort.Error($"Error on process: {ex.Message}");
            }
        }
    }
}
