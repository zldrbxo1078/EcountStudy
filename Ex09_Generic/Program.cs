using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Generic
{
    class Person    //DTO, VO, Domian 클래스 >> 데이터를 담을 수 있는 클래스 
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Person() { }
        public Person(string name, string phone, string email)
        {
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
        }
        public override string ToString()
        {
            return "name : " + Name + "Phone : " + Phone + "Email : " + Email;
        }
    }

    //class List<>도 enumerable, enumerator 구현되어있다.

    class PersonList : IEnumerable, IEnumerator //열거된 자원에 대해 순차적으로 접근 데이터 read
    {
        private ArrayList persons = new ArrayList();
        //private List<Person> people = new List<Person> ();
        private int position = -1;  //reset 값

        public void Add(Person person)
        {
            persons.Add(person);
        }

        public void Add(string name, string phone, string email)
        {
            persons.Add(new Person(name, phone, email));
        }

        public object Current { get { return persons[position]; } }  //property 구현 get 로직 구현


        public IEnumerator GetEnumerator()
        {
            //Enumerator 상속해서 구현하고 객체의 주소를 리턴
            return this;
        }

        public bool MoveNext()
        {
            if (position+1 < persons.Count)
            {
                position++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset() // 실행블럭 초기화 >> 배열의 리셋은 -1 값 부여
        {
            position = -1;  //원점으로 초기화
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();   //단일 데이터 처리 시 
            //List<Person> list = new List<Person>(); //다수의 데이터 처리 시 
            PersonList list = new PersonList();
            //for (int i = 0; i < 10; i++)
            //{
            //    list.Add("Ne" + i, "Ph" + i, "Em" + i);
            //}
            //foreach (var person in list)
            //{
            //    Console.WriteLine(person.ToString());
            //}

            IEnumerator ie = list.GetEnumerator();

            while(ie.MoveNext()){
                Console.WriteLine(ie.Current);
            }


            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                { 0,"value_1" },
                { 1,"value_2" },
                { 2,"value_3" }
            };
            //이런 식으로 초기화 가능

            //var dictionary = new Dictionary<string, string>();  //이런 식으로도 가능

            for (int i = 0; i < dict.Count; i++)
            {
                //Console.WriteLine($"index:{i} - {dict[i]}");
            }

            foreach (var entry in dict)
            {
                //Console.WriteLine($"key : {entry.Key} Value : {entry.Value}");  //이게 많이 쓰이는 유형
            }

        }
    }
}
