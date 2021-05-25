using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace StringsAndLoops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String sentence = "A statement";
            Console.WriteLine("The character A at is at " + sentence.IndexOf('A'));

            Console.WriteLine("The character a at is at " + sentence.ToLower().IndexOf('a'));
            Console.WriteLine(sentence.Contains("s"));
            String sentencePlus = "     A statement    ";
            Console.WriteLine(sentencePlus.Length);
            Console.WriteLine(sentencePlus);
            Console.WriteLine(sentencePlus.Trim().Length);
            Console.WriteLine(sentencePlus.Trim());
            Console.WriteLine("The character A at is at " + sentence.LastIndexOf('t'));
            Console.WriteLine(sentence.Length);
            Console.WriteLine(sentence.Substring(0, 1));
            try
            {
                Console.WriteLine(sentence.Substring(5, 7));
            }
            catch (Exception e)
            {
                Console.WriteLine("Something bad happened");
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("I finished trying the thing!");
            }

            String introduction = "Hi my name is Andrew and I am your Instructor";
            String[] words = introduction.Split(" ");
            foreach (String word in words)
            {
                Console.WriteLine(word);
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            for (int i = 0; i < words.Length; i+=2)
            {
                Console.WriteLine(words[i]);
            }

            for (int i = 0; i < words.Length; i +=2)
            {
                Console.WriteLine(words[i]);
                Console.WriteLine(words[i+1]);
            }

            int count = 0;
            while (count < words.Length)
            {
                Console.WriteLine(words[count]);
                count++;
            }

            if (sentence.Equals(sentencePlus.Trim()))
            {
                Console.WriteLine("Our sentence equals our other sentence when trimmed");
            }

            if (sentence == sentencePlus.Trim())
            {
                Console.WriteLine("Our sentences share a memory address");
            }
            else
            {
                Console.WriteLine("Our sentences do not share a memory address");
            }
             

            // something something
            //bool somethingHappens = true;
            bool somethingHappens = false;
            while (somethingHappens)
            {
                Console.WriteLine(somethingHappens);
            }
            //bool continuing = true;
            bool continuing = false;
            do
            {
                //bank switch statement
                Console.WriteLine("Do you want to continue");
            } while (continuing);

            List<String> wordsList = new List<string>();
            foreach (string word in words)
            {
                wordsList.Add(word);
            }

            for (int i = 0; i < wordsList.Count; i++)
            {
                Console.WriteLine(wordsList[i]);
            }
        }
    }
}

