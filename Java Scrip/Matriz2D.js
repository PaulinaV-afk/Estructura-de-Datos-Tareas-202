// Implementacion
let TwoDimensionalArray = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
];

console.log("Los elementos del array son:");
for (let row of TwoDimensionalArray) {
    let line = "";
    for (let element of row) {
        line += element + " ";
    }
    console.log(line);
}