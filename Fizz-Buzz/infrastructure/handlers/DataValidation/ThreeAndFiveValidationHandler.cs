namespace Fizz_Buzz.infrastructure.handlers.DataValidation
{
    public class ThreeAndFiveValidationHandler : Handler<string[]>
    {
        public override void Handle(string[] request)
        {
            if (!string.IsNullOrEmpty(request[0]) && 
                decimal.TryParse(request[0], out decimal value) && 
                value % 3 == 0 && value % 5 == 0)
            {
                request[1] = Constants.FizzBuzz;
            }
            else
            base.Handle(request);
        }
    }
}
