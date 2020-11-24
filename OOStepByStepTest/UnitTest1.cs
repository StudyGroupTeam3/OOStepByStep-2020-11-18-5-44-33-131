namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_Person_Say_Name_And_Age()
        {
            //given
            var name = "Tom";
            var age = 21;
            var person = new Person(name, age);
            string expect = "My name is Tom. I am 21 years old.";

            //when
            var actual = person.SelfIntroduce();

            //then
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void Should_Student_introduce_with_vocation()
        {
            //given
            var name = "Tom";
            var age = 18;
            string expect = "My name is Tom. I am 18 years old. I am a student.";
            var person = new Student(name, age);

            //when
            var actual = person.SelfIntroduce();

            //then
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void Should_Teacher_introduce_himself_with_vocation()
        {
            //given
            var name = "Amy";
            var age = 30;
            string expect = "My name is Amy. I am 30 years old. I am a teacher.";
            var person = new Teacher(name, age);

            //when
            var actual = person.SelfIntroduce();

            //then
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void Should_Student_introduce_with_and_class_number()
        {
            //given
            var student = new Student("Tom", 18);
            var teacher = new Teacher("Amy", 30);
            var class2 = new Class(teacher, "class 2");
            class2.AddNewStudent(student);
            string expect = "My name is Tom. I am 18 years old. I am a student of class 2.";

            //when
            var actual = class2.IntroduceStudent(student);

            //then
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void Should_Teacher_introduce_himself_with_vocation_and_class_number()
        {
            //given
            var teacher = new Teacher("Amy", 30);
            var class2 = new Class(teacher, "class 2");
            string expect = "My name is Amy. I am 30 years old. I am a teacher of class 2.";

            //when
            var actual = class2.IntroduceTeacher(teacher);

            //then
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void Should_ClassMember_Welcome_new_comer()
        {
            //given
            var teacher = new Teacher("Amy", 30);
            var student = new Student("Tom", 18);
            var class2 = new Class(teacher, "class 2");
            string expect = "My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Tom join class 2.\n";

            //when
            var actual = class2.AddNewStudent(student);

            //then
            Assert.Equal(expect, actual);
        }

        [Fact]
        public void Should_ClassMembers_Welcome_new_comer()
        {
            //given
            var teacher = new Teacher("Amy", 30);
            var student = new Student("Tom", 18);
            var student2 = new Student("Jim", 18);
            var class2 = new Class(teacher, "class 2");
            class2.AddNewStudent(student);
            string expect = "My name is Amy. I am 30 years old. I am a teacher of class 2. Welcome Jim join class 2.\n"
                + "My name is Tom. I am 18 years old. I am a student of class 2. Welcome Jim join class 2.\n";

            //when
            var actual = class2.AddNewStudent(student2);

            //then
            Assert.Equal(expect, actual);
        }
    }
}
