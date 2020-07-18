<<<<<<< HEAD
#ifndef MYUTIL_H
#define MYUTIL_H

#include <QObject>
#include "myutil_global.h"

class MYUTILSHARED_EXPORT MyUtil : public QObject
{
    Q_OBJECT
public:
    explicit MyUtil(QObject *parent = nullptr);
    int getSumValue(int a, int b);
};

#endif // MYUTIL_H
=======
#ifndef MYUTIL_H
#define MYUTIL_H

#include <QObject>
#include "myutil_global.h"

class MYUTILSHARED_EXPORT MyUtil : public QObject
{
    Q_OBJECT
public:
    explicit MyUtil(QObject *parent = nullptr);
    int getSumValue(int a, int b);
};

#endif // MYUTIL_H
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
