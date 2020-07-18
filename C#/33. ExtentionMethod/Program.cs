﻿using System;
using System.Text;
namespace ExtentionMethod
{
    public static class ExClass
    {
        // static 확장 메서드 정의, 첫번째 파라미터는 어떤 클래스가 사용할지만 지정
        public static string ToChangeCase(this String str)
        {
            StringBuilder sb = new StringBuilder();
            foreach(var ch in str)
            {
                if (ch >= 'A' && ch <= 'Z')
                sb.Append((char)('a' + ch - 'A'));
                else if (ch >= 'a' && ch <= 'x')
                sb.Append((char)('A' + ch - 'a'));
                else
                sb.Append(ch);
            }
         return sb.ToString();
      }
      // 이 확장 메서드는 파라미터 ch가 필요
      public static bool Found(this String str,char ch)
      {
          int position= str.IndexOf(ch);
          return position >= 0;
      }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "This is a Test";

            // s객체 즉 String 객체가 확장 메서드의 첫 파라미터 This는 파라미터로 취급 안함
            string s2 = s.ToChangeCase();


            bool found = s.Found('z');

            Console.WriteLine("s: {0}, s2: {1}",s,s2);

        }
    }
}
