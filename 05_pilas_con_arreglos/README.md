# Pilas con arreglos

> Implementación del Tipo de Dato Abstracto (TDA) Pila basado en memoria contigua (arreglos de capacidad fija) bajo el principio LIFO (Last-In, First-Out).

## Información del estudiante y asignación de lenguaje
* **Estudiante:** Valdez Cota Paulina
* **Matrícula / Repositorio:** 20001223
* **Grupo:** Grupo 2 (202)
* **Organización:** EstructuraDeDatos2026-202

### Lenguajes asignados para este bloque
* **Ejercicio 1:** `C++` *(Código de referencia proporcionado en clase - Diapositivas 20 y 21)*
* **Ejercicio 2:** `Java` *(Monitoreo TraceCode IA)*
* **Ejercicio 3:** `C#` *(Monitoreo TraceCode IA)*
* **Ejercicio 4:** `JavaScript` *(Monitoreo TraceCode IA)*
* **Ejercicio 5:** `Python` *(Monitoreo TraceCode IA)*

> **Nota sobre TraceCode IA:** A excepción del Ejercicio 1 (código base proporcionado), los ejercicios 2 al 5 deben desarrollarse bajo la telemetría de TraceCode IA mediante commits incrementales en tu repositorio.

---

## Especificaciones de los ejercicios

### Ejercicio 1: Pila con Arreglos en C++ (Código de Referencia)
* **Complejidad:** ⭐ Básica
* **Objetivo:** Replicar, compilar y validar la implementación de la Pila basada en arreglos estáticos explicada en la presentación de clase (Diapositivas 20-21).
* **Entorno:** No requiere TraceCode IA (código de referencia).
* **Código proporcionado en clase:**
```cpp
#include <iostream>
#define MAX_SIZE 100

int stack[MAX_SIZE];
int top = -1;

void push(int item) {
    if (top == MAX_SIZE - 1) {
        std::cout << "Stack Overflow" << std::endl;
        return;
    }
    stack[++top] = item;
}

int pop() {
    if (top == -1) {
        std::cout << "Stack Underflow" << std::endl;
        return -1;
    }
    return stack[top--];
}

int peek() {
    if (top == -1) {
        std::cout << "Pila vacía" << std::endl;
        return -1;
    }
    return stack[top];
}

bool isEmpty() { return top == -1; }
bool isFull() { return top == MAX_SIZE - 1; }

int main() {
    push(10);
    push(20);
    push(30);

    std::cout << "Elemento Superior: " << peek() << std::endl;
    std::cout << "Extrae elemento: " << pop() << std::endl;
    std::cout << "Elemento Superior: " << peek() << std::endl;

    return 0;
}
```
* **Requisitos:**
  - Crear el archivo `pila_arreglo.cpp` dentro de esta carpeta.
  - Replicar el código base e incluir la función `main()` de prueba.
  - Compilar con `g++ -std=c++17 pila_arreglo.cpp -o pila_arreglo` y verificar su ejecución limpia.

---

### Ejercicio 2: Pila con Arreglos en Java
* **Complejidad:** ⭐⭐ Básica-intermedia
* **Objetivo:** Replicar y adaptar la lógica de la Pila con arreglos estáticos en lenguaje Java mediante Programación Orientada a Objetos (POO), programando la solución bajo TraceCode IA.
* **Entorno:** Requiere TraceCode IA activo.
* **Plantilla base:**
```java
public class PilaArreglo {
    private static final int MAX_SIZE = 100;
    private int[] stack = new int[MAX_SIZE];
    private int top = -1;

    public void push(int item) {
        // Implementar con verificación de Stack Overflow
    }

    public int pop() {
        // Implementar con verificación de Stack Underflow
        return -1;
    }

    public int peek() {
        // Implementar consulta del elemento superior
        return -1;
    }

    public boolean isEmpty() {
        return top == -1;
    }

    public boolean isFull() {
        return top == MAX_SIZE - 1;
    }

    public static void main(String[] args) {
        // Demostrar inserciones, extracciones y casos de desbordamiento
    }
}
```
* **Requisitos:**
  - Crear la clase `PilaArreglo.java` encapsulando el arreglo `int[] stack` y la variable `top`.
  - Implementar las operaciones `push`, `pop`, `peek`, `isEmpty` e `isFull`.
  - Compilar y probar con `javac PilaArreglo.java && java PilaArreglo`.

