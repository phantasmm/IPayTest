using System;

namespace IPay88Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string indexStr = Console.ReadLine();

            string[] indexSplit = indexStr.Split(' ');

            int startIndex = 0, endIndex = 0;
            try
            {
                startIndex = Convert.ToInt32(indexSplit[0]);
                endIndex = Convert.ToInt32(indexSplit[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // StringProcessing(text, startIndex, endIndex); //for Substring Method
            StringProcessingV2(text, startIndex, endIndex); //for No use C# library


        }
        public static void StringProcessing(string text, int startIndex, int endIndex)
        {
            Console.WriteLine(text.Substring(startIndex, endIndex - startIndex));
            return;
        }

        public static void StringProcessingV2(string text, int startIndex, int endIndex)
        {
            string ans = "";
            for (int i = startIndex; i < endIndex; i++)
            {
                ans += text[i];
            }
            Console.WriteLine(ans);
            return;
        }
    }
}
