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
            string expect = "My name is Tom. I am 21 years old";
            var person = new Person();

            //when
            var actual = person.SelfIntroduce();

            //then
            Assert.Equal(expect, actual);
        }
    }
}
