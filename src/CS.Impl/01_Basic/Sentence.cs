using System;

namespace CS.Impl._01_Basic
{
    public class Sentence
    {
        public string Reverse(string sentence)
        {
            string[] splitSentence = sentence.Split(' ');
            Array.Reverse(splitSentence);
            
            return String.Join(' ', splitSentence);
        }
    }
}
