using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{

    class Car
    {
        private string name;
        private string color;
        public Car()    //기본이름을 가지고 있다. 
        {
            this.name = "G70";
            this.color = "white";
        }
        public Car(string name, string color)   // 이름과 색상을 옵션으로 선택할 수 있다. 
        {
            this.name = name;
            this.color = color;
        }
        //조회가 가능하다. 
        public void info()  
        {
            Console.WriteLine($"{this.name} {this.color}");
        }

        //이름과 색상정보를 확인할 수 있다. 
        public string Name { get { return this.name; } }    //읽기만 가능하도록
        public string Color { get { return this.color; } }
    }
}
