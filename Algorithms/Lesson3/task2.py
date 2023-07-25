# 2.Доп Задача.Добавляем метод сортировки для связного списка. 
from random import randint

class node:
    def __init__(self):
        self.left = None
        self.right = None
        self.value = 0
    
def generateNodes(num):
    nodes = []
    
    for i in range(num):
        n = node()
        n.value = randint(0,10)
        nodes += [n]
    
    for i in range(num):
        if i == 0:
            nodes[i].right = nodes[i+1]
        elif i == num-1:
            nodes[i].left = nodes[i-1]
        else:
            nodes[i].right = nodes[i+1]
            nodes[i].left = nodes[i-1]
    
    return nodes[0]

def printNodes(node):
    s = ""

    while node != None:
        s += f"{node.value} "
        node = node.right

    print(s)

def sortNodes(left):
    right = left.right
    temp = node()
    while left.right != None:
        while right != None:
            if left.value > right.value:
                temp.value = left.value
                left.value = right.value
                right.value = temp.value
            right = right.right
        left = left.right
        right = left.right

nums = 10

start = generateNodes(nums)

printNodes(start)

sortNodes(start)
print("After sort: ")
printNodes(start)



