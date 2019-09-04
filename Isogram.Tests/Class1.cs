using System;
using Xunit;
using isogram_csharp_problem;

namespace Isogram.Tests
{
    public class Class1
    {

        [Theory]
        [InlineData("",true)]
        [InlineData("isogram",true)]
        [InlineData("eleven",false)]
        [InlineData("subdermatoglyphic", true)]
        [InlineData("Alphabet", true)]
        [InlineData("thumbscrew-japingly", true)]
        [InlineData("six-year-old", true)]
        [InlineData("Q w E", true)]
        [InlineData("QWERTYUIOPASDFGHJKLZXCVBNM - - -qwertyuiop  asdfghjkl zxcvbnm", true)]
        [InlineData("QWERTYUIOPASDFGHJKLZXCVBNM - - -qwerrtyuiop  asdfghjkl zxcvbnm", false)]

        public void IsIsogram(string value,bool y)
        {
            var result = Program.isIsogram(value);

            Assert.Equal(result,y);
        }
    }
}
