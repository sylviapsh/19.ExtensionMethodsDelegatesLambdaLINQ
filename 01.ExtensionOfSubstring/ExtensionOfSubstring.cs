using System;
using System.Text;
//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace ExtensionOfSubstring
{
    public static class ExtensionOfSubstring
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int length)
        {
            //Check if the index has a correct value
            if (index < 0 || index >= text.Length || index + length > text.Length)
            {
                throw new IndexOutOfRangeException(); 
            }
            else
            {
                //Build the substring
                StringBuilder resultText = new StringBuilder();

                for (int i = index; i < index + length; i++)
                {
                    resultText.Append(text[i]);
                }

                return resultText;
            }
        }

        public static StringBuilder Substring(this StringBuilder text, int index)
        {
            return text.Substring(index, text.Length - index);
        }
    }
}
