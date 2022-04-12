namespace Fizz_Buzz.infrastructure.handlers.DataValidation
{
    public class NaNValidationHandler : Handler<string[]>
    {
        public override void Handle(string[] request)
        {
            if (!decimal.TryParse(request[0], out _))
            {
                request[1] = Constants.InvalidItem;
            }
            else
            base.Handle(request);
        }
    }
}
