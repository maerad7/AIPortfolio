<<<<<<< HEAD
﻿using System;
using System.Dynamic;
using System.Collections.Generic;
namespace DynamicT
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.M1();
        }
        public void M1()
        {
            //dynamic은 아무 자료형으로나 쓸 수 있다.
            dynamic person = new ExpandoObject();            
            person.Name = "Kim";
            person.Age = 10;            
            person.Display = (Action)(() => { });
            person.ChangeAge = (Action<int>)((age) => { person.Age = age; });
            person.AgeChanged = null;
            person.AgeChanged += new EventHandler((s, e) => { });

            // ExpandoObject를 IDictionary로 변환
            var dict = (IDictionary<string, object>)person;

            // person 의 속성,메서드,이벤트는
            // IDictionary 해시테이블에 저정되어 있는데
            // 아래는 이를 출력함
            foreach (var d in dict)
            {
                Console.WriteLine("{0}: {1}", d.Key, d.Value);
            }
        }

    }
}
=======
﻿using System;
using System.Dynamic;
using System.Collections.Generic;
namespace DynamicT
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.M1();
        }
        public void M1()
        {
            //dynamic은 아무 자료형으로나 쓸 수 있다.
            dynamic person = new ExpandoObject();            
            person.Name = "Kim";
            person.Age = 10;            
            person.Display = (Action)(() => { });
            person.ChangeAge = (Action<int>)((age) => { person.Age = age; });
            person.AgeChanged = null;
            person.AgeChanged += new EventHandler((s, e) => { });

            // ExpandoObject를 IDictionary로 변환
            var dict = (IDictionary<string, object>)person;

            // person 의 속성,메서드,이벤트는
            // IDictionary 해시테이블에 저정되어 있는데
            // 아래는 이를 출력함
            foreach (var d in dict)
            {
                Console.WriteLine("{0}: {1}", d.Key, d.Value);
            }
        }

    }
}
>>>>>>> d2e7b951dce912923d6d05b0809030f1f81655b7
