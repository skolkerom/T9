namespace T9Api
{
    public class T9InputBulkProcessor
    {
        private T9InputProcessor t9;

        public T9InputBulkProcessor()
        {
            t9 = new T9InputProcessor();
        }

        public string GetLetters(string numbers)
        {
            (string result, string lastChar) = ("", "");

            foreach (var n in numbers)
                (result, lastChar) = t9[n];

            return result + lastChar;
        }
    }
}
