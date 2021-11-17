namespace DataStructuresAndAlgorithms.DemoCodingAssessment
{
    using System.Collections.Generic;

    public class CodePromo
    {
        private const string JokerString = "anything";

        /// <summary>
        /// The function is expected to return an INTEGER.
        /// The function accepts following parameters:
        ///     1. STRING_ARRAY codeList
        ///     2. STRING_ARRAY shoppingCart
        /// </summary>
        /// <param name="codeList"></param>
        /// <param name="shoppingCart"></param>
        /// <returns></returns>
        public int WeHaveWinner(List<string> codeList, List<string> shoppingCart)
        {
            int matched = 0;
            int startPosition = 0;
            string[] shoppingCartArray = shoppingCart.ToArray();
            int shoppingCartLength = shoppingCart.Count;
            foreach (string item in codeList)
            {
                string[] listOfCodesItem = item.Split(" ");
                int listOfCodesItemLength = listOfCodesItem.Length;
                int finishPosition = startPosition + listOfCodesItemLength - 1;
                int jokerStringPosition = GetJokerStringPosition(listOfCodesItem, listOfCodesItemLength);
                bool found = false;
                while (!found && finishPosition < shoppingCartLength)
                {
                    string shoppingCartCurrentSelection = this.GetShoppingCartSelection(shoppingCartArray, startPosition, finishPosition, startPosition + jokerStringPosition);
                    if (shoppingCartCurrentSelection.ToLower() != item.ToLower())
                    {
                        startPosition++;
                        finishPosition++;
                        continue;
                    }

                    matched++;
                    if (matched == codeList.Count)
                    {
                        return 1; // winner
                    }

                    found = true;
                    startPosition = finishPosition + 1;
                }
            }

            return 0; // not a winner
        }

        private int GetJokerStringPosition(string[] listOfCodesItem, int listOfCodesItemLength)
        {
            var jokerStringPosition = -1;
            for (var i = 0; i < listOfCodesItemLength; i++)
            {
                if (listOfCodesItem[i] == JokerString)
                {
                    return i;
                }
            }

            return jokerStringPosition;
        }

        /// <summary>
        /// Recursive solution might be more efficient
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <param name="startPosition"></param>
        /// <param name="finishPosition"></param>
        /// <param name="jokerStringPosition"></param>
        /// <returns></returns>
        private string GetShoppingCartSelection(string[] shoppingCart, int startPosition, int finishPosition, int jokerStringPosition)
        {
            string shoppingCartSelection = "";
            for (int i = startPosition; i <= finishPosition; i++)
            {
                shoppingCartSelection += i == jokerStringPosition 
                    ? JokerString 
                    : shoppingCart[i];
                
                if (i != finishPosition)
                {
                    shoppingCartSelection += " ";
                }
            }

            return shoppingCartSelection;
        }
    }
}
