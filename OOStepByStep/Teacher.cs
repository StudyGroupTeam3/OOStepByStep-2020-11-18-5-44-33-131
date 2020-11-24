using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private string name;
        private int age;
        private string classNumber;

        public Teacher(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

        public Teacher(string name, int age, string classNumber) : base(name, age)
        {
            this.name = name;
            this.age = age;
            this.classNumber = classNumber;
        }

        public string Say()
        {
            return $"My name is {this.name}. I am {this.age} years old. I am a teacher.";
        }

        public string SayWithClassNumber()
        {
            return $"My name is {this.name}. I am {this.age} years old. I am a teacher of class {this.classNumber}.";
        }
    }
}
