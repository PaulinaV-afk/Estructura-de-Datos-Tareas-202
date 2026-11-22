#include <iostream>
using namespace std;

struct Nodo{
   int dato;
   Nodo*siguiente;
};

class ColaListas{
    private:
    Nodo*front;
    Nodo*rear;

    public:
    ColaListas(): front(nullptr), rear(nullptr) {}

    ~ColaListas(){
        while(!estaVacia()){
            desencolar();
        }
    }

    void encolar(int item){
        Nodo*nuevo = new Nodo{item, nullptr};
        if(estaVacia()){
            front = rear = nuevo;
        }else{
            rear->siguiente=nuevo;
            rear = nuevo;
        }
    }

    int desencolar(){
        if(estaVacia()){
            return -1;
        }
        Nodo*temp = front;
        int valor = temp->dato;
        front = front->siguiente;
        if(front == nullptr){
            rear = nullptr;
        }
        delete temp;
        return valor;
    }

    void mostrar(){
        Nodo*actual = front;
        while(actual!=nullptr){
            cout << actual->dato << " ";
            actual = actual->siguiente;
        }
        cout << endl;
    }

    bool estaVacia(){
        return front == nullptr;
    }
};

int main(){
    ColaListas c;
    c.encolar(100);
    c.encolar(200);
    c.encolar(300);
    c.mostrar();
    cout << "Desencolado: "<< c.desencolar() << endl;
    c.mostrar();
    return 0;
}