using System;
using DecoratorPatternDemo.Interfaces;

namespace DecoratorPatternDemo.MessageWriters
{
    public class ValidatingMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter _writer;
        private readonly IValidator _validator;

        public ValidatingMessageWriter(IMessageWriter writer, IValidator validator)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));
            if (validator == null)
                throw new ArgumentNullException(nameof(validator));
            _writer = writer;
            _validator = validator;
        }

        public void Write(string message)
        {
            if (_validator.IsValid(message))
                _writer.Write(message);
            else
                _writer.Write("Validation: The message is not valid");
        }
    }
}