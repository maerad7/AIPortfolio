<<<<<<< HEAD
QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = AppWithLibrary
TEMPLATE = app

SOURCES += main.cpp\
        widget.cpp

HEADERS  += widget.h

FORMS    += widget.ui

LIBS += -L$$PWD/../../build-AppWithLibrary-Desktop_Qt_5_12_2_MinGW_32_bit-Debug/MyUtil/debug -lMyUtil

INCLUDEPATH += $$PWD/../MyUtil
DEPENDPATH += $$PWD/../MyUtil
=======
QT       += core gui

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = AppWithLibrary
TEMPLATE = app

SOURCES += main.cpp\
        widget.cpp

HEADERS  += widget.h

FORMS    += widget.ui

LIBS += -L$$PWD/../../build-AppWithLibrary-Desktop_Qt_5_12_2_MinGW_32_bit-Debug/MyUtil/debug -lMyUtil

INCLUDEPATH += $$PWD/../MyUtil
DEPENDPATH += $$PWD/../MyUtil
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7