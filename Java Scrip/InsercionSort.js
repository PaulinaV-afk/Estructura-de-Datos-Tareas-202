function insertionSort(a) {
    for (let i = 1; i < a.length; i++) {
        let temp = a[i];
        //mueve los elementos mayores que temp
        // a una posicion mas adelante que su posicion actual
        let j = i - 1;
        while (j >= 0 && temp < a[j]) {
            a[j + 1] = a[j];
            j = j - 1;
        }
        a[j + 1] = temp;
    }
}

function printArr(a) { // funcion para imprimir el array
    let str = "";
    for (let i = 0; i < a.length; i++) {
        str += a[i] + " ";
    }
    console.log(str);
}

let a = [70, 15, 2, 51, 60];
console.log("Antesde ordenar los elementos del arreglo: ");
printArr(a);
insertionSort(a);
console.log("\nDespues de arreglos de los elementos del arreglo: ");
printArr(a);