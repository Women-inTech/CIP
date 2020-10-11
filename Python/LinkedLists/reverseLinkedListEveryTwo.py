'''
Reverse a Silgle Linked List every two nodes. 
IN:   N1->N2->N3->N4->None
OUT:  N2->N1->N4->N3->None
'''
class Node:
    def __init__ (self,value=None,next=None):
        self.value = value
        self.next = next

def reverseLinkedListEveryTwo (head:Node):
    previousN = head
    tempN = Node()
    outN = Node()
    out = True
    while previousN != None :
        currentN = previousN.next
        if out:
            outN = currentN    #This is the new head node (the one to return)
            out = False
        nextN = currentN.next
        currentN.next = previousN
        tempN.next = currentN
        tempN = previousN
        previousN = nextN
    tempN.next = None
    return outN



node1 = Node()
node2 = Node()
node3 = Node()
node4 = Node()
node5 = Node()
node6 = Node()

node1.next = node2
node1.value = "N1"
node2.next = node3
node2.value = "N2"
node3.next = node4
node3.value = "N3"
node4.next = node5
node4.value = "N4"
node5.next = node6
node5.value = "N5"
node6.next = None
node6.value = "N6"

def displayList (headNode: Node):
    while (headNode != None):
        print(headNode.value)
        headNode=headNode.next     

print("Initial Linked List: ")
displayList(node1)
print("Final Linked List: ")
finalN = reverseLinkedListEveryTwo(node1)
displayList(finalN)
