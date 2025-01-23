public class Atoi {
    public static int MyAtoi(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        bool isPositive = true;
        var input = s.Trim();
        var chars = input.ToCharArray();
        if (chars == null || chars.Length == 0) return 0;
        int startindex = 0;
        int length = 0;
        if (chars[0] == '-' || chars[0] == '+') {
            startindex = 1;
            if (chars[0] == '-') isPositive = false;
        }
        for(int i = startindex;i < chars.Length;i++) {
            char c = chars[i];
            if (!char.IsDigit(c)) {
                break;
            } else {
                length++;
            }
        }
        var intstring = input.Substring(startindex, length);
        try{
            if (string.IsNullOrEmpty(intstring)) return 0;
            var value = Convert.ToInt32(intstring);
            if (!isPositive && value > 0) value = value * -1;
            return value;
        } catch(OverflowException) {
            if (isPositive) {
                return Int32.MaxValue;
            } else {
                return Int32.MinValue;
            }
        }
    }
}