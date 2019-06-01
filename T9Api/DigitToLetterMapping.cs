namespace T9Api
{
    public class DigitToLetterMapping
    {
        string[] mapping = {
            "   ",
            "   ",
            "abc",
            "def",
            "ghi",
            "jkl",
            "mno",
            "pqrs",
            "tuv",
            "wxyz"
        };

        public char this[int number, int count]
        {
            get {
                var s = mapping[number];

                if (count >= s.Length)
                    count = count % s.Length;

                return s[count]; }
        }
        
    }
}
