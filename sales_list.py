# Константа  NUM_DAYS содержит количество дней,
#  за которые мы соберем данные продаж.
NUM_DAYS = 5

def main():
    # Создать спиисок,который будет содержать
    # продажи за каждый день.
    sales = [0] * NUM_DAYS

    # Создать переменную которая будет содержать индекс.
    index = 0

    print('Введите продажи за каждый день.')

    # Получить продажи за каждый день.
    while index < NUM_DAYS:
        print('День №', index + 1, ': ', sep='', end='')
        sales[index] = float(input())
        index += 1
        # Вычисляем сумму продаж.
        total_sum = sum(sales)

    # Показать введенные значения.
    print('Вот значения котрые были введены: ')
    for value in sales:
        print(value)
    print('Доход составил', total_sum)
# Вызвать главную функцию.
main()