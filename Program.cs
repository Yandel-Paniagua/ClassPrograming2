// See https://aka.ms/new-console-template for more information
using Tarea_1_c_;

Console.WriteLine("Hello, World!");


var obj1  = new ComunityMenber();

obj1.Name = "Rafael trujillo";
obj1.Adress = "KM 18 de las americas";
obj1.PhoneNumber = 8090223694;
obj1.DateOfBirthdate = "2/5/2000";
obj1.Sex = "male\n";

Console.WriteLine(obj1.Name);
Console.WriteLine(obj1.Adress);
Console.WriteLine(obj1.DateOfBirthdate);
Console.WriteLine(obj1.PhoneNumber);
Console.WriteLine(obj1.Sex);



// CLASS 2 ExStudent

var obj2 = new ExStudent();

obj2.Name = "carlos manuel";
obj2.ID = 1586;
obj2.Carreer = "Lawyer";
obj2.DateGraduation = "18/6/2022\n";

Console.WriteLine(obj2.Name);
Console.WriteLine(obj2.Carreer);
Console.WriteLine(obj2.ID);
Console.WriteLine(obj2.DateGraduation);


// CLASS 3 Student

var obj3 = new Student();

obj3.Name = "Jose miguel";
obj3.ID = 1039;
obj3.Average = 91;
obj3.Carreer = "accountant\n";


Console.WriteLine(obj3.Name);
Console.WriteLine(obj3.Average); // indice
Console.WriteLine(obj3.ID);
Console.WriteLine(obj3.Carreer);

// CLASS 4 Employee

var obj4 = new Employee();

obj4.Name = "maicol guerrero";
obj4.Id = 7432;
obj4.Salary = 58000;
obj4.Company = "Plaza Lama";
obj4.PhoneNumber = 8296539874;
obj4.Position = "Supervisor\n";


Console.WriteLine(obj4.Name);
Console.WriteLine(obj4.Salary); 
Console.WriteLine(obj4.Company);
Console.WriteLine(obj4.PhoneNumber);
Console.WriteLine(obj4.Id);
Console.WriteLine(obj4.Position);


// CLASS 5 Teacher

var obj5 = new Teacher();

obj5.Name = "maria lupita";
obj5.Id = 2510;
obj5.Salary = 38000;
obj5.Subject = "Math";
obj5.PhoneNumber = 8095684588;
obj5.School = "Politecnico Itla\n";


Console.WriteLine(obj5.Name);
Console.WriteLine(obj5.Salary);
Console.WriteLine(obj5.Id);
Console.WriteLine(obj5.Subject);
Console.WriteLine(obj5.PhoneNumber);
Console.WriteLine(obj5.School);


// CLASS 6 Teacher#2

var obj6 = new Teacher_2();

obj6.Name = "jose pereira";
obj6.Id = 4589;
obj6.Salary = 36000;
obj6.Subject = "History";
obj6.PhoneNumber = 8095684588;
obj6.Adress = "Calle san luis #15";
obj6.School = "Escula la restauracion\n";


Console.WriteLine(obj6.Name);
Console.WriteLine(obj6.Salary);
Console.WriteLine(obj6.Id);
Console.WriteLine(obj6.Subject);
Console.WriteLine(obj6.PhoneNumber);
Console.WriteLine(obj6.Adress);
Console.WriteLine(obj6.School);


// CLASS 7 Admin

var obj7 = new Admin();

obj7.Name = "carlos rivera";
obj7.Salary = 94000;
obj7.Country = "cuba";
obj7.Email = "carlosrivera@gmail.com";
obj7.Position = "vicepresidente";
obj7.Company = "adidas\n";


Console.WriteLine(obj7.Name);
Console.WriteLine(obj7.Salary);
Console.WriteLine(obj7.Country);
Console.WriteLine(obj7.Position);
Console.WriteLine(obj7.Email);
Console.WriteLine(obj7.Company);

// CLASS 8 Admin#2

var obj8 = new Admin();

obj8.Name = "Hilary hidalgo";
obj8.Salary = 86000;
obj8.Country = "Suisa";
obj8.Email = "hilaryhidalgo@gmail.com";
obj8.Position = "Gerente de ventas";
obj8.Company = "Tommy Hilfiger\n";




Console.WriteLine(obj8.Name);
Console.WriteLine(obj8.Salary);
Console.WriteLine(obj8.Country);
Console.WriteLine(obj8.Position);
Console.WriteLine(obj8.Email);
Console.WriteLine(obj8.Company);
