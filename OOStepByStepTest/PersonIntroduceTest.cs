using System;
using System.Collections.Generic;
using System.Text;
using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
    public class PersonIntroduceTest
    {
        [Fact]
        public void IntroduceSelf()
        {
            // given
            var person = new Person("Tom", 21);
            var expectResult = "My name is Tom. I am 21 years old.";

            // when
            var actual = person.Introduce();

            // then
            Assert.Equal(expectResult, actual);
        }
    }
}
