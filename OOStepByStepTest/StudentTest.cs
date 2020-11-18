using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;
    public class StudentTest
    {
        [Fact]
        public void Should_return_student_introduction_when_introduce()
        {
            // given
            Student student = new Student("Tom", 18);
            string expect = "My name is Tom. I am 18 years old. I am a student.";

            // when
            string actual = student.Introduce();

            // then
            Assert.Equal(expect, actual);
        }
    }
}
