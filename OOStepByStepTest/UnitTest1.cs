namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_Person_Introduce_Name_Age()
        {
            //given
            Person person = new Person("Tom", 21);
            //when
            string actual = person.Introduce();
            string expected = "My name is Tom. I am 21 years old.";
            //then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Student_Introduce_Name_Age_Job()
        {
            //given
            Student student = new Student("Tom", 18);
            //when
            string actual = student.StudentIntroduce();
            string expected = "My name is Tom. I am 18 years old. I am a student.";
            //then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Teacher_Introduce_Name_Age_Job()
        {
            //given
            Teacher teacher = new Teacher("Amy", 30);
            //when
            string actual = teacher.TeacherIntroduce();
            string expected = "My name is Amy. I am 30 years old. I am a teacher.";
            //then
            Assert.Equal(expected, actual);
        }
    }
}
