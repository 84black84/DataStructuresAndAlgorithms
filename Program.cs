namespace DataStructuresAndAlgorithms
{
    using DemoCodingAssessment;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            CheckIfOrderWins();
        }

        public static void GetSuggestions()
        {
            TextWriter textWriter = new StreamWriter("C:\\Tempo\\note.txt", true);

            //int repositoryCount = Convert.ToInt32(Console.ReadLine()?.Trim());

            //List<string> repository = new List<string>();

            //for (int i = 0; i < repositoryCount; i++)
            //{
            //    string repositoryItem = Console.ReadLine();
            //    repository.Add(repositoryItem);
            //}

            //string customerQuery = Console.ReadLine();
            List<string> repository = new() { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            List<string> customerQueries = new List<string> { "mo", "mou", "mous", "mouse" };

            List<List<string>> result = new List<List<string>>();
            var customerReviews = new CustomerReviews();
            foreach (string customerQuery in customerQueries)
            {
                List<string> resultPerTime = customerReviews.SearchSuggestions(repository, customerQuery);
                result.Add(resultPerTime);
            }

            textWriter.WriteLine(string.Join("\n", result.Select(list => string.Join(" ", list))));
            textWriter.Flush();
            textWriter.Close();
        }

        public static void CheckIfOrderWins()
        {
            /*
             * First test data - Working
             * List<string> codeList = new List<string> { "apple apple", "banana anything banana" };
             * List<string> shoppingCart = new List<string> { "orange", "apple", "apple", "banana", "orange", "banana" };
             */

            /*
             * Second test data - Not Working
             * List<string> codeList = new List<string> { "apple apple", "banana anything banana" };
             * List<string> shoppingCart = new List<string> { "banana", "orange", "banana", "apple", "apple" };
             */

            /*
             * Third test data - Not Working
             * List<string> codeList = new List<string> { "apple apple", "banana anything banana" };
             * List<string> shoppingCart = new List<string> {"apple", "banana", "apple", "banana", "orange", "banana" };
             */

            /*
             * Fourth test data - Not Working
             * List<string> codeList = new List<string> { "apple apple", "apple apple banana" };
             * List<string> shoppingCart = new List<string> {"apple", "apple", "apple", "banana" };
             */

            List<string> codeList = new List<string> { "apple apple", "banana anything banana" };
            List<string> shoppingCart = new List<string> { "orange", "apple", "apple", "banana", "orange", "banana" };

            var codePromo = new CodePromo();
            int result = codePromo.WeHaveWinner(codeList, shoppingCart);

            TextWriter textWriter = new StreamWriter("C:\\Tempo\\note.txt", true);
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }

    }
}
