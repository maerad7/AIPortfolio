<<<<<<< HEAD
#include "counter.h"
#include <QDebug>

Counter::Counter(QString mStr)
{
    mString = mStr;
    mValue = 0;
}

void Counter::setValue(int mValue)
{
    mValue = mValue;

    qDebug() << mString << ", mValue : " << mValue;
    //qDebug() << "mValue : " << mValue;
}
=======
#include "counter.h"
#include <QDebug>

Counter::Counter(QString mStr)
{
    mString = mStr;
    mValue = 0;
}

void Counter::setValue(int mValue)
{
    mValue = mValue;

    qDebug() << mString << ", mValue : " << mValue;
    //qDebug() << "mValue : " << mValue;
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
