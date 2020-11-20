using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private readonly string vocation;
        public Teacher(string name, int age) : base(name, age)
        {
            vocation = "teacher";
        }

        public string ClassNumber { get; set; }

        public override string SelfIntroduce()
        {
            return $"My name is {Name}. I am {Age} years old. I am a {vocation}.";
        }
    }
}
