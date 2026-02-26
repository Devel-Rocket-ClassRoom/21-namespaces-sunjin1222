using MyGame.Characters;
using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");



MyGame.Characters.Player plyer=new MyGame.Characters.Player();
plyer.attack();
MyGame.Characters.Enemy enemy = new MyGame.Characters.Enemy();
enemy.TakeDamage();


MyGame.Items.Weapon weapon=new MyGame.Items.Weapon();
weapon.GetDamage();

MyGame.Items.Potion potion = new MyGame.Items.Potion();
potion.Use();


namespace MyGame.Characters
{
    class Player 
    {
        public string name = "용사";
        public void attack()
        {
            Console.WriteLine($"플레이어 {name}(이)가 공격합니다!");
        }
    }

    class Enemy
    {
        string type="고블린";
        public void TakeDamage()
        {
            Console.WriteLine($"적 {type} (이)가 데미지를 받았습니다!");
        }
    }
}



namespace MyGame.Items
{
    class Weapon
    {
        string name="불꽃";
        public void GetDamage()
        {
            Console.WriteLine($"무기 {name}의 공격력: 50");
        }
    }

    class Potion
    {
        string name="체력";
        public void Use()
        {
            Console.WriteLine($"포션 {name} 포션을(를) 사용했습니다.");
        }
    }


}






