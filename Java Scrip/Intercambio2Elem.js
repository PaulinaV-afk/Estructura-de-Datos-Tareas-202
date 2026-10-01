// Función para intercambiar dos elementos en el arreglo
function swap(a, j, k) { // intercambia los elementos
    let temp = a[j];
    a[j] = a[k];
    a[k] = temp; // intercambia los elementos
}

// Función para particionar el arreglo alrededor de un pivote
function partition(a, l, h) {
    let pivot = a[h];
    let i = l - 1;
    for (let j = l; j < h; j++) {
        if (a[j] <= pivot) {
            i += 1;
            swap(a, i, j);
        }
    }
    swap(a, i + 1, h);
    return i + 1;
}

// Implementación de la función QuickSort
function qckSort(a, l, h) { // función principal de QuickSort
    if (l < h) { // si el índice izquierdo es menor que el derecho
        // pi es el índice de partición, regresa el índice del pivote
        let pi = partition(a, l, h); // particiona el arreglo
        // llamadas recursivas para los elementos menores
        // y mayores o iguales a los elementos
        qckSort(a, l, pi - 1); // llamada recursiva para los elementos menores que el pivote
        qckSort(a, pi + 1, h); // llamada recursiva para los elementos mayores o iguales que el pivote
    }
}

// Código para probar la implementación de QuickSort
if (require.main === module) { // punto de entrada del programa
    let a = [10, 7, 8, 9, 1, 5]; // arreglo desordenado
    let size = a.length; // tamaño del arreglo
    console.log("El arreglo antes de ordenarlo: ");
    let beforeStr = "";
    for (let v of a) { // imprime el arreglo
        beforeStr += v + " ";
    }
    console.log(beforeStr);
    console.log(); // salto de línea
    qckSort(a, 0, size - 1);
    console.log("El arreglo después de ordenarlo: ");
    let afterStr = "";
    for (let v of a) { // imprime el arreglo ordenado
        afterStr += v + " ";
    }
    console.log(afterStr);
}