using CleanArchitectureDemo.Domain.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureDemo.Application.UseCases.Customer.Save
{
    public class CustomerSaveRequest
    {
        public Domain.Customer.Customer Customer { get; private set; }

        public CustomerSaveRequest(Guid id,
            string name,
            DocumentType documentType,
            string documentNumber,
            int age,
            string email)
        {
            Customer = new Domain.Customer.Customer(id, name, documentType, documentNumber, age, email);
        }

        public CustomerSaveRequest(string name,
            DocumentType documentType,
            string documentNumber,
            int age,
            string email)
        {
            Customer = new Domain.Customer.Customer(Guid.NewGuid(), name, documentType, documentNumber, age, email);
        }
    }
}
