#include <atomic>
#include <iostream>
#include <thread>
#include <vector>

void worker(std::atomic<int>& counter){
    for (int i=0; i<10000; i++){
        counter++;
    }
}

int main(){
    std::atomic<int> counter(0);

    std::vector<std::thread> workers;

    for (int i=0; i<4; i++){
        workers.push_back(std::thread(worker,std::ref(counter)));
    }

    for(int i=0;i<4;i++){
        workers[i].join();
    }
    //트루일때 아토믹 프로그래밍 가능
    std::cout << "is lock free ? : " << counter.is_lock_free() << std::endl;


    std::cout <<"Counter Final : " << counter << std::endl;
}