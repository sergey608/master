# Создаем функцию для анализа чисел
def analyze_numbers(numbers):
    print("Наименьшее число в списке:", min(numbers))
    print("Наибольшее число в списке:", max(numbers))
    print("Сумма чисел в списке:", sum(numbers))
    print("Среднее арифметическое чисел:", sum(numbers)/len(numbers))

# Создаем пустой список
numbers = []
#Используем цикл фор для записания чисел.
for i in range(20):
    number = int(input(f"Введите число {i+1}: "))
    numbers.append(number)

# Вызываю основную функцию
analyze_numbers(numbers)

