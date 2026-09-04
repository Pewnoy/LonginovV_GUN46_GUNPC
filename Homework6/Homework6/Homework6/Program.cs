namespace HomeWork6
{
    internal class Program
    {
        // Задание 1
        private class ListTask
        {
            private readonly List<string> _list = new List<string>();
            public void TaskLoop()
            {
                _list.Add("Apple");
                _list.Add("Banana");
                _list.Add("Orange");

                Console.WriteLine("Enter a new string or -exit to quit:");

                string? input = Console.ReadLine();

                if (input == "-exit")
                {
                    return;
                }

                if (input != null)
                {
                    _list.Add(input);
                }

                Console.WriteLine("List:");

                foreach (string item in _list)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("Enter another string to insert in the middle or -exit to quit:");

                input = Console.ReadLine();

                if (input == "-exit")
                {
                    return;
                }

                if (input != null)
                {
                    int middle = _list.Count / 2;
                    _list.Insert(middle, input);
                }

                Console.WriteLine("Final list:");

                foreach (string item in _list)
                {
                    Console.WriteLine(item);
                }
            }
        }

        // Задание 2
        private class DictionaryTask
        {
            private readonly Dictionary<string, int> _students = new Dictionary<string, int>();
            public void TaskLoop()
            {
                Console.WriteLine("Enter student name or -exit to stop:");
                while (true)
                {
                    string? name = Console.ReadLine();
                    if (name == "-exit")
                    {
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("Name cannot be empty.");
                        continue;
                    }

                    Console.WriteLine("Enter grade (2-5):");
                    if (!int.TryParse(Console.ReadLine(), out int grade))
                    {
                        Console.WriteLine("Invalid grade.");
                        continue;
                    }

                    if (grade < 2 || grade > 5)
                    {
                        Console.WriteLine("Grade must be between 2 and 5.");
                        continue;
                    }

                    _students[name] = grade;
                    Console.WriteLine("Student added.");
                    Console.WriteLine("Enter another student name or -exit to search:");
                    break;
                }

                Console.WriteLine("Enter student name to find or -exit to quit:");

                string? searchName = Console.ReadLine();

                if (searchName == "-exit")
                {
                    return;
                }
                if (searchName == null)
                {
                    Console.WriteLine("Name cannot be empty");
                    return;
                }

                if (_students.TryGetValue(searchName, out int studentGrade))
                {
                    Console.WriteLine("Grade: " + studentGrade);
                }
                else
                {
                    Console.WriteLine("Student with this name does not exist.");
                }
            }
        }

        // Задание 3
        private class LinkedListTask
        {
            private class Node
            {
                public int Value;
                public Node? Next;
                public Node? Previous;

                public Node(int value)
                {
                    Value = value;
                }
            }
            public void TaskLoop()
            {
                Console.WriteLine("Enter number of elements (3-6) or -exit:");

                if (!int.TryParse(Console.ReadLine(), out int count))
                {
                    Console.WriteLine("Invalid number.");
                    return;
                }

                if (count < 3 || count > 6)
                {
                    Console.WriteLine("Number of elements must be from 3 to 6.");
                    return;
                }

                Node? head = null;
                Node? tail = null;
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("Enter element " + (i + 1) + ":");

                    string? input = Console.ReadLine();

                    if (input == "-exit")
                    {
                        return;
                    }

                    if (!int.TryParse(input, out int value))
                    {
                        Console.WriteLine("Invalid number.");
                        i--;
                        continue;
                    }


                    Node newNode = new Node(value);

                    if (head == null)
                    {
                        head = newNode;
                        tail = newNode;
                    }
                    else
                    {
                        newNode.Previous = tail;
                        tail!.Next = newNode;
                        tail = newNode;
                    }
                }

                Console.WriteLine("Forward:");
                Node? current = head;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }

                Console.WriteLine();
                Console.WriteLine("Backward:");

                current = tail;

                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Previous;
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1, 2 or 3 to select a task:");

            if (!int.TryParse(Console.ReadLine(), out int task))
            {
                Console.WriteLine("Invalid task number.");
                return;
            }

            switch (task)
            {
                case 1:
                    CheckTaskFirst();
                    break;

                case 2:
                    CheckTaskSecond();
                    break;

                case 3:
                    CheckTaskThird();
                    break;

                default:
                    Console.WriteLine("Wrong task number.");
                    break;
            }
        }
        private static void CheckTaskFirst()
        {
            var listTask = new ListTask();
            listTask.TaskLoop();
        }
        private static void CheckTaskSecond()
        {
            var dictionaryTask = new DictionaryTask();
            dictionaryTask.TaskLoop();
        }
        private static void CheckTaskThird()
        {
            var linkedListTask = new LinkedListTask();
            linkedListTask.TaskLoop();
        }
    }
}