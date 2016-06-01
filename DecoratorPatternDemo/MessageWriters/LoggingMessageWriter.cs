using System;
using DecoratorPatternDemo.Interfaces;

namespace DecoratorPatternDemo.MessageWriters
{
    public class LoggingMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter _writer;
        private readonly ILogger _logger;

        public LoggingMessageWriter(IMessageWriter writer, ILogger logger)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));

            _writer = writer;
            _logger = logger;
        }

        public void Write(string message)
        {
            _writer.Write(message);
            _logger.Log(message);
        }
    }
}