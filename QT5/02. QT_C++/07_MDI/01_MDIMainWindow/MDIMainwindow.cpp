<<<<<<< HEAD
#include "MDIMainwindow.h"
#include <QMdiArea>
#include <QMdiSubWindow>
#include <QPushButton>

MDIMainWindow::MDIMainWindow(QWidget *parent)
    : QMainWindow(parent)
{
    setWindowTitle(QString::fromUtf8("My MDI"));

    QMdiArea* area = new QMdiArea();
    area->setSizePolicy(QSizePolicy::Expanding,QSizePolicy::Expanding);

    // MdiSubWindow 생성
    QMdiSubWindow* subWindow1 = new QMdiSubWindow();
    subWindow1->resize(300, 200);

    QPushButton *btn = new QPushButton(QString("Button"));
    subWindow1->setWidget(btn);


    QMdiSubWindow* subWindow2 = new QMdiSubWindow();
    subWindow2->resize(300, 200);

    // MDIMainWindows에 서브 윈도우 추가
    area->addSubWindow(subWindow1);
    area->addSubWindow(subWindow2);

    setCentralWidget(area);
}

=======
#include "MDIMainwindow.h"
#include <QMdiArea>
#include <QMdiSubWindow>
#include <QPushButton>

MDIMainWindow::MDIMainWindow(QWidget *parent)
    : QMainWindow(parent)
{
    setWindowTitle(QString::fromUtf8("My MDI"));

    QMdiArea* area = new QMdiArea();
    area->setSizePolicy(QSizePolicy::Expanding,QSizePolicy::Expanding);

    // MdiSubWindow 생성
    QMdiSubWindow* subWindow1 = new QMdiSubWindow();
    subWindow1->resize(300, 200);

    QPushButton *btn = new QPushButton(QString("Button"));
    subWindow1->setWidget(btn);


    QMdiSubWindow* subWindow2 = new QMdiSubWindow();
    subWindow2->resize(300, 200);

    // MDIMainWindows에 서브 윈도우 추가
    area->addSubWindow(subWindow1);
    area->addSubWindow(subWindow2);

    setCentralWidget(area);
}

>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
