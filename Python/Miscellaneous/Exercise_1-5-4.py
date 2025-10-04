# Exercise 1-5-4
from time import time

start_time = time()

for i in range(20000):
    ergebnis = i * 8
    print(f'8 x {i} = {ergebnis}')

end_time = time()
script_runtime = end_time - start_time
print(f"{script_runtime:.5f}")
