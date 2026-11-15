class Nodo{
    constructor(dato){
        this.dato = dato;
        this.siguiente = null;
    }
}

class PilaLista{
    constructor(){
        this.top = null;
    }

    push(item){
    const nuevoNodo = new Nodo(item);
    nuevoNodo.siguiente = this.top;
    this.top = nuevoNodo; 
}

   pop(){
       if(this.isEmpty()){
          return -1;
        }

       const datoExtraido = this.top.dato;
       this.top = this.top.siguiente;
       return datoExtraido;
    }

    peek(){
       if(this.isEmpty()){
         return -1;
        }
       return this.top.dato;
    }

    isEmpty(){
        return this.top === null;
    }

    display(){
       let actual = this.top;
       while(actual != null){
          actual = actual.siguiente;
        }
    }
}

const miPila = new PilaLista();
miPila.push(10);
miPila.push(20);
miPila.push(30);

console.log("Elemento Superior: "+ miPila.peek());
console.log("Extraer elemento: "+ miPila.pop());
console.log("Elemento Superior: "+ miPila.peek());
