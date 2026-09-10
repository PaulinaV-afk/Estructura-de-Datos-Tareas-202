// Programa para eliminar un elemento al final
let inputArr = [11, 21, 31, 41, 51, 61];
console.log("Antes de eliminar, el array es: ");
let strAntes = "";
for (let j = 0; j < inputArr.length; j++) {
    strAntes += inputArr[j] + " ";
}
console.log(strAntes);

// Eliminando el elemento al final
inputArr.pop();

console.log("Después de eliminar, el array es: ");
let strDespues = "";
for (let j = 0; j < inputArr.length; j++) {
    strDespues += inputArr[j] + " ";
}
console.log(strDespues);