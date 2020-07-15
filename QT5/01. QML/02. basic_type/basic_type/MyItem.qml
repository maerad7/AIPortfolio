import QtQuick 2.0
import QtQml 2.0

QtObject{
    // Qt.platform을 이용하면 현재 운영체제도 알 수있다.
    property string platform: Qt.platform.os

    // Qt 5.10 부터 QML에서 enum을 선언하는 것이 가능하다.
    enum MyEnum {
        First = 10,
        Second
    }
}
