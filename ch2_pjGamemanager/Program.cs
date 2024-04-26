using System;
using JobClass;
using MyStatus;
using MyInventory;
using Myshop;


namespace ch2_pjGamemanager

{

    class Program

    {
        static Job selectedJob = null;
        static void Main(string[] args)
        {
            
            Program program = new Program();

            Console.WriteLine("게임을 시작합니다.");
            Console.WriteLine("직업을 선택해주세요:");
            Console.WriteLine("1. 전사");
            Console.WriteLine("2. 마법사");
            Console.WriteLine("3. 궁수");

            int choice = int.Parse(Console.ReadLine());
            
            
            switch (choice)
            {
                case 1:
                    Job.Selectjob(Job.Warrior);
                    break;
                case 2:
                    Job.Selectjob(Job.Mage);
                    break;
                case 3:
                    Job.Selectjob(Job.Archer);
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    return;
            }
            
            Console.WriteLine($"당신은 {Job.SelectedJob.Name}입니다.");
            Console.WriteLine($"체력은: {Job.SelectedJob.Health}입니다.");
            Console.WriteLine($"공격력: {Job.SelectedJob.AttackPower}");
            Console.WriteLine($"방어력: {Job.SelectedJob.DefensePower}");

            Shop.ShopItem(); // 상점아이템 리스트 추가
            Inventory.ADDInmyInventory(); // 인벤토리 리스트 추가

            Startgame();

            static void Startgame()
            {
                

                while (true)
                {
                    
                    Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                    Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                    Console.WriteLine(" ");
                    Console.WriteLine("1. 상태보기");
                    Console.WriteLine("2. 인벤토리");
                    Console.WriteLine("3. 상점");
                    Console.WriteLine(" ");
                    Console.WriteLine("원하시는 행동을 입력해주세요");
                    Console.WriteLine(">> ");

                    string input = Console.ReadLine();
                    Job selectedJob = null;
                    switch (input)
                    {
                        case "1":
                            
                            Status.PrintStatus(selectedJob); // 상태보기
                            break;
                        case "2":
                            Inventory.ShowInventory(); //인벤토리
                            break;
                        case "3":
                            Shop shop = new Shop();
                            shop.BuyShop();
                            break;

                    }




                }
            }
        }


    }
}
