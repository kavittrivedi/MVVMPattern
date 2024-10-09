// See https://aka.ms/new-console-template for more information
using MVVMDemo.ViewModels;

Console.WriteLine("Hello, World!");
PersonViewModel viewModel = new PersonViewModel();

Console.WriteLine("Initial Person Details:");
Console.WriteLine($"Name: {viewModel.Name}, Age: {viewModel.Age}");

// Update name and age
Console.WriteLine("Enter new name:");
viewModel.Name = Console.ReadLine();

Console.WriteLine("Enter new age:");
if (int.TryParse(Console.ReadLine(), out int newAge))
{
    viewModel.Age = newAge;
}

Console.WriteLine("Updated Person Details:");
Console.WriteLine($"Name: {viewModel.Name}, Age: {viewModel.Age}");
