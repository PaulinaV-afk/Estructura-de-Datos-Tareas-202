# Listas enlazadas dobles

> Estructura lineal bidireccional donde cada nodo contiene enlaces explícitos tanto al elemento siguiente (next) como al elemento anterior (prev).

## Información del estudiante y asignación de lenguaje
* **Estudiante:** PAULINA VALDEZ COTA
* **Matrícula / Repositorio:** 20001223
* **Grupo:** Grupo 2
* **Organización:** EstructuraDeDatos2026-202

### Lenguajes asignados para este bloque (TraceCode IA)
* **Ejercicio 1:** `C++`
* **Ejercicio 2:** `JavaScript`
* **Ejercicio 3:** `Python`
* **Ejercicio 4:** `Java`
* **Ejercicio 5:** `C#`

> **Nota sobre TraceCode IA:** Para registrar adecuadamente la telemetría de desarrollo, realiza commits frecuentes e incrementales a medida que implementas cada solución en tu lenguaje asignado dentro de esta carpeta.

---

## Especificaciones de los ejercicios

### Ejercicio 1: Construcción y recorrido bidireccional
* **Complejidad:** ⭐ Básica
* **Objetivo:** Implementar la estructura NodoDoble y permitir mostrar la lista hacia adelante y hacia atrás.
* **Ejemplo:**
```text
Inserción: 10, 20, 30, 40
Recorrido directo: 10 ⇄ 20 ⇄ 30 ⇄ 40
Recorrido inverso: 40 ⇄ 30 ⇄ 20 ⇄ 10
```
* **Requisitos:**
  - Estructura de nodo con punteros dato, anterior y siguiente.
  - Funciones de inserción al final e impresión en ambos sentidos.

---

### Ejercicio 2: Inserción ordenada en lista doble
* **Complejidad:** ⭐⭐ Básica-intermedia
* **Objetivo:** Insertar un nuevo valor en la posición adecuada para conservar el orden ascendente.
* **Ejemplo:**
```text
Lista actual: 10 ⇄ 30 ⇄ 50
Insertar 25
Resultado: 10 ⇄ 25 ⇄ 30 ⇄ 50
```
* **Requisitos:**
  - Actualizar correctamente los 4 enlaces involucrados.
  - Contemplar inserción al inicio (nueva cabeza), intermedia y final (nueva cola).

---

### Ejercicio 3: Eliminación de nodo por valor
* **Complejidad:** ⭐⭐⭐ Intermedia
* **Objetivo:** Localizar un nodo en la lista doble y desvincularlo liberando la memoria.
* **Ejemplo:**
```text
Lista: 5 ⇄ 15 ⇄ 25 ⇄ 35
Eliminar 15
Resultado: 5 ⇄ 25 ⇄ 35
```
* **Requisitos:**
  - Casos especiales: elemento en cabeza, en cola, único nodo o inexistente.
  - Reconectar los punteros de los nodos adyacentes de manera consistente.

---

### Ejercicio 4: Invertir una lista doble in-place
* **Complejidad:** ⭐⭐⭐⭐ Intermedia-avanzada
* **Objetivo:** Invertir el orden intercambiando los punteros anterior y siguiente de cada nodo.
* **Ejemplo:**
```text
Original: 1 ⇄ 2 ⇄ 3 ⇄ 4
Invertida: 4 ⇄ 3 ⇄ 2 ⇄ 1
```
* **Requisitos:**
  - Complejidad temporal O(n) y espacial O(1).
  - No utilizar estructuras auxiliares ni duplicar nodos.

---

### Ejercicio 5: Sistema de caché LRU simplificado
* **Complejidad:** ⭐⭐⭐⭐⭐ Avanzada
* **Objetivo:** Implementar política de desalojo del elemento menos recientemente utilizado con capacidad fija.
* **Ejemplo:**
```text
Capacidad = 3:
1. Insertar A, B, C → [C ⇄ B ⇄ A]
2. Consultar A → [A ⇄ C ⇄ B]
3. Insertar D → Desaloja B → [D ⇄ A ⇄ C]
```
* **Requisitos:**
  - Mover elementos accedidos a la cabeza.
  - Desalojar automáticamente el nodo de la cola al exceder la capacidad.

---

## Lineamientos de entrega y monitoreo (TraceCode IA)

1. **Repositorio asignado:** Todo el código fuente, pruebas unitarias y archivos de solución deben alojarse y versionarse mediante commits progresivos en tu repositorio personal asignado.
2. **Monitoreo:** Cada entrega es analizada por TraceCode IA para verificar la autoría y progresión incremental del código.
3. **Diversificación de lenguajes:** En este bloque temático de 5 ejercicios, cada estudiante debe implementar cada ejercicio en el lenguaje que le fue asignado de forma personalizada.