def greater_than_p(numbers, p):
    # Создаем пустой список для хранения результата
    result = []
    # Итерируемся по каждому элементу в списке чисел
    for number in numbers:
        # Проверяем, больше ли текущий элемент, чем p
        if number > p:
            # Если да, добавляем его в список result
            result.append(number)
    # Возвращаем список result, содержащий все числа, большие p
    return result

# Определяем список чисел и значение р
numbers = [1, 3, 5, 7, 9]
p = 4

# Вызываю функцию greater_than_р чотбы получить числа превышающие p
result = greater_than_p(numbers, p)

# Отражаю результат в консоли
print(f"Числа в списке, которые больше {p}: {result}")
