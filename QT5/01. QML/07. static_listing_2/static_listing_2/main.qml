import QtQuick 2.14
import QtQuick.Window 2.14

Window {
    id: idWindow
    visible: true
    width: 300
    height: 100

    Rectangle{
        id:content
        anchors.fill: parent
        color: "#F0F0F0"

        Row{
            id:list
            anchors.horizontalCenter: parent.horizontalCenter
            anchors.verticalCenter: parent.verticalCenter

            spacing: 10

            Component{
                id:blue
                Rectangle{
                    width:40
                    height: 30
                    color: "blue"
                    Text{
                        anchors.centerIn: parent
                        text: qsTr("Blue")
                    }

                }
            }

            Component{
                id:red
                Rectangle{
                    width: 50
                    height: 40
                    color: "red"
                    Text{
                        anchors.centerIn: parent
                        text: qsTr("Red")
                    }

                }
            }

            Component{
                id:green
                Rectangle{
                    width: 50
                    height: 40
                    color: "green"
                    Text{
                        anchors.centerIn: parent
                        text:qsTr("Green")

                    }
                }
            }

            Repeater{
                model: [ red,green,blue]

                Loader{
                    sourceComponent:modelData
                }

            }
        }
    }
}
