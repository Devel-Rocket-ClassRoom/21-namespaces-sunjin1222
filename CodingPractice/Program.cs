using System;
using System.Runtime.ConstrainedExecution;

/*
// 과제 1: 정규화된 이름으로 네임스페이스 사용
Foo.Car fooCar = new Foo.Car();
fooCar.Go();

Bar.Car barCar = new Bar.Car();
barCar.Go();

namespace Foo
{
    class Car
    {
        public void Go()
        {
            Console.WriteLine("Foo 네임스페이스의 Car 클래스");
        }
    }
}
namespace Bar
{
    class Car
    {
        public void Go()
        {
            Console.WriteLine("Bar 네임스페이스의 Car 클래스");
        }
    }
}


// 과제 2: 중첩 네임스페이스 활용
Korea.Incheon.car Incheoncar = new Korea.Incheon.car();
Incheoncar.Run();

Korea.Seoul.car Seoul = new Korea.Seoul.car();
Seoul.Run();



namespace Korea.Incheon
{
    class car
    {
        public void Run()
        {
            Console.WriteLine("인천 자동차가 달립니다.");
        }
    }
}

namespace Korea.Seoul
{
    class car
    {
        public void Run()
        {
            Console.WriteLine("서울 자동차가 달립니다.");
        }
    }
}
*/

// 과제 3: using static 지시문

using static System.Console;
using static System.Math;

WriteLine("Hello, World!");

double x = Sqrt(16);
WriteLine($"제곱근: {x}");

double MaxValue = Max(10,20);
WriteLine($"최대값: {MaxValue}");

