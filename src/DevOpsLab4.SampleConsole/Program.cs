using DevOpsLab4.StringExtensions;

var testValues = new[]
{
    "Hello world",
    "hello world"
};

foreach (var value in testValues)
{
    Console.WriteLine($"\"{value}\" starts with uppercase: {value.StartsWithUpperCaseLetter()}");
}
