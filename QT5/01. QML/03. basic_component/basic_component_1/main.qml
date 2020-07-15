import QtQuick 2.14
import QtQuick.Window 2.14

Window {
    visible: true
    width: 640
    height: 480
    title: qsTr("Hello World")

    Item{

            id: basicItem
            x: 0
            y: 0
            z: 0

            width: parent.width   // 부모(Window)의 폭을 사용
            height: parent.height // 부모(Window)의 높이를 사용

            visible: true
            opacity: 0.3
            scale: 0.7

            Rectangle{
                width: 200
                height: 100
                anchors.centerIn: parent // 상위 컴포넌트의 중앙애 배치
                color: "black"
                border.width: 1
                border.color: "black"

                Text {
                           id: title             // 이 객체에 id를 부여 (중복되면 안됨)
                           anchors.fill: parent  // 상위 컴포넌트(Rectangle)의 영역을 채운다.
                           text: qsTr("텍스트 컴포넌트")
                           font.pixelSize: 20
                           font.bold: true
                           font.family: "나눔고딕"
                           color: "green"
                           horizontalAlignment: Text.AlignHCenter  // 수평에 대한 중앙 정렬
                           verticalAlignment: Text.AlignVCenter    // 수직에 대한 중앙 정렬
                       }
            }
            // width, height를 설정하지 않으면 이미지의 원본 사이즈로 표시된다.
//            Image{
//                        anchors.verticalCenter: parent.verticalCenter
//                        anchors.horizontalCenter: parent.horizontalCenter
//                        source: "qrc:/makersweb.png"
//            }

    }
}
