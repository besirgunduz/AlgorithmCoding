namespace AlgorithmCoding
{
    public class ExcelSheetColumnNumber
    {
        public static int TitleToNumber(string s)
        {
            //Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number.

            //Input: columnTitle = "AB"
            //Output: 28

            //Input: columnTitle = "ZY"
            //Output: 701

            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result = result * 26 + (s[i] - 'A' + 1);
            }
            return result;
        }
    }
}
