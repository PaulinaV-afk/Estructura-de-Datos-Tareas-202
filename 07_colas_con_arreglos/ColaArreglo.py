class ColaArreglo:
    def __init__(self, maxsize=5):
        self.maxsize = maxsize
        self.queue = [None]* maxsize
        self.front = -1
        self.rear = -1

    def insertar(self, elemento):
        if self.rear == self.maxsize -1:
            return
        if self.front == -1:
            self.front = 0
        self.rear += 1
        self.queue[self.rear] = elemento
        print("Elemento insertado correctamente.")

    def eliminar(self):
        if self.front == -1 or self.front > self.rear:
            return None
        eliminado = self.queue[self.front]
        self.queue[self.front] = None
        if self.front == self.rear:
            self.front = -1
            self.rear = -1
        else:
            self.front += 1
        return eliminado

    def mostrar(self):
        if self.front == -1 or self.front>self.rear:
            return
        for i in range(self.front,self.rear + 1):
            print(self.queue[i])

if __name__ == "__main__":
    cola = ColaArreglo()
    cola.insertar(10)
    cola.insertar(20)
    cola.mostrar()
    cola.eliminar()
    cola.mostrar()