// See https://aka.ms/new-console-template for more information
using Immutable;

Console.WriteLine("Hello, World!");
var human = new Human.Builder()
            .Height(183)
            .Weigth(73)
            .Money(200)
            .Build();
human = new Human.Builder()
            .Height(182)
            .Weigth(71)
            .Money(20)
            .Build();