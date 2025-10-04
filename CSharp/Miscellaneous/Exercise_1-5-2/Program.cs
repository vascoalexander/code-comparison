// Exercise 1-5-2
string name = "Julien";
int age = 32;
string language = "C#";

// String Interpolation
Console.WriteLine($"My name is {name}, and I am {age} Years old. " +
    $"I am learning the programming language {language}.");
// String concatenation
Console.WriteLine("My name is " + name + ", and I am " + Convert.ToString(age) +
    " Years old. I am learning the programming language " + language + ".");
// older method using string.format
Console.WriteLine(string.Format("My name is {0}, and I am {1} years old. " +
    "I am learning the programming language {2}", name, age, language));