---

### Ejercicio 3: Pila con Arreglos en C#
* **Complejidad:** ⭐⭐ Básica-intermedia
* **Objetivo:** Replicar la Pila de capacidad fija con arreglos en C# (.NET) utilizando clases y métodos con convención PascalCase, codificando la solución en TraceCode IA.
* **Entorno:** Requiere TraceCode IA activo.
* **Plantilla base:**
```csharp
using System;

public class PilaArreglo {
    private const int MAX_SIZE = 100;
    private int[] stack = new int[MAX_SIZE];
    private int top = -1;

    public void Push(int item) {
        // Implementar con verificación de Stack Overflow
    }

    public int Pop() {
        // Implementar con verificación de Stack Underflow
        return -1;
    }

    public int Peek() {
        // Implementar consulta del tope
        return -1;
    }

    public bool IsEmpty() => top == -1;
    public bool IsFull() => top == MAX_SIZE - 1;

    public static void Main() {
        // Pruebas en consola
    }
}
```
* **Requisitos:**
  - Crear el archivo `PilaArreglo.cs`.
  - Seguir convenciones idiomáticas de C#: `Push`, `Pop`, `Peek`, `IsEmpty`, `IsFull`.
  - Validar límites y ejecutar con `dotnet run` o `csc`.

---

### Ejercicio 4: Pila con Arreglos en JavaScript
* **Complejidad:** ⭐⭐ Básica-intermedia
* **Objetivo:** Implementar la Pila con arreglo de tamaño fijo en JavaScript (ES6 Class) simulando memoria estática, desarrollada bajo TraceCode IA.
* **Entorno:** Requiere TraceCode IA activo.
* **Plantilla base:**
```javascript
class PilaArreglo {
    constructor(maxSize = 100) {
        this.maxSize = maxSize;
        this.stack = new Array(maxSize);
        this.top = -1;
    }

    push(item) {
        // Implementar sin usar Array.prototype.push
    }

    pop() {
        // Implementar sin usar Array.prototype.pop
    }

    peek() {
        // Retornar elemento superior
    }

    isEmpty() {
        return this.top === -1;
    }

    isFull() {
        return this.top === this.maxSize - 1;
    }
}

// Pruebas de funcionamiento en Node.js
```
* **Requisitos:**
  - Crear el archivo `pila_arreglo.js`.
  - **Regla estricta:** Prohibido usar `Array.prototype.push` o `Array.prototype.pop`. Se debe manipular manualmente el índice `this.top` sobre el arreglo predimensionado.
  - Ejecutar y verificar con `node pila_arreglo.js`.

---

### Ejercicio 5: Pila con Arreglos en Python
* **Complejidad:** ⭐⭐ Básica-intermedia
* **Objetivo:** Replicar la Pila con capacidad fija en Python mediante una lista predimensionada de tamaño fijo y control de índice top, codificada en TraceCode IA.
* **Entorno:** Requiere TraceCode IA activo.
* **Plantilla base:**
```python
class PilaArreglo:
    def __init__(self, max_size: int = 100):
        self.max_size = max_size
        self.stack = [None] * max_size
        self.top = -1

    def push(self, item: int) -> None:
        # Implementar sin usar list.append()
        pass

    def pop(self) -> int:
        # Implementar sin usar list.pop()
        pass

    def peek(self) -> int:
        pass

    def is_empty(self) -> bool:
        return self.top == -1

    def is_full(self) -> bool:
        return self.top == self.max_size - 1

if __name__ == '__main__':
    # Pruebas de funcionamiento
    pass
```
* **Requisitos:**
  - Crear el archivo `pila_arreglo.py`.
  - **Regla estricta:** Usar la lista preasignada `[None] * max_size`. Prohibido usar métodos nativos dinámicos como `append()` o `pop()`.
  - Incluir type hints y ejecutar con `python pila_arreglo.py`.

---

## Lineamientos de entrega y monitoreo (TraceCode IA)

1. **Repositorio asignado:** Todo el código fuente debe alojarse y versionarse mediante commits progresivos en esta carpeta `05_pilas_con_arreglos/`.
2. **Monitoreo:** Cada entrega es analizada por TraceCode IA para verificar la autoría y progresión incremental del código.
3. **Plazo de entrega:** Próximo domingo a las 23:59 hrs.
