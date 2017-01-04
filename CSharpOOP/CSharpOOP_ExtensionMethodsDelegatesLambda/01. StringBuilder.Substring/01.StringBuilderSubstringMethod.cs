using System.Text;

namespace CSharpOOP_ExtMethodsDelegatesLambda
{
    public static class Program
    {
        public static StringBuilder SubstringMethod(this string text, int index, int lenght = 0)
        {
            var builder = new StringBuilder();

            for (int i = index; i < lenght; i++)
            {
                builder.Append(text[i]);
            }

            return new StringBuilder(builder.ToString());
        }
    }
}