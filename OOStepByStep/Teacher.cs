namespace OOStepByStep
{
    using System;
    public class Teacher : Person
    {
        private readonly IClass iClass;
        private string job = "teacher";
        public Teacher(string name, int age, IClass iClass) : base(name, age)
        {
            this.iClass = iClass;
        }

        public string TeacherIntroduce()
        {
            return this.Introduce() + $" I am a {this.job} of {this.iClass.Introduce()}.";
        }
    }
}
