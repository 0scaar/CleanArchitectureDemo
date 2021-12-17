using System;

namespace CleanArchitectureDemo.Application.UseCases.Customer.Delete
{
    public class CustomerDeleteRequest
    {
        public Guid Id { get; private set; }

        public CustomerDeleteRequest(Guid id)
        {
            Id = id;
        }
    }
}
