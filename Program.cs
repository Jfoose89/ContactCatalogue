using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContactCatalogue.Models;
using ContactCatalogue.Repositories;
using ContactCatalogue.Services;
using ContactCatalogue.Exceptions;

namespace ContactCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new ContactRepository();
            var service = new ContactService(repository);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("=== Contact Catalog ===");
                Console.WriteLine("1) Add");
                Console.WriteLine("2) List");
                Console.WriteLine("3) Search (Name contains)");
                Console.WriteLine("4) Filter by Tag");
                Console.WriteLine("0) Exit");
                Console.Write("> ");

                string input = Console.ReadLine()!;

                switch (input)
                {
                    case "1":
                        int id;
                        while (true)
                        {
                            Console.Write("Id number: ");
                            string? userInput = Console.ReadLine();
                            if (int.TryParse(userInput, out id))
                                break;

                            Console.WriteLine("Invalid Id. Please enter a number.");
                        }

                        Console.Write("Name: ");
                        string name = Console.ReadLine()!;

                        Console.Write("Email: ");
                        string email = Console.ReadLine() ?? string.Empty;

                        Console.Write("Tags (separate by commas): ");
                        string tagsInput = Console.ReadLine() ?? string.Empty;
                        string[] tags = string.IsNullOrWhiteSpace(tagsInput)
                            ? Array.Empty<string>()
                            : tagsInput.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

                        var contact = new Contact(id, name, email, tags);

                        try
                        {
                            repository.Add(contact);
                            Console.WriteLine("Contact added successfully.");
                        }
                        catch (InvalidEmailException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        catch (DuplicateEmailException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        catch (ArgumentException)
                        {
                            Console.WriteLine("Error: A contact with that Id already exists");
                        }
                        break;
                            
                    case "2":
                        var allContacts = repository.GetAll();

                        if (!allContacts.Any())
                        {
                            Console.WriteLine("No contacts found.");
                        }
                        else
                        {
                            foreach (var c in allContacts)
                            {
                                Console.WriteLine(c);
                            }
                        }
                        break;

                    case "3":
                        Console.Write("Enter search term for name: ");
                        string searchTerm = Console.ReadLine() ?? string.Empty;

                        var resultsByName = service.SearchByName(searchTerm);

                        if (!resultsByName.Any())
                        {
                            Console.WriteLine("No contacts found by that name.");
                        }
                        else
                        {
                            foreach (var c in resultsByName)
                            {
                                Console.WriteLine(c);
                            }
                        }
                            break;

                    case "4":
                        Console.Write("Enter tag to filter by: ");
                        string tag = Console.ReadLine()!;

                        var resultsByTag = service.FilterByTag(tag);

                        if (!resultsByTag.Any())
                        {
                            Console.WriteLine($"No contacts found with tag '{tag}'.");
                        }
                        else
                        {
                            foreach (var c in resultsByTag)
                            {
                                Console.WriteLine(c);
                            }
                        }
                        break;

                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}