#!/usr/bin/env python
import rospy
from std_msgs.msg import String
from tutorials.msg import Num

def talker():
    pub = rospy.Publisher('chatter',Num,queue_size=10)
    rospy.init_node('talker',anonymous=True)
    rate = rospy.Rate(10)
    while not rospy.is_shutdown():
        #hello_str='Hello world %s' % rospy.get_time()
        a = Num()
        a.num = 2
        rospy.loginfo(a)
        pub.publish(a)
        rate.sleep()

if __name__ == '__main__':
    try:
        talker()
    except rospy.ROSInterruptException:
        pass