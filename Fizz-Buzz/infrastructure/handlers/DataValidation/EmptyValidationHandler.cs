namespace Fizz_Buzz.infrastructure.handlers.DataValidation
{
    public class EmptyValidationHandler : Handler<string[]>
    {
        public override void Handle(string[] request)
        {
            if (string.IsNullOrEmpty(request[0]))
            {
                request[0] = Constants.EmptyValue;
                request[1] = Constants.InvalidItem;
            }
            else
            base.Handle(request);
        }
    }
}
