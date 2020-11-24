using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        public Teacher(string name, int age) : base(name, age)
        {
        }

        public override string Introduce()
        {
            return base.Introduce() + " I am a teacher.";
        }

        public string IntroduceWithClass(IClass classNumber)
        {
            return this.Introduce() + $" I am a teacher of" + $"{classNumber.ClassNumber()}";
        }

        public string IntroduceWithWelcome(IClass classNumber, Student newStudent)
        {
            return this.IntroduceWithClass(classNumber) + $" Welcome {newStudent.Name} join{classNumber.ClassNumber()}";
        }
    }
}
