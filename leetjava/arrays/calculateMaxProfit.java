package arrays;
public class calculateMaxProfit {
  public int maxProfit(int[] prices) {
      int maxProfit = 0;

      for (int i = 1; i < prices.length; i++) {
          if (prices[i] > prices[i - 1]) {
              maxProfit += prices[i] - prices[i - 1];
          }
      }

      return maxProfit;
  }
  public static void main(String[] args) {
    calculateMaxProfit profiter = new calculateMaxProfit();
      
      int[] prices = {7,1,5,3,6,4};
      
      int max = profiter.maxProfit(prices);
      
      System.out.println("Max Profit: " + max);
  }
}
