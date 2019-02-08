using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var outcome = "odd";
            var a = 5;
            var actual = EvenorOdd(5);
            Assert.Equal(outcome, actual);
        }
        [Theory]
        [InlineData(4, "even")]
        public void Test2(int a, String b)
        {
            Assert.Equal(b, EvenorOdd(a));
        }
        String EvenorOdd(int val)
        {
            var str =" ";
            
            if (val == 0)
            {
                str = "neither even nor odd";
            }
            else if (val % 2 == 0)
            {
               str = "even";
            }
            else if (val < 0)
            {
                str = "Negative number";
            }
            else
            {
                str = "odd";
            }
            return str;
            
        }
    }
}
