using DecoratorPatternDemo.Interfaces;
using DecoratorPatternDemo.MessageWriters;
using NSubstitute;
using NUnit.Framework;

namespace DecoratorPatternDemo.Tests
{
    [TestFixture]
    public class LoggingMessageWriterTests
    {
        private IMessageWriter _writer;
        private ILogger _logger;
        private LoggingMessageWriter _decoratedWriter;

        [SetUp]
        public void Setup()
        {
            _writer = Substitute.For<IMessageWriter>();
            _logger = Substitute.For<ILogger>();

            _decoratedWriter = new LoggingMessageWriter(_writer, _logger);
        }

        [Test]
        public void ShouldWriteAndLog()
        {
            const string message = "Hello World!";

            _decoratedWriter.Write(message);

            _writer.Received().Write(message);
            _logger.Received().Log(message);
        }
    }
}