namespace _20251204_4
    // 클래스 상속 실습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Animal animal = new Animal("바둑이");  // 부모 클래스 생성
            Animal animal1 = new Dog(); // 업캐스팅 (부모로부터 자식 클래스 생성)
            Animal animal2 = new Cat(); // 업캐스팅 (부모로부터 자식 클래스 생성)
            Animal animal3 = new Brid(); // 업캐스팅 (부모로부터 자식 클래스 생성)

            animal.Speak();
            ((Dog)animal1).SpeakDog("멍멍");  // 다운캐스팅
            ((Cat)animal2).SpeakCat("야옹");  // 다운캐스팅
            ((Bird)animal3).SpeakBird("짹짹");  // 다운캐스팅
        }
    }

    public class Animal
    {
        public string Name;
        public Animal(string Name) 
        { 
            this.Name = Name;
        }

        public void Speak()
        {
            Console.WriteLine($"{Name}: 동물이 소리를 냅니다.");
        }
    }

    public class Dog : Animal
    {
        public Dog() : base("흰둥이") { }
        public void SpeakDog(string a)
        {
            Console.WriteLine($"{Name}: 강아지가 {a} 소리를 냅니다.");
        }
    }
    public class Cat : Animal
    {
        public Cat() : base("야옹이") { }
        public void SpeakCat(string a)
        {
            Console.WriteLine($"{Name}: 고양이가 {a} 소리를 냅니다.");
        }
    }
    public class Bird : Animal
    {
        public Bird() : base("짹짹이") { }
        public void SpeakBird(string a)
        {
            Console.WriteLine($"{Name}: 새가 {a} 소리를 냅니다.");
        }
    }

}
