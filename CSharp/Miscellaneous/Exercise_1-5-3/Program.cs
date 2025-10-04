string file = "image.png";
string[] substrings = file.Split('.');
string fileName = substrings[0];
string fileExtension = substrings[1];

Console.WriteLine("The filename: " + fileName);
Console.WriteLine("The file extension: " + fileExtension);
