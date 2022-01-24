using System;

namespace CleanArchitectureDemo.Domain
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
