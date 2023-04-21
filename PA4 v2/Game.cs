namespace PA4
{
    public class Game
    {
        private Character player1;
        private Character player2;

        public string Name { get; private set; }
        public int Health = 100;
        public object? MaxPower { get; private set; }
        public object AttackStrength { get; private set; }
        public object DefensivePower { get; private set; }

        public Game()
        {
            System.Console.WriteLine("Character Select: ");
            System.Console.WriteLine("1. Jack Sparrow");
            System.Console.WriteLine("2. Will Turner");
            System.Console.WriteLine("3. Davy Jones");
            System.Console.WriteLine("4. Jeff Lucas");

            int choice = int.Parse(Console.ReadLine());

            //player1 user
            switch (choice)
            {
                case 1:
                    player1 = new JackSparrow();
                    break;
                
                case 2:
                    player1 = new WillTurner();
                    break;

                case 3:
                    player1 = new DavyJones("Davy Jones");
                    break;

                case 4:
                    player1 = new JeffLucas();
                    break;

                default:
                    throw new ArgumentException("Invalid Choice");
            }

            //player2 computer
            Random randomchoice = new Random();
            choice = randomchoice.Next(1,5);

            switch (choice)
            {
                case 1:
                    player2 = new JackSparrow();
                    break;
                
                case 2:
                    player2 = new WillTurner();
                    break;

                case 3:
                    player2 = new DavyJones("Davy Jones");
                    break;

                case 4:
                    player2 = new JeffLucas();
                    break;
                
                default:
                    throw new ArgumentException("Invalid Choice");
            }
        }

        public void Play()
        {
            Random randomposition = new Random();
            int turn = randomposition.Next(2);

            if (turn == 0)
            {
                System.Console.WriteLine("You go first!");
                while (player1.Health > 0 && player2.Health > 0)
                {
                    System.Console.WriteLine("Your Turn:");
                    UserTurn();
                    if (player2.Health <= 0)
                    {
                        System.Console.WriteLine("You win!");
                        break;
                    }
                    System.Console.WriteLine();

                    System.Console.WriteLine("Computer's turn:");
                    ComputerTurn();
                    if (player1.Health <=0)
                    {
                        System.Console.WriteLine("Computer wins!");
                        break;
                    }
                    System.Console.WriteLine();
                }
            }

            else
            {
                System.Console.WriteLine("Computer goes first!");
                while (player1.Health > 0 && player2.Health > 0)
                {
                    System.Console.WriteLine("Computer's turn:");
                    ComputerTurn();
                    if (player1.Health <= 0)
                    {
                        System.Console.WriteLine("Computer Wins!");
                        break;
                    }
                    System.Console.WriteLine();

                    System.Console.WriteLine("Your turn:");
                    UserTurn();
                    if (player2.Health <= 0)
                    {
                        System.Console.WriteLine("You win!");
                        break;
                    }
                    System.Console.WriteLine();
                }
            }
        }

        private void UserTurn()
        {
            Console.WriteLine($"{player1.Name}, what do you want to do? (Enter 'A' to attack or 'D' to defend)");

            string input = Console.ReadLine();

            System.Console.WriteLine("Name: {0}\nHealth: {1}\nMax Power: {2}\nAttack Strength: {3}\nDefensive Power: {4}", Name, Health, MaxPower, AttackStrength, DefensivePower);

            if (input.ToLower() == "a")
            {
                player1.Attack(player2);
            }
            else if (input.ToLower() == "d")
            {
                player1.Defend();
            }
            else
            {
                Console.WriteLine("Invalid input, turn skipped.");
            }
        }

        private void ComputerTurn()
        {
            Random random = new Random();
            int choice = random.Next(2);

            System.Console.WriteLine("Name: {0}\nHealth: {1}\nMax Power: {2}\nAttack Strength: {3}\nDefensive Power: {4}", Name, Health, MaxPower, AttackStrength, DefensivePower);
        

            if (choice == 0)
            {
                Console.WriteLine($"{player2.Name} is attacking.");
                player2.Attack(player1);
            }
            else
            {
                Console.WriteLine($"{player2.Name} is defending.");
                player2.Defend();
            }
        }
    }
}