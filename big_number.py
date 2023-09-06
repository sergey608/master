
def greater_than_p(lst_big, n):
    result = []
    for num in lst_big:
        if num > n:
            result.append(num)
    return result

list_big = [1, 2, 3, 4, 6 , 7, 8, 9]
n = 5

result = greater_than_p(list_big, n)
print(result)
