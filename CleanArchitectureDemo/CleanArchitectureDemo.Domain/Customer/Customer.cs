using CleanArchitectureDemo.Domain.Validator;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureDemo.Domain.Customer
{
    public class Customer : Entity
    {
        public string Name { get; private set; }
        public string DocumentType { get; private set; }
        public string DocumentNumber { get; private set; }
        public int Age { get; private set; }
        public string Email { get; private set; }

        public Customer(string name, string documentType, string documentNumber, 
            int age, string email)
        {
            Name = name;
            DocumentType = documentType;
            DocumentNumber = documentNumber;
            Age = age;
            Email = email;

            Validate(this, new CustomerValidator());
        }
    }
}
