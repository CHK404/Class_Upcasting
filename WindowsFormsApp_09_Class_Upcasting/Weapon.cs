using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_09_Class_Upcasting
{
    #region 1. 부모 클래스(무기)
    public class Weapon
    {
        //필드
        //private string name; - 필요 x
        protected int damage;

        //속성
        public string Name { get; set; }
        
        //생성자
        public Weapon(int damage)
        {
            this.damage = damage;
        }

        //메서드
        public void Attack()
        {
            Console.WriteLine($"{Name} (으)로 공격");
        }
    }

    #endregion

    #region 2. 자식 클래스
    //자식 클래스: Sword(검)
    public class Sword : Weapon
    {
        //생성자
        public Sword(int damage) : base(damage) { }

        public void Sharp()
        {
            Console.WriteLine("검이 날카롭게 빛납니다.");
        }
    }
    //자식 클래스: Gun(총)
    public class Gun : Weapon
    {
        public void Reload()
        {
            Console.WriteLine("총을 재장전 합니다.");
        }
    }
    //자식 클래스: Bow(활)
    public class Bow : Weapon
    {
        public void Aim()
        {
            Console.WriteLine("활을 당겨 조준합니다.");
        }
    }

    #endregion
}
