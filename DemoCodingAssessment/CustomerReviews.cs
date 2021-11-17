namespace DataStructuresAndAlgorithms.DemoCodingAssessment
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Question 1 ( number one)
    /// </summary>
    public class CustomerReviews
    {
        public void GetSuggestions()
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
            foreach (string customerQuery in customerQueries)
            {
                List<string> resultPerTime = this.SearchSuggestions(repository, customerQuery);
                result.Add(resultPerTime);
            }

            textWriter.WriteLine(string.Join("\n", result.Select(list => string.Join(" ", list))));
            textWriter.Flush();
            textWriter.Close();
        }

        private List<string> SearchSuggestions(List<string> repository, string customerQuery)
        {
            List<string> suggestionList = new List<string>();
            if (string.IsNullOrWhiteSpace(customerQuery) || customerQuery.Length < 2)
            {
                return new List<string>();
            }

            string[] repositoryArray = repository.ToArray();

            int counter = 0;
            for (int i = 0; i < repositoryArray.Length; i++)
            {
                string repositoryItem = repositoryArray[i];
                if (customerQuery.Length == repositoryItem.Length)
                {
                    if (string.Equals(repositoryItem, customerQuery, StringComparison.CurrentCultureIgnoreCase))
                    {
                        suggestionList.Add(repositoryItem);
                        counter++;
                    }
                }
                else if (customerQuery.Length < repositoryItem.Length)
                {
                    if (repositoryItem.StartsWith(customerQuery, true, CultureInfo.CurrentCulture))
                    {
                        suggestionList.Add(repositoryItem);
                        counter++;
                    }
                }

                if (counter >= 3)
                {
                    break;
                }
            }

            return suggestionList;
        }
    }
}
