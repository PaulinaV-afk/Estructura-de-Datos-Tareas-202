# Quick Sort
# Funcion para intercambiar dos elementos del arreglo
def swap(a, i, j):
    a[i], a[j] = a[j], a[i] #esto lo agrege ya q no venia def el swap en el ejemplo de la clase
# Funcion para hacer la particion del arreglo
def partition(a, l ,h):
    #selecciona el elemento pivote
    pvt = a[h]
    #j es el indice de los elementos menores
    #pivote y tambien indica la posicion correcta del pivote hasta el momento
    j = l - 1
    #Recorre a[l..h-1] y mueve todos los elementos menores
    #al lado izq del pivote
    #elementos de l a j son mas pequeños despues de cada iteracion
    for k in range(l, h): #recorre el arrglo
        #si el elemento actual al pivote
        if a[k] < pvt: #compara el lemento actual con el pivote
            j += 1 #incrementa el indice de los elementos mas pequeños
            swap(a, j, k) #intercambia los elementos
    #mover el pivote despues de los elementos mas pequeños
    #devolverlo a su posicion
    swap(a, j + 1, h) #intercambia el pivote con el elemento siguiente al ulrimo elemento mas pequeño
    return j + 1 #devuleve el indice del pivote
