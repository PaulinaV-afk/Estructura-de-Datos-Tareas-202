// Implementacion
let r = 3; let c = 3;
let arr = new Array(r * c).fill(0);

// Matriz iniciada y luego se asigna un valor
let TwoDArr = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]; // Almacenae elemnetos en array unidimensional ordenados por filas

let k = 0;
for (let x = 0; x < r; x++) {
    for (let y = 0; y < c; y++) {
        k = x * r + y;
        arr[k] = TwoDArr[x][y];
        k = k + 1;
    }
}

console.log("Los elementos del array bidimensional son:");
for (let row of TwoDArr) {
    let line = "";
    for (let ele of row) {
        line += ele + " "; // Mostrar los elementos de la fila separados por espacios
    }
    console.log(line); // Ir a la siguiente linea despues de mostrar una fila
}

console.log("\nLos elementos del array unidimensional son:");
// Imprimir los elemenos del array unidimensional
let flatStr = "";
for (let x = 0; x < r; x++) {
    for (let y = 0; y < c; y++) {
        flatStr += arr[x * r + y] + " ";
    }
}
console.log(flatStr);