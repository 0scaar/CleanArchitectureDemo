using CleanArchitectureDemo.Domain.Log.Enum;
using System;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Infrastructure.PostgresDataAccess.Entities
{
    public class Log : Entity
    {
        public string Service { get; set; }
        public string Message { get; set; }
        public DateTime DateLog { get; set; }
        public TypeLog TypeLog { get; set; }
        public string StackTrace { get; set; }
        public Guid? FileId { get; set; }
        public virtual List<LogDetail> LogDetails { get; set; }
    }
}
