<<<<<<< HEAD
#ifndef COUNTER_H
#define COUNTER_H

#include <QObject>

class Counter : public QObject
{
    Q_OBJECT

public:
    Counter(QString mStr);

private:
    QString mString;
    int mValue;

signals:
    void valueChagned(int mValue);

public slots:
    void setValue(int mValue);
};

#endif // COUNTER_H
=======
#ifndef COUNTER_H
#define COUNTER_H

#include <QObject>

class Counter : public QObject
{
    Q_OBJECT

public:
    Counter(QString mStr);

private:
    QString mString;
    int mValue;

signals:
    void valueChagned(int mValue);

public slots:
    void setValue(int mValue);
};

#endif // COUNTER_H
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
