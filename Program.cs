using System;

namespace SimpleWebWorker
{
    public class Program
    {
        public static void Main(string[] args)
        {
		    var webCaller = new WebCaller();
            
            string content = webCaller.GetContent("http://www.wp.pl/").Result;
            
            Console.WriteLine(content.Length);
        }
    }
}
