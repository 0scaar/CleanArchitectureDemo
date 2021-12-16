using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitectureDemo.Domain
{
    public interface IEntity
    {
        Guid Id { get; set; }
    }
}
