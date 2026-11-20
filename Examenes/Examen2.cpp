#include <iostream>
using namespace std;

string operacion;

int main(){


  if(!(cin>>operacion)){
    return 0;
  }

  stack<int>pila;

  for( char c : operacion){

    if(c >= 0 | c <= 9){
        int num = c - '0';
        pila.push(num);
    }


    else if( c == '+'| c == '-'| c == '*'){
        int der = pila.pop();
        pila.pop();

        int izq = pila.pop();
        pila.pop();

        int resul = 0;

        switch(c){
            case '+':
            resul = der + izq;
            break;

            case '-':
            resul = der - izq;
            break;

            case '*':
            resul = der * izq;
            break;

        }
        pila.push(resul);
    }

  if(!(pila.empty())){
    cout>>pila.pop() << "\n"
  }

  }

}
