using System;

namespace CleanArchitectureDemo.Infrastructure.PostgresDataAccess.Entities
{
    public class LogDetail : Entity
    {
        public string Line { get; set; }
        public string Message { get; set; }
        public Guid LogId { get; set; }
    }
}
