﻿using PooCSharp.ContentContext;


namespace PooCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "orientacao-CSharp"));
            articles.Add(new Article("Artigo sobre .NET", "orientacao-dotnet"));


            /**
			foreach (var article in articles)

			{
				Console.WriteLine(article.Id);
				Console.WriteLine(article.Title);
				Console.WriteLine(article.Url);
			}
			**/
            var couses = new List<Course>();

            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAsp = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            couses.Add(courseOOP);
            couses.Add(courseCSharp);
            couses.Add(courseAsp);

            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseOOP);

            careerDotnet.Items.Add(careerItem);
            careers.Add(careerDotnet);


            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);
                }
            }

        }
    }
}
