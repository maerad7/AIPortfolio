#include <future>
#include <iostream>
#include <string>
#include <thread>

using std::string;

void worker(std::promise<string>* p){

    p->set_value("some data");
}

int main(){
    std::promise<string> p;

    // 미래에 스트링 데이터를 돌려줌
    std::future<string> data = p.get_future();

    std::thread t(worker,&p);
    // wait 안해도 됨
    data.wait();
    // get 두번 안됨
    std::cout << "받은 데이터 :" << data.get() << std::endl;

    t.join();
}