<<<<<<< HEAD
#ifndef WIDGET_H
#define WIDGET_H

#include <QWidget>
#include "person.h"

namespace Ui {
class Widget;
}

class Widget : public QWidget
{
    Q_OBJECT

public:
    explicit Widget(QWidget *parent = nullptr);
    ~Widget();

public slots:
    void buttonPressed();
    void nameChanged(const QString &n);

private:
    Ui::Widget *ui;

    Person *goodman;

};

#endif // WIDGET_H
=======
#ifndef WIDGET_H
#define WIDGET_H

#include <QWidget>
#include "person.h"

namespace Ui {
class Widget;
}

class Widget : public QWidget
{
    Q_OBJECT

public:
    explicit Widget(QWidget *parent = nullptr);
    ~Widget();

public slots:
    void buttonPressed();
    void nameChanged(const QString &n);

private:
    Ui::Widget *ui;

    Person *goodman;

};

#endif // WIDGET_H
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
