import QtQuick 2.14
import QtQuick.Window 2.14
import QtQuick.Controls 2.5


Window {
    visible: true
    width: 640
    height: 480
    title: qsTr("Hello World")

    ListModel{
        id: mymodel
    }

    Text {
        id: count
        anchors.horizontalCenter: parent.horizontalCenter
        anchors.top: parent.top

        text: qsTr("count: " + mymodel.count)
        font.pixelSize: 25
    }

    Row{
        anchors.horizontalCenter: parent.horizontalCenter
        height: parent.height

        spacing: 20

        Button{
            anchors.verticalCenter: parent.verticalCenter
            text: "append"
            onClicked:
                // Math.random() 는 0과 1 사이의 난수를 반환하고,
                // Math.ceil()는 소수점 이하를 올려 정수로 만든다.
                // 모델에 아이템을 추가한다.
                mymodel.append({'number': Math.ceil(Math.random() * 10)})
        }

        ListView{
            width: 350
            height: 400
            anchors.verticalCenter: parent.verticalCenter
            spacing: 10
            clip: true // ListView 영역을 벋어난 부분을 자른다.

            model: mymodel

            delegate:
                Rectangle {
                width: parent.width
                height: 50
                color: "white"
                border.width: 1

                Text {
                    anchors.centerIn: parent
                    text: qsTr("number: " + number) // 모델 아이템의 'number'
                    font.pixelSize: 20
                }

                Button{
                    anchors.right: parent.right
                    anchors.rightMargin: 15
                    anchors.verticalCenter: parent.verticalCenter

                    text: "remove"
                    onClicked:
                        // 클릭한 아이템을 모델에서 삭제
                        mymodel.remove(index)

                }
            }
        }
    }
}
