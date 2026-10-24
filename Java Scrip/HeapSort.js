// Heapsort es un algoritmo de ordenamiento basado en un árbol binario llamado "heap".
// La idea es construir un heap máximo (max-heap) y luego extraer el mayor elemento
// (la raíz) para colocarlo al final del arreglo, repitiendo el proceso hasta ordenar todo.
function heapify(arr, n, i) {
    // Función para asegurar que el subárbol con raíz en el índice i
    // cumpla con la propiedad de heap máximo.
    // arr: lista a ordenar
    // n: tamaño del heap
    // i: índice de la raíz del subárbol
    let largest = i;        // Inicialmente, asumimos que la raíz es el mayor
    let left = 2 * i + 1;    // Índice del hijo izquierdo
    let right = 2 * i + 2;   // Índice del hijo derecho
    
    // Si el hijo izquierdo existe y es mayor que la raíz
    if (left < n && arr[left] > arr[largest]) {
        largest = left;
    }
    
    // Si el hijo derecho existe y es mayor que el mayor actual
    if (right < n && arr[right] > arr[largest]) {
        largest = right;
    }
    
    // Si el mayor no es la raíz, intercambiamos y seguimos ajustando recursivamente
    if (largest !== i) {
        let temp = arr[i];
        arr[i] = arr[largest];
        arr[largest] = temp; // Intercambio
        heapify(arr, n, largest); // Ajustar el subárbol afectado
    }
}

function heapsort(arr) {
    // Función principal de Heapsort.
    // Ordena la lista arr en orden ascendente.
    let n = arr.length;
    
    // Paso 1: Construir un heap máximo
    for (let i = Math.floor(n / 2) - 1; i >= 0; i--) {
        heapify(arr, n, i);
    }
    
    // Paso 2: Extraer elementos uno por uno del heap
    for (let i = n - 1; i > 0; i--) {
        // Mover la raíz (máximo) al final
        let temp = arr[0];
        arr[0] = arr[i];
        arr[i] = temp;
        
        // Llamar heapify en el heap reducido
        heapify(arr, i, 0);
    }
}

// Ejemplo de uso
let lista = [12, 11, 13, 5, 6, 7];
console.log("Antes de ordenar los elementos del array son: ", lista);
heapsort(lista);
console.log("\nDespués de ordenar el arreglo: ", lista);