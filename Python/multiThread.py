#!/usr/bin/env

from threading import Thread
import time

def work(id, start, end, result):
    total = 0 
    for i in range(start,end):
        total += i
    result.append(total)
    return

if __name__=="__main__":
    start_time =time.time()
    START, END = 0 , 10000000
    result= list()
    
    th1 = Thread(target=work,args=(1,START,END//2,result))
    th2 = Thread(target=work,args=(2,END//2,END,result))

    th1.start()
    th2.start()

    th1.join()
    th2.join()


print("Result: %d" ,sum(result))
print("time :", time.time() - start_time)