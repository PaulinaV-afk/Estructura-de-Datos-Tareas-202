function bubbleSort(a) {
    let s = a.length;
    //Iternando por todos los elementos del array
    for (let j_outer = 0; j_outer < s; j_outer++) {
        let isSwapped = false;
        //los ultimos elemntos ya estan en su puesto correspondiente
        for (let j = 0; j < s - j_outer - 1; j++) {
            //recorriendo el array de 0 a s - j - 1
            //intercambiando si el elemento encontrado es mayor
            //que el siguiente elemento
            if (a[j] > a[j + 1]) {
                let temp = a[j];
                a[j] = a[j + 1];
                a[j + 1] = temp;
                isSwapped = true;
            }
        }
        if (isSwapped === false) {
            break;
        }
    }
}

//Codigo del controlador para la prueba anterior
let a = [15, 16, 11, 13, 14];
console.log("Antes de ordenar los elementos del array son: ");
console.log(a.join(" "));

bubbleSort(a);
console.log("\nDespues de ordenar los elementos del array son: ");
let outputStr = "";
for (let j = 0; j < a.length; j++) {
    outputStr += a[j] + " ";
}
console.log(outputStr);