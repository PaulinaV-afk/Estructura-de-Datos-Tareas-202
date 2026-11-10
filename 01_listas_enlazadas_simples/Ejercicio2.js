
class Nodo {
    constructor(dato) {
        this.dato = dato;
        this.siguiente = null;
    }
}


class ListaEnlazada {
    constructor() {
        this.cabeza = null;
    }

    // para insertar un nodo en una posición específica
    insertarEnPosicion(posicion, valor) {
        if (posicion < 0) {
            console.log("Error: Posición inválida (negativa).");
            return;
        }

        const nuevoNodo = new Nodo(valor);

        // Caso 1
        if (posicion === 0) {
            nuevoNodo.siguiente = this.cabeza;
            this.cabeza = nuevoNodo;
            return;
        }

        // Recorrer hasta el nodo anterior a la posición deseada
        let actual = this.cabeza;
        let indiceActual = 0;

        while (actual !== null && indiceActual < posicion - 1) {
            actual = actual.siguiente;
            indiceActual++;
        }

        // Si 'actual' es nulo, la posición está fuera de rango
        if (actual === null) {
            console.log(`Error: Posición ${posicion} fuera de rango.`);
            return;
        }

        // Caso 2 y 3
        nuevoNodo.siguiente = actual.siguiente;
        actual.siguiente = nuevoNodo;
    }

    //para mostrar la lista en consola
    mostrar() {
        let actual = this.cabeza;
        let resultado = "";
        while (actual !== null) {
            resultado += actual.dato;
            if (actual.siguiente !== null) {
                resultado += " → ";
            }
            actual = actual.siguiente;
        }
        console.log(resultado);
    }

    
    agregarAlFinal(valor) {
        const nuevoNodo = new Nodo(valor);
        if (this.cabeza === null) {
            this.cabeza = nuevoNodo;
            return;
        }
        let actual = this.cabeza;
        while (actual.siguiente !== null) {
            actual = actual.siguiente;
        }
        actual.siguiente = nuevoNodo;
    }
}

console.log("--- Prueba 1 ---");
const lista1 = new ListaEnlazada();
lista1.agregarAlFinal(10);
lista1.agregarAlFinal(20);
lista1.agregarAlFinal(30);
console.log("Inicial: 10 → 20 → 30 | Posicion: 0 | Valor: 5");
process.stdout.write("Resultado: ");
lista1.insertarEnPosicion(0, 5);
lista1.mostrar(); 

console.log("\n--- Prueba 2---");
const lista2 = new ListaEnlazada();
lista2.agregarAlFinal(10);
lista2.agregarAlFinal(20);
lista2.agregarAlFinal(30);
console.log("Inicial: 10 → 20 → 30 | Posicion: 2 | Valor: 15");
process.stdout.write("Resultado: ");
lista2.insertarEnPosicion(2, 15);
lista2.mostrar(); 

console.log("\n--- Prueba 3 ---");
const lista3 = new ListaEnlazada();
lista3.agregarAlFinal(10);
lista3.agregarAlFinal(20);
lista3.agregarAlFinal(30);
console.log("Inicial: 10 → 20 → 30 | Posicion: 3 | Valor: 40");
process.stdout.write("Resultado: ");
lista3.insertarEnPosicion(3, 40);
lista3.mostrar(); 