
function findEle(arr, targetValue) {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === targetValue) {
            return i;
        }
    }
    return -1;
}

const inputArr = [12, 34, 10, 6, 40, 89, 98, 57, 19, 69]; // arrays de entrada
const targetElement = 40; // elemento a encontrar

// operación de búsqueda
const idx = findEle(inputArr, targetElement);
if (idx !== -1) {
    console.log("El elemento se encuentra en la posición: " + (idx + 1));
} else {
    console.log("El elemento no se encuentra.");
}