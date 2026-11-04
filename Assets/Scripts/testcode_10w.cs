using UnityEngine;

public class testcode_10w : MonoBehaviour
{
    public class Human
    {
        public string name;
        public int age;
        public float height;
        protected string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int _age)
        {
            age = _age;
        }

        public Human()
        {

        }

        public Human(string _name, int _age, float _height)
        {
            name = _name;
            age = _age;
            height = _height;
        }

        public void Eat()
        {
            Debug.Log("eat");
        }

        public virtual void Walk()
        {
            Debug.Log("walk");
        }

        public void Sleep()
        {
            Debug.Log("sleep");
        }
    }

    class Adult : Human
    {
        public Adult(string _name, int _age, float _height) //자식 클래스 생성자 호출
            : base(_name, _age, _height) { } //부모 클래스 생성자 호출

        public void PrintAddress()
        {
            Debug.Log(address);
        }

        public int Age;
        public void SetBaseAge(int age)
        {
            base.age = age;
        }

        public int GetBaseAge()
        {
            return base.age;
        }

        void Start()
        {
            Adult maria = new Adult("Alice", 10, 140f);
            maria.Age = 12;
            maria.SetBaseAge(2);
            Debug.Log(maria.Age);
            Debug.Log(maria.GetBaseAge()); //작동안함

        }

        void Update()
        {

        }
    }
}
