using Domain;

var a = new MyEntity
{
    Id = 1,
    Name = "test",
    Age = 22
};

Console.WriteLine($"{a.Id} {a.Name}");
