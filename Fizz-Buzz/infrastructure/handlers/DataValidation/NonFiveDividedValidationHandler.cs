namespace Fizz_Buzz.infrastructure.handlers.DataValidation
{
    public class NonFiveDividedValidationHandler : Handler<string[]>
    {
        public override void Handle(string[] request)
        {
            if (!string.IsNullOrEmpty(request[0]) &&
                decimal.TryParse(request[0], out decimal value) &&
                value % 5 != 0 && value % 3 != 0)
            {
                request[(value % 3 != 0) ? 2 : 1] = $"Devided {request[0]} By 5";
            }
            base.Handle(request);
        }
    }
}
