namespace SeriesAnalyzer
{
    class Program()
    {
        static void Main(string[] args)
        {
            List<string> inputSeries()
            {
                Console.Write("Enter at least 3 numbers: ");
                string inputNumbers = Console.ReadLine()!;

                // validation input
                List<string> seriesList = inputNumbers.Split("").ToList();
                return seriesList;
            }


            void Menu()
            {
                // show menu

                string choice = Console.ReadLine()!.ToLower();
                switch (choice)
                {
                    case "a":
                        {
                            // inputSeries
                            break;
                        }
                    case "b":
                        {
                            // displaySeries
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
                }
            }
        }
    }
}