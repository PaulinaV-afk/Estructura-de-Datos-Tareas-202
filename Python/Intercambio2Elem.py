# Función para intercambiar dos elementos en el arreglo
def swap(a, j, k):  # intercambia los elementos
    a[j], a[k] = a[k], a[j]  # intercambia los elementos
# Función para particionar el arreglo alrededor de un pivote
def partition(a, l, h):
    pivot = a[h]
    i = l - 1
    for j in range(l, h):
        if a[j] <= pivot:
            i += 1
            swap(a, i, j)
    swap(a, i + 1, h)
    return i + 1

# Implementación de la función QuickSort
def qckSort(a, l, h):  # función principal de QuickSort
    if l < h:  # si el índice izquierdo es menor que el derecho
        # pi es el índice de partición, regresa el índice del pivote
        pi = partition(a, l, h)  # particiona el arreglo
        # llamadas recursivas para los elementos menores
        # y mayores o iguales a los elementos
        qckSort(a, l, pi - 1)  # llamada recursiva para los elementos menores que el pivote
        qckSort(a, pi + 1, h)  # llamada recursiva para los elementos mayores o iguales que el pivote
        
# Código para probar la implementación de QuickSort
if __name__ == "__main__":  # punto de entrada del programa
    a = [10, 7, 8, 9, 1, 5]  # arreglo desordenado
    size = len(a)  # tamaño del arreglo
    print("El arreglo antes de ordenarlo: ")
    for v in a:  # imprime el arreglo
        print(v, end=" ")
    print()  # salto de línea
    qckSort(a, 0, size - 1)
    print("El arreglo después de ordenarlo: ")
    for v in a:  # imprime el arreglo ordenado
        print(v, end=" ")