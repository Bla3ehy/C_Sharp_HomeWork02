using System;

namespace HomeWork002
{
    public class MyClass
    {
        public bool StringTest(string input)
        {
            char[] inPutArray = input.ToCharArray();
            Array.Reverse(inPutArray);
            string RevInPutArray = new string(inPutArray);

            if (input.Equals(RevInPutArray))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}