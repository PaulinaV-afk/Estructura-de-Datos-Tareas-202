# Implementación en Python
def findEle(arr, targetValue):
    for i in range(len(arr)):
        if arr[i] == targetValue:
            return i
    return -1

if __name__ == '__main__':
    inputArr = [12, 34, 10, 6, 40, 89, 98, 57, 19, 69] # arrays de entrada
    targetElement = 40 # elemento objetivo a encontrar
    
    # operación de búsqueda
    idx = findEle(inputArr, targetElement)
    if idx != -1:
        print("El elemento se encuentra en la posición: " + str(idx + 1))
    else:
        print("No se encuentra el elemento.")