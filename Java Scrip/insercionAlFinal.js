let inputArr = [10, 20, 30];
let elementToInsert = 40;

console.log("Antes de insertar, el array es:");
let strAntes = "";
for (let j = 0; j < inputArr.length; j++) {
    strAntes += inputArr[j] + " ";
}
console.log(strAntes);

// Insertando elemento al final
inputArr.push(elementToInsert);

console.log("Después de insertar " + elementToInsert + " al final, el array es:");
let strDespues = "";
for (let j = 0; j < inputArr.length; j++) {
    strDespues += inputArr[j] + " ";
}
console.log(strDespues);