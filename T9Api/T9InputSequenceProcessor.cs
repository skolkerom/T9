using System;

namespace T9Api
{
    public class T9InputSequenceProcessor
    {
        private T9InputProcessor t9;

        public T9InputSequenceProcessor()
        {
            t9 = new T9InputProcessor();
        }

        public string GetNextLetter(char number)
        {
            return t9[number].lastChar;
        }
    }
}
