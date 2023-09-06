# Эта программа вычисляет заработную плату
# для каждого сотрудника Меган.

# NUM_EMPLOYEES применяется как константа
# для размера списка.
NUM_EMPLOYEES = 6

def main():
    # Создать спсок который будет содержать отработанные часы.
    hours = [0] * NUM_EMPLOYEES

    # Получить часы отработанные каждым сотрудником.
    for index in range(NUM_EMPLOYEES):
        print('Введите количество отработанных часов сотрудником',
              index + 1, ': ', sep='', end='')
        hours[index] = float(input())
    # Получить почасовую ставку оплаты.
    pay_rate = float(input('Введите почасовую ставку оплаты: '))

    # Показать зароботную оплату каждого сотрудника.
    for index in range(NUM_EMPLOYEES):
        gross_pay = hours[index] * pay_rate
        print('Заработная плата сотрудника', index + 1, ': $',
              format(gross_pay, '.2f'), sep='')

# Вызвать главную функцию.
main()

