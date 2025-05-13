namespace SeriesAnalyzer
{
    class Program
    {

        static void Main(string[] args)
        {

            List<int> seriesList = new List<int>();
            if (validationInput(args))
            {
                seriesList = ConvertFromStringToIntList(args);
            }
            else
            {
                seriesList = inputSeries();
            }

            // Display the menu
            void showMenu()
            {
                Console.WriteLine("/************************************/");
                Console.WriteLine("Welcome to the Series Analyzer");
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("a. Enter a series of numbers");
                Console.WriteLine("b. Display the series");
                Console.WriteLine("c. Display the series in reverse");
                Console.WriteLine("d. Display the series sorted");
                Console.WriteLine("e. Display the maximum number");
                Console.WriteLine("f. Display the minimum number");
                Console.WriteLine("g. Display the average");
                Console.WriteLine("h. Display the number of elements");
                Console.WriteLine("i. Display the sum");
                Console.WriteLine("j. Exit");
                Console.WriteLine("\n /************************************/");
            }

            // Convert string array to list of integers
            List<int> ConvertFromStringToIntList(string[] inputNumbers)
            {
                List<int> seriesList = new List<int>();
                foreach (string number in inputNumbers)
                {
                    int num = int.Parse(number);
                    seriesList.Add(num);
                }
                return seriesList;
            }

            // Validate input
            bool validationInput(string [] inputNumbers)
            {
                if (inputNumbers.Length < 3)
                {
                    Console.WriteLine("Please enter at least 3 numbers.");
                    return false;
                }
                foreach (string number in inputNumbers)
                {
                    if (!int.TryParse(number, out int numberInt) )
                    {
                        Console.WriteLine($"Invalid input: {number} is not a number.");
                        return false;
                    } 
                    else if (numberInt < 0)
                    {
                        Console.WriteLine($"Invalid input: {number} is a negative number.");
                        return false;
                    }

                }
                return true;
            }

            // input series and validate and return the list numbers
            // if the input is not valid, it will ask for input again
            List<int> inputSeries()
            {
                Console.Write("Enter a series of numbers separated by spaces (3 or more): ");
                string inputNumbers = Console.ReadLine()!;
                string[] inputNumbersArras = inputNumbers.Split();

                // Check if the input is valid
                // if the input is not valid, it will ask for input again
                if (validationInput(inputNumbersArras))
                {
                    return ConvertFromStringToIntList(inputNumbersArras);
                }
                Console.WriteLine("Enter a valid number: ");
                return inputSeries();
            }

            // Display the series list
            void displaySeriesList(List<int> seriesList)
            {
                foreach (int num in seriesList)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            // Convert the list to reverse and return the list
            List<int> convertListToReverse(List<int> seriesList)
            {
                List<int> seriesListRevers = new List<int>();
                int lengthList = SeriesNumberElements(seriesList);
                for (int i = lengthList - 1; i >= 0; i--)
                {
                    seriesListRevers.Add(seriesList[i]);
                }
                return seriesListRevers;
            }

            // Sort the list and return the list
            List<int> SeriesSorted(List<int> seriesList)
            {
                List<int> seriesListSorted = new List<int>(seriesList);
                int lengthList = SeriesNumberElements(seriesList);
                for (int i = 0; i < lengthList - 1; i++)
                {
                    for (int j = 0; j < lengthList - i - 1; j++)
                    {
                        if (seriesListSorted[j] > seriesListSorted[j + 1])
                        {
                            int temp = seriesListSorted[j];
                            seriesListSorted[j] = seriesListSorted[j + 1];
                            seriesListSorted[j + 1] = temp;
                        }
                    }
                }
                return seriesListSorted;
            }

            // Calculate the max number in the list and return the number
            int SeriesMax(List<int> seriesList)
            {
                int max = 0;
                foreach (int num in seriesList)
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
                return max;
            }

            // Calculate the min number in the list and return the number
            int SeriesMin(List<int> seriesList)
            {
                int min = seriesList[0];
                foreach (int num in seriesList)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }
                return min;
            }

            // Calculate the average of the list and return the number           
            float SeriesAverage(List<int> seriesList)
            {
                int NumElements = SeriesNumberElements(seriesList);
                int sum = calculateSumSeries(seriesList);
                float average = (float)sum / NumElements;

                return average;
            }

            // Calculate the number of elements in the list and return the number
            int SeriesNumberElements(List<int> seriesList)
            {
                int numElements = 0;
                foreach (int num in seriesList)
                {
                    numElements += 1;
                }
                return numElements;
            }

            // Calculate the sum of the list and return the number
            int calculateSumSeries(List<int> seriesList)
            {
                int sum = 0;
                foreach (int num in seriesList)
                {
                    sum += num;
                }
                return sum;
            }

            // Display the menu and get the user choice
            bool Menu()
            {
                showMenu();
                string choice = Console.ReadLine()!.ToLower();
                switch (choice)
                {
                    case "a":
                        seriesList = inputSeries();
                        break;
                    case "b":
                        displaySeriesList(seriesList);
                        break;
                    case "c":
                        List<int> reversList = convertListToReverse(seriesList);
                        displaySeriesList(reversList);
                        break;
                    case "d":
                        List<int> seriesListSort = SeriesSorted(seriesList);
                        displaySeriesList(seriesListSort);
                        break;
                    case "e":
                        int max = SeriesMax(seriesList);
                        Console.WriteLine($"Max number: {max}");
                        break;
                    case "f":
                        int min = SeriesMin(seriesList);
                        Console.WriteLine($"Min number: {min}");
                        break;
                    case "g":
                        float average = SeriesAverage(seriesList);
                        Console.WriteLine($"Average number: {average}");
                        break;
                    case "h":
                        int numElements = SeriesNumberElements(seriesList);
                        Console.WriteLine($"Number of elements: {numElements}");
                        break;
                    case "i":
                        int sum = calculateSumSeries(seriesList);
                        Console.WriteLine($"Sum of series: {sum}");
                        break;
                    case "j":
                        Console.WriteLine("Exiting...");
                        return true;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
                return false;
            }

            // Display the menu and loop until the user chooses to exit
            void displayLoopMenu()
            {
                bool exit;
                do
                {
                    exit = Menu();
                }
                while (!exit);
            }
            // Call the display loop menu function
            // to display the menu and get the user choice
            displayLoopMenu();
        }
    }
}