using System;

namespace HomeWork5
{
    struct Interval
    {
        private Random random = new Random();
        public float Min { get; }
        public float Max { get; }
        public Interval(int minValue, int maxValue)
        {
            if (minValue < 0)
            {
                Console.WriteLine("Incorrect input: minimum value cannot be negative.");
                minValue = 0;
            }

            if (maxValue < 0)
            {
                Console.WriteLine("Incorrect input: maximum value cannot be negative.");
                maxValue = 0;
            }

            if (minValue > maxValue)
            {
                Console.WriteLine("Incorrect input: values were swapped.");

                int temp = minValue;
                minValue = maxValue;
                maxValue = temp;
            }

            if (minValue == maxValue)
            {
                Console.WriteLine("Incorrect input: maximum value was increased by 10.");
                maxValue += 10;
            }

            Min = minValue;
            Max = maxValue;
            random = new Random();
        }

        public float Get()
        {
            return (float)(Min + random.NextDouble() * (Max - Min));
        }
    }


    class Unit
    {
        private float health;
        public string Name { get; }
        public float Health
        {
            get { return health; }
        }

        public Interval Damage { get; }
        public float Armor { get; }
        public Unit(string name, int minDamage, int maxDamage)
        {
            Name = name;
            health = 100f;
            Damage = new Interval(minDamage, maxDamage);
            Armor = 0.6f;
        }

        public Unit() : this("Unknown Unit", 0, 5)
        {
        }

        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage(float value)
        {
            health = Health - value * Armor;
            return Health <= 0f;
        }

        public override string ToString()
        {
            return Name;
        }
    }


    struct Room
    {
        public Unit Unit;
        public Unit Weapon;
        public Room(Unit unit, Unit weapon)
        {
            Unit = unit;
            Weapon = weapon;
        }
    }


    class Dungeon
    {
        private Room[] rooms;
        public Dungeon()
        {
            rooms = new Room[]
            {
                new Room(
                    new Unit("Knight", 0, 10),
                    new Unit("Sword", 0, 20)
                ),

                new Room(
                    new Unit("Orc", 0, 15),
                    new Unit("Axe", 0, 25)
                ),

                new Room(
                    new Unit("Wizard", 0, 8),
                    new Unit("Staff", 0, 12)
                )
            };
        }

        public void ShowRooms()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                var room = rooms[i];

                Console.WriteLine("Unit of room: " + room.Unit);
                Console.WriteLine("Weapon of room: " + room.Weapon);
                Console.WriteLine("---");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Dungeon dungeon = new Dungeon();
            dungeon.ShowRooms();
        }
    }
}