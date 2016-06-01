﻿using System;
using DecoratorPatternDemo.Interfaces;

namespace DecoratorPatternDemo.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("ConsoleLogger -> {0}", message);
        }
    }
}