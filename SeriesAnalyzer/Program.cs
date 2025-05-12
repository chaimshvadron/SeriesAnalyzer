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

            void inputSeries()
            {
                Console.Write("Enter at least 3 numbers: ");
                string inputNumbers = Console.ReadLine()!;

                // validation input
                // convert to seriesList int
                
                
            }

            void displaySeriesList(List<int> seriesList)
            {
                foreach (int num in seriesList)
                {
                    Console.Write(num);
                }
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