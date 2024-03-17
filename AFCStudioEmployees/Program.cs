// ���������� ������
using AFCStudioEmployees;
using Microsoft.EntityFrameworkCore;

ApplicationContext dbinsert = new ApplicationContext();

// ������� ��� ������� User
User user1 = new User { Name = "Tom", Age = 33 };
User user2 = new User { Name = "Alice", Age = 26 };

// ��������� �� � ��
dbinsert.Users.AddRange(user1, user2);
dbinsert.SaveChanges();

// ��������� ������
ApplicationContext dbselect = new ApplicationContext();

// �������� ������� �� �� � ������� �� �������
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
