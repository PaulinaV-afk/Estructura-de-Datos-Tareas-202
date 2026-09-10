const inputArr = [12, 34, 10, 6, 40];
const s = inputArr.length;

console.log("Recorrido inverso del array:");
for (let j = s - 1; j >= 0; j--) {
    console.log("Elemento en el índice " + j + ": " + inputArr[j]);
}