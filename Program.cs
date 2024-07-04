using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;
using Balta.SubscriptionContext;

public class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();

        var articles = new List<Article>
        {
            new Article("Artigo sobre OOP", "orientacao-objetos"),
            new Article("Artigo sobre C#", "csharp"),
            new Article("Artigo sobre .NET", "dotnet")
        };

        // foreach (var article in articles)
        // {
        //     Console.WriteLine(article.Id);
        //     Console.WriteLine(article.Title);
        //     Console.WriteLine(article.Url);
        // }

        var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
        var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
        var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

        var courses = new List<Course>
        {
            courseOOP,
            courseCsharp,
            courseAspNet
        };

        var careers = new List<Career>();
        var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");

        var careerItem2 = new CareerItem(2, "Aprenda OOP", string.Empty, null);
        var careerItem3 = new CareerItem(3, "Aprenda .NET", string.Empty, courseAspNet);
        var careerItem1 = new CareerItem(1, "Comece por aqui", string.Empty, courseCsharp);

        careerDotnet.Items.Add(careerItem2);
        careerDotnet.Items.Add(careerItem3);
        careerDotnet.Items.Add(careerItem1);

        careers.Add(careerDotnet);

        foreach (var career in careers)
        {
            Console.WriteLine(career.Title);

            foreach (var item in career.Items.OrderBy(x => x.Order))
            {
                Console.WriteLine($"{item.Order} - {item.Title}");
                Console.WriteLine(item.Course?.Title);
                Console.WriteLine(item.Course?.Level);

                foreach (var notification in item.Notifications)
                {
                    Console.WriteLine($"{notification.Property} - {notification.Message}");
                }
            }
        }

        var paypalSubscription = new PagarMeSubscription();
        var student = new Student();
        student.CreateSubscription(paypalSubscription);
    }
}