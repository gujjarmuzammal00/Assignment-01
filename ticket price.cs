using System;

double basePrice = 20.0;

// Example input
int age = 22;
bool isStudent = true;

string discountType;
double discountPercent;

if (age < 12)
{
    discountType = "Child";
    discountPercent = 50;
}
else if (age >= 12 && age <= 17)
{
    discountType = "Youth";
    discountPercent = 25;
}
else if (age >= 65)
{
    discountType = "Senior";
    discountPercent = 30;
}
else if (isStudent)
{
    discountType = "Student";
    discountPercent = 15;
}
else
{
    discountType = "Adult";
    discountPercent = 0;
}

double discountAmount = basePrice * (discountPercent / 100.0);
double finalPrice = basePrice - discountAmount;

Console.WriteLine($"Age: {age}");
Console.WriteLine($"Student: {(isStudent ? "Yes" : "No")}");
Console.WriteLine($"Discount Type: {discountType}");
Console.WriteLine($"Discount: {discountPercent}%");
Console.WriteLine($"Original Price: ${basePrice:F2}");
Console.WriteLine($"Discount Amount: -${discountAmount:F2}");
Console.WriteLine($"Final Price: ${finalPrice:F2}");