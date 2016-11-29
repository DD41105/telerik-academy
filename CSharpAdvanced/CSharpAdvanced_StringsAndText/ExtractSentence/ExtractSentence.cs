using System;

namespace ExtractSentence
{
    class ExtractSentence
    {
        static bool SentenceContainsWord(string sentence, string word)
        {
            for (int sIndex = 0; ;)
            {
                int rc = sentence.IndexOf(word, sIndex);
                if (rc < 0)
                {
                    return false;
                }
                if (rc == 0)
                {
                    if (rc + word.Length == sentence.Length) return true;
                    if (!char.IsLetter(sentence[rc + word.Length])) return true;
                }
                else
                {
                    if (!char.IsLetter(sentence[rc - 1]) && (rc + word.Length == sentence.Length || !char.IsLetter(sentence[rc + word.Length]))) return true;
                }
                sIndex = rc + word.Length;
            }
        }

        static void Main(string[] args)
        {
            string wrd = Console.ReadLine();
            string str = Console.ReadLine();
            for (int curPos = 0; ;)
            {
                int rc = str.IndexOf('.', curPos);
                string curSentance;
                if (rc < 0)
                {
                    curSentance = str.Substring(curPos);
                    if (SentenceContainsWord(curSentance, wrd)) Console.Write(curSentance);
                    break;
                }
                //rc - curPos instead of rc - curPos + 1 will not put put the delimiter "." in the end of curSentance
                curSentance = str.Substring(curPos, rc - curPos);
                if (SentenceContainsWord(curSentance, wrd))
                {
                    Console.Write(curSentance.Trim() + ". ");
                }
                curPos = rc + 1;
            }
        }
    }
}