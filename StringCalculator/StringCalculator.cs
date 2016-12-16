namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbersToParse)
        {
            if (ThereAreNo(numbersToParse))
            {
                return 0;
            }

            if (numbersToParse.Contains(","))
            {
                var singleNumbers = numbersToParse.Split(',');

                var firstNumberToParse = singleNumbers[0];
                var secondNumberToParse = singleNumbers[1];

                var firstNumber = int.Parse(firstNumberToParse);
                var secondNumber = int.Parse(secondNumberToParse);

                return firstNumber + secondNumber;
            }

            var number = int.Parse(numbersToParse);
            return number;
        }

        private static bool ThereAreNo(string numbersToParse)
        {
            return string.IsNullOrEmpty(numbersToParse);
        }
    }
}