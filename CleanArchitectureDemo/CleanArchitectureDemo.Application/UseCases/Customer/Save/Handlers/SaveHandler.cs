using CleanArchitectureDemo.Application.Repositories;
using System;

namespace CleanArchitectureDemo.Application.UseCases.Customer.Save.Handlers
{
    public class SaveHandler : Handler<CustomerSaveRequest>
    {
        private readonly ICustomerWriteOnlyRepository customerWriteOnlyRepository;

        public SaveHandler(ICustomerWriteOnlyRepository customerWriteOnlyRepository)
        {
            this.customerWriteOnlyRepository = customerWriteOnlyRepository;
        }

        public override void ProcessRequest(CustomerSaveRequest request)
        {
            var ret = customerWriteOnlyRepository.Save(request.Customer);
            if (ret == 0)
                throw new ArgumentException("Problem to save Customer");

            if (sucessor != null)
                sucessor.ProcessRequest(request);
        }
    }
}
