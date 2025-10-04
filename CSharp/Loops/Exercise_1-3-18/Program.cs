// Exercise 1-3-18
Console.Write("How much to pay monthly: ");
int rate = Convert.ToInt32(Console.ReadLine());
int month = 1;
double credit = 1000.0;

while (credit > 0)
{
    credit = (credit + credit * 0.015) - rate;
    Console.WriteLine(string.Format("Month {0,6} | Saldo: {1,6:N2} | Sum payed: {2,8:N2}", month, credit, (rate * month)));
    month++;
}