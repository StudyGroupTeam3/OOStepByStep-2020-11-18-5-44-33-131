namespace OOStepByStep
{
    using System;
    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        protected string Name { get; }
        protected int Age { get; }

        public virtual string SelfIntroduce()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }
    }

    public class Student : Person
    {
        private readonly string vocation;
        public Student(string name, int age) : base(name, age)
        {
            vocation = "student";
        }

        public override string SelfIntroduce()
        {
            return $"My name is {Name}. I am {Age} years old. I am a {vocation}.";
        }
    }

    public class Teacher : Person
    {
        private readonly string vocation;
        public Teacher(string name, int age) : base(name, age)
        {
            vocation = "teacher";
        }

        public override string SelfIntroduce()
        {
            return $"My name is {Name}. I am {Age} years old. I am a {vocation}.";
        }
    }
}
