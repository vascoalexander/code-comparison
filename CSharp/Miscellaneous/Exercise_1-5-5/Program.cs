Random number = new Random();
List<int> lotteryNumbers = new List<int>();
while (lotteryNumbers.Count < 6)
{
    int nextNumber = number.Next(1, 50);
    if (!lotteryNumbers.Contains(nextNumber))
    {
        lotteryNumbers.Add(nextNumber);
    }
}
foreach (int i in lotteryNumbers)
{
    Console.Write(i + " ");
}

