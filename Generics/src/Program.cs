using Generics;

var studentStore = new Store<Student>();

studentStore.Add(new Student { Id = 1, Name = "Ahmed" });
studentStore.Add(new Student { Id = 2, Name = "Mona" });

var student = studentStore.GetById(1);

Console.WriteLine($"{student?.Id}: {student?.Name}");

Console.WriteLine("All students:");
foreach (var item in studentStore.GetAll())
{
    Console.WriteLine($"{item.Id}: {item.Name}");
}

studentStore.Remove(2);

Console.WriteLine("After removing student 2:");
foreach (var item in studentStore.GetAll())
{
    Console.WriteLine($"{item.Id}: {item.Name}");
}

var courseStore = new Store<Course>();

courseStore.Add(new Course
{
    Id = 101,
    Title = "C#",
    Price = 1500
});

courseStore.Add(new Course
{
    Id = 102,
    Title = "OOP",
    Price = 2000
});

var course = courseStore.GetById(101);

Console.WriteLine($"{course?.Id}: {course?.Title}");