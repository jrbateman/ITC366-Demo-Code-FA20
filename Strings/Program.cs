using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiaing a string object

            string string1 = "This is a string created by assignment.";
            Console.WriteLine(string1);

            string string2a = "The path is C:\\PublicDocuments\\Report1.doc";
            Console.WriteLine(string2a);

            string string2b = @"The path is C:\PublicDocuments\Report1.doc";
            Console.WriteLine(string2b);

            // The example displays the following output:
            //       This is a string created by assignment.
            //       The path is C:\PublicDocuments\Report1.doc
            //       The path is C:\PublicDocuments\Report1.doc   
            // The @ special character serves as a verbatim identifier.


            // *******************************************
            // instantiaing using several string constuctor

            char[] chars = { 'w', 'o', 'r', 'd' };
            sbyte[] bytes = { 0x41, 0x42, 0x43, 0x44, 0x45, 0x00 };

            // Create a string from a character array.
            string string11 = new string(chars);
            Console.WriteLine(string11);

            // Create a string that consists of a character repeated 20 times.
            string string2 = new string('c', 20);
            Console.WriteLine(string2);

            // The example displays the following output:
            //       word
            //       cccccccccccccccccccc


            // *******************************************
            //By using the string concatenation operator (+ in C# ) to create a single string from any combination of String instances and string literals. 
            //The following example illustrates the use of the string concatenation operator.

            string string111 = "Today is " + DateTime.Now.ToString("D") + ".";
            Console.WriteLine(string11);

            string string22 = "This is one sentence. " + "This is a second. ";
            string2 += "This is a third sentence.";
            Console.WriteLine(string22);
            Console.WriteLine();
            Console.WriteLine();
            // The example displays output like the following:
            //    Today is Tuesday, July 06, 2011.
            //    This is one sentence. This is a second. This is a third sentence.


            // *******************************************
            //By retrieving a property or calling a method that returns a string. 
            //The following example uses the methods of the String class to extract a substring from a larger string.

            string sentence = "This sentence has five words.";
            // Extract the second word.
            int startPosition = sentence.IndexOf(" ") + 1;
            string word2 = sentence.Substring(startPosition,
                sentence.IndexOf(" ", startPosition) - startPosition);

            Console.WriteLine("Second word: " + word2);
            Console.WriteLine();
            // The example displays the following output:
            //       Second word: sentence

            // *******************************************
            //By calling a formatting method to convert a value or object to its string representation. 
            //The following example uses the composite formatting feature to embed the string representation of two objects into a string.

            DateTime dateAndTime = new DateTime(2011, 7, 6, 7, 32, 0);
            double temperature = 68.3;
            string result = String.Format("At {0:t} on {0:D}, the temperature was {1:F1} degrees Fahrenheit.",
                dateAndTime, temperature);
            Console.WriteLine(result);

            // The example displays the following output:
            //       At 7:32 AM on Wednesday, July 06, 2011, the temperature was 68.3 degrees Fahrenheit.  


            // *******************************************

            //The $ special character identifies a string literal as an interpolated string. 
            // An interpolated string is a string literal that might contain interpolated expressions.

            string name = "James";
            var date = DateTime.Now;

            // Composite formatting:
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);

            // String interpolation:
            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

            // Both calls produce the same output that is similar to:
            // Hello, James! Today is Wednesday, it's 19:40 now.



            // Strings and Indexes

            string s1 = "This string consists of a single short sentence.";
            int nWords = 0;

            s1 = s1.Trim();
            for (int ctr = 0; ctr < s1.Length; ctr++)
            {
                if (Char.IsPunctuation(s1[ctr]) | Char.IsWhiteSpace(s1[ctr]))
                    nWords++;
            }
            Console.WriteLine("The sentence\n   {0}\nhas {1} words.",
                s1, nWords);

            // The example displays the following output:
            //       The sentence
            //          This string consists of a single short sentence.
            //       has 8 words.


            // *******************************************
            // Comparing String

            String s = "a houseboat";
            //String s1 = "house";
            String s2 = s.Substring(2, 5);
            String s3 = "horse";
            String s4 = s1;
            Console.WriteLine("s1 == s2 is {0}", s1 == s2);
            Console.WriteLine("s1.Equals(s2) is {0}", s1.Equals(s2));
            Console.WriteLine($"s1.Equals(s2) is {s1.Equals(s2)}");
            Console.WriteLine("s1.Equals(s3) is {0}", s1.Equals(s3));


            String w1 = "Apple";
            String w2 = "apple";
            String w3 = "butter";
            Console.WriteLine("{0} compared to {1} is {2}",
                w1, w2, w1.CompareTo(w2));
            Console.WriteLine("{0} compared to {1} is {2}",
                w1, w2, String.Compare(w1, w2, true));

            Console.WriteLine("s1.Equals(s3) is {0}", s1.Equals(s3));


            Console.WriteLine("{0} compared to {1} is {2}",
                w1, w3, w1.CompareTo(w3));
            Console.WriteLine("{0} compared to {1} is {2}",
                w1, w3, w1.Equals(w3));

            //  String.Compare performs a culture-sensitive comparison while String.Equals performs an ordinal comparison. 
            //  String.Equals performs an ordinal or binary (e.g., byte for byte) match of the String.  
            //  The Equals method is meant to determine exact binary matches of two strings:

            // String.Compare performs a culture-sensitive or linguistic evaluation of the String.
            // The Compare method is meant to determine the sort order of two strings for the current culture.  
            //For example, in Swedish, some vowels with diacritics sort after Z.  
            //However, in other European languages, the same diacritic vowel sorts right after the non-diacritic vowel: 


            //true to ignore case during the comparison; otherwise, false.
            //Zero	strA occurs in the same position as strB in the sort order.



        }

    }
}
