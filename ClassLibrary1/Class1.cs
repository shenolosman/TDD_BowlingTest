using System;

namespace ClassLibrary1
{
    public class Class1
    {

        /*
         * Metod Beskrivning
public int StringLength(params string[] array) Den här metoden ska räkna ut den sammanlagda 
längden av alla strängar i listan.
Tester
• ”Hello”,”World”
• Tom lista
• Null
• String[]{”Hello”,null,”World”
         */
        public int? StringLength(string[] strings)
        {
            int res = 0;
            if (strings==null)
            {
                return null;
            }
            foreach (var str in strings)
                res += str.Length;
            return res;
        }

        public int GetSum(int[] numbers)
        {
            int res = 0;
            foreach (var number in numbers)
            {
                res += number;
            }

            return res;
        }
    }
}

