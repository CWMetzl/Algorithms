public class Reverse {
    public static int MyReverse(int x) {
        var intchars = x.ToString().ToCharArray();
        try {
            int multiplier = 1;
            if (intchars != null && intchars.Length > 0 && (intchars[0] == '-' || intchars[0] == '+') ) {
                if (intchars[0] == '-') multiplier = -1;
                intchars = Math.Abs(x).ToString().ToCharArray();
            }
            if (intchars == null || intchars.Length == 0) return 0;
            Array.Reverse(intchars);
            var reversed = new string(intchars);
            var reversedInt = Convert.ToInt32(reversed);
            return reversedInt * multiplier;
        } catch (OverflowException) {
            return 0;
        }
    }
}