import QtQuick 2.14
import QtQuick.Window 2.14

Window {
    visible: true
    width: 640
    height: 480
    title: qsTr("Hello World")

    Text {
        id: idText
        text: qsTr("text")
        anchors.centerIn: parent
        font.pixelSize: 15

    }
    Item{
        focus: true
        Keys.onPressed: {
            switch(event.key){
            case Qt.Key_A :
                idText.text = "input A key"
                break;
            case Qt.Key_0:
                idText.text = " input num0 key"
                break;
            default:
                break;
            }
        }
    }
}
