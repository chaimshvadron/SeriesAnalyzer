namespace SeriesAnalyzer
{
    class Program()
    {
        static void Main(int[] args)
        {
            List<int> seriesList = new List<int>();

            
            void showMenu()
            {
                Console.WriteLine("Series Analyzer");
                Console.WriteLine("a. Input series");
                Console.WriteLine("b. Display series");
                Console.WriteLine("c. Display series in reverse");
                Console.WriteLine("d. Display series sorted");
                Console.WriteLine("e. Display max number");
                Console.WriteLine("f. Display min number");
                Console.WriteLine("g. Display average");
                Console.WriteLine("h. Display number of elements");
                Console.WriteLine("i. Display average");
                Console.WriteLine("j. Exit");
                Console.Write("Enter your choice: ");
            }


            List<int> convertFromStringTolistInt(string inputNumbers)
            {
                List<int> seriesList = new List<int>();
                string[] numbers = inputNumbers.Split(' ');
                foreach (string number in numbers)
                {
                    int num = int.Parse(number);
                    seriesList.Add(num);
                }
                return seriesList;
                
            }


            bool validationInput(string inputNumbers)
            {
                string[] numbers = inputNumbers.Split(' ');
                if (numbers.Length < 3)
                {
                    Console.WriteLine("Please enter at least 3 numbers.");
                    return false;
                }
                foreach (string number in numbers)
                {
                    if (!double.TryParse(number, out _))
                    {
                        Console.WriteLine($"Invalid input: {number} is not a number.");
                        return false;
                    }
                }
                return true;
            }


            void inputSeries()
            {
                Console.Write("Enter at least 3 numbers: ");
                string inputNumbers = Console.ReadLine()!;

                // validation input
                // convert to seriesList type int
                
                
            }

            void displaySeriesList(List<int> seriesList)
            {
                foreach (int num in seriesList)
                {
                    Console.Write(num);
                }
            }

            List<int> convertListToReverse(List<int> seriesList)
            {
                List<int> sriesListRevers = new List<int>();
                for (int i = seriesList.Count; i >= 0; i--)
                {
                    sriesListRevers.Add(seriesList[i]);
                }
                return sriesListRevers;
            }

            void Menu()
            {
                showMenu();
                string choice = Console.ReadLine()!.ToLower();
                switch (choice)
                {
                    case "a":
                        {
                            inputSeries();
                            break;
                        }
                    case "b":
                        {
                            displaySeriesList(seriesList);
                            break;
                        }
                    case "c":
                        {
                            // displaySeriesRevers
                            break;
                        }
                    case "d":
                        {
                            // displaySeriesSorted
                            break;
                        }
                    case "e":
                        {
                            // displaySeriesMax
                            break;
                        }
                    case "f":
                        {
                            // displaySeriesMin
                            break;
                        }
                    case "g":
                        {
                            // displaySeriesAverage
                            break;
                        }
                    case "h":
                        {
                            // displaySeriesNumberElements
                            break;
                        }
                    case "i":
                        {
                            // displaySeriesAverege
                            break;
                        }
                    case "j":
                        {
                            // exit
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("invalid choice");
                            break;
                            // displayMenu
                        }
                    void main()
                        {
                            Menu();
                        }
                }
            }
        }
    }
}