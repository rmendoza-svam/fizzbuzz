namespace Fizz_Buzz.infrastructure.handlers.DataValidation
{
    public class FiveValidationHandler : Handler<string[]>
    {
        public override void Handle(string[] request)
        {

            if (decimal.TryParse(request[0], out decimal value) && 
                value %  5 == 0 && value % 3 != 0)
            {
                request[1] = Constants.Buzz;
            }
            else
            base.Handle(request);
        }
    }
}
