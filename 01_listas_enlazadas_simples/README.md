# Listas enlazadas simples

> Implementación de estructuras lineales donde cada nodo almacena un elemento de datos y un puntero único de referencia hacia el nodo siguiente.

## Información del estudiante y asignación de lenguaje
* **Estudiante:** PAULINA VALDEZ COTA
* **Matrícula / Repositorio:** 20001223
* **Grupo:** Grupo 2
* **Organización:** EstructuraDeDatos2026-202

### Lenguajes asignados para este bloque (TraceCode IA)
* **Ejercicio 1:** `C++`
* **Ejercicio 2:** `JavaScript`
* **Ejercicio 3:** `C#`
* **Ejercicio 4:** `Python`
* **Ejercicio 5:** `Java`

> **Nota sobre TraceCode IA:** Para registrar adecuadamente la telemetría de desarrollo, realiza commits frecuentes e incrementales a medida que implementas cada solución en tu lenguaje asignado dentro de esta carpeta.

---

## Especificaciones de los ejercicios

### Ejercicio 1: Crear y mostrar una lista enlazada
* **Complejidad:** ⭐ Básica
* **Objetivo:** Implementar una lista simplemente enlazada que permita almacenar números enteros y mostrar todos sus elementos.
* **Ejemplo:**
```text
Inserción: 10 → 20 → 30 → 40
Salida: 10 20 30 40
```
* **Requisitos:**
  - Crear la estructura o clase Nodo con dato y puntero siguiente.
  - Insertar elementos al final de la lista.
  - Implementar una función para recorrer e imprimir secuencialmente todos los elementos.

---

### Ejercicio 2: Insertar elementos en posiciones específicas
* **Complejidad:** ⭐⭐ Básica-intermedia
* **Objetivo:** Permitir insertar un nuevo nodo en cualquier posición válida de la lista.
* **Ejemplo:**
```text
Lista inicial: 5 → 15 → 25
Insertar 20 en la posición 2
Resultado: 5 → 15 → 20 → 25
```
* **Requisitos:**
  - Insertar al inicio (nueva cabeza).
  - Insertar al final de la lista.
  - Insertar en una posición intermedia.
  - Validar y rechazar posiciones inválidas fuera de rango.

---

### Ejercicio 3: Eliminar nodos según diferentes criterios
* **Complejidad:** ⭐⭐⭐ Intermedia
* **Objetivo:** Implementar operaciones de eliminación de nodos en la lista.
* **Ejemplo:**
```text
Lista inicial: 10 → 20 → 30 → 40
Eliminar valor 30
Resultado: 10 → 20 → 40
```
* **Requisitos:**
  - Eliminar el primer nodo (cabeza).
  - Eliminar el último nodo.
  - Eliminar un nodo dado por su valor específico.
  - Manejar casos especiales: lista vacía, valor inexistente, cabeza y único nodo.

---

### Ejercicio 4: Invertir una lista enlazada
* **Complejidad:** ⭐⭐⭐⭐ Intermedia-avanzada
* **Objetivo:** Invertir el orden de los nodos sin utilizar arreglos ni memorias auxiliares.
* **Ejemplo:**
```text
Lista original: 1 → 2 → 3 → 4 → 5
Lista invertida: 5 → 4 → 3 → 2 → 1
```
* **Requisitos:**
  - Modificar exclusivamente los enlaces entre nodos (in-place).
  - Complejidad temporal O(n) y complejidad espacial auxiliar O(1).
  - Responder preguntas de análisis: punteros auxiliares requeridos y complejidad.

---

### Ejercicio 5: Detectar y eliminar ciclos en una lista enlazada
* **Complejidad:** ⭐⭐⭐⭐⭐ Avanzada
* **Objetivo:** Determinar si una lista contiene un ciclo y, en caso afirmativo, romperlo.
* **Ejemplo:**
```text
Ciclo: 1 → 2 → 3 → 4 → 5 (donde 5 apunta de regreso a 3)
Resultado tras romper ciclo: 1 → 2 → 3 → 4 → 5 → NULL
```
* **Requisitos:**
  - Detectar ciclo con el algoritmo de Floyd (Tortuga y Liebre / dos punteros).
  - Localizar el nodo donde inicia el ciclo.
  - Romper el ciclo asignando el puntero siguiente del último nodo a NULL.
  - No utilizar arreglos ni tablas hash o conjuntos auxiliares.

---

## Lineamientos de entrega y monitoreo (TraceCode IA)

1. **Repositorio asignado:** Todo el código fuente, pruebas unitarias y archivos de solución deben alojarse y versionarse mediante commits progresivos en tu repositorio personal asignado.
2. **Monitoreo:** Cada entrega es analizada por TraceCode IA para verificar la autoría y progresión incremental del código.
3. **Diversificación de lenguajes:** En este bloque temático de 5 ejercicios, cada estudiante debe implementar cada ejercicio en el lenguaje que le fue asignado de forma personalizada.