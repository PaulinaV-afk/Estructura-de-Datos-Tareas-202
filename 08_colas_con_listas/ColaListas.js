class Nodo{
    constructor(valor){
        this.valor = valor;
        this.siguiente =  null;
    }
}

class ColaListas{
    constructor(){
        this.front = null;
        this.rear = null;
    }

    encolar(valor){
        const nuevo = new Nodo(valor);
        if(this.front === null){
            this.front =  this.rear = nuevo;
        }else{
            this.rear.siguiente =  nuevo;
            this.rear = nuevo;
        }
    }

    desencolar(){
        if(this.front === null){
            return null;
        }
        const valorExtraido = this.front.valor;
        this.front = this.front.siguiente;
        if(this.front === null){
            this.rear = null;
        }
        return valorExtraido;
    }

    mostar(){
        let actual = this.front;
        const elementos = [];
        while(actual != null){
            elementos.push(actual.valor);
            actual = actual.siguiente;
        }
        console.log(elementos.join(" "));
    }
}

const c = new ColaListas();
c.encolar(100);
c.encolar(200);
c.encolar(300);
c.mostar();
console.log("Desencolado: "+c.desencolar());
c.mostar();
