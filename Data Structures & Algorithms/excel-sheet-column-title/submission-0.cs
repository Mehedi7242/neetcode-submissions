public class Solution {
    public string ConvertToTitle(int columnNumber) {
        int baseNumber = 26;
        string result = "";

        while (columnNumber > 0){
            columnNumber --;

            int remainder = columnNumber % 26;
            Console.WriteLine(remainder);
            char currentLetter = (char)('A'+remainder);

            result = currentLetter + result;
            columnNumber =  columnNumber / 26;

        }
        return result;

    }
}