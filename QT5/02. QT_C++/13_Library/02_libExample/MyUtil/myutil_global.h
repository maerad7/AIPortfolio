<<<<<<< HEAD
#ifndef MYUTIL_GLOBAL_H
#define MYUTIL_GLOBAL_H

#include <QtCore/qglobal.h>

#if defined(MYUTIL_LIBRARY)
#  define MYUTILSHARED_EXPORT Q_DECL_EXPORT
#else
#  define MYUTILSHARED_EXPORT Q_DECL_IMPORT
#endif

#endif // MYUTIL_GLOBAL_H
=======
#ifndef MYUTIL_GLOBAL_H
#define MYUTIL_GLOBAL_H

#include <QtCore/qglobal.h>

#if defined(MYUTIL_LIBRARY)
#  define MYUTILSHARED_EXPORT Q_DECL_EXPORT
#else
#  define MYUTILSHARED_EXPORT Q_DECL_IMPORT
#endif

#endif // MYUTIL_GLOBAL_H
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
