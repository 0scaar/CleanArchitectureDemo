using CleanArchitectureDemo.Application.Boundaries.Customer;
using CleanArchitectureDemo.Application.Repositories;
using System;

namespace CleanArchitectureDemo.Application.UseCases.Customer.Delete
{
    public class CustomerDeleteUseCase : ICustomerDeleteUseCase
    {
        private readonly ICustomerWriteOnlyRepository customerWriteOnlyRepository;
        private readonly IOutputPort outputPort;

        public CustomerDeleteUseCase(
            ICustomerWriteOnlyRepository customerWriteOnlyRepository, 
            IOutputPort outputPort)
        {
            this.customerWriteOnlyRepository = customerWriteOnlyRepository;
            this.outputPort = outputPort;
        }

        public void Execute(CustomerDeleteRequest request)
        {
            try
            {
                var ret = customerWriteOnlyRepository.Delete(request.Id);
                if (ret == 0)
                {
                    outputPort.Error("Error on process Delete Customer");
                    return;
                }

                outputPort.Standard(request.Id);
            }
            catch (Exception ex)
            {
                outputPort.Error($"Error on process: {ex.Message}");
            }
        }
    }
}
