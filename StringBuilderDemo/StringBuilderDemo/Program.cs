using System;
using System.Text;

namespace StringBuilderDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var builder = new StringBuilder();
            builder.Append('-', 20);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 20);
            Console.WriteLine(builder);
            builder.Replace('-', '#');
            Console.WriteLine(builder);
            builder.Remove(0, 10);
            Console.WriteLine(builder);

            var name = "Mosh";
            name[0] = "N";
            name.ToUpper();
            Console.WriteLine(name);

            var name2 = " ";
            var result = String.IsNullOrEmpty(name2);
            Console.WriteLine(result);

            var name3 = new StringBuilder("Most");
            var index = name3.IndexOf

        }
    }
}
