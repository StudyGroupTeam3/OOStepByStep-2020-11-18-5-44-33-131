using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Student : Person
    {
        private IClass studentClass;

        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, IClass studentClass) : base(name, age)
        {
            this.studentClass = studentClass;
        }

        public override string Introduce()
        {
            return this.studentClass == null ? $"{base.Introduce()} I am a student." : $"{base.Introduce()} I am a student of class {studentClass.GetClassNumber()}.";
        }
    }
}
