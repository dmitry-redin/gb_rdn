# 1.Необходимо реализовать метод разворота связного списка (двухсвязного или односвязного на выбор).

class node:
    def __init__(self):
        self.next = None
        self.value = 0

    def copy(self):
        newNode = node()
        newNode.next = self.next
        newNode.value = self.value
        return newNode

def generateNodes(num):
    nodes = []
    for i in range(nodesNum):
        nodes += [node()]
    for i in range(num):
        nodes[i].value = i
        if i != num - 1:
            nodes[i].next = nodes[i+1]
    return nodes

def printNodes(node):
    s = ""
    while node != None:
        s += f"{node.value} "
        node = node.next
    print(s)

def reverseList(node):
    next = node.next.copy()
    node.next = None
    result = None
    while next != None:
        if next.next != None:
            prevNext = next.next.copy()
        else:
            prevNext = None
        next.next = node.copy()
        node = next.copy()
        if prevNext != None:
            next = prevNext.copy()
        else:
            next = None
    
    return node

nodesNum = 10
nodes = generateNodes(nodesNum)

firstNode = nodes[0]

printNodes(firstNode)

newFirstNode = reverseList(firstNode)

printNodes(newFirstNode)

print("END PROGRAMM")