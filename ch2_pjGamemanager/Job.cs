using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyItem;
using MyInventory;
using System.ComponentModel.Design;

namespace JobClass
{
    
    public class Job
    {
        
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }
        public int DefensePower { get; private set; }

        private  Job(string name, int health, int attackPower, int defensePower)
        {

            Name = name;
            Health = health;
            AttackPower = attackPower;
            DefensePower = defensePower;

        }

        public static Job Warrior { get { return new Job("전사", 100, 10, 5); } }
        public static Job Mage { get { return new Job("마법사", 80, 12, 5); } }
        public static Job Archer { get { return new Job("궁수", 90, 13, 4); } }

        public static Job SelectedJob { get; private set; }

        public static void Selectjob(Job job)

        {

            SelectedJob = job;

        }

        public static int CalculateAttack(List<Item> inventory)
        {
            int totalAttack = SelectedJob.AttackPower;
            foreach (var item in inventory)
            {
                if (item.equipped)
                    totalAttack += item.attack;
            }
            return totalAttack;
        }

        public static int CalculateDefense(List<Item> inventory)
        {
            int totalDefense = SelectedJob.DefensePower;
            foreach (var item in inventory)
            {
                if (item.equipped)
                    totalDefense += item.defense;
            }
            return totalDefense;
        }
    }
}

