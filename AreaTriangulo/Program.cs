// See https://aka.ms/new-console-template for more information
double b, h, a;
Console.WriteLine("Enter the height:");
h = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the base:");
b = double.Parse(Console.ReadLine());
a = (b * h) / 2;
Console.WriteLine("The area of the triangle is:" + a);
Console.ReadKey();
