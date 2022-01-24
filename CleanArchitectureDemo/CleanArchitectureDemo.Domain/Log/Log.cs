using CleanArchitectureDemo.Domain.Log.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitectureDemo.Domain.Log
{
    public class Log : Entity
    {
        public string Service { get; private set; }
        public Guid? FileId { get; private set; }
        public string Message { get; private set; }
        public DateTime DateLog { get; private set; }
        public TypeLog TypeLog { get; private set; }
        public string StackTrace { get; private set; }
        public List<LogDetail> LogDetails { get; set; }

        #region constructors
        public Log()
        {
        }

        public Log(string service, string message, TypeLog typeLog)
        {
            Id = Guid.NewGuid();
            Service = GetString(service, 50);
            Message = GetString(message, 400);
            DateLog = DateTime.UtcNow;
            TypeLog = typeLog;
        }
        public Log(string service, string message, TypeLog typeLog, string stackTrace)
        {
            Id = Guid.NewGuid();
            Service = GetString(service, 50);
            Message = GetString(message, 400);
            DateLog = DateTime.UtcNow;
            TypeLog = typeLog;
            StackTrace = GetString(stackTrace, 3000);
        }
    
        #endregion

        #region Auxiliar methods
        private string GetString(string str, int maxIndex)
        {
            return new string(str?.Take(maxIndex).ToArray());
        }
        #endregion

        
    }
}
