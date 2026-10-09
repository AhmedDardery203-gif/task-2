namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> ahmed = new List<int>();
            char x ;
            do
            {
                Console.WriteLine("Menu options");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("Q - Quit");
                Console.Write("Enter your choice: ");

                x = char.ToUpper(Console.ReadLine()[0]);

                switch (x)
            {
                case 'P':
                        if (ahmed.Count == 0)
                            Console.WriteLine("[] - the list is empty");
                        else
                            Console.WriteLine("[" + string.Join(" ", ahmed) + "]");
                        break;

                    case 'A':
                        Console.Write("Enter a number: ");
                        ahmed.Add(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 'M':
                        if (ahmed.Count == 0)
                        {
                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                            int sum = 0;
                            for (int i = 0; i < ahmed.Count; i++)
                            {
                                sum += ahmed[i];
                            }
                            Console.WriteLine(sum / ahmed.Count);
                        }
                        break;
                    case 'S':
                        if (ahmed.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        else
                        {
                            int min = ahmed[0];
                            for (int i = 1; i < ahmed.Count; i++)
                            {
                                if (ahmed[i] < min)
                                {
                                    min = ahmed[i];
                                }
                            }
                            Console.WriteLine(min);
                        }
                        break;
                    case 'L':
                        if (ahmed.Count == 0)
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        else
                        {
                            int max = ahmed[0];
                            for (int i = 1; i < ahmed.Count; i++)
                            {
                                if (ahmed[i] > max)
                                {
                                    max = ahmed[i];
                                }
                            }
                            Console.WriteLine(max);
                        }
                        break;
                    case 'C':
                        ahmed.Clear();
                        break;
                    case 'Q':
                        return;
                        break;

            }

            } while (true);


        }
    }
}
