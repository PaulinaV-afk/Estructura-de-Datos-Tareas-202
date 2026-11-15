class Nodo:
    def __init__(self, dato: int):
        self.dato = dato
        self.siguiente = None

class PilaLista:
    def __init__(self):
        self.top = None

    def push(self, item: int)->None:
        nuevo_nodo = Nodo(item)
        nuevo_nodo.siguiente = self.top
        self.top = nuevo_nodo

    def pop(self)->int:
        if self.is_empty():
            return -1
        dato_extraido = self.top.dato
        self.top = self.top.siguiente
        return dato_extraido

    def peek(self)->int:
        if self.is_empty():
            return -1
        return self.top.dato

    def is_empty(self)->bool:
        return self.top is None

    def display(self)->None:
        actual = self.top
        while actual is not None:
            actual = actual.siguiente

if __name__ == '__main__':
    mi_pila = PilaLista()

    mi_pila.push(10)
    mi_pila.push(20)
    mi_pila.push(30)

    print(f"Elemento Superior: {mi_pila.peek()}")
    print(f"Extrae elemento: {mi_pila.pop()}")
    print(f"Elemento Superior: {mi_pila.peek()}")