#include <iostream>

using namespace std;

struct Process {
    int id;
    int burstTime;
    Process* next;

    Process(int id, int burstTime) {
        this->id = id;
        this->burstTime = burstTime;
        this->next = nullptr;
    }
};

class RoundRobinScheduler {
private:
    Process* tail;

public:
    RoundRobinScheduler() {
        tail = nullptr;
    }

    void addProcess(int id, int burstTime) {
        Process*newNode = new Process(id, burstTime);
        if(tail == nullptr){
            tail = newNode;
            tail->next = tail;
        }else{
            newNode->next = tail->next;
            tail->next =newNode;
            tail = newNode;
        }
    }

    void simulate(int quantum) {
        if (tail == nullptr) return;

        cout << "Quantum " << quantum << " ms. Procesos en lista circular con tiempo restante de ráfaga.\n";

        Process* current = tail->next;
        Process* prev = tail;

        while (tail != nullptr) {
            cout << "P" << current->id << " (" << current->burstTime << "ms)";

            if (current->burstTime > quantum) {
                current->burstTime -= quantum;
                cout << " -> Resta " << current->burstTime << "ms\n";
                prev = current;
                current = current->next;
            } else {
                cout << " -> Finalizado\n";
                if (current == tail && current->next == tail) {
                    delete current;
                    tail = nullptr;
                    break;
                }else{
                    prev->next=current->next;
                    if(current == tail){
                        tail = prev;
                    }
                    Process*temp= current;
                    current = current->next;
                    delete temp;
                }
            }
        }
    }
};

int main(){
    RoundRobinScheduler scheduler;
    scheduler.addProcess(1, 5);
    scheduler.addProcess(2, 3);
    scheduler.addProcess(3, 8);

    scheduler.simulate(2);
    return 0;
}
