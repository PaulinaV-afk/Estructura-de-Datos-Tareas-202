def bubbleSort(a):
    s = len(a)
    #Iternando por todos los elementos del array
    for j in range(s):
        #los ultimos elemntos ya estan en su puesto correspondiente
        for j in range(0, s - j - 1):
            #recorriendo el array de 0 a s - j - 1
            #intercambiando si el elemento encontrado es mayor
            #que el siguiente elemento
            if a[j] >a[j + 1]:
                a[j], a[j + 1] = a[j + 1], a[j]
                isSwapped = True
                if (isSwapped == False):
                    break
#Codigo del controlador para la prueba anterior
if __name__ == "__main__":
    a = [15, 16, 11, 13, 14]
print("Antes de ordenar los elementos del array son: ")
for j in a:
    print(j, end=' ')

bubbleSort(a)
print("\nDespues de ordenar los elementos del array son: ")
for j in range(len(a)):
    print("%d" % a[j], end=" ")