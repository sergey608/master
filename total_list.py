# Эта программа вычисляет сумму значений в списке

def main():
    # Создать список.
    numbers = [2, 4, 6, 8, 10]

    # Создать переменную для применения в качестве накопителя.
    total = 0

    # Выислить сумму значкний элементов списка.
    for value in numbers:
        total += value
    # Показать сумму значений элементов списка.
    print('Сумма элементов состовляет', total)

# Вызвать главную функцию.
main()