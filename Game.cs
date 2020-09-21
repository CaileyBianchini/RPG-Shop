using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    struct Items
    {
        public int itemBoost;
        public string itemName;
        public int itemPrice;
    }



    class Game
    {
        public void Continue()
        {
            Console.WriteLine("\nPress [Enter] to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        public void PlayersStats()
        {
            _player.PrintStats();
            Console.WriteLine(_money + " gold");
        }

        // INPUTS

        public void GetInput(out char input, string option1, string option2, string quiry)
        {
            Console.WriteLine(quiry);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            input = ' ';

            //loops till valid is received
            while (input != '1' && input != '2')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2')
                {
                    Console.WriteLine("Invalid Input. Please Try Again.");

                }
            }

            Continue();
        }


        public void GetInput(out char input, string option1, string option2, string option3, string quiry)
        {
            Console.WriteLine(quiry);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.WriteLine("3. " + option3);
            input = ' ';

            //loops till valid is received
            while (input != '1' && input != '2' && input != '3')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3')
                {
                    Console.WriteLine("Invalid Input. Please Try Again.");

                }
            }

            Continue();
        }

        public void GetInput(out char input, string option1, string option2, string option3, string option4, string quiry)
        {
            Console.WriteLine(quiry);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.WriteLine("3. " + option3);
            Console.WriteLine("4. " + option4);
            input = ' ';

            //loops till valid is received
            while (input != '1' && input != '2' && input != '3' && input != '4')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3' && input != '4')
                {
                    Console.WriteLine("Invalid Input. Please Try Again.");

                }
            }

            Continue();
        }

        public void GetInput(out char input, string option1, string option2, string option3, string option4, string option5, string option6, string quiry)
        {
            Console.WriteLine(quiry);
            Console.WriteLine("1. " + option1);
            Console.WriteLine("2. " + option2);
            Console.WriteLine("3. " + option3);
            Console.WriteLine("4. " + option4);
            Console.WriteLine("5. " + option5);
            Console.WriteLine("6. " + option6);
            input = ' ';

            //loops till valid is received
            while (input != '1' && input != '2' && input != '3' && input != '4' && input != '5' && input != '6')
            {
                input = Console.ReadKey().KeyChar;
                if (input != '1' && input != '2' && input != '3' && input != '4' && input != '5' && input != '6')
                {
                    Console.WriteLine("Invalid Input. Please Try Again.");

                }
            }

            Continue();
        }

        //______________________________________________________________________________________________________________________________________________
        private Items _longSword;
        private Items _dagger;
        private Items _ax;
        private Items _staff;
        private Items _mace;
        private Items _hammer;


        private Items _firePotion;
        private Items _poisonPotion;
        private Items _fearPotion;
        private Items _fartPotion;

        private Items _money;


        public void SwitchItems(Player player)
        {
            Continue();

            Items[] inventory = player.GetInventory();

            char input = ' ';
            //utilize Length, one more entry then what is actually in the array
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].itemName + "\n Damage: " + inventory[i].itemBoost);
            }
            Console.Write("> ");
            input = Console.ReadKey().KeyChar;

            switch (input)
            {
                case '1':
                    {
                        player.EquipItem(0);
                        Console.WriteLine("\nYou equiped " + player.GetInventory()[0].itemName);
                        Console.WriteLine("Main damage increased by " + player.GetInventory()[0].itemBoost);
                        break;
                    }
                case '2':
                    {
                        player.EquipItem(1);
                        Console.WriteLine("\nYou equiped " + player.GetInventory()[1].itemName);
                        Console.WriteLine("Main damage increased by " + player.GetInventory()[1].itemBoost);
                        break;
                    }
                case '3':
                    {
                        
                        break;
                    }
                case '4':
                    {
                        
                        break;
                    }
                case '5':
                    {
                        
                        break;
                    }
                default:
                    {
                        player.UnequipItem();
                        Console.WriteLine("You accidently dropped your item! \nHow unfortunate!");
                        break;
                    }
            }
        }


        public void StartStory()
        {
            while (_gameOver = true)
            {
                Console.WriteLine("Welcom to my shop, Player!");
                Shop();

                Battle();
            }

        }

        public void Shop()
        {
            char input;
            GetInput(out input, "Potions", "Weapons", "What would you like to purchase?");
            if (input == '1')
            {
                BuyPotions();
            }
            if (input == '2')
            {
                BuyWeapon();
            }
            return;
        }


        public void BuyWeapon()
        {
            PlayersStats();

            char input;
            GetInput(out input, "Long Sword: " + _longSword.itemPrice + " Gold", "Dagger: " + _dagger.itemPrice + " Gold", "Ax: " + _ax.itemPrice + " Gold", "Staff: " + _staff.itemPrice + " Gold", "Mace: " + _mace.itemPrice + " Gold", "Hammer: " + _hammer.itemPrice + " Gold", "Which weapon do you want?");
            //Long Sword
            if (input == '1' && _money.itemPrice >= _longSword.itemPrice)
            {
                _player.AddItemToInventory(_longSword, 0);
                _money.itemPrice -= _longSword.itemPrice;
                Console.WriteLine("You purchased Long Sword!");
            }
           //Dagger
            if (input == '2' && _money.itemPrice >= _dagger.itemPrice)
            {
                _player.AddItemToInventory(_dagger, 0);
                _money.itemPrice -= _longSword.itemPrice;
                Console.WriteLine("You purchased Dagger!");
            }
            //Ax
            if (input == '3' && _money.itemPrice >= _ax.itemPrice)
            {
                _player.AddItemToInventory(_ax, 0);
                _money.itemPrice -= _longSword.itemPrice;
                Console.WriteLine("You purchased Ax!");
            }
            //Staff
            if (input == '4' && _money.itemPrice >= _staff.itemPrice)
            {
                _player.AddItemToInventory(_staff, 0);
                _money.itemPrice -= _longSword.itemPrice;
                Console.WriteLine("You purchased Staff!");
            }
            //Mace
            if (input == '5' && _money.itemPrice >= _mace.itemPrice)
            {
                _player.AddItemToInventory(_mace, 0);
                _money.itemPrice -= _longSword.itemPrice;
                Console.WriteLine("You purchased Mace!");
            }
            //hammer
            if (input == '6' && _money.itemPrice >= _hammer.itemPrice)
            {
                _player.AddItemToInventory(_hammer, 0);
                _money.itemPrice -= _longSword.itemPrice;
                Console.WriteLine("You purchased Hammer!");
            }
            
            else
            {
                Console.WriteLine("Woops seems like you can't get the item you wanted!");
            }

            Continue();
            //again!
            PlayersStats();
            GetInput(out input, "Yes", "No", "Do you want another weapon? You can only have 2 weapons.");

            if (input == '1')
            {
                GetInput(out input, "Long Sword: " + _longSword.itemPrice + " Gold", "Dagger: " + _dagger.itemPrice + " Gold", "Ax: " + _ax.itemPrice + " Gold", "Staff: " + _staff.itemPrice + " Gold", "Mace: " + _mace.itemPrice + " Gold", "Hammer: " + _hammer.itemPrice + " Gold", "Which weapon do you want?");
                //Long Sword
                if (input == '1' && _money.itemPrice >= _longSword.itemPrice)
                {
                    _player.AddItemToInventory(_longSword, 1);
                    _money.itemPrice -= _longSword.itemPrice;
                    Console.WriteLine("You purchased Long Sword!");
                }
                //Dagger
                if (input == '2' && _money.itemPrice >= _dagger.itemPrice)
                {
                    _player.AddItemToInventory(_dagger, 1);
                    _money.itemPrice -= _longSword.itemPrice;
                    Console.WriteLine("You purchased Dagger!");
                }
                //Ax
                if (input == '3' && _money.itemPrice >= _ax.itemPrice)
                {
                    _player.AddItemToInventory(_ax, 1);
                    _money.itemPrice -= _longSword.itemPrice;
                    Console.WriteLine("You purchased Ax!");
                }
                //Staff
                if (input == '4' && _money.itemPrice >= _staff.itemPrice)
                {
                    _player.AddItemToInventory(_staff, 1);
                    _money.itemPrice -= _longSword.itemPrice;
                    Console.WriteLine("You purchased Staff!");
                }
                //Mace
                if (input == '5' && _money.itemPrice >= _mace.itemPrice)
                {
                    _player.AddItemToInventory(_mace, 1);
                    _money.itemPrice -= _longSword.itemPrice;
                    Console.WriteLine("You purchased Mace!");
                }
                //hammer
                if (input == '6' && _money.itemPrice >= _hammer.itemPrice)
                {
                    _player.AddItemToInventory(_hammer, 1);
                    _money.itemPrice -= _longSword.itemPrice;
                    Console.WriteLine("You purchased Hammer!");
                }

                else
                {
                    Console.WriteLine("Woops seems like you can't get the item you wanted!");
                }
            }
            if(input == '2')
            {
                Console.WriteLine("Thank you for comming to my shop!");
                return;
            }
            Continue();
        }

        public void BuyPotions()
        {
            char input;
            Continue();
            PlayersStats();
            GetInput(out input, "Fire Potion: 1 Gold", "Poison Potion: 2 Gold", "Fear Potion: 2 Gold", "Fart Potion: 5 Gold", "Which potion do you wish to buy?");
            if(input == '1' && _money.itemPrice >= 1)
            {
                _player.AddItemToInventory(_firePotion, 3);
                _money.itemPrice -= 1;
                Console.WriteLine("You purchased a Fire Potion!");
            }
            if (input == '2' && _money.itemPrice >= 2)
            {
                _player.AddItemToInventory(_poisonPotion, 3);
                _money.itemPrice -= 2;
                Console.WriteLine("You purchased a Poison Potion!");
            }
            if (input == '3' && _money.itemPrice >= 2)
            {
                _player.AddItemToInventory(_fearPotion, 3);
                _money.itemPrice -= 2;
                Console.WriteLine("You purchased a Fear Potion!");
            }
            if (input == '4' && _money.itemPrice >= 5)
            {
                _player.AddItemToInventory(_fartPotion, 3);
                _money.itemPrice -= 5;
                Console.WriteLine("You purchased a Fart Potion!");
            }
            else
            {
                Console.WriteLine("Oops! Seems like you can't get the potion you wanted!");
            }
            Continue();
            GetInput(out input, "Yes", "No", "Do you want another potion? You can only have 3 potions.");

            if (input == '1')
            {
                PlayersStats();
                GetInput(out input, "Long Sword: " + _longSword.itemPrice + " Gold", "Dagger: " + _dagger.itemPrice + " Gold", "Ax: " + _ax.itemPrice + " Gold", "Staff: " + _staff.itemPrice + " Gold", "Mace: " + _mace.itemPrice + " Gold", "Hammer: " + _hammer.itemPrice + " Gold", "Which weapon do you want?");
                GetInput(out input, "Fire Potion: 1 Gold", "Poison Potion: 2 Gold", "Fear Potion: 2 Gold", "Fart Potion: 5 Gold", "Which potion do you wish to buy?");
                if (input == '1' && _money.itemPrice >= 1)
                {
                    _player.AddItemToInventory(_firePotion, 4);
                    _money.itemPrice -= 1;
                    Console.WriteLine("You purchased a Fire Potion!");
                }
                if (input == '2' && _money.itemPrice >= 2)
                {
                    _player.AddItemToInventory(_poisonPotion, 4);
                    _money.itemPrice -= 2;
                    Console.WriteLine("You purchased a Poison Potion!");
                }
                if (input == '3' && _money.itemPrice >= 2)
                {
                    _player.AddItemToInventory(_fearPotion, 4);
                    _money.itemPrice -= 2;
                    Console.WriteLine("You purchased a Fear Potion!");
                }
                if (input == '4' && _money.itemPrice >= 5)
                {
                    _player.AddItemToInventory(_fartPotion, 4);
                    _money.itemPrice -= 5;
                    Console.WriteLine("You purchased a Fart Potion!");
                }
                else
                {
                    Console.WriteLine("Woops seems like you can't get the item you wanted!");
                }
                Continue();
                PlayersStats();
                GetInput(out input, "Yes", "No", "Do you want another potion? You can only have 3 potions.");
                
                if (input == '1')
                {
                    GetInput(out input, "Long Sword: " + _longSword.itemPrice + " Gold", "Dagger: " + _dagger.itemPrice + " Gold", "Ax: " + _ax.itemPrice + " Gold", "Staff: " + _staff.itemPrice + " Gold", "Mace: " + _mace.itemPrice + " Gold", "Hammer: " + _hammer.itemPrice + " Gold", "Which weapon do you want?");
                    GetInput(out input, "Fire Potion: 1 Gold", "Poison Potion: 2 Gold", "Fear Potion: 2 Gold", "Fart Potion: 5 Gold", "Which potion do you wish to buy?");
                    if (input == '1' && _money.itemPrice >= 1)
                    {
                        _player.AddItemToInventory(_firePotion, 5);
                        _money.itemPrice -= 1;
                        Console.WriteLine("You purchased a Fire Potion!");
                    }
                    if (input == '2' && _money.itemPrice >= 2)
                    {
                        _player.AddItemToInventory(_poisonPotion, 5);
                        _money.itemPrice -= 2;
                        Console.WriteLine("You purchased a Poison Potion!");
                    }
                    if (input == '3' && _money.itemPrice >= 2)
                    {
                        _player.AddItemToInventory(_fearPotion, 5);
                        _money.itemPrice -= 2;
                        Console.WriteLine("You purchased a Fear Potion!");
                    }
                    if (input == '4' && _money.itemPrice >= 5)
                    {
                        _player.AddItemToInventory(_fartPotion, 5);
                        _money.itemPrice -= 5;
                        Console.WriteLine("You purchased a Fart Potion!");
                    }
                    else
                    {
                        Console.WriteLine("Woops seems like you can't get the item you wanted!");
                    }
                }
                if (input == '2')
                {
                    Console.WriteLine("Thank you for comming to my shop!");
                    return;
                }
            }
            if (input == '2')
            {
                Console.WriteLine("Thank you for comming to my shop!");
                return;
            }
        }

        public Player CreateCharacter()
        {

            Player player = new Player(100, 10, 10, 5);
            return player;
        }

        public Player EnemyStats()
        {

            Player player = new Player(80, 20);
            return player;
        }

        public void Battle()
        {
            while (_player.GetIsAlive() && _player.EnemyAlive())
            {
                //prints player one and two's stat
                Console.WriteLine("Player");
                _player.PrintStats();

                char input;

                //Player One
                GetInput(out input, "Attack", "Peace", "Open Invatory", "\nPlayer one! What do you wish to do?");

                if (input == '1')
                {
                    _player.Attack(_enemy);
                }
                if (input == '2')
                {
                    Console.WriteLine("\nPlayer one went with a peaceful option! Hopefully the enemy feels the same!");

                }
                if (input == '3')
                {
                    SwitchItems(_player);
                }

                Continue();

                //eneimies attack!
            }


        }


        public void InitializeItems()
        {
            _longSword.itemBoost = 15;
            _longSword.itemName = "Long Sword";
            _longSword.itemPrice = 2;

            _dagger.itemBoost = 10;
            _dagger.itemName = "Dagger";
            _dagger.itemPrice = 1;

            _ax.itemBoost = 13;
            _ax.itemName = "Ax";
            _ax.itemPrice = 3;

            _staff.itemBoost = 14;
            _staff.itemName = "Staff";
            _staff.itemPrice = 2;

            _mace.itemBoost = 17;
            _mace.itemName = "Mace";
            _mace.itemPrice = 4;

            _hammer.itemBoost = 9;
            _hammer.itemName = "Hammer";
            _hammer.itemPrice = 1;

            //items
            _money.itemPrice = 10;

            //potions
            _firePotion.itemPrice = 1;
            _firePotion.itemName = "Fire Potion";
            _firePotion.itemBoost = 10;

            _poisonPotion.itemPrice = 2;
            _poisonPotion.itemName = "Poison Potion";
            _poisonPotion.itemBoost = 20;

            _fearPotion.itemPrice = 2;
            _fearPotion.itemName = "Fear Potion";
            _fearPotion.itemBoost = 10;

            _fartPotion.itemPrice = 5;
            _fartPotion.itemName = "Fart Potion";
            _fartPotion.itemBoost = 100;

        }




        bool _gameOver = false;
        private Player _player;
        private Player _enemy;

        //Run the game
        public void Run()
        {
            Start();
            while (_gameOver == false)
            {
                Update();
            }
            End();
        }

        //Performed once when the game begins
        public void Start()
        {
            InitializeItems();
        }

        //Repeated until the game ends
        public void Update()
        {
            _player = CreateCharacter();
            _enemy = EnemyStats();
            StartStory();
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
