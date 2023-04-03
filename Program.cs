class program{

    static void Main(string[] args){
        List<double> numbers = new List<double>();
            string input = (Console.ReadLine());           
            
    while ((input = Console.ReadLine()) != "End")
        {
            double number;
            if (double.TryParse(input, out number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    
       while ((input = Console.ReadLine()) != "")
        {
            switch (input)
            {
                case "FindMax":
                    Console.WriteLine($"Maximum value: {numbers.Max()}");
                    break;

                case "FindMin":
                    Console.WriteLine($"Minimum value: {numbers.Min()}");
                    break;

                case "FindMean":
                    Console.WriteLine($"Mean value: {numbers.Average()}");
                    break;

                default:
                    Console.WriteLine("Invalid mode.");
                    break;
            }

        }
    }   
}