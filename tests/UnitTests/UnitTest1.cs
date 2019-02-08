using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        int EvenorOdd(int val)
        {
            
            if (val == 0)
            {
                sol.value = "neither even nor odd";
            }
            else if (val % 2 == 0)
            {
                sol.value = "even";
            }
            else
            {
                sol.value = "odd";
            }
        }
    }
}
