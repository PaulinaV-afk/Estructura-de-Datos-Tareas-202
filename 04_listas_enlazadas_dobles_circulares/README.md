# Listas enlazadas dobles circulares

> Estructura bidireccional de ciclo continuo donde la cabeza apunta hacia atrás al último nodo y la cola apunta hacia adelante al primer nodo.

## Información del estudiante y asignación de lenguaje
* **Estudiante:** PAULINA VALDEZ COTA
* **Matrícula / Repositorio:** 20001223
* **Grupo:** Grupo 2
* **Organización:** EstructuraDeDatos2026-202

### Lenguajes asignados para este bloque (TraceCode IA)
* **Ejercicio 1:** `C++`
* **Ejercicio 2:** `Python`
* **Ejercicio 3:** `C#`
* **Ejercicio 4:** `Java`
* **Ejercicio 5:** `JavaScript`

> **Nota sobre TraceCode IA:** Para registrar adecuadamente la telemetría de desarrollo, realiza commits frecuentes e incrementales a medida que implementas cada solución en tu lenguaje asignado dentro de esta carpeta.

---

## Especificaciones de los ejercicios

### Ejercicio 1: Navegación continua en carrusel
* **Complejidad:** ⭐ Básica
* **Objetivo:** Navegar indefinidamente en sentido horario y antihorario a través de los nodos.
* **Ejemplo:**
```text
[Elemento 1] ⇄ [Elemento 2] ⇄ [Elemento 3] ⇄ (vuelve al inicio)
```
* **Requisitos:**
  - Moverse hacia adelante con siguiente y hacia atrás con anterior.
  - Cerrar correctamente los enlaces dobles en extremos.

---

### Ejercicio 2: Inserción antes y después de un valor de referencia
* **Complejidad:** ⭐⭐ Básica-intermedia
* **Objetivo:** Insertar un nuevo nodo antes o después de un nodo existente conservando la circularidad doble.
* **Ejemplo:**
```text
En A ⇄ B ⇄ C, insertar X antes de B → A ⇄ X ⇄ B ⇄ C
```
* **Requisitos:**
  - Localizar el nodo de referencia.
  - Ajustar los 4 punteros de forma segura.

---

### Ejercicio 3: Reproductor multimedia con rotación y eliminación de pista
* **Complejidad:** ⭐⭐⭐ Intermedia
* **Objetivo:** Control de lista de reproducción con avance, retroceso y eliminación de la pista activa.
* **Ejemplo:**
```text
Eliminar pista en curso y reanudar en la pista siguiente sin romper el ciclo.
```
* **Requisitos:**
  - Gestionar el caso de eliminación cuando sólo queda una pista.
  - Mantener consistencia en punteros dobles.

---

### Ejercicio 4: Verificación de palíndromo bidireccional
* **Complejidad:** ⭐⭐⭐⭐ Intermedia-avanzada
* **Objetivo:** Verificar si la secuencia es palíndroma recorriendo simultáneamente desde cabeza y cola.
* **Ejemplo:**
```text
R ⇄ A ⇄ D ⇄ A ⇄ R es palíndromo (verdadero).
H ⇄ O ⇄ L ⇄ A no es palíndromo (falso).
```
* **Requisitos:**
  - Avanzar puntero frontal y retroceder puntero trasero hasta cruzarse.
  - Complejidad temporal O(n/2) y espacial O(1).

---

### Ejercicio 5: Mezcla ordenada in-place de dos listas circulares dobles
* **Complejidad:** ⭐⭐⭐⭐⭐ Avanzada
* **Objetivo:** Fusionar dos listas circulares dobles ordenadas en una sola lista circular doble ordenada.
* **Ejemplo:**
```text
Lista 1 (1 ⇄ 4 ⇄ 7) y Lista 2 (2 ⇄ 3 ⇄ 8) → 1 ⇄ 2 ⇄ 3 ⇄ 4 ⇄ 7 ⇄ 8
```
* **Requisitos:**
  - Reutilizar nodos existentes sin crear memoria auxiliar O(1).
  - Preservar la circularidad doble completa al finalizar la mezcla.

---

## Lineamientos de entrega y monitoreo (TraceCode IA)

1. **Repositorio asignado:** Todo el código fuente, pruebas unitarias y archivos de solución deben alojarse y versionarse mediante commits progresivos en tu repositorio personal asignado.
2. **Monitoreo:** Cada entrega es analizada por TraceCode IA para verificar la autoría y progresión incremental del código.
3. **Diversificación de lenguajes:** En este bloque temático de 5 ejercicios, cada estudiante debe implementar cada ejercicio en el lenguaje que le fue asignado de forma personalizada.