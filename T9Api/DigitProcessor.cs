using System;

namespace T9Api
{
    public class DigitProcessor
    {
        private DigitToLetterMapping mapping;
        private int count;
        private int currentNumber;

        public DigitProcessor()
        {
            mapping = new DigitToLetterMapping();
        }

        public char? GetLetter(char charToNumber)
        {
            if (char.IsWhiteSpace(charToNumber))
            {
                count = 0;
                return null;
            }

            var number = (int)char.GetNumericValue(charToNumber);

            if (number == -1)
                throw new ArgumentException("Incorrect input. Only digits allowed");

            if (currentNumber != number)
            {
                count = 0;
                currentNumber = number;
            }

            var letter = mapping[currentNumber, count++];
            
            return letter;
        }
    }
}
