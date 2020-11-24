namespace OOStepByStep
{
    using System;
    public class ClassTwo : IClass
    {
        private string classNumber = "class 2";

        string IClass.Introduce()
        {
            return this.classNumber;
        }
    }
}
