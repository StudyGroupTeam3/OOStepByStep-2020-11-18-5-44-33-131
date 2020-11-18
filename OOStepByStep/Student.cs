using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            return base.Introduce() + " I am a student.";
        }

        public string IntroduceWithClass(IClass classNumber)
        {
            return this.Introduce() + $" I am a student of" + $"{classNumber.ClassNumber()}";
        }
    }
}
