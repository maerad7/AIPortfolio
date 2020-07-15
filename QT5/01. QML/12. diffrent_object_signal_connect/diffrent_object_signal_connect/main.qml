import QtQuick 2.14
import QtQuick.Window 2.14

Window {
    visible: true
    width: 640
    height: 480
    title: qsTr("Hello World")

    Component.onCompleted:{
        console.log("window created")
    }


 //   QML내에서 객체간 시그널 슬롯을 연결하는 일반적인 방법은 Connections 요소를 사용하는 것이다.

  //  대상(객체id)을 설정후 다음과 같이 시그널이 발생할 때 시그널을 처리하는 "on<Signal이름>"핸들러를 작성한다.
    Connections{
        target: mySignalItem
        onSignalItemCreated:{
            console.log("SignalItem created.")
        }
    }

    SignalItem{
        id: mySignalItem
    }


}
