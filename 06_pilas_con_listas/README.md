# Pilas con listas enlazadas

> Implementación del Tipo de Dato Abstracto (TDA) Pila dinámico utilizando nodos enlazados con punteros/referencias bajo semántica LIFO (Last-In, First-Out), eliminando la restricción de capacidad fija.

## Información del estudiante y asignación de lenguaje
* **Estudiante:** Valdez Cota Paulina
* **Matrícula / Repositorio:** 20001223
* **Grupo:** Grupo 2 (202)
* **Organización:** EstructuraDeDatos2026-202

### Lenguajes asignados para este bloque (TraceCode IA)
* **Ejercicio 6:** `C++` *(Punteros y memoria dinámica `new`/`delete`)*
* **Ejercicio 7:** `Java` *(Nodos autorreferenciados POO)*
* **Ejercicio 8:** `C#` *(Referencias tipadas .NET y propiedades)*
* **Ejercicio 9:** `JavaScript` *(Clases ES6 y referencias de objetos)*
* **Ejercicio 10:** `Python` *(Clases POO y enlaces de nodos)*

> **Nota sobre TraceCode IA:** Todos los ejercicios de este bloque (Ejercicios 6 al 10) deben desarrollarse obligatoriamente bajo la telemetría de TraceCode IA mediante commits incrementales en tu repositorio.

---

## Especificaciones de los ejercicios

### Ejercicio 6: Pila con Listas Enlazadas en C++
* **Complejidad:** ⭐⭐⭐ Intermedia
* **Objetivo:** Diseñar e implementar el TDA Pila dinámica sobre nodos enlazados con punteros y memoria dinámica en C++, desarrollado bajo TraceCode IA.
* **Entorno:** Requiere TraceCode IA activo.
* **Plantilla base:**
```cpp
#include <iostream>

struct Nodo {
    int dato;
    Nodo* siguiente;
};

class PilaLista {
private:
    Nodo* top;

public:
    PilaLista() : top(nullptr) {}
    ~PilaLista(); // Liberar memoria de todos los nodos

    void push(int item);
    int pop();
    int peek();
    bool isEmpty();
    void display();
};

int main() {
    // Demostrar inserción, consulta, extracción y recorrido
    return 0;
}
```
* **Requisitos:**
  - Crear el archivo `pila_lista.cpp`.
  - Gestionar memoria dinámica explícita: usar `new Nodo` en `push` y `delete` en `pop` y en el destructor `~PilaLista()`.
  - Garantizar complejidad temporal O(1) en inserción y extracción.
  - Compilar con `g++ -std=c++17 pila_lista.cpp -o pila_lista`.

---

### Ejercicio 7: Pila con Listas Enlazadas en Java
* **Complejidad:** ⭐⭐⭐ Intermedia
* **Objetivo:** Implementar el TDA Pila dinámico utilizando nodos autorreferenciados en Java, programado en TraceCode IA.
* **Entorno:** Requiere TraceCode IA activo.
* **Plantilla base:**
```java
public class PilaLista {
    private static class Nodo {
        int dato;
        Nodo siguiente;
        Nodo(int dato) { this.dato = dato; this.siguiente = null; }
    }

    private Nodo top = null;

    public void push(int item) { /* Tu código aquí */ }
    public int pop() { /* Control de Underflow */ return -1; }
    public int peek() { /* Tu código aquí */ return -1; }
    public boolean isEmpty() { return top == null; }
    public void display() { /* Recorrido e impresión */ }

    public static void main(String[] args) {
        // Pruebas de funcionamiento
    }
}
```
* **Requisitos:**
  - Crear el archivo `PilaLista.java`.
  - Modelar la clase `Nodo` interna o independiente.
  - Operaciones primitivas en tiempo O(1) y verificación en `main()`.

---

### Ejercicio 8: Pila con Listas Enlazadas en C#
* **Complejidad:** ⭐⭐⭐ Intermedia
* **Objetivo:** Implementar el TDA Pila dinámico sobre nodos enlazados en C# con gestión de referencias .NET en TraceCode IA.
* **Entorno:** Requiere TraceCode IA activo.
* **Plantilla base:**
```csharp
using System;

public class PilaLista {
    private class Nodo {
        public int Dato { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo(int dato) { Dato = dato; Siguiente = null; }
    }

    private Nodo top = null;

    public void Push(int item) { /* Tu código aquí */ }
    public int Pop() { /* Tu código aquí */ return -1; }
    public int Peek() { /* Tu código aquí */ return -1; }
    public bool IsEmpty() => top == null;
    public void Display() { /* Recorrer y mostrar */ }

    public static void Main() {
        // Pruebas en consola
    }
}
```
* **Requisitos:**
  - Crear el archivo `PilaLista.cs`.
  - Convenciones idiomáticas de C# (.NET).
  - Validar operaciones O(1) y verificar con `dotnet run`.

---

### Ejercicio 9: Pila con Listas Enlazadas en JavaScript
* **Complejidad:** ⭐⭐⭐ Intermedia
* **Objetivo:** Implementar el TDA Pila dinámico mediante nodos y referencias en JavaScript (ES6 Classes) con TraceCode IA.
* **Entorno:** Requiere TraceCode IA activo.
* **Plantilla base:**
```javascript
class Nodo {
    constructor(dato) {
        this.dato = dato;
        this.siguiente = null;
    }
}

class PilaLista {
    constructor() {
        this.top = null;
    }

    push(item) { /* Tu código aquí */ }
    pop() { /* Tu código aquí */ }
    peek() { /* Tu código aquí */ }
    isEmpty() { return this.top === null; }
    display() { /* Recorrer y mostrar */ }
}

// Pruebas en Node.js
```
* **Requisitos:**
  - Crear el archivo `pila_lista.js`.
  - Construir la pila utilizando únicamente referencias a objetos `Nodo`.
  - Validar operaciones con `node pila_lista.js`.

---

### Ejercicio 10: Pila con Listas Enlazadas en Python
* **Complejidad:** ⭐⭐⭐ Intermedia
* **Objetivo:** Implementar el TDA Pila dinámico sobre nodos enlazados en Python mediante POO y referencias de memoria, desarrollado bajo TraceCode IA.
* **Entorno:** Requiere TraceCode IA activo.
* **Plantilla base:**
```python
class Nodo:
    def __init__(self, dato: int):
        self.dato = dato
        self.siguiente = None

class PilaLista:
    def __init__(self):
        self.top = None

    def push(self, item: int) -> None:
        pass

    def pop(self) -> int:
        pass

    def peek(self) -> int:
        pass

    def is_empty(self) -> bool:
        return self.top is None

    def display(self) -> None:
        pass

if __name__ == '__main__':
    # Pruebas de funcionamiento
    pass
```
* **Requisitos:**
  - Crear el archivo `pila_lista.py`.
  - Implementar las clases `Nodo` y `PilaLista` garantizando operaciones O(1).
  - Validar casos en el bloque `if __name__ == '__main__':`.

---

## Lineamientos de entrega y monitoreo (TraceCode IA)

1. **Repositorio asignado:** Todo el código fuente debe alojarse y versionarse mediante commits progresivos en esta carpeta `06_pilas_con_listas/`.
2. **Monitoreo:** Cada entrega es analizada por TraceCode IA para verificar la autoría y progresión incremental del código.
3. **Plazo de entrega:** Próximo domingo a las 23:59 hrs.
