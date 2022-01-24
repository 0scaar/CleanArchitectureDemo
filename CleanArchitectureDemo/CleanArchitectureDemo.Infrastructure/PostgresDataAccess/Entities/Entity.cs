using System;

namespace CleanArchitectureDemo.Infrastructure.PostgresDataAccess.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
    }
}
