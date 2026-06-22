public class Solution {
    public int MaxProfit(int[] prices) {
        Console.WriteLine(prices);
        int maximumProfit = 0;
        int minPrice = prices[0];
        int profitIfSoldToday = 0;
        for(int i = 0; i < prices.Length; i++){
            Console.WriteLine(prices[i]+" "+minPrice);
            if(prices[i] < minPrice) {
                minPrice = prices[i];
            }
            profitIfSoldToday = prices[i] - minPrice;

            if(profitIfSoldToday > maximumProfit){
                maximumProfit = profitIfSoldToday;
            }
        }
        return maximumProfit;
    }
}
