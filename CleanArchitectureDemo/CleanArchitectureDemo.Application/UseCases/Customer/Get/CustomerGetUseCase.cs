using CleanArchitectureDemo.Application.Boundaries.Customer;
using CleanArchitectureDemo.Application.Repositories;
using CleanArchitectureDemo.Application.Repositories.Log;
using System;

namespace CleanArchitectureDemo.Application.UseCases.Customer.Get
{
    public class CustomerGetUseCase : ICustomerGetUseCase
    {
        private readonly ICustomerReadOnlyRepository customerReadOnlyRepository;
        private readonly ILogWriteOnlyRepository logWriteOnlyRepository;
        private readonly IOutputPort outputPort;

        public CustomerGetUseCase(
            ICustomerReadOnlyRepository customerReadOnlyRepository,
            IOutputPort outputPort, ILogWriteOnlyRepository logWriteOnlyRepository)
        {
            this.customerReadOnlyRepository = customerReadOnlyRepository;
            this.outputPort = outputPort;
            this.logWriteOnlyRepository = logWriteOnlyRepository;
        }

        public void Execute(CustomerGetRequest request)
        {
            try
            {
                request.AddProcessingLog("Get Customer by ID");

                var customer = customerReadOnlyRepository.GetById(request.Id);
                if (customer == null)
                {
                    request.AddProcessingLog("Don't find any customer", Domain.Log.Enum.TypeLog.NotFound);
                    outputPort.NotFound($"Not found customer with id: {request.Id}");
                    return;
                }

                outputPort.Standard(customer);
            }
            catch (Exception ex)
            {
                request.AddExceptionLog(ex.Message, ex.StackTrace);
                outputPort.Error($"Error on process: {ex.Message}");
            }
            finally
            {
                logWriteOnlyRepository.Add(request.Logs);
            }
        }
    }
}
