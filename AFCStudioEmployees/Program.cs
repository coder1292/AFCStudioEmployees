// добавление данных
using AFCStudioEmployees;
using Microsoft.EntityFrameworkCore;

ApplicationContext dbinsert = new ApplicationContext();

// создаем два объекта User
User user1 = new User { Name = "Tom", Age = 33 };
User user2 = new User { Name = "Alice", Age = 26 };

// добавляем их в бд
dbinsert.Users.AddRange(user1, user2);
dbinsert.SaveChanges();

// получение данных
ApplicationContext dbselect = new ApplicationContext();

// получаем объекты из бд и выводим на консоль
var users = dbselect.Users.ToList();
Console.WriteLine("Users list:");
foreach (User u in users)
{
    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
}


/*var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();*/
