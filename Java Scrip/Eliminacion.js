// Programa para eliminar un elemento al principio de un array
let inputArr = [11, 21, 31, 41, 51, 61];

console.log("Antes de la eliminacion el array es: ");
let antes = "";
for (let j = 0; j < inputArr.length; j++) {
    antes += inputArr[j] + " ";
}
console.log(antes);

// Eliminando el primer elemento
inputArr.shift();

console.log("Despuesde la eliminacion, el array es ");
let despues = "";
for (let j = 0; j < inputArr.length; j++) {
    despues += inputArr[j] + " ";
}
console.log(despues);
