<<<<<<< HEAD
QT       -= gui

TARGET = MyUtil
TEMPLATE = lib

DEFINES += MYUTIL_LIBRARY

SOURCES += myutil.cpp

HEADERS += myutil.h\
        myutil_global.h

unix {
    target.path = /usr/lib
    INSTALLS += target
}
=======
QT       -= gui

TARGET = MyUtil
TEMPLATE = lib

DEFINES += MYUTIL_LIBRARY

SOURCES += myutil.cpp

HEADERS += myutil.h\
        myutil_global.h

unix {
    target.path = /usr/lib
    INSTALLS += target
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
