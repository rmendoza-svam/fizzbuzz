using Fizz_Buzz.infrastructure;
using Fizz_Buzz.infrastructure.handlers.DataValidation;

namespace Fizz_Buzz.Models
{
    public class Fizz_BuzzModel
    {
        public Fizz_BuzzModel()
        {
            Data = new string[1];
            DataResult = new string[1][];
            initDataResult();
        }
        public Fizz_BuzzModel(int values)
        {
            Data = new string[values];
            DataResult = new string[values][];
            initDataResult();
        }
        private void initDataResult()
        {
            for(int index = 0; index < DataResult.Count(); index++)
            {
                DataResult[index] = new string[3];
            }
        }
        public string[]? Data { get; set; }
        public string[][]? DataResult { get; set; }

        public void CalculateOri()
        {
            //for(int index = 0; index < this.Data.Length; index++)
            //{
            //    if (this.Data[index] == null)
            //        this.DataResult[index, 0] = Constants.EmptyValue;
            //    else
            //        this.DataResult[index, 0] = this.Data[index];
            //    if (!decimal.TryParse(this.Data[index], out decimal number))
            //    {
            //        this.DataResult[index, 1] = Constants.InvalidItem;
            //        continue;
            //    }
            //    setResultValue(number, index);
            //}
        }
        public void Calculate()
        {
            for (int index = 0; index < DataResult.Count(); index++)
            {
                this.DataResult[index][0] = this.Data[index];
            }
            foreach (var item in this.DataResult)
            {
                var handler = new EmptyValidationHandler();
                handler.SetNext(new NonThreeDividedValidationHandler())
                    .SetNext(new NonFiveDividedValidationHandler())
                    .SetNext(new NaNValidationHandler())
                    .SetNext(new ThreeAndFiveValidationHandler())
                    .SetNext(new FiveValidationHandler())
                    .SetNext(new ThreeValidationHandler())
                    ;
                handler.Handle(item);
            }
        }
        void setResultValue(decimal number, int index)
        {
            //bool is3 = divideBy3(number);
            //bool is5 = divideBy5(number);
            //if (is3 && is5)
            //{
            //    this.DataResult[index, 1] = Constants.FizzBuzz;
            //}
            //else if (is3)
            //{
            //    this.DataResult[index, 1] = Constants.Fizz;
            //}
            //else if (is5)
            //{
            //    this.DataResult[index, 1] = Constants.Buzz;
            //}
            //else
            //{
            //    this.DataResult[index, 1] = $"Divided {number} by 3";
            //    this.DataResult[index, 2] = $"Divided {number} by 5";
            //}
        }

        public bool divideBy3(decimal number)
        {
            return number % 3 == 0;
        }
        public bool divideBy5(decimal number)
        {
            return number % 5 == 0;
        }
    }
}
