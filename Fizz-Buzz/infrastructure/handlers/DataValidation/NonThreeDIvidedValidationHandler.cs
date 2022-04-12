namespace Fizz_Buzz.infrastructure.handlers.DataValidation
{
    public class NonThreeDividedValidationHandler : Handler<string[]>
    {
        public override void Handle(string[] request)
        {
            if (!string.IsNullOrEmpty(request[0]) &&
                decimal.TryParse(request[0], out decimal value) &&
                value % 3 != 0)
            {
                request[1] = $"Devided {request[0]} By 3";
            }
            base.Handle(request);
        }
    }
}
