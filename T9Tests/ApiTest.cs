using System;
using T9Api;
using Xunit;

namespace T9Tests
{  
    public class T9TestSuite
    {   
        [Theory]
        [InlineData("0", " ")]
        [InlineData("0 0", "  ")]
        [InlineData("44 444", "hi")]
        [InlineData("999337777", "yes")]
        [InlineData("333666 6660 022 2777", "foo  bar")]
        [InlineData("4433555 555666096667775553", "hello world")]
        public void BulkProcessorReturnsCorrectLettersByNumber(string input, string expectedLetters)
        {
            var t9Processor = new T9InputBulkProcessor();
            var actualLetter = t9Processor.GetLetters(input);
            Assert.Equal(expectedLetters, actualLetter);
        }

        [Fact]
        public void DigitProcessorThrowsArgumentExceptionWhenInputIsNotDigit()
        {
            var t9Processor = new T9InputProcessor();
            Assert.Throws<ArgumentException>(() => t9Processor['x']);
        }
    }
}
