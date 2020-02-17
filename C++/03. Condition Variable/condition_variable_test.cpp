#include <chrono>
#include <iostream>
#include <mutex>
#include <queue>
#include <string>
#include <thread>
#include <vector>
#include <condition_variable>

void producer(std::queue<std::string>* downloaded_pages, std::mutex* m,int index, std::condition_variable* cv){
    for (int i = 0; i<5; i++){
        std::this_thread::sleep_for(std::chrono::microseconds(100*index));
        std::string content = "웹사이트 : " + std::to_string(i) + " from thread(" + std::to_string(index) + ")\n";

        m->lock();
        downloaded_pages->push(content);
        m->unlock();

        cv->notify_one();
    }
}


void consumer(std::queue<std::string>* download_pages, std::mutex* m, int* num_processed,std::condition_variable* cv){
    while(*num_processed < 25){
        std::unique_lock<std::mutex> lk(*m);

        cv->wait(
            lk,[&] {return !download_pages->empty()||*num_processed ==25; }
        );

        if (*num_processed ==25){
            lk.unlock();
            return;
        }

        std::string content = download_pages->front();
        download_pages->pop();

        (*num_processed)++;
        lk.unlock();

        std::cout << content;
        std::this_thread::sleep_for(std::chrono::microseconds(80));
    }
}


int main(){
    std::queue<std::string> downloaded_pages;
    std::mutex m;
    std::condition_variable cv;

    std::vector<std::thread> producers;
    for(int i=0; i<5; i++){
        producers.push_back(
            std::thread(producer,&downloaded_pages,&m,i+1,&cv));
        
    }

    int num_processed = 0;
    std::vector<std::thread> consumers;
    for(int i=0; i<3;i++){
        consumers.push_back(
            std::thread(consumer,&downloaded_pages,&m,&num_processed,&cv)
        );
    }

    for (int i=0; i<5 ; i++){
        producers[i].join();
    }

    cv.notify_all();

    for(int i= 0; i<3; i++){
        consumers[i].join();
    }
}