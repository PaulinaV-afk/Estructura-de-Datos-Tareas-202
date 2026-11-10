#include <iostream>
using namespace std;

struct Node{
    int data;
    Node*next;

    Node(int val) : data(val),next(nullptr){}
};

class ListaCircularEnlazada{
    private:
    Node*head;

  public:
  ListaCircularEnlazada(): head(nullptr){}
  
  //Para insertar elementos al final de la lista
  void insert(int val){
    Node*newNode = new Node(val);
    if(head == nullptr){
        head = newNode;
        head->next=head;//el unico nodo apunta asi mismo
    }else{
        Node*current=head;//se avanza para encont al ultimo nodo
        while(current->next!=head){
            current = current->next;
        }
        current->next=newNode;
        newNode->next=head;//se cierra el circulo
    }
  }

  //para recorrer y contar vuelta
  void recorrerYcontar(){
    //checa si la lista esta vacia
    if(head==nullptr){
        cout<<"La lista esta vacia, total de nodos: " << endl;
        return;
    }

    Node*current=head;
    int count = 0; //contador :b

    cout<< "Elementos: ";

    //do while pa almeos una iteracion y det para cuando topa o vuelve a la cabeza(head)
    do{
        cout<< current->data<< " ";
        count++;
        current = current->next;
    }while(current!=head);

    cout<<"| Total de nodos: " << count << "\n";

  }
};
int main(){
    ListaCircularEnlazada lista;
    //Ej 10 -> 20 -> 30
    lista.insert(10);
    lista.insert(20);
    lista.insert(30);

    //ej la funcion d recorrido y conteo
    lista.recorrerYcontar();
    return 0;
}