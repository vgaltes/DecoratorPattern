using DecoratorPatternDemo.Interfaces;

namespace DecoratorPatternDemo.Validators
{
    public class MyValidator : IValidator
    {
        public bool IsValid(string message)
        {
            return !string.IsNullOrEmpty(message);
        }
    }
}