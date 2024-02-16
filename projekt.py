#определение функции
def sayHello():
    print('hello')
    print('world')
    print('and evrybody')
    
def square(x):
    print('кваадрат чила ', x, '=', x**2)
    
def multiply(a,b):
    print(a*b)

def even(a):
    if a%2==0:
        print(a, 'chetnoe')
    else:
        print(a, 'nechetnoe')
def factorial(n):
    pr = 1 
    for i in range(2, n + 1):
        pr = pr*i
    print(pr)
    
if 5 > 6:
    def primer():
        print('hello')
else:
        def primer():
            print('HELLO')
    
#главная программа( в ней будем вызывать функции)
primer()