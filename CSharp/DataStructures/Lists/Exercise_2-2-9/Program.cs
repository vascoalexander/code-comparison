// Exercise 2-2-9
List<(string fruit, int count)> tupleList = new List<(string, int)> 
{
    ("apple", 15),
    ("banana", 8),
    ("miller", 12),
    ("kiwi", 9),
    ("peach", 2) 
};
tupleList.Sort((x, y) => x.count.CompareTo(y.count));
foreach (var tuple in tupleList)
{
    Console.WriteLine($"Fruit: {tuple.fruit}, Count: {tuple.count}");
}

