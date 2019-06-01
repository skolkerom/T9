namespace T9Api
{
    public class T9InputProcessor
    {
        private DigitProcessor digitProcessor;
        private char currentNumber;
        private string result;
        private string currentChar;

        public T9InputProcessor()
        {
            digitProcessor = new DigitProcessor();
            currentNumber = char.MinValue;
        }

        public (string res, string lastChar) this[char number]
        {
            get
            {
                if (currentNumber != number)
                {
                    result += currentChar;

                    currentChar = digitProcessor.GetLetter(number).ToString();

                    currentNumber = number;
                }
                else
                    currentChar = digitProcessor.GetLetter(number).ToString();

                return (result, currentChar);
            }
        }
    }
}
