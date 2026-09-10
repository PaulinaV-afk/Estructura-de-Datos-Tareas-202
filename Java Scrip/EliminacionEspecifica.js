let inputArr = [10, 20, 30, 40, 50];
let targetValue = 30;

console.log("Antes de eliminar, el array es:");
let strAntes = "";
for (let j = 0; j < inputArr.length; j++) {
    strAntes += inputArr[j] + " ";
}
console.log(strAntes);

// Eliminación específica por valor
let idx = inputArr.indexOf(targetValue);
if (idx !== -1) {
    inputArr.splice(idx, 1);
}

console.log("Después de eliminar " + targetValue + ", el array es:");
let strDespues = "";
for (let j = 0; j < inputArr.length; j++) {
    strDespues += inputArr[j] + " ";
}
console.log(strDespues);