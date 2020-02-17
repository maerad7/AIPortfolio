#include <future>
#include <iostream>
#include <thread>
#include <vector>

int sum(const std::vector<int>& v,int start, int end){
    int total = 0;
    for (int i= start; i< end; ++i){
        total += v[i];
    }
    return total;
}

int parallel_sum(const std::vector<int>& v){
   
    // lower_half_future 는 1 ~ 500 까지 비동기적으로 더함
    // 참고로 람다 함수를 사용하면 좀 더 깔끔하게 표현할 수 도 있다.
    // --> std::async([&v]() { return sum(v, 0, v.size() / 2); });
    // std::launch::async -> 바로 쓰레드를 생성해서 인자로 전달된 함수를 실행
    // std::launch::deferred -> future의 get 함수가 호출되었을 때 쓰레드를 생성해서 실행한다.
    
    std::future<int> lower_half_future= std::async(std::launch::async,sum,std::cref(v),0,v.size()/2);

    int upper_half = sum(v,v.size()/2,v.size());

    return lower_half_future.get() + upper_half;
}

int main(){
    std::vector<int> v;
    v.reserve(1000);

    for (int i=0; i<1000; ++i){
        v.push_back(i+1);
    }

    std::cout<< "1부터 1000까지의 합 : " << parallel_sum(v) << std::endl;
}