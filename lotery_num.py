import random

# Генерируем семь случайных чисел от 0 до 9 и записываем их
# в список
lottery_numbers = []
for i in range(7):
    lottery_numbers.append(random.randint(0,9))

# Выводим список сгенерированных случайных чисел.
for number in lottery_numbers:
    print(number, end='')
print()