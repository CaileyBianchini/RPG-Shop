using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _health;
        private int _baseDamage;
        private int _potionDamage;
        public Items _currency;
        private Items[] _inventory;
        private Items _currentWeapon;
        private Items _hands;

        private int _enemyHealth;
        private int _enemyAttack;

        public Player()
        {
            _inventory = new Items[5];
            _health = 100;
            _baseDamage = 10;
            _currency.itemPrice = 10;
            
            _hands.itemName = "Your fugly hands";
            _hands.itemBoost = 0;


            _enemyHealth = 80;
            _enemyAttack = 20;
        }

        

        public Player(int healthVal, int damageVal, int currencyVal, int inventorySize)
        {
            _health = healthVal;
            _baseDamage = damageVal;
            _currency.itemPrice = currencyVal;  
            _inventory = new Items[inventorySize];
            _hands.itemName = "Your fugly hands";
            _hands.itemBoost = 0;
        }

        public Player(int enemyAttackVal, int enemyHealthVal)
        {
            _enemyHealth = enemyHealthVal;
            _enemyAttack = enemyAttackVal;

        }
        public void AddItemToInventory(Items item, int index)
        {
            _inventory[index] = item;

        }

        public bool Contains(int itemIndex)
        {
            if (itemIndex > 0 && itemIndex < _inventory.Length)
            {
                return true;
            }
            return false;
        }

        public void EquipItem(int itemIndex)
        {
            if (Contains(itemIndex) == true)
            {
                _currentWeapon = _inventory[itemIndex];
            }
        }

        public void UseItem(int itemIndex)
        {
            if (Contains(itemIndex) ==true)
            {
                //_potionDamage = _inventory[itemIndex];
            }
        }
            

        public void UnequipItem()
        {
            _currentWeapon = _hands;
        }

        public Items[] GetInventory()
        {
            return _inventory;
        }

        public bool GetIsAlive()
        {
            return _health > 0;

        }

        public bool EnemyAlive()
        {
            return _enemyHealth > 0;
        }

        public void Attack(Player enemy)
        {

            int totalDamage = _baseDamage + _currentWeapon.itemBoost;
            _enemyHealth -= totalDamage;
        }

        public void PrintStats()
        {
            Console.WriteLine("Your Stats");
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Damage: " + _baseDamage);
        }

        public void TakeDamage(int damageVal)
        {
            if (GetIsAlive())
            {
                _health -= damageVal;
            }
            Console.WriteLine("You took " + damageVal + " damage!!!");
        }

    }


}
