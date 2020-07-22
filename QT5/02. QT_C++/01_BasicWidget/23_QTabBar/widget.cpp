<<<<<<< HEAD
#include "widget.h"

Widget::Widget(QWidget *parent) : QWidget(parent)
{
    QTabBar *tab = new QTabBar(this);

    tab->addTab("Browser");
    tab->addTab("User");
    tab->addTab("Application");

    tab->setShape(QTabBar::RoundedNorth);

    tab->setGeometry(20, 20, 300, 250);

    connect(tab,  SIGNAL(currentChanged(int)),
            this, SLOT(currentTab(int)));
}

void Widget::currentTab(int index)
{
    qDebug("Current Tab : %d", index);
}

Widget::~Widget()
{
    
}
=======
#include "widget.h"

Widget::Widget(QWidget *parent) : QWidget(parent)
{
    QTabBar *tab = new QTabBar(this);

    tab->addTab("Browser");
    tab->addTab("User");
    tab->addTab("Application");

    tab->setShape(QTabBar::RoundedNorth);

    tab->setGeometry(20, 20, 300, 250);

    connect(tab,  SIGNAL(currentChanged(int)),
            this, SLOT(currentTab(int)));
}

void Widget::currentTab(int index)
{
    qDebug("Current Tab : %d", index);
}

Widget::~Widget()
{
    
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
