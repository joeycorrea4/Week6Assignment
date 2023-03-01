using System;
using System.Collections.Generic;
namespace Week6Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            problemOne();
        }


        internal static class problemOne
        { 
            public static void Run()
            {
                var names = new List<string>();

                while (true)
                {
                    var name = AskForName();

                    if (string.IsNullOrEmpty(name))
                        break;

                    names.Add(name);
                    Console.WriteLine(GetLikesMessage(names));
                }
            }

            private static string AskForName()
            {
                Console.WriteLine("Enter a name: (Leave it empty to close the program)");
                return Console.ReadLine();
            }

            private static string GetLikesMessage(List<string> names)
            {
                if (names.Count > 2)
                    return names[0] + ", " + names[1] + " and " + GetExtraLikes(names).Count + " liked your post";
                if (names.Count == 2)
                    return names[0] + " and " + names[1] + " liked your post";

                return names[0] + " liked your post";
            }

            private static List<string> GetExtraLikes(List<string> names)
            {
                return names.GetRange(2, names.Count - 2);
            }
        }


    
    }
}