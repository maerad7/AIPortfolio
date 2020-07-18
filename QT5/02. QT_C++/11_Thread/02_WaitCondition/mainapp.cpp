<<<<<<< HEAD
#include "mainapp.h"
#include <QDebug>

static QMutex mutex;
static QWaitCondition incNumber;
int numUsed;

//Producer::Producer() { }
void Producer::run()
{
    for(int i = 0 ; i < 10 ; i++)
    {
        mutex.lock();
            incNumber.wait(&mutex);
        mutex.unlock();

        qDebug("numUsed : %d", numUsed);
    }
}

Consumer::Consumer() { }
void Consumer::run()
{
    for(int i = 0 ; i < 10 ; i++)
    {
        mutex.lock();
            incNumber.wait(&mutex);
        mutex.unlock();

        qDebug("numUsed : %d", numUsed);
    }
}

MainApp::MainApp(QObject *parent) : QObject(parent)
{
    qDebug() << Q_FUNC_INFO;

    Producer *producer = new Producer();
    Consumer consumer;
    producer->start();
    consumer.start();
}
=======
#include "mainapp.h"
#include <QDebug>

static QMutex mutex;
static QWaitCondition incNumber;
int numUsed;

//Producer::Producer() { }
void Producer::run()
{
    for(int i = 0 ; i < 10 ; i++)
    {
        mutex.lock();
            incNumber.wait(&mutex);
        mutex.unlock();

        qDebug("numUsed : %d", numUsed);
    }
}

Consumer::Consumer() { }
void Consumer::run()
{
    for(int i = 0 ; i < 10 ; i++)
    {
        mutex.lock();
            incNumber.wait(&mutex);
        mutex.unlock();

        qDebug("numUsed : %d", numUsed);
    }
}

MainApp::MainApp(QObject *parent) : QObject(parent)
{
    qDebug() << Q_FUNC_INFO;

    Producer *producer = new Producer();
    Consumer consumer;
    producer->start();
    consumer.start();
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
