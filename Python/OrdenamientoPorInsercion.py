def insertionSort(a):
    for i in range(1, len(a)):
        temp =a[i]
        #mueve los elementos mayores que temp
        # a una posicion mas adelante que su posicion actual
        j = i-1
        while j >= 0 and temp < a[j] :
            a[j +1]= a[j]
            j = j-1
        a[j + 1] = temp
def printArr(a): # funcion para imprimir el array
    for i in range(len(a)):
        print (a[i], end = " ")
a = [70, 15, 2, 51, 60]
print("Antesde ordenar los elementos del arreglo: ")
printArr(a)
insertionSort(a)
print("\nDespues de arreglos de los elementos del arreglo: ")
printArr(a)
