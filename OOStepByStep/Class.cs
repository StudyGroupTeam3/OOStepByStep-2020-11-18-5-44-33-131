using System;
using System.Collections.Generic;
using System.Text;

namespace OOStepByStep
{
    public class Class : IClass
    {
        private int classNumber;

        public Class(int classNumber)
        {
            this.classNumber = classNumber;
        }

        public int GetClassNumber()
        {
            return this.classNumber;
        }
    }
}
