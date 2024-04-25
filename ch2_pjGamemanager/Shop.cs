using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyItem;
using MyInventory;
using System.Threading.Channels;
using MyStatus;




namespace Myshop
{
    public class Shop
    {
        public static List<Item> Buyingshop = new List<Item>();
        public static void BuyShop()
        {
            
            
            
                Console.WriteLine("상점");
                Console.WriteLine("");
                Console.WriteLine("[보유골드]");
                Console.WriteLine($"{Status.Gold}");
                Console.WriteLine("");
                Console.WriteLine("[아이템목록]");

                for (int i = 0; i < Buyingshop.Count; i++)
                {
                    Console.Write($" - {i + 1} ");
                    if (Buyingshop[i].purchased)
                    {
                        Console.WriteLine($"{Buyingshop[i].name} | {Buyingshop[i].description} 구매 완료.");
                    }
                    else
                    {
                        Console.WriteLine($"{Buyingshop[i].name} | {Buyingshop[i].description} {Buyingshop[i].price} G.");
                    }
                }
                Console.WriteLine("\n1. 아이템 구매");
                Console.WriteLine("0. 나가기");

                Console.Write("\n원하시는 행동을 입력해주세요: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        BuyItem();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            }

        



        //        수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |  1000 G
        //- 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료
        //- 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G
        //- 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  600 G
        //- 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G
        //- 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료


        public static void ShopItem()
        {
            Buyingshop.Add(new Item("수련자 갑옷", "수련에 도움을 주는 갑옷입니다.", 0, 5, 1000));
            Buyingshop.Add(new Item("무쇠 갑옷", "무쇠로 만들어져 튼튼한 갑옷입니다.", 0, 9, 2000));
            Buyingshop.Add(new Item("스파르타의 갑옷", "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 0, 15, 3500));
            Buyingshop.Add(new Item("낡은 검", "쉽게 볼 수 있는 낡은 검 입니다.", 2, 0, 600));
            Buyingshop.Add(new Item("청동 도끼", "어디선가 사용됐던거 같은 도끼입니다.", 5, 0, 1500));
            Buyingshop.Add(new Item("스파르타의 창", "수련에 도움을 주는 갑옷입니다.", 7, 0, 3000));
        }


        static void BuyItem()
        {
            Console.WriteLine("\n상점 - 아이템 구매");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");

            Console.WriteLine("[보유 골드]");
            Console.WriteLine($"{Status.Gold} G\n");
            Console.WriteLine("[아이템 목록]");

            for (int i = 0; i < Buyingshop.Count; i++)
            {
                Console.Write($"- {i + 1} ");
                if (Buyingshop[i].purchased)
                {
                    Console.WriteLine($"{Buyingshop[i].name} | {Buyingshop[i].description} |  구매완료");
                }
                else
                {
                    Console.WriteLine($"{Buyingshop[i].name} | {Buyingshop[i].description} |  {Buyingshop[i].price} G");
                }
            }

            Console.WriteLine("\n원하시는 아이템 번호를 입력해주세요: ");
            int index;
            if (int.TryParse(Console.ReadLine(), out index))
            {
                if (index >= 1 && index <= Buyingshop.Count)
                {
                    if (Buyingshop[index - 1].purchased)
                    {
                        Console.WriteLine("이미 구매한 아이템입니다.");
                    }
                    else if (Status.Gold >= Buyingshop[index - 1].price)
                    {
                        Status.Gold -= Buyingshop[index - 1].price;
                        Inventory.inventory.Add(new Item(Buyingshop[index - 1]));
                        Buyingshop[index - 1].purchased = true;
                        Console.WriteLine($"\"{Buyingshop[index - 1].name}\"를 구매했습니다.");
                    }
                    else
                    {
                        Console.WriteLine("Gold가 부족합니다.");
                    }
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
        }




    }
}

