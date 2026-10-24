class Shellsort:
    #Una funcion de utilidad para imprimir una matriz de tamaño n
    @staticmethod
    def displayArr(imputArr):
        for k in imputArr:
            print(k, end=" ")
        print()
    #Funcionpara ordenar imputArr usando shellsort
    def sort(self, imputArr):
        size = len(imputArr)
        #Comience con un espacio grande y luego reduzca su espacio
        gapSize = size // 2
        while gapSize > 0:
            #Estamos implementando una ordenacion por insercion con un espacio de tamaño especifico
            #Los primeros elementos de espacio de la matriz imputArr[0..gapSize-1]
            #Ya en orden, ahora tenemos que seguir agregando
            #un elemento mas hasta que la matriz este completamente ordenada
            for j in range(gapSize, size):
                val = imputArr[j]
                k = j
                while k >= gapSize and imputArr[k - gapSize] > val:
                    imputArr[k] = imputArr[k - gapSize]
                    k = k - gapSize
                imputArr[k] = val
            gapSize = gapSize // 2
        return 0

        
if __name__ == "__main__":
    imputArr = [36, 34, 43, 11, 15, 20, 28, 25]
    print("Antes de ser ordenados: ")
    Shellsort.displayArr(imputArr)
    obj = Shellsort()
    obj.sort(imputArr)
    print("Arreglo despues de ser ordenados: ")
    Shellsort.displayArr(imputArr)
