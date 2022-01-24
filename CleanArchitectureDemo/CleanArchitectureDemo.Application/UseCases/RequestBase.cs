using FluentValidation.Internal;
using CleanArchitectureDemo.Domain.Log;
using CleanArchitectureDemo.Domain.Log.Enum;
using CleanArchitectureDemo.Domain.Utils;
using System;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Application.UseCases
{
    public abstract class RequestBase
    {
        public List<Log> Logs { get; private set; }

        public RequestBase()
        {
            Logs = new List<Log>();
        }

        public void AddProcessingLog(string message, Type typeFrom)
            => Logs.Add(new Log($"Log from {typeFrom.Name}", message, TypeLog.Processing));

        public void AddExceptionLog(string message, string stackTrace, Type typeFrom)
            => Logs.Add(new Log($"Log from {typeFrom.Name}", message, TypeLog.Error, stackTrace));

        public void AddExceptionLog(string message, string stackTrace)
            => Logs.Add(new Log($"Log from {GetType().GetLastNameSpace()}", message, TypeLog.Error, stackTrace));

        public void AddProcessingLog(string message)
            => Logs.Add(new Log($"Log from {GetType().GetLastNameSpace()}", message, TypeLog.Processing));

        public void AddProcessingLog(string message, TypeLog typeLog)
            => Logs.Add(new Log($"Log from {GetType().GetLastNameSpace()}", message, typeLog));
    }
}
