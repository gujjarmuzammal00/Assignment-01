using System;

Console.Write("Full name: ");
string? fullNameIn = Console.ReadLine();

Console.Write("City: ");
string? cityIn = Console.ReadLine();

if (string.IsNullOrWhiteSpace(fullNameIn) || string.IsNullOrWhiteSpace(cityIn))
{
    Console.WriteLine("Both name and city are required.");
    return;
}

string fullName = fullNameIn.Trim();
string city = cityIn.Trim();

// Split name by whitespace. Use first and last tokens for initials if available.
string[] parts = fullName.Split(' ', StringSplitOptions.RemoveEmptyEntries);

// Get initials
char firstInitial = char.ToUpperInvariant(parts[0][0]);
char lastInitial = parts.Length > 1 ? char.ToUpperInvariant(parts[^1][0]) : '_';

// Format initials
string initials = lastInitial == '_'
    ? $"{firstInitial}._"
    : $"{firstInitial}.{lastInitial}.";

// Calculate name length (includes spaces)
int nameLength = fullName.Length;

// Build ID: CITY_INITIALS_LEN
string id = lastInitial == '_'
    ? $"{city.ToUpperInvariant()}_{firstInitial}_{nameLength}"
    : $"{city.ToUpperInvariant()}_{firstInitial}{lastInitial}_{nameLength}";

Console.WriteLine($"Hello, {fullName} ({initials}) from {city}");
Console.WriteLine($"Name length: {nameLength}");
Console.WriteLine($"ID: {id}");