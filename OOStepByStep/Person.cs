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

        internal protected string Name { get; }
        protected int Age { get; }

        public virtual string SelfIntroduce()
        {
            return $"My name is {Name}. I am {Age} years old.";
        }
    }
}
