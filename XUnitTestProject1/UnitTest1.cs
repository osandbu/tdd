using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var text = IntToTextConverter.Convert(1);
            Assert.Equal("en", text);
        }

        [Theory]
        [InlineData(2, "to")]
        [InlineData(3, "tre")]
        [InlineData(4, "fire")]
        [InlineData(5, "fem")]
        [InlineData(6, "seks")]
        [InlineData(7, "sju")]
        [InlineData(8, "åtte")]
        [InlineData(9, "ni")]
        public void Test9(int input, string expected)
        {
            var text = IntToTextConverter.Convert(input);
            Assert.Equal(expected, text);
        }
    }
}
