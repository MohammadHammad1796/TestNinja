using System;

namespace TestNinja.Mocking
{
    public class Program
    {
        public static void Main()
        {
            var service = new VideoService(new FileReader(), new VideoRepository());
            var title = service.ReadVideoTitle();
            Console.WriteLine(title);
        }
    }
}
