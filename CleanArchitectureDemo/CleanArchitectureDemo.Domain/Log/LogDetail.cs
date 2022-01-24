using System;

namespace CleanArchitectureDemo.Domain.Log
{
    public class LogDetail : Entity
    {
        public string Line { get; private set; }
        public string Message { get; private set; }
        public Guid LogId { get; private set; }

        public LogDetail(string line, string message)
        {
            Line = line;
            Message = message;
        }
    }
}
