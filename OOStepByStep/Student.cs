namespace OOStepByStep
{
    using System;
    public class Student : Person
    {
        private readonly IClass iClass;
        private string job = "student";
        public Student(string name, int age, IClass iClass) : base(name, age)
        {
            this.iClass = iClass;
        }

        public string StudentIntroduce()
        {
            return this.Introduce() + $" I am a {this.job} of {this.iClass.Introduce()}.";
        }
    }
}
