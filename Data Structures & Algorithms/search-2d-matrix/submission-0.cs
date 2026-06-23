public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int temp = 0;
        for(int i = temp; i < matrix.Length; i++)
        {
            //Console.WriteLine(matrix[i][matrix[i].Length - 1]);
            if ((matrix[i][matrix[i].Length - 1]) < target)
            {
                temp++;
            }
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == target)
                    {
                        Console.WriteLine(matrix[i][j]);
                        return true;

                    }
                }
            }
        }
        return false;

    }
}
