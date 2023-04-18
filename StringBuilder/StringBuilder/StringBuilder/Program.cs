using StringBuilderEX.Entities;
using System;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Tenha uma boa viagem");
            Comment c2 = new Comment("uau q bosta ");
            Post p1 = new Post(
                DateTime.Parse("21/06/2023 13:05:44"),
                "nao sei oq Nova Zelandia",
                "I`m going to visit this wonderful county!",
                12
                );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2023 23:14:19"),
                "bnoa noite mother fuckers",
                "seu C# Tomorrow!",
                5
                );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
