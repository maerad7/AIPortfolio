<<<<<<< HEAD
#ifndef WIDGET_H
#define WIDGET_H

#include <QWidget>
#include "myutil.h"

namespace Ui {
class Widget;
}

class Widget : public QWidget
{
    Q_OBJECT

public:
    explicit Widget(QWidget *parent = nullptr);
    ~Widget();

private:
    MyUtil *myUtil;

    Ui::Widget *ui;

private slots:
    void slotBtnClick();

};

#endif // WIDGET_H
=======
#ifndef WIDGET_H
#define WIDGET_H

#include <QWidget>
#include "myutil.h"

namespace Ui {
class Widget;
}

class Widget : public QWidget
{
    Q_OBJECT

public:
    explicit Widget(QWidget *parent = nullptr);
    ~Widget();

private:
    MyUtil *myUtil;

    Ui::Widget *ui;

private slots:
    void slotBtnClick();

};

#endif // WIDGET_H
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
