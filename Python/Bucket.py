def insertion_sort(bukt): #Funcion de ordenamiento por insercion
    for j in range(1, len(bukt)):              #Iterar desde el segundo elemento hasta el final del arreglo
        val = bukt[j]                          #Elemento actual a insertar
        k = j - 1                              #Indice del elemento anterior
        while k >= 0 and bukt[k] > val:        #Mover los elementos mayores a la derecha
            bukt[k + 1] = bukt[k]              #Desplazar elemento
            k = k - 1                          #Mover el sig elemento a la izquierda
        bukt[k + 1] = val                      #Insertar el elemento actual en su posición correcta
def bucket_sort(inputArr):                     #Funcion de ordenamiento por cubetas
    s = len(inputArr)                          #Numero de buckets
    bucketArr = [[] for _ in range(s)]         #Crear una lista de buckets vacíos
    for j in inputArr:                         #Iterar sobre cada elemento del arreglo de entrada
        bi = int(s * j)                        #Indice del bucket
        bucketArr[bi].append(j)                #Agregar el elemento al bucket correspondiente
    for bukt in bucketArr:                     #Iterar sobre cada bucket y ordenarlo usando insertion_sort
        insertion_sort(bukt)                   #Ordenar el bucket
    idx = 0                                    #Indice para el arreglo de entrada
    for bukt in bucketArr:                     #Iterar sobre cada bucket
        for j in bukt:                         #Iterar sobre cada elemento del bucket
            inputArr[idx] = j                  #Colocar elemento ordenado en el arreglo de entrada
            idx += 1                           #Mover al siguiente indice
#Ejemplo de uso
inputArr = [0.77, 0.16, 0.38, 0.25, 0.71, 0.93, 0.22, 0.11, 0.24, 0.67] #Arreglo de entarda
print("Arreglo antes de ser ordenado: ")#Imprime el arreglo antes de ser ordenado
print(" ".join(str(j) for j in inputArr))
bucket_sort(inputArr)
print("Arreglo después de ser ordenado: ")#Imprime el arreglo después de ser ordenado
print(" ".join(map(str, inputArr)))
