# Listas enlazadas simples circulares

> Estructura lineal donde el último nodo enlaza directamente de regreso con el primer nodo de la lista (cabeza), formando un ciclo continuo sin punteros nulos.

## Información del estudiante y asignación de lenguaje
* **Estudiante:** PAULINA VALDEZ COTA
* **Matrícula / Repositorio:** 20001223
* **Grupo:** Grupo 2
* **Organización:** EstructuraDeDatos2026-202

### Lenguajes asignados para este bloque (TraceCode IA)
* **Ejercicio 1:** `Python`
* **Ejercicio 2:** `Java`
* **Ejercicio 3:** `C#`
* **Ejercicio 4:** `C++`
* **Ejercicio 5:** `JavaScript`

> **Nota sobre TraceCode IA:** Para registrar adecuadamente la telemetría de desarrollo, realiza commits frecuentes e incrementales a medida que implementas cada solución en tu lenguaje asignado dentro de esta carpeta.

---

## Especificaciones de los ejercicios

### Ejercicio 1: Recorrido y conteo de nodos circulares
* **Complejidad:** ⭐ Básica
* **Objetivo:** Recorrer y contar exactamente una vuelta completa sin caer en bucle infinito.
* **Ejemplo:**
```text
Lista: 10 → 20 → 30 → (vuelve a 10)
Salida: Elementos: 10 20 30 | Total de nodos: 3
```
* **Requisitos:**
  - Condición de parada adecuada (do...while o referencia a la cabeza).
  - Validación para listas vacías y listas de un solo nodo.

---

### Ejercicio 2: Inserción en O(1) utilizando solo puntero a la cola
* **Complejidad:** ⭐⭐ Básica-intermedia
* **Objetivo:** Administrar la lista únicamente con el puntero tail, logrando inserción en O(1) al inicio y al final.
* **Ejemplo:**
```text
Lista: 10 → 20 → 30 → (10)
Insertar inicio (5): 5 → 10 → 20 → 30 → (5)
Insertar final (40): 5 → 10 → 20 → 30 → 40 → (5)
```
* **Requisitos:**
  - Aprovechar que la cabeza es accesible inmediatamente como tail.sig.
  - Actualizar tail adecuadamente en inserciones al final.

---

### Ejercicio 3: División de una lista circular en dos mitades
* **Complejidad:** ⭐⭐⭐ Intermedia
* **Objetivo:** Dividir una lista circular de longitud N en dos listas circulares independientes.
* **Ejemplo:**
```text
Original: 1 → 2 → 3 → 4 → 5 → 6 → (1)
Mitad 1: 1 → 2 → 3 → (1)
Mitad 2: 4 → 5 → 6 → (4)
```
* **Requisitos:**
  - Uso de puntero rápido y lento para hallar el punto medio.
  - Cerrar la circularidad de ambas sublistas de forma independiente.

---

### Ejercicio 4: Planificador de CPU Round-Robin
* **Complejidad:** ⭐⭐⭐⭐ Intermedia-avanzada
* **Objetivo:** Simular la planificación de procesos Round-Robin con un quantum de tiempo en lista circular.
* **Ejemplo:**
```text
Quantum 2 ms. Procesos en lista circular con tiempo restante de ráfaga.
```
* **Requisitos:**
  - Disminuir el tiempo de ráfaga en cada turno.
  - Eliminar el nodo cuando el tiempo llega a cero o avanzar al siguiente.

---

### Ejercicio 5: El problema de Josephus
* **Complejidad:** ⭐⭐⭐⭐⭐ Avanzada
* **Objetivo:** Resolver el problema de Josephus con N personas y paso de eliminación K.
* **Ejemplo:**
```text
N = 5 personas (1 a 5), paso K = 2.
Eliminaciones: 2, 4, 1, 5.
Superviviente: 3.
```
* **Requisitos:**
  - Imprimir la secuencia de eliminación paso a paso.
  - Retornar el nodo superviviente.

---

## Lineamientos de entrega y monitoreo (TraceCode IA)

1. **Repositorio asignado:** Todo el código fuente, pruebas unitarias y archivos de solución deben alojarse y versionarse mediante commits progresivos en tu repositorio personal asignado.
2. **Monitoreo:** Cada entrega es analizada por TraceCode IA para verificar la autoría y progresión incremental del código.
3. **Diversificación de lenguajes:** En este bloque temático de 5 ejercicios, cada estudiante debe implementar cada ejercicio en el lenguaje que le fue asignado de forma personalizada.