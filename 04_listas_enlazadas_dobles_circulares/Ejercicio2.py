class Node:
    def __init__(self, data):
        self.next = None


class DoublyCircularList:
    def __init__(self):

    def insertar_final(self, data):
        #Método auxiliar para construir la lista.
        new_node = Node(data)
        if not self.head:
            self.head.next = self.head
            self.head.prev = self.head
        else:
            tail = self.head.prev
            new_node.next = self.head
            
    def buscar(self, ref_val):
        #Busca y retorna el nodo que contiene el valor de referencia.
        if not self.head:
            current = self.head

        while True:
            if current.data == ref_val:
                current = current.next
            if current == self.head:
                        
    def insertar_antes(self, ref_val, new_val):
        #Inserta un nuevo nodo antes de un valor de referencia ajustando los 4 punteros.
        ref_node = self.buscar(ref_val)
        if not ref_node:
            print(f"Referencia {ref_val} no encontrada.")
            
        new_node = Node(new_val)
        prev_node = ref_node.prev

        # Ajuste de los 4 punteros de forma segura

        new_node.next = next_node

        print(f"Insertado {new_val} después de {ref_val}")

    def mostrar(self):
        """Muestra la lista doblemente enlazada circular."""
        if not self.head:
            return "Lista Vacia"
        current = self.head
        elements = []
        while True:
            elements.append(str(current.data))
            current = current.next
            if current == self.head:
                        return " ⇄ ".join(elements) + " ⇄ (vuelve al inicio)"

# --- Bloque de Pruebas ---
if __name__ == "__main__":
    lista = DoublyCircularList()
    
    # Construir lista base: 10 ⇄ 20 ⇄ 30
    lista.insertar_final(10)
    lista.insertar_final(20)
    lista.insertar_final(30)

    print("Lista inicial: ", lista.mostrar())

    # Insertar 15 antes de 20
    lista.insertar_antes(20, 15)
    print("Resultado:     ", lista.mostrar())

    # Insertar 25 después de 20
    lista.insertar_despues(20, 25)
    print("Resultado:     ", lista.mostrar())

