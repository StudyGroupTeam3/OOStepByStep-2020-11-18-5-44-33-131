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

        [Fact]
        public void IntroduceStudent()
        {
            // given
            var student = new Student("Tom", 18);
            var expectResult = "My name is Tom. I am 18 years old. I am a student.";

            // when
            var actual = student.Introduce();

            // then
            Assert.Equal(expectResult, actual);
        }

        [Fact]
        public void IntroduceTeacher()
        {
            // given
            var teacher = new Teacher("Amy", 30);
            var expectResult = "My name is Amy. I am 30 years old. I am a teacher.";

            // when
            var actual = teacher.Introduce();

            // then
            Assert.Equal(expectResult, actual);
        }

        [Fact]
        public void IntroduceWithClassNumberTeacher()
        {
            // given
            var teacher = new Teacher("Amy", 30);
            var expectResult = "My name is Amy. I am 30 years old. I am a teacher. I am a teacher of class 2.";
            var classNumber = new Class2();

            // when
            var actual = teacher.IntroduceWithClass(classNumber);

            // then
            Assert.Equal(expectResult, actual);
        }

        [Fact]
        public void IntroduceWithClassNumberStudent()
        {
            // given
            var teacher = new Student("Tom", 18);
            var expectResult = "My name is Tom. I am 18 years old. I am a student. I am a student of class 2.";
            var classNumber = new Class2();

            // when
            var actual = teacher.IntroduceWithClass(classNumber);

            // then
            Assert.Equal(expectResult, actual);
        }

        [Fact]
        public void IntroduceTeacherAndWelcome()
        {
            // given
            var teacher = new Teacher("Amy", 30);
            var expectResult = "My name is Amy. I am 30 years old. I am a teacher. I am a teacher of class 2. Welcome Jim join class 2.";
            var classNumber = new Class2();
            var newStudent = new Student("Jim", 20);

            // when
            var actual = teacher.IntroduceWithWelcome(classNumber, newStudent);

            // then
            Assert.Equal(expectResult, actual);
        }

        [Fact]
        public void IntroduceStudentAndWelcome()
        {
            // given
            var student = new Student("Tom", 18);
            var expectResult = "My name is Tom. I am 18 years old. I am a student. I am a student of class 2. Welcome Jim join class 2.";
            var classNumber = new Class2();
            var newStudent = new Student("Jim", 20);

            // when
            var actual = student.IntroduceWithWelcome(classNumber, newStudent);

            // then
            Assert.Equal(expectResult, actual);
        }
    }
}
