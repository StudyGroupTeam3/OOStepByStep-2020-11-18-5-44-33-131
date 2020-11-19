using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Student : Person
    {
        private string name;
        private int age;

        public Student(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

        public string Say()
        {
            return $"My name is {this.name}. I am {this.age} years old. I am a student.";
        }
    }
}
