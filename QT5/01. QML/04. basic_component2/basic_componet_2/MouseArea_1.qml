import QtQuick 2.0

MouseArea {
    width: 100
    height: 100
    onPressed: {
        console.log("Pressed")
    }
    onReleased: {
        console.log("Released")
    }
    onClicked:{
        console.log("clicked")
    }
    onPressedChanged: {
        console.log("Changed")
    }
}
