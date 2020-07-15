import QtQuick 2.14
import QtQuick.Window 2.14

Window {
    id : idWindow
    visible: true
    width: 1024
    height: 680
    flags: Qt.FramelessWindowHint

//    Row{
//        anchors.centerIn: parent
//        spacing :20

//        Image{
//            source: "download.jpeg"
//        }

//        Image{
//            source: "download.jpeg"
//        }
//    }
     Rectangle{
         anchors.fill:parent
         color: "#F0F0F0"

         Column{
             anchors.centerIn: parent
             spacing: 20

             Image{
                 source: "download.jpeg"
             }
             Image{
                 source: "download.jpeg"
             }

             Rectangle{
                 color:"green"
                 width: 110
                 height: 50
             }
         }
     }
}
