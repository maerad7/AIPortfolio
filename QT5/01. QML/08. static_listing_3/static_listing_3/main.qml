import QtQuick 2.14
import QtQuick.Window 2.14

Window {
    id :idWindow
    visible: true
    width: 150
    height: 300

    Rectangle{
        id:content
        anchors.fill: parent
        color: "#F0F0F0"

        ListModel{
            id:users
            ListElement{ name: "Lee"; ID: "goal21"; point:210}
            ListElement{ name: "kim"; ID: "efgh"; point:190}
            ListElement{ name: "Park"; ID: "abcd"; point:220}
            ListElement{ name: "Kim"; ID: "hello32"; point:150}

        }

        Column{
            id:list
            anchors.horizontalCenter: parent.horizontalCenter
            anchors.verticalCenter:  parent.verticalCenter

            spacing: 10

            Repeater{
                model:users

                Rectangle{
                    width:150
                    height: 50
                    color: "blue"
                    radius: 5

                    Row{
                        spacing: 10
                        anchors.centerIn: parent
                        Text {
                            id: name
                            font.bold : true
                            font.pixelSize: 20
                            anchors.verticalCenter: parent.verticalCenter
                        }
                        Text {
                                text: ID
                                color: "white"
                                font.bold: true
                                font.pixelSize: 15
                                anchors.verticalCenter: parent.verticalCenter
                        }
                        Text {
                                text: point
                                color: "white"
                                font.bold: true
                                font.pixelSize: 15
                                anchors.verticalCenter: parent.verticalCenter


                        }
                    }
                }
            }
        }
    }
}
