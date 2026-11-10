class Node{
    constructor(data){
        this.data = data;
        this.prev = null;
        this.next = null;
    }
}

class ListaEnlazadaCircular{
    constructor(){
        this.tail = null;
    }

    append(data){
        let newNode = new Node(data);
        if(this.tail === null){
            this.tail = newNode;
            newNode.next = newNode;
            newNode.prev = newNode;   
        }else{
            let head = this.tail.next;
            this.tail.next = newNode;
            newNode.prev = this.tail;
            newNode.next = head;
            head.prev =newNode;
            this.tail = newNode;
        }
    }

    toStringList(){
        if(this.tail === null)return "";
        let head = this.tail.next;
        let current = head;
        let elements = []
        do{
            elements.push(current.data);
            current = current.next;
        }while(current!=head);
        return elements.join("  ⇄ ");
    }
}

function mezclarDosListasEnlazadasCircularesDobles(list1, list2){
    if(list1.tail === null) return list2;
    if(list2.tal === null)return list1;

    let h1 = list1.tail.next;
    let t1 = list1.tail;
    t1.next = null;
    h1.prev = null;
    
    let h2 = list2.tail.next;
    let t2 = list2.tail;
    t2.next = null;
    h2.prev = null;

    let dummyHead = new Node(0);
    let tail = dummyHead;

    let curr1 = h1;
    let curr2 = h2;

   while( curr1 !== null&& curr2!== null){
        if(curr1.data <= curr2.data){
         tail.next = curr1;
         curr1.prev = tail;
         curr1 = curr1.next;
        }else{
         tail.next = curr2;
         curr2.prev = tail;
         curr2 =curr2.next;
        }
        tail = tail.next;
    }
    if(curr1 !== null){
        tail.next = curr1;
        curr1.prev = tail;
        tail = t1;
    }else{
        tail.next = curr2;
        curr2.prev = tail;
        tail = t2;
    }

    let newHead = dummyHead.next;
    newHead.prev = tail;
    tail.next = newHead;

    let listaMezclada = new ListaEnlazadaCircular();
    listaMezclada.tail = tail;
    return listaMezclada;

}

let list1 = new ListaEnlazadaCircular();
list1.append(1);
list1.append(4);
list1.append(7);

let list2 = new ListaEnlazadaCircular();
list2.append(2);
list2.append(3);
list2.append(8);

console.log(`Lista 1 (${list1.toStringList()}) y Lista 2 (${list2.toStringList()}) →`);

let merged = mezclarDosListasEnlazadasCircularesDobles(list1, list2);
console.log(merged.toStringList());