#Find if a Single LinkedList is cycled or not

class Node:
    def __init__ (self, data = 0, next = None):
        self.data = data
        self.next = next



def isCycled (head:Node):
    step1=head
    step2=head
    while step1!=None and step2!=None :
        step1= step1.next
        step2= step2.next.next
        if step2==step1:   #If they are in the same position that means the LinkedList is cycled
            return True
    return False


node1 = Node()
node2 = Node()
node3 = Node()
node4 = Node()

node1.next = node2
node1.value = 1
node2.next = node3
node2.value = 2
node3.next = node4
node3.value = 3
node4.next = None   #Try node4.next = node1 to cycle the LinkedList
node4.value = 4


print(isCycled(node1))

