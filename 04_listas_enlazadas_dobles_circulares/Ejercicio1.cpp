#include <iostream>
#include <string>

using namespace std;

// Definición del Nodo para Lista Doblemente Enlazada Circular
class Node {
public:
    int data;
    Node* next;
    Node* prev;

    Node(int data) {
        this->data = data;
        this->next = nullptr;
        this->prev = nullptr;
    }
};

// Clase Carrusel
class Carousel {
private:
    Node* current; // Puntero que mantiene la posición actual en el carrusel

public:
    Carousel() {
        this->current = nullptr;
    }

    // Insertar un nuevo elemento manteniendo la circularidad doble
    void insertar(int data) {
        Node* newNode = new Node(data);
        if (current == nullptr) {
            current = newNode;
            current->next = current;
            current->prev = current;
        } else {
            Node* tail = current->prev; // El anterior al actual es el último nodo

            // Enlazar el nuevo nodo entre tail y current
            tail->next = newNode;
            newNode->prev = tail;
            newNode->next = current;
            current->prev = newNode;
        }
    }
    // Navegar hacia adelante (sentido horario)
    void avanzar() {
        if (current != nullptr) {
            current = current->next;
        }
    }

    // Navegar hacia atrás (sentido antihorario)
    void retroceder() {
        if (current != nullptr) {
            current = current->prev;
        }
    }

    // Obtener el valor del elemento actual
    int obtenerActual() {
        if (current != nullptr) {
            return current->data;
        }
        return -1;
    }

    // Mostrar el carrusel simulando la navegación continua por N pasos
    void navegar(int pasos) {
        if (current == nullptr) {
            cout << "Carrusel vacio." << endl;
            return;
        }

        Node* temp = current;
        for (int i = 0; i < pasos; i++) {
            cout << "[Elemento " << temp->data << "] ⇄ ";
            temp = temp->next;
        }
        cout << "(vuelve al inicio)\n";
    }
};

int main() {
    // Forzar consola en UTF-8 si es necesario para las flechas ⇄
    Carousel carrusel;

    // Agregamos elementos al carrusel
    carrusel.insertar(1);
    carrusel.insertar(2);
    carrusel.insertar(3);

    cout << "--- Navegacion continua (5 pasos) ---" << endl;
    carrusel.navegar(5);

    cout << "\n--- Probando metodos de movimiento ---" << endl;
    cout << "Actual: " << carrusel.obtenerActual() << endl; // Debería ser 1

    cout << "Avanzando..." << endl;
    carrusel.avanzar();
    cout << "Actual: " << carrusel.obtenerActual() << endl; // Debería ser 2

    cout << "Retrocediendo dos veces..." << endl;
    carrusel.retroceder();
    carrusel.retroceder();
    cout << "Actual: " << carrusel.obtenerActual() << endl; // Debería volver a dar la vuelta hasta el 3
    
    return 0;
}