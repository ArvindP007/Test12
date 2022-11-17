namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is a very very very very very long string...";
            var shortenPost = post.Shorten(4);
            Console.WriteLine(shortenPost);
        }
    }
}
