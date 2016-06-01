using DecoratorPatternDemo.Interfaces;
using DecoratorPatternDemo.MessageWriters;
using NSubstitute;
using NUnit.Framework;

namespace DecoratorPatternDemo.Tests
{
    [TestFixture]
    public class ValidatingMessageWriterTests
    {
        private IMessageWriter _writer;
        private IValidator _validator;
        private ValidatingMessageWriter _decoratedWriter;

        [SetUp]
        public void Setup()
        {
            _writer = Substitute.For<IMessageWriter>();
            _validator = Substitute.For<IValidator>();

            _decoratedWriter = new ValidatingMessageWriter(_writer, _validator);
        }

        [Test]
        public void ShouldWriteValidMessage()
        {
            const string message = "Hello World!";

            _validator.IsValid(message).Returns(true);

            _decoratedWriter.Write(message);

            _writer.Received().Write(message);
        }

        [Test]
        public void ShouldNotWriteInvalidMessage()
        {
            const string message = "Hello World!";

            _validator.IsValid(message).Returns(false);

            _decoratedWriter.Write(message);

            _writer.DidNotReceive().Write(message);
            _writer.Received().Write(Arg.Any<string>());
        }
    }
}
