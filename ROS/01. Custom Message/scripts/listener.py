#!/usr/bin/env python

import rospy
from std_msgs.msg import String
from tutorials.msg import Num
def callback(data):
    rospy.loginfo(rospy.get_caller_id() + "I heard %s", data.num)

def listener():
    rospy.init_node('listener',anonymous=True)
    rospy.Subscriber("chatter",Num,callback)

    rospy.spin()

if __name__=='__main__':
    listener()