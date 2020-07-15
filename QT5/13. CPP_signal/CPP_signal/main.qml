import QtQuick 2.14
import QtQuick.Window 2.14

Window {
    visible: true
    width: 640
    height: 480
    title: qsTr("Hello World")

    Component.onCompleted: {
        console.log("Window created.")

        // SignalItem의 시그널을 Window에 정의한 슬롯에 연결
        mySignalItem.signalItemCreated.connect(signalItemCreatedHandler)
    }

    function signalItemCreatedHandler()
    {
        console.log("SignalItem created")
    }

    SignalItem{
        id : mySignalItem
    }
}
