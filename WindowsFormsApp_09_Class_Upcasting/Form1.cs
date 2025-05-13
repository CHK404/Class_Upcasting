using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_09_Class_Upcasting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //1. 자식 객체 생성
            Sword sword = new Sword();
            sword.Name = "Long Sword";
            sword.Attack(); //부모 메서드 호출
            sword.Sharp();  //자식 고유 메서드 호출

            Console.WriteLine("=====================");

            //2. 업캐스팅: "자식" 클래스를 "부모" 클래스 타입으로 참조
            //쓰는 이유: 다형성을 통해 여러 자식 객체를 부모타입 하나로 통합
            //유연하고 재사용 가능한 코드로 작성하기 위해
            //자식 클래스 고유 기능 사용 불가/부모 클래스 메서드만 사용 가능

            //3. 업캐스팅 방식 3가지
            //1) 묵시적 업캐스팅(중간 변수 활용)
            //Sword sword = new Sword();
            Weapon weapon1 = sword;
            weapon1.Attack();   //부모 메서드 호출
            //weapon1.Sharp();  //자식 고유 메서드 호출(X)

            //2) 다이렉트(=묵시적) 업캐스팅 (바로 대입) - 가장 많이 사용
            Weapon weapon2 = new Gun();
            weapon2.Name = "AK-47";
            weapon2.Attack();   //부모 메서드 호출
            //weapon2.Reload(); //자식 고유 메서드 호출(X)

            //3) 명시적 업캐스팅 (형변환 기호 사용) - 자주 사용x
            Weapon weapon3 = (Weapon)new Bow();
            weapon3.Name = "Iron Bow";
            weapon3.Attack();
            //weapon3.Aim();

            Console.ReadLine();
            Console.WriteLine("=====================");

            //4. 추가 내용

            //검 생성
            Sword sword2 = new Sword(30); //damage = 30
            sword2.Name = "Long Sword";
            sword2.Attack();
            Console.WriteLine($"검 공격 데미지: {sword2.Slash(1)}");
            Console.WriteLine("=====================");

            //업캐스팅
            Weapon weapon4 = sword2;    //Sword -> Weapon 업캐스팅
            weapon4.Attack();
            //weapon4.Slash(1);
            //다운캐스팅해서 다시 사용 가능(권장 x)
            //ㄴ 실제 타입을 정확히 알고 있을때는 안전
            //ㄴ 실행중 타입이 다르면 오류 발생
            //ㄴ 안정성이 떨어져 유지보수나 확장성에 불리

            Console.WriteLine($"검 공격 데미지: {((Sword)weapon4).Slash(1)}");
            Console.WriteLine("=====================");

            //인스턴스를 덮어 씌우는 것으로 자식 클래스 변경 가능
            weapon4 = new Gun(100); //실제 객체는 Gun
            weapon4.Name = "Gun";
            weapon4.Attack();
            Console.WriteLine($"총 공격 데미지: {((Gun)weapon4).Fire(10)}");

            //직관적
            Weapon sword10 = new Sword();
            Weapon gun3 = new Gun();
            Weapon bow3 = new Bow();

            //Sword sword9 = new Sword();
            //Gun gun = new Gun();
            //Bow bow = new Bow();

            Console.WriteLine("=====================");

            //ex

            Animal dog = new Dog();
            dog.Name = "Max";
            dog.Speak();
            //dog.d_Speak;(x)
            Console.WriteLine($"{dog.Name} says {((Dog)dog).ani_Sound}");   //다운캐스팅

            Animal cat = new Cat();
            cat.Name = "Nibbles";
            cat.Speak();
            //cat.c_Speak();(x)
            Console.WriteLine($"{cat.Name} says {((Cat)cat).ani_Sound}");

            Animal bird = new Bird();
            bird.Name = "Fluffy";
            bird.Speak();
            //bird.b_Speak();(x)
            Console.WriteLine($"{bird.Name} says {((Bird)bird).ani_Sound}");


        }
    }
}
