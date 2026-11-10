class Node:
    def __init__(self, data):
     self.data = data
     self.prev = None
     self.next = None


class ListaDobleEnlazada:
 def __init__(self):
     self.head = None

 def insertar(self, data):
    #para insertar al final de la lista
    new_node = Node(data)
    if not self.head:
        self.head = new_node
        return
    
    current = self.head
    while current.next:
        current = current.next

    current.next = new_node
    new_node.prev = current

 def mostrar(self):
    #muestra la lista
    elements = []
    current = self.head
    while current:
        elements.append(str(current.data))
        current = current.next
    print(" ⇄ ".join(elements)if elements else "Lista Vacia")

 def elim_por_valor(self, target):
    #elim el ndoo con el valor objetivo(target)
    if not self.head:
        print(f"La lista esta vacia. No se puede eliminar {target}.")
        return False
    current = self.head
    #busqueda del nodo con el objetivo
    while current and current.data!=target:
        current = current.next
    #si no existe en la lista
    if not current:
        print(f"El valor {target} no se encuentra en la lista.")
        return False
    #ev casos espec y rec punteros
    #el unico nodo de la lista
    if current == self.head and current.next is None:
        self.head = None
    #nodo esta en la cabeza(hay mas d un nodo)
    elif current == self.head:
        self.head = current.next
        self.head.prev = None
    #nodo en cola
    elif current.next is None:
        current.prev.next = None
    #ndo en medio
    else:
        current.prev.next = current.next
        current.next.prev = current.prev
    #limpiar ref del nodo eliminado :b
    current.prev = None
    current. next = None

    print(f"Nodo con el valor {target} fue eliminado.")
    return True

dll = ListaDobleEnlazada()
for val in [5, 15, 25, 35]:
   dll.insertar(val)

dll.mostrar()
dll.elim_por_valor(15)
dll.mostrar()
#:D