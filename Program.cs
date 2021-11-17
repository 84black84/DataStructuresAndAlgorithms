using DataStructuresAndAlgorithms.DemoCodingAssessment;

namespace DataStructuresAndAlgorithms
{
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static void Main()
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
