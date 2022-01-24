using CleanArchitectureDemo.Application.Boundaries.Customer;
using CleanArchitectureDemo.Application.UseCases.Customer.Save.Handlers;
using System;

namespace CleanArchitectureDemo.Application.UseCases.Customer.Save
{
    public class CustomerSaveUseCase : ICustomerSaveUseCase
    {
        private readonly ValidateHandler validateHandler;
        private readonly IOutputPort outputPort;

        public CustomerSaveUseCase(
            ValidateHandler validateHandler, 
            SaveHandler saveHandler,
            IOutputPort outputPort)
        {
            this.validateHandler = validateHandler;
            this.outputPort = outputPort;

            this.validateHandler.SetSucessor(saveHandler);
        }

        public void Execute(CustomerSaveRequest request)
        {
            try
            {
                validateHandler.ProcessRequest(request);
                outputPort.Standard(request.Customer.Id);
            }
            catch (Exception ex)
            {
                outputPort.Error($"Error on process: {ex.Message}");
            }
        }
    }
}
