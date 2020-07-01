using System;
namespace Class1
{
    public class MyCustomer
    {
        //필드
        private string name;
        private int age;

        // event

        public event EventHandler NameChanged;

        // 생성자
        public MyCustomer()
        {
            name = string.Empty;
            age = -1;
        }

        //속성
        public string Name
        {
            get {return this.name;}
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    if (NameChanged != null)
                    {
                        NameChanged(this, EventArgs.Empty);
                    }
                }
            }
        }
        public int Age
        {
            get {return this.age;}
            set {this.age = value;}
        }

        // 메서드
        public string GetCustomerData()
        {
            string data = string.Format("Name: {0} (Age : {1})", this.NameChanged, this.Age);
            return data;
        }
    }
}