using Generics;

var studentStore = new Store<Student>();

studentStore.Add(new Student { Id = 1, Name = "Ahmed" });
studentStore.Add(new Student { Id = 2, Name = "Mona" });
studentStore.Add(new Student { Id = 3, Name = "Omar" });
studentStore.Add(new Student { Id = 4, Name = "Sara" });
studentStore.Add(new Student { Id = 5, Name = "Ali" });

var courseStore = new Store<Course>();

courseStore.Add(new Course { Id = 101, Title = "C#", Price = 500 });
courseStore.Add(new Course { Id = 102, Title = "OOP", Price = 600 });
courseStore.Add(new Course { Id = 103, Title = "Generics", Price = 700 });

Console.WriteLine($"Student: {studentStore.GetById(1)?.Name}");
Console.WriteLine($"Course: {courseStore.GetById(101)?.Title}");

try
{
    studentStore.Add(new Student { Id = 1, Name = "Duplicate" });
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Page 2:");

foreach (var student in studentStore.GetAll().Page(2, 2))
{
    Console.WriteLine($"{student.Id}: {student.Name}");
}

var courses = new List<Course>
{
    new Course { Id = 201, Title = "Backend", Price = 800 },
    new Course { Id = 202, Title = "Database", Price = 900 },
    new Course { Id = 203, Title = "API", Price = 1000 }
};

var foundCourse = courses.FindById(202);

Console.WriteLine($"Found course: {foundCourse?.Title}");

// var invalidStore = new Store<string>(); // must NOT compile