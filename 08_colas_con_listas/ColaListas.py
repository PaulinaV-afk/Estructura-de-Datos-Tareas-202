class Nodo:
    def __init__(self, dato):
        self.dato = dato
        self.siguiente = None

class ColaListas:
    def __init__(self):
        self.front = None
        self.rear = None

    def encolar(self, dato):
        nuevo = Nodo(dato)
        if self.rear is None:
            self.front = self.rear = nuevo
        else:
            self.rear.siguiente = nuevo
            self.rear =  nuevo

    def desencolar(self):
        if self.front is None:
            return None
        valor_extraido = self.front.dato
        self.front = self.front.siguiente
        if self.front is None:
            self.rear = None
        return valor_extraido

    def mostrar(self):
        actual = self.front
        elementos = []
        while actual is not None:
            elementos.append(str(actual.dato))
            actual = actual.siguiente
        print(" ".join(elementos))

if __name__ == "__main__":
    c = ColaListas()
    c.encolar(100)
    c.encolar(200)
    c.encolar(300)
    c.mostrar()
    print("Desencolado: ", c.desencolar())
    c.mostrar()

    