// See https://aka.ms/new-console-template for more information
using ClassDemoArv.model;

Console.WriteLine("Hello, World!");

Person p = new Person();
Console.WriteLine(p);

Person p2 = new Person("Peter", "22334455");
Console.WriteLine(p2);

Kok k = new Kok();
Console.WriteLine(k);

Kok k2 = new Kok("Jakob", "33322255", 23, "Desserter");
Console.WriteLine(k2);

k2.Name = "Nyt navn";
