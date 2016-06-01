using System;
using DecoratorPatternDemo.Interfaces;

namespace DecoratorPatternDemo.MessageWriters
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}