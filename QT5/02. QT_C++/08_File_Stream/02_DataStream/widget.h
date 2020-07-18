<<<<<<< HEAD
#ifndef WIDGET_H
#define WIDGET_H

#include <QWidget>
#include <QFile>

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
    Ui::Widget *ui;
    QFile *mFile;

private slots:
    void slotPbtFileSave();
    void slotPbtFileRead();
};

#endif // WIDGET_H
=======
#ifndef WIDGET_H
#define WIDGET_H

#include <QWidget>
#include <QFile>

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
    Ui::Widget *ui;
    QFile *mFile;

private slots:
    void slotPbtFileSave();
    void slotPbtFileRead();
};

#endif // WIDGET_H
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
