using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;
    public class TeacherTest
    {
        [Fact]
        public void Should_return_teacher_introduction_when_introduce()
        {
            // given
            Teacher teacher = new Teacher("Amy", 30);
            string expect = "My name is Amy. I am 30 years old. I am a teacher.";

            // when
            string actual = teacher.Introduce();

            // then
            Assert.Equal(expect, actual);
        }
    }
}
