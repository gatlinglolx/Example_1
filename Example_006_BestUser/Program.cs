﻿Console.Write("Enter userName");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Hurrah, this is Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}