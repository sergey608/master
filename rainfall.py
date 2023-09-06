# создаем список для хранения количества дождевых осадков
# за каждый месяц
rainfall = []

# Запрашиваем у пользователя количество дождевых осадков
# за каждый месяц и добовавляем их в список.
for i in range(12):
    month_rainfall = float(input("Введите количество дождевых"
                                 "осадков за" + str(i + 1)+"-й месяц:"))
    rainfall.append(month_rainfall)

# Вычисляем суммарное количество дождевых осадков за год.
total_rainfall = sum(rainfall)

# Вычисляем среднее ежемесячное количество осадков.
average_rainfall = total_rainfall / 12
# Находим месяцы с самим высоким и низким
# количеством дождевых осадков.
max_rainfall_month = rainfall.index(max(rainfall)) + 1
min_rainfall_month = rainfall.index(min(rainfall)) + 1

# Выыодим результаты.
print('Сумарное количество дождевых осадков за год:', total_rainfall)
print('Среднее ежемесячное количество дождевых осадков:', average_rainfall)
print('Месяц с наибольшим количеством дождевых осадков:', max_rainfall_month)
print('Месяц с наименьшим количеством дождевых осадков', min_rainfall_month)