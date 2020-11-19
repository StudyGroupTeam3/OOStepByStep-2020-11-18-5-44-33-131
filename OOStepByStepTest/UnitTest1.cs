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

        //[Fact]
        //public void Should_Student_introduce_with_vocation()
        //{
        //    //given
        //    string expect = "My name is Tom. I am 21 years old. My name is Tom. I am 18 years old. I am a student.";
        //    var person = new Person();

        //    //when
        //    var actual = person.SelfIntroduce();

        //    //then
        //    Assert.Equal(expect, actual);
        //}

        //[Fact]
        //public void Should_Teacher_introduce_himself_with_vocation()
        //{
        //    //given
        //    string expect = "My name is Amy. I am 30 years old. I am a teacher.";
        //    var person = new Person();

        //    //when
        //    var actual = person.SelfIntroduce();

        //    //then
        //    Assert.Equal(expect, actual);
        //}
    }
}
