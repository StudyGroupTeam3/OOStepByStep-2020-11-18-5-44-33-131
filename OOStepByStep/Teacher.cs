using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private IClass teacherClass;

        public Teacher(string name, int age) : base(name, age)
        {
        }

        public Teacher(string name, int age, IClass teacherClass) : base(name, age)
        {
            this.teacherClass = teacherClass;
        }

        public override string Introduce()
        {
            return this.teacherClass == null ? $"{base.Introduce()} I am a teacher." : $"{base.Introduce()} I am a teacher of class {teacherClass.GetClassNumber()}.";
        }
    }
}
