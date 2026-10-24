// Programa de JavaScript para implementar Radix Sort
// Una función que ordena arr[] según el dígito representado por exp.
function countingSort(arr, exp) { // exp es 10^i donde i es el dígito actual
    let s = arr.length; // Tamaño del arreglo de entrada
    // El arreglo de salida que tendrá el arreglo ordenado
    // inicializando todos los elementos a 0
    let outputArray = new Array(s).fill(0); // array de tamaño s
    let countArray = new Array(10).fill(0); // array de conteo para dígitos (0-9)

    // almacenando el conteo de ocurrencias en countArray[]
    for (let j = 0; j < s; j++) { // j es el índice del arreglo de entrada
        let idx = Math.floor(arr[j] / exp); // Obtener el dígito actual
        countArray[idx % 10] += 1; // Incrementar el conteo del dígito
    }

    // Cambiar countArray[i] para que ahora contenga la posición real de este dígito en el arreglo de salida
    for (let j = 1; j < 10; j++) { // j es el índice del arreglo de conteo
        countArray[j] += countArray[j - 1]; // Acumular los conteos
    }

    // Construir el arreglo de salida
    let j = s - 1; // Índice del último elemento del arreglo de entrada
    while (j >= 0) { // j es el índice del arreglo de entrada
        let idx = Math.floor(arr[j] / exp); // Obtener el dígito actual
        outputArray[countArray[idx % 10] - 1] = arr[j]; // Colocar el elemento en la posición correcta
        countArray[idx % 10] -= 1; // Decrementar el conteo
        j -= 1; // Mover al siguiente elemento
    }

    // Copiar el arreglo de salida a arr[],
    // Por lo tanto, arr ahora contiene números en ordenados
    for (let k = 0; k < arr.length; k++) { // j es el índice del arreglo de entrada
        arr[k] = outputArray[k]; // Copiar el elemento al arreglo de entrada
    }
}

// Metodo principal para implementar Radix Sort
function radixSort(arr) { // La función principal que ordena arr[] usando Radix Sort
    // Obtener el número máximo para saber el número de dígitos
    let max1 = Math.max(...arr); // Encontrar el valor máximo en el arreglo

    // Hacer un conteo de ordenamiento para cada dígito.
    // Aplicando counting sort para cada dígito.
    let exp = 1; // Exponente inicial (10^0)
    while (max1 / exp >= 1) { // Mientras queden dígitos por procesar
        countingSort(arr, exp); // Ordenar según el dígito actual
        exp *= 10; // Mover al siguiente dígito
    }
}

// Ejemplo de uso
let arr = [171, 46, 76, 91, 803, 25, 3, 67]; // Arreglo de entrada
console.log("Arreglo antes de ordenar: "); // Imprimir arreglo antes de ordenar
let str1 = "";
for (let j = 0; j < arr.length; j++) { // j es el índice del arreglo
    str1 += arr[j] + " "; // Imprimir elementos del arreglo
}
console.log(str1);

// Llamar a la función de ordenamiento Radix
radixSort(arr); // Llamar a la función de ordenamiento Radix
console.log("\nDespués de ordenar el arreglo: "); // Imprimir el arreglo ordenado
let str2 = "";
for (let j = 0; j < arr.length; j++) { // j es el índice del arreglo
    str2 += arr[j] + " "; // Imprimir elementos del arreglo ordenado
}
console.log(str2);