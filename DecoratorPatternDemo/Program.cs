using System;
using DecoratorPatternDemo.Loggers;
using DecoratorPatternDemo.MessageWriters;
using DecoratorPatternDemo.Validators;

namespace DecoratorPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var writer = new ConsoleMessageWriter();
            var writer = new LoggingMessageWriter(new ValidatingMessageWriter(new ConsoleMessageWriter(), new MyValidator()), new ConsoleLogger());

            writer.Write("Hello world!");

            Console.ReadLine();
        }
    }
}
