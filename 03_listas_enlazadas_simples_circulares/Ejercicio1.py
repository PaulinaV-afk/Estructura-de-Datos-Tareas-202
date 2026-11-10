class Node:
    def __init__(self, data):
        self.data = data
        self.next = None

class ListaENlazadaCircular:
    def __init__(self):
        self.head = None

    def append(self, data):
        #para insertar y manterner el circulo
        new_node = Node(data)
        if not self.head:
            self.head = new_node
            new_node.next = self.head # el unico nodo apunta a si mismo
            return

        current = self.head
        #para avanzar al ultimo nodo
        while current.next!=self.head:
            current = current.next

        current.next = new_node
        new_node.next = self.head # el nuevo nodo cierra el circulo

    def recorrerYcontar(self):
        #recorre la lista por una vuelta completa
        #validacion para lista vacia
        if not self.head:
            print("Elementos: (Lista Vacia) | Total de nodos: 0")
            return

        current = self.head
        elements = []
        count = 0

        #bucle para la vuelta
        while True:
            elements.append(str(current.data))
            count += 1
            current = current.next
            if current == self.head:
                break

        print(f"Elementos: {' '.join(elements)} | Total de nodos: {count}")

lec = ListaENlazadaCircular()
for val in [10, 20, 30]:
    lec.append(val)

lec.recorrerYcontar()
print("\n----Con un solo nodo----")
lec_single = ListaENlazadaCircular()
lec_single.append(99)
lec_single.recorrerYcontar()
print("\n ----Con lista vacia----")
lec_empty = ListaENlazadaCircular()
lec_empty.recorrerYcontar()

