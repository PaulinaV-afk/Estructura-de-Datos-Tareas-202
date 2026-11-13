#include <iostream>
using namespace std;

struct Nodo{
    int dato;
    Nodo*siguiente;
};

class PilaLista{
    private:
       Nodo*top;

    public:
      PilaLista(): top(nullptr){}

      //destruct:libera la memoria rest de la pila
      ~PilaLista(){
        while(!isEmpty()){
            pop();
        }
    }

    //push
    void push(int item){
        Nodo*nuevoNodo = new Nodo;
        nuevoNodo->dato = item;
        nuevoNodo->siguiente = top;
        top = nuevoNodo;
    }

    //pop
    int pop(){
        if(isEmpty()){
            cout << "Error: Stack Underflow (pila vacia).\n";
            return -1;
        }
        Nodo*temp = top;
        int item = temp->dato;
        top = top->siguiente;
        delete temp;//lib de la memoria
        return item;
    }

    //peek
    int peek(){
        if(isEmpty()){
            cout << "La pila esta vacia. \n";
            return -1;
        }
        return top->dato;
    }

    bool isEmpty(){
        return top == nullptr;
    }

    //recorrer todos los nodos hasta la cima hasta la base
    void display(){
        Nodo*actual = top;
        cout<<"Pila pila (cima a base): ";
        while(actual != nullptr){
            cout<<actual->dato<<" ";
            actual = actual->siguiente;
        }
        cout<<"\n";
    }
};

int main(){
    PilaLista miPila;

    miPila.push(10);
    miPila.push(20);
    miPila.push(30);

    cout << "Elemento Superior: "<<miPila.peek()<< "\n";
    cout << "Extrae elemento: "<<miPila.pop()<< "\n";
    cout << "Elemento Superior: "<<miPila.peek()<< "\n";

    return 0;
}