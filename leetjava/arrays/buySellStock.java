package arrays;
class buySellStock {
  public int maxProfit(int[] prices) {
      int biggest = 0;
      int running = 0;
      int i = 0;
      while(i < prices.length) {
          int buyPrice = 0;
          boolean isFirst = true;
          for(int j = i;j < prices.length;j++) {
              if (isFirst) {
                buyPrice = prices[j];
                isFirst = false;
              } else {
                if ((prices[j] - buyPrice) > running) {
                  running = prices[j] - buyPrice;
                  if(running > biggest) {
                    biggest = running;
                  }
                }
              }
          }
          i++;
      }
      return biggest;
  }

  public int maxProfit2(int[] prices) {
    if (prices == null || prices.length == 0) {
        return 0;
    }
    
    int minPrice = Integer.MAX_VALUE;
    int maxProfit = 0;

    for (int price : prices) {
        if (price < minPrice) {
            minPrice = price;
        } else if (price - minPrice > maxProfit) {
            maxProfit = price - minPrice;
        }
    }

    return maxProfit;
}

    
  public static void main(String[] args) {
    buySellStock profiter = new buySellStock();
      
      int[] prices = {7,1,5,3,6,4};
      
      int max = profiter.maxProfit(prices);
      
      System.out.println("Max Profit: " + max);
  }
}
