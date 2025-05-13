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

        }
    }
}
