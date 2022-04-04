using System;
using System.Collections.Generic;
using System.Text;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();
            string comment = Console.ReadLine();
            List<string> comments = new List<string>();

            while (comment != "end of comments")
            {
                comments.Add(comment);
                comment = Console.ReadLine();
            }

            StringBuilder html = new StringBuilder();
            html.AppendLine("<h1>");
            html.AppendLine($"    {title}");
            html.AppendLine("</h1>");
            html.AppendLine("<article>");
            html.AppendLine($"    {article}");
            html.AppendLine("</article>");

            foreach (var item in comments)
            {
                html.AppendLine("<div>");
                html.AppendLine($"    {item}");
                html.AppendLine("</div>");
            }
            Console.WriteLine(html);
        }
    }
}