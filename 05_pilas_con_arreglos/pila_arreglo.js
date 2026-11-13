class PilaArreglo{
    constructor(maxSize = 100){
        this.maxSize = maxSize;
        this.stack = new Array(maxSize);
        this.top = -1;
    }

    push(item){
        if(this.isFull()){
            console.log("Error: Stack Overflow (pila llena).");
            return;
        }
        this.top++;
        this.stack[this.top] = item;
    }

    pop(){
        if(this.isEmpty()){
            console.log("Error: Stack Overflow (pila vacia).");
            return -1;
        } 
        let item = this.stack[this.top];
        this.top--;
        return item;   
    }

    peek(){
        if(this.isEmpty()){
            console.log("La pila esta vacia.")
            return -1;
        }
        return this.stack[this.top];
    }

    isEmpty(){
        return this.top === -1;
    }

    isFull(){
        return this.top === this.maxSize -1;
    }
}

const miPila = new PilaArreglo();
miPila.push(10);
miPila.push(20);
miPila.push(30);

console.log("Elemento Superior: " +miPila.peek());
console.log("Extrae elemento: " +miPila.pop());
console.log("Elemento Superior: " +miPila.peek());