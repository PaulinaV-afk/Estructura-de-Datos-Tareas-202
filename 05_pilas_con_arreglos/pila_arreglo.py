class PilaArreglo:
    def __init__(self, max_size: int = 100):
        self.max_size = max_size
        self.stack = [None]*max_size
        self.top = -1

    def push(self, item: int)->None:
        if self.is_full():
            print("Error: Stack Overflow (Pila llena).")
            return
        self.top += 1
        self.stack[self.top] = item

    def pop(self) -> int:
        if self.is_empty():
            print("Error: Stack Underflow (Pila vacia).")
            return -1
        item = self.stack[self.top]
        self.stack[self.top] = None
        self.top -= 1
        return item

    def peek(self) -> int:
        if self.is_empty():
            print("Pila vacia.")
            return -1
        return self.stack[self.top]

    def is_empty(self)-> bool:
        return self.top == -1

    def is_full(self)-> bool:
        return self.top == self.max_size - 1


if __name__=='__main__':
     mi_pila =PilaArreglo()
     mi_pila.push(10)
     mi_pila.push(20)
     mi_pila.push(30)

     print(f"Elemento Superior: {mi_pila.peek()}")
     print(f"Extrae elemento: {mi_pila.pop()}")
     print(f"Elemento Superior: {mi_pila.peek()}")


