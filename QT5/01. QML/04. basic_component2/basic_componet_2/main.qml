import QtQuick 2.14
import QtQuick.Window 2.14

Window {
    visible: true
    width: 320
    height: 240
    title: qsTr("Hello Makerweb")

    property bool flag : false
   Button{
       id : newButton

       function buttonClickProcess(){
          var state = flag

           flag = !flag

           if(flag !== state)
               return true
           else
               return false
       }
       onButtonClicked: {
           if(buttonClickProcess())
               isOn = flag
           else
               return
       }
   }
}
