class Node:
    def __init__(self, data):
        self.data = data
        self.next = None

class ListaEnlazada:
    def __init__(self):
        self.head = None

    def append(self, data):
        new_node = Node(data)
        if not self.head:
            self.head = new_node
        else:
            current = self.head
            while current.next:
                current = current.next
            current.next = new_node

    def print_list(self):
     current = self.head
     elements = []
     while current:
         elements.append(str(current.data))
         current = current.next
     print(" → ".join(elements))



def merge_sorted_list(list1, list2):
    dummy = Node(0)
    tail = dummy

    curr1 = list1.head
    curr2 = list2.head


    while curr1 and curr2:
        if curr1.data <= curr2.data:
            tail.next = curr1  
            curr1 = curr1.next
        else:
            tail.next = curr2
            curr2 = curr2.next 
        tail = tail.next       

    if curr1:
        tail.next = curr1
    elif curr2:
        tail.next = curr2


    merged_list = ListaEnlazada()
    merged_list.head = dummy.next
    return merged_list

list_a = ListaEnlazada()
for val in [1, 3, 5, 7, 9]:
    list_a.append(val)

list_b = ListaEnlazada()
for val in [2, 4, 6, 8]:
    list_b.append(val)

print("Lista A: ", end="")
list_a.print_list()

print("Lista B: ", end="")
list_b.print_list()

result_list = merge_sorted_list(list_a, list_b)

print("Lista resultante ordenada:")
result_list.print_list()
