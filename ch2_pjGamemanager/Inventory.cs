using MyItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobClass;

namespace MyInventory
{

    public class Inventory

    {
        public static List<Item> inventory = new List<Item>();

        public static void ShowInventory()
        {
            
            Console.WriteLine("\n인벤토리를 보여줍니다.");
            Console.WriteLine("\n[아이템 목록]");

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.Write($"- {i + 1}. ");
                if (inventory[i].equipped)
                    Console.Write("[E] ");
                Console.WriteLine($"{inventory[i].name} | {inventory[i].description} | 공격력 : {inventory[i].attack} | 방어력 : {inventory[i].defense}");
            }

            Console.WriteLine("\n1. 장착 관리");
            Console.WriteLine("0. 나가기");

            Console.Write("\n원하시는 행동을 입력해주세요: ");
            string input = Console.ReadLine();

            switch (input)
            {

                case "1":
                    ManageEquip();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;

            }
        }
        static void ManageEquip()
        {
            Console.WriteLine("인벤토리 - 장착 관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("[아이템 목록]");

            for (int i = 0; i < inventory.Count; i++)
            {
                Console.Write($"- {i + 1}. ");
                if (inventory[i].equipped)
                    Console.Write("[E] ");
                Console.WriteLine($"{inventory[i].name} | {inventory[i].description} | 공격력 : {inventory[i].attack} | 방어력 : {inventory[i].defense}");
            }

            Console.WriteLine("0. 나가기");

            Console.Write("원하시는 아이템 번호를 입력해주세요: ");
            int index;
            if (int.TryParse(Console.ReadLine(), out index))
            {
                if (index >= 1 && index <= inventory.Count)
                {
                    inventory[index - 1].equipped = !inventory[index - 1].equipped;
                    Console.WriteLine($"아이템 \"{inventory[index - 1].name}\"의 장착을 변경하였습니다.");
                }
                else if (index == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }

            ShowInventory();
        }
//        - 1 [E]무쇠갑옷      | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.
//        - 2 [E] 스파르타의 창  | 공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.
//        - 3 낡은 검         | 공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다.

        public static void ADDInmyInventory()
        {
            inventory.Add(new Item("무쇠갑옷", "무쇠로 만들어져 튼튼한 갑옷입니다.", 0, 5, 1000));
            inventory.Add(new Item("스파르타의 창", "스파르타의 전사들이 사용했다는 전설의 창입니다.", 20, 0, 1500));
            inventory.Add(new Item("낡은 검 ", "쉽게 볼 수 있는 낡은 검 입니다.", 500, 0, 1000));

        }
    }
  
}
