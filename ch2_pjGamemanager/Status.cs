using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using JobClass;
using MyInventory;


namespace MyStatus
{

    public class Status
    {
        public static int level = 1;
        public static int Gold = 2000;

        public static void PrintStatus(Job job)
        {
            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine(" ");
            Console.WriteLine($"Lv {level:D2}");
            Console.WriteLine($"직업 : {Job.SelectedJob.Name} ");
            Console.WriteLine($"공격력 :{Job.CalculateAttack(Inventory.inventory)}");
            Console.WriteLine($"방어력 :{Job.CalculateDefense(Inventory.inventory)}");
            Console.WriteLine($"체력 :{Job.SelectedJob.Health}");
            Console.WriteLine($"Gold : {Gold}");
            Console.WriteLine(" ");
            Console.WriteLine("0. 나가기 ");
            Console.WriteLine(" ");
            Console.WriteLine("원하시는 행동을 입력해주세요");
            Console.WriteLine(">> ");

            string input = Console.ReadLine();

            if (input == "0") return;
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
        }
    }
}
