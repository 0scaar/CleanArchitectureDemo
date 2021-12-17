using CleanArchitectureDemo.Domain.Customer;
using System;

namespace CleanArchitectureDemo.Tests.Builders
{
    public class CustomerBuilder
    {
        public Guid Id;
        public DocumentType DocumentType;
        public string DocumentNumber;
        public string Name;
        public int Age;
        public string Email;

        public static CustomerBuilder New()
        {
            return new CustomerBuilder()
            {
                Id = Guid.NewGuid(),
                DocumentType = DocumentType.Passport,
                DocumentNumber = "4537563456",
                Name = "Angus Young",
                Age = 66,
                Email = "angus@acdc.com"
            };
        }

        public CustomerBuilder WithId(Guid id)
        {
            Id = id;
            return this;
        }

        public CustomerBuilder WithDocumentType(DocumentType documentType)
        {
            DocumentType = documentType;
            return this;
        }

        public CustomerBuilder WithDocumentNumber(string documentNumber)
        {
            DocumentNumber = documentNumber;
            return this;
        }

        public CustomerBuilder WithName(string name)
        {
            Name = name;
            return this;
        }

        public CustomerBuilder WithAge(int age)
        {
            Age = age;
            return this;
        }

        public CustomerBuilder WithEmail(string email)
        {
            Email = email;
            return this;
        }

        public Customer Build()
        {
            return new Customer(Id, Name, DocumentType, DocumentNumber, Age, Email);
        }
    }
}
