using System;
using DecoratorPatternDemo.Interfaces;

namespace DecoratorPatternDemo.Loggers
{
    public class SuperDuperLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("SuperDuperLogger -> {0}", message);
        }
    }
}