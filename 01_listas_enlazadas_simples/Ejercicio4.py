class Node:
    def __init__(self, data):
        self.data = data
        self.next = None

class SinglyLinkedList:
    def __init__(self):
        self.head = None

    def insertar_final(self, data):
        new_node = Node(data)
        if not self.head:
            self.head = new_node
            return
        current = self.head
        while current.next:
            current = current.next
        current.next = new_node

    def mostrar(self):
        current = self.head
        elements = []
        while current:
            elements.append(str(current.data))
            current = current.next
        return " → ".join(elements)

    def invertir(self):
        #Invierte la lista enlazada in-place cambiando las referencias next.
        prev = None
        current = self.head

        
        while current:
            next_node = current.next  # 1. Guardar temporalmente el siguiente nodo
            current.next = prev       # 2. Invertir el enlace apuntando al anterior
            prev = current            # 3. Avanzar 'prev'un paso
            current = next_node       # 4. Avanzar current'un paso
            
        # El nuevo inicio de la lista invertida es 'prev'
        self.head = prev 
                
# --- Bloque de Pruebas ---
if __name__ == "__main__":
    lista = SinglyLinkedList()
    
    # Construir lista original: 1 → 2 → 3 → 4 → 5
    for i in range(1, 6):
     lista.insertar_final(i)

    print("Lista original:  ", lista.mostrar())

    # Invertir la lista
    lista.invertir()

    print("Lista invertida: ", lista.mostrar())