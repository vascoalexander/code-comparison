# Exercise 1-2-12
portions = int(input('How much portions to heat?: '))
heating_time = int(input('Enter the heating time(in sec): '))
heating_time_mod = 1.0

if portions == 2:
    heating_time_mod = 1.5
elif portions == 3:
    heating_time_mod = 2.0
elif portions > 3:
    print('Heating more than 3 portions is not recommended')

m = (heating_time * heating_time_mod) // 60
s = (heating_time * heating_time_mod) % 60

print(f"Time to heat: {m:.0f} min {s:.0f} sec")

