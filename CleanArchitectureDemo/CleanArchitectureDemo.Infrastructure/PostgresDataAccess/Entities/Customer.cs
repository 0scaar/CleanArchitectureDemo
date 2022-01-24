using CleanArchitectureDemo.Domain.Customer;

namespace CleanArchitectureDemo.Infrastructure.PostgresDataAccess.Entities
{
    public class Customer : Entity
    {
        public string Name { get; private set; }
        public DocumentType DocumentType { get; private set; }
        public string DocumentNumber { get; private set; }
        public int Age { get; private set; }
        public string Email { get; private set; }
    }
}
