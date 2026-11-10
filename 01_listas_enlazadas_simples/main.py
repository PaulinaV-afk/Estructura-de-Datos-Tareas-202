#Ignorelo es lo q habia hecho en clase
class Nodo:
    def _init_(self, dato):
        self.dato = dato
        self.siguiente = None

    def traverseAndPrint(head):
        CurrentNode = head
        while CurrentNode :
            print (CurrentNode.dato, end=" ")
            CurrentNode = CurrentNode.siguiente
            
        print("Null")

    def InsertarNodeAPosicion(head, nuevoNodo, posicion):
        if posicion == 1:
         nuevoNodo.siguiente = head
         return nuevoNodo

    CurrentNode = head
    for _ in range(posicion - 2):
        if CurrentNode.siguiente is None:
            break
        CurrentNode = CurrentNode.siguiente
        
    nuevoNodo.siguiente = CurrentNode.siguiente
    CurrentNode.siguiente = nuevoNodo
    return head
    
    node1 = Node(5)
    node2 = Node(15)
    node3 = Node(25)
    
    node1.siguiente = node2
    node2.siguiente = node3
    
    print(" Lista Original : ")
    traverseAndPrint(node1)
    
    nuevoNodo = Node(20)
    node2 = InsertarNodeAPosicion (node2, nuevoNodo, 3)
    
    print(" Despues de la insercion: ")
    traverseAndPrint(node1)
    
    
    