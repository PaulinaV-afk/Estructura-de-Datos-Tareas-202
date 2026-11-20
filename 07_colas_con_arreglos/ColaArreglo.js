class ColaArreglo{
    constructor(){
        this.MAXSIZE = 5;
        this.queue = new Array(this.MAXSIZE).fill(null);
        this.front = -1;
        this.rear = -1;
    }

    insertar(elemento){
        if(this.rear === this.MAXSIZE -1){
            console.log("OVERFLOW");
            return;
        }
        if(this.front === -1){
            this.front = 0;
        }
        this.rear++;
        this.queue[this.rear] = elemento;
        console.log("Elemento insertado correctamente.");
    }

    eliminar(){
        if(this.front === -1||this.front>this.rear){
            console.log("UNDERFLOW");
            return null;
        }
        const eliminado = this.queue[this.front]
        this.queue[this.front] = null;

        if(this.front === this.rear){
            this.front = -1;
            this.rear = -1;
        }else{
            this.front++;
        }
        return eliminado;
    }

    mostrar(){
        if(this.front === -1||this.front>this.rear){
            return;
        }
        for(let i = this.front; i<= this.rear; i++){
            console.log(this.queue[i]);
        }
    }
}

const c = new ColaArreglo();
c.insertar(10);
c.insertar(20);
c.insertar(30);
c.mostrar();
c.eliminar();
c.mostrar();
