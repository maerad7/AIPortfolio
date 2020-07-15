import QtQuick 2.0

Rectangle{
    width: 200
    height: 200
    anchors.centerIn: parent
    color: isOn ? "green" : "yellow"
    border.width: 2
    border.color: "black"

    property bool isOn: false // state flag로 사용될 사용자 정의 프로퍼티

    signal buttonPressed(bool isPressed)
    signal buttonReleased(bool isPressed)
    signal buttonClicked()

    Text{
        id : title
        anchors.fill: parent
        text: parent.isOn? qsTr("On") : qsTr("Off") // state flag에 따라 text를 설정하는 삼항연산자
        color:parent.isOn? "yellow" : "green"
        horizontalAlignment: Text.AlignHCenter
        verticalAlignment: Text.AlignVCenter
    }

//    MouseArea{
//        anchors.fill: parent // Rectangle 영역을 채움
//        onPressed: parent.isOn = true // on 설정
//        onReleased: parent.isOn = false //off 설정
//        onClicked: console.log("clicked")
//        onParentChanged: console.log("state: " + parent.isOn)
//    }
    MouseArea{
        anchors.fill: parent
        onPressed: buttonPressed(pressed)
        onReleased: buttonReleased(pressed)
        onClicked: buttonClicked()
    }
}
