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

        [Fact]
        public void ShouldReturnIntroductionGivenAStudent()
        {
            // given
            string expected = "My name is Tom. I am 18 years old. I am a student.";

            // when
            Student student = new Student("Tom", 18);
            string actual = student.Say();

            // then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnIntroductionGivenATeacher()
        {
            // given
            string expected = "My name is Amy. I am 30 years old. I am a teacher.";

            // when
            Teacher teacher
                = new Teacher("Amy", 30);
            string actual = teacher.Say();

            // then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShouldReturnIntroductionGivenAStudentAndClassNumber()
        {
            // given
            string expected = "My name is Tom. I am 18 years old. I am a student of class 2.";

            // when
            Student student = new Student("Tom", 18, "2");
            string actual = student.SayWithClassNumber();

            // then
            Assert.Equal(expected, actual);
        }
    }
}
