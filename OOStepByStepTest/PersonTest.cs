using System;
using System.IO;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Fact]
        public void Test_Console()
        {
            // given
            Person person = new Person("Tom", 21);
            string expect = "My name is Tom. I am 21 years old.";

            // when
            string actual = person.Introduce();

            // then
            Assert.Equal(expect, actual);
        }
    }
}
