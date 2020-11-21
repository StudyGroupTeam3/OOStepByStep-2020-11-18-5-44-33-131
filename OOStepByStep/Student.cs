using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Student : Person
    {
        private string name;
        private int age;
        private string classNumber;
        public Student(string name, int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }

        public Student(string name, int age, string classNumber) : base(name, age)
        {
            this.name = name;
            this.age = age;
            this.classNumber = classNumber;
        }

        public string Say()
        {
            return $"My name is {this.name}. I am {this.age} years old. I am a student.";
        }

        public string SayWithClassNumber()
        {
            return $"My name is {this.name}. I am {this.age} years old. I am a student of class {this.classNumber}.";
        }
    }
}
