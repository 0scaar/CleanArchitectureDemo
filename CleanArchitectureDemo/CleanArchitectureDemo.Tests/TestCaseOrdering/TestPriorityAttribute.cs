using System;

namespace CleanArchitectureDemo.Tests.TestCaseOrdering
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class TestPriorityAttribute : Attribute
    {
        public int Priority { get; private set; }

        public TestPriorityAttribute(int priority)
        {
            Priority = priority;
        }
    }
}
