using Generics;

var store = new StudentStore();

store.Add(new Student
{
    Id = 1,
    Name = "Ahmed"
});

store.Add(new Student
{
    Id = 2,
    Name = "Mona"
});

var student = store.GetById(1);

if (student != null)
{
    Console.WriteLine($"{student.Id}: {student.Name}");
}

Console.WriteLine("All students:");

foreach (var item in store.GetAll())
{
    Console.WriteLine($"{item.Id}: {item.Name}");
}

store.Remove(2);

Console.WriteLine("After removing student 2:");

foreach (var item in store.GetAll())
{
    Console.WriteLine($"{item.Id}: {item.Name}");
}