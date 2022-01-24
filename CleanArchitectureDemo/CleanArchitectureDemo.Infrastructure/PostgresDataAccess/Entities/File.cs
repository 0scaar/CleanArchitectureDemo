using CleanArchitectureDemo.Domain.File.Enum;
using System;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Infrastructure.PostgresDataAccess.Entities
{
    public class File: Entity
    {
        public Guid? IdParent { get; set; }
        public string FileName { get; set; }
        public DateTime InclusionDate { get; set; }
        public Status Status { get; set; }
        public TypeRegister Type { get; set; }
        public virtual List<Log> Logs { get; set; }
    }
}
