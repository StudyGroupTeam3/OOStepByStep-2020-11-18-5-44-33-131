using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class ConsoleTest
    {
        [Fact]
        public void ShouldReturnIntroductionGivenAPerson()
        {
            // given
            string expected = "My name is Tom. I am 21 years old.";

            // when
            Person person = new Person("Tom", 21);
            string actual = person.Say();

            // then
            Assert.Equal(expected, actual);
        }
    }
}
