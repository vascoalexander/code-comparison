rate = int(input("How much to pay monthly: "))
credit = 1000.0
month = 1

while credit > 0:
    credit = (credit + credit * 0.015) - rate
    print(f"Month {month:>2}  Saldo: {credit:>7.2f}  Sum payed: {(rate * month):>5}")
    month += 1
