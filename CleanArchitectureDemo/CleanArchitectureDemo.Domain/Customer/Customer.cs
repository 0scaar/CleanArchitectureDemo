using CleanArchitectureDemo.Domain.Validator;
using System;

namespace CleanArchitectureDemo.Domain.Customer
{
    public class Customer : Entity
    {
        public string Name { get; private set; }
        public DocumentType DocumentType { get; private set; }
        public string DocumentNumber { get; private set; }
        public int Age { get; private set; }
        public string Email { get; private set; }

        public Customer(Guid id, 
            string name, 
            DocumentType documentType, 
            string documentNumber, 
            int age, 
            string email)
        {
            Id = id;
            Name = name;
            DocumentType = documentType;
            DocumentNumber = documentNumber;
            Age = age;
            Email = email;

            Validate(this, new CustomerValidator());
        }
    }
}
