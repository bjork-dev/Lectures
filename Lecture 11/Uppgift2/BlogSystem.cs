using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Uppgift2
{
    class BlogSystem
    {
        public static void AddPost()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\test.txt";
            Console.WriteLine("Enter title: ");
            string title = "Post created " + DateTime.Now.ToString("dddd, dd MMMM yyyy")	 + " " + "Title - " + Console.ReadLine();
            Console.WriteLine("Enter your useless post, enter to save: ");
            string content = Console.ReadLine();
            string total = title + "\n" + content;
            File.AppendAllText(path, total );
            Console.WriteLine("Post saved");
        }
    }
}
