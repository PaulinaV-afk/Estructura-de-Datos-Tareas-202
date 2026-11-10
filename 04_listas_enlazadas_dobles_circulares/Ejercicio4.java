
class Node {
    char data;
    Node prev, next;

    public Node(char data) {
        this.data = data;
        this.prev = null;
        this.next = null;
    }
}

class DoublyPalindromeChecker {
    Node head;
    Node tail;

    public void append(char data) {
        Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
            tail = newNode;
        }else{
            tail.next = newNode;
            newNode.prev =tail;
            tail = newNode;
        }
    }

    public boolean isPalindrome(){
        if(head == null|head == tail){
            return true;
        }

        Node left = head;
        Node right = tail;
        while(left != right&&left.prev != right){
            if(left.data != right.data){
                return false;
            }
            left =left.next;
            right = right.prev;
        }
        return true;
    }

    public void printResult(){
        Node temp = head;
        StringBuilder sb = new StringBuilder();
        while (temp != null){
            sb.append(temp.data);
            if(temp.next!=null){
                sb.append(" ⇄ ");
            }
            temp = temp.next;
        }
          
        boolean result = isPalindrome();
        if(result){
            sb.append(" es palindromo (verdadero).");
        }else{
            sb.append(" no es palindromo (falso).");
        }
        System.out.println(sb.toString());
    }
 }

 public class Ejercicio4{
    public static void main(String[] args) {
        
        DoublyPalindromeChecker list1 = new DoublyPalindromeChecker();
        char[] word1 = {'R', 'A', 'D', 'A', 'R'};
        for (char c : word1) list1.append(c);
        list1.printResult();

        // Prueba 2: HOLA
                DoublyPalindromeChecker list2 = new DoublyPalindromeChecker();
        char[] word2 = {'H', 'O', 'L', 'A'};
        for (char c : word2) list2.append(c);
        list2.printResult();
    }
}
