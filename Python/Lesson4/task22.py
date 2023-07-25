# Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями). Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
# Пользователь вводит 2 числа. n — кол-во элементов первого множества. m — кол-во элементов второго множества. Затем пользователь вводит сами элементы множеств.
from random import randint

n = int(input("n = "))
m = int(input("m = "))

array1 = []
array2 = []

while n > 0:
    array1 += [randint(0,10)]
    n -= 1

while m > 0:
    array2 += [randint(0,10)]
    m -= 1

result = set()

for a1 in array1:
    for a2 in array2:
        if a1 == a2 and not a1 in result:
            result.add(a1)
            break

result = list(result)

print(f"array1 = {array1}")
print(f"array2 = {array2}")
result.sort()
print(f"result = {result}") 