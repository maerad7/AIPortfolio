import QtQuick 2.14
import QtQuick.Window 2.14

Window {
    id: idWindow
    visible: true
    width: 100
    height: 300
    Rectangle{
        id : content
        anchors.fill: parent
        color: "#F0F0F0"

        Column{
            id:list
            anchors.horizontalCenter: parent.horizontalCenter
            anchors.verticalCenter: parent.verticalCenter

            spacing:10

            Repeater{
                model: 5

                Rectangle{
                    anchors.horizontalCenter: parent.horizontalCenter
                    width: 40
                    height: 40
                    radius: 20
                    border.width: 1
                    color: "yellow"

                    Text {
                        id: text
                        anchors.centerIn: parent
                        text : index
                    }
                }
            }
        }
    }
}
