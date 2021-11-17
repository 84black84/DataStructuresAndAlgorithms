namespace DataStructuresAndAlgorithms.DemoCodingAssessment
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    /// <summary>
    /// Question 1 ( number one)
    /// </summary>
    public class CustomerReviews
    {
        public List<string> SearchSuggestions(List<string> repository, string customerQuery)
        {
            List<string> suggestionList = new List<string>();
            if (string.IsNullOrWhiteSpace(customerQuery) || customerQuery.Length < 2)
            {
                return new List<string>();
            }

            string[] repositoryArray = repository.ToArray();
            int repositoryArrayLength = repositoryArray.Length;
            int counter = 0;
            for (int i = 0; i < repositoryArrayLength; i++)
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
