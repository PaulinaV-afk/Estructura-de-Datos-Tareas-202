class Shellsort {
    //Una funcion de utilidad para imprimir una matriz de tamaño n
    static displayArr(imputArr) {
        console.log(imputArr.join(" "));
    }

    //Funcion para ordenar imputArr usando shellsort
    sort(imputArr) {
        let size = imputArr.length;
        //Comience con un espacio grande y luego reduzca su espacio
        let gapSize = Math.floor(size / 2);
        while (gapSize > 0) {
            //Estamos implementando una ordenacion por insercion con un espacio de tamaño especifico
            //Los primeros elementos de espacio de la matriz imputArr[0..gapSize-1]
            //Ya en orden, ahora tenemos que seguir agregando
            //un elemento mas hasta que la matriz este completamente ordenada
            for (let j = gapSize; j < size; j++) {
                let val = imputArr[j];
                let k = j;
                while (k >= gapSize && imputArr[k - gapSize] > val) {
                    imputArr[k] = imputArr[k - gapSize];
                    k = k - gapSize;
                }
                imputArr[k] = val;
            }
            gapSize = Math.floor(gapSize / 2);
        }
        return 0;
    }
}

let imputArr = [36, 34, 43, 11, 15, 20, 28, 25];
console.log("Antes de ser ordenados: ");
Shellsort.displayArr(imputArr);
let obj = new Shellsort();
obj.sort(imputArr);
console.log("Arreglo despues de ser ordenados: ");
Shellsort.displayArr(imputArr);