import QtQuick 2.14
import QtQuick.Window 2.14

Window {
    visible : true
    width: 640
    height: 480
    title: qsTr("Hello World")

    // Completed 시그널은 qml 객체가 인스턴스화 되면 가장 먼저 발생하며 모든 qml에서 사용 할 수 있다.

    Component.onCompleted: {
        console.log("Window created.")
    }

    SignalItem{
        id:mySignalItem
//        Component.onCompleted: {
//            console.log("name created")
//        }
        onSignalItemCreated: {
            console.log(name + " created.")
        }
    }
}
