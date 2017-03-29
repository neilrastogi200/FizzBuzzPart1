namespace InformaFizzBuzz
{
    public class Calculation : ICalculation
    {
        public string DisplayNumber(int number)
        {
            if (IsFizzBuzz(number))
            {
                return "fizzbuzz";
            }
            if (IsFizz(number))
            {
                return "fizz";
            }
            return IsBuzz(number) ? "buzz" : number.ToString();
        }


        private bool IsFizz(int i)
        {
            return (i%3 == 0);
        }

        private bool IsBuzz(int i)
        {
            return (i%5 == 0);
        }

        private bool IsFizzBuzz(int i)
        {
            return (i%15 == 0);
        }
    }
}