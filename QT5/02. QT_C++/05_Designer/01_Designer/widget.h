<<<<<<< HEAD
#ifndef WIDGET_H
#define WIDGET_H

#include <QWidget>

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
    Ui::Widget *ui; // 윈도우상에 배치한 위젯을 접근하기 위한 오브젝트

public slots:
    void slider1_valueChanged(int value);
    void slider2_valueChanged(int value);
    void slider3_valueChanged(int value);
};

#endif // WIDGET_H
=======
#ifndef WIDGET_H
#define WIDGET_H

#include <QWidget>

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
    Ui::Widget *ui; // 윈도우상에 배치한 위젯을 접근하기 위한 오브젝트

public slots:
    void slider1_valueChanged(int value);
    void slider2_valueChanged(int value);
    void slider3_valueChanged(int value);
};

#endif // WIDGET_H
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
