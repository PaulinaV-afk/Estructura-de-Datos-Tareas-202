class Node {
    constructor(id) {
        this.id = id;
        this.next = null;
    }
}

class JosephusProblem {
    constructor() {
        this.tail = null;
    }

    // Inicializar la lista circular con N personas (1 a N)
    initialize(n) {
        if (n <= 0) return;

        for (let i = 1; i <= n; i++) {
            let newNode = new Node(i);
            if(this.tail ==  null){
                this.tail = newNode;
                this.tail.next = this.tail;
            }else{
                newNode.next = this.tail.next;
                this.tail.next = newNode;
                this.tail = newNode;
            }

        }
    }
    solve(k){
     if(this.tail === null)return null;
     let n = this.tail.next.id === 1 ? this.tail.next :null;
     //contar nodos
     let count = 0;
     let tempCheck = this.tail;
     do{
        count++;
        tempCheck = tempCheck.next;
     }while(tempCheck !== this.tail);


        console.log(`N= ${count} personas (1 a ${count}), paso K = ${k}.)`);
        
        let eliminations = [];
        let current = this.tail.next; // Comienza en la persona 1 (head)
        let prev = this.tail;          // Predecesor para eliminar

        // El ciclo continúa hasta que solo quede un nodo apuntando a sí mismo
        while (current.next !== current) {
            // Avanzar K-1 pasos
            for (let i = 1; i < k; i++) {
                prev = current;
                current = current.next;
            }

            // Registrar la eliminación
            eliminations.push(current.id);

            // Desvincular el nodo actual
            prev.next = current.next;
            if (current === this.tail) {
                this.tail = prev;
            }

            let temp = current;
            current = current.next; 
            
            temp = null; 
        }

        console.log(`Eliminaciones: ${eliminations.join(", ")}.`);
        console.log(`Superviviente: ${current.id}.`);

        this.tail = null;
        return current; 
    }
}

const game = new JosephusProblem();
game.initialize(5);
let survivorNode = game.solve(2);
    