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
            string expected = "My name is Tom. I am 21 years old";
            //then
            Assert.Equal(expected, actual);
        }
    }
}
