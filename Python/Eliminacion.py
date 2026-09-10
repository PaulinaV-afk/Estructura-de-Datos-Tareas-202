# Programa para eliminar un elementoal principio de un array
inputArr= [11, 21, 31, 41, 51, 61]
print("Antes de la eliminacion el array es: ")
for j in range(len(inputArr)):
    print(inputArr[j], end=" ")
#Eliminando el primer elemento del inputArr[0]
inputArr.pop(0)
print("\nDespuesde la eliminacion, el array es ")
for j in range(len(inputArr)):
    print(inputArr[j], end=" ")