using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    struct Post
    {
        int number;
        string Text;
        bool score;
    }
    class Program
    {
        public static List<Post> AllPosts = new List<Post>();
        static void Main(string[] args)
        {
            Menu();
        }
        static void WriteAllPosts()
        {
            for (int i = 0; i < AllPosts.Count; i++)
            {
                Console.WriteLine(AllPosts[i]);
            }
        }
        static void Menu()
        {
            WriteAllPosts();
        }
        static void Actions()
        {

        }
    }
}
