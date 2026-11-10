#include <iostream>

using namespace std;

// 1. Estructura o clase Nodo
class Nodo {
public:
    int dato;
    Nodo* siguiente;

    // Constructor para inicializar el nodo
    Nodo(int valor) {
        dato = valor;
        siguiente = nullptr;
    }
};

// Clase para administrar la Lista Enlazada
class ListaEnlazada {
private:
    Nodo* cabeza;

public:
    ListaEnlazada() {
        cabeza = nullptr;
    }

    // Insertar elementos al final de la lista
    void insertarAlFinal(int valor) {
        Nodo* nuevoNodo = new Nodo(valor);
        
        // Si la lista esta vacía, el nuevo nodo es la cabeza
        if (cabeza == nullptr) {
            cabeza = nuevoNodo;
        } else {
            // Si no esta vacía, recorremos hasta el último nodo
            Nodo* actual = cabeza;
            while (actual->siguiente != nullptr) {
                actual = actual->siguiente;
            }
            // Enlazamos el nuevo nodo al final
            actual->siguiente = nuevoNodo;
        }
    }

    // Funcion para recorrer e imprimir d imprimir todos los elementos
    void mostrar() {
        Nodo* actual = cabeza;
        while (actual != nullptr) {
            cout << actual->dato << " ";
            actual = actual->siguiente;
        }
        cout << endl;
    }
};

int main() {
    ListaEnlazada lista;

    // Insercion de los valores
    lista.insertarAlFinal(10);
    lista.insertarAlFinal(20);
    lista.insertarAlFinal(30);
    lista.insertarAlFinal(40);

    cout << "Salida: ";
    lista.mostrar();

    return 0;
}