<<<<<<< HEAD
#include "widget.h"
#include <QApplication>
#include <QTranslator>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);

    QTranslator translator;
    translator.load(":/widget.qm");
    QApplication::installTranslator(&translator);

    Widget w;
    w.show();

    return a.exec();
}
=======
#include "widget.h"
#include <QApplication>
#include <QTranslator>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);

    QTranslator translator;
    translator.load(":/widget.qm");
    QApplication::installTranslator(&translator);

    Widget w;
    w.show();

    return a.exec();
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
