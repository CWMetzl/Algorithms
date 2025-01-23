public class Cipher {
  public static string RotationalCipher(String input, int rotationFactor) {
    const int alpha = 26;
    const int digits = 10;
    const int charAscii = 97;
    const int numAscii = 48;

    if (string.IsNullOrEmpty(input)) return string.Empty;
    if (rotationFactor == 0) return input;
    var chars = input.ToCharArray();
    var output = new char[input.Length];
    int pos = 0;
    foreach(char c in chars) {
      if (!char.IsLetterOrDigit(c)) {
        output[pos++] = c;
        continue;
      }
      if (char.IsNumber(c)) {
        int val = ((int)char.GetNumericValue(c) + rotationFactor) % digits;
        output[pos++] = (char)(val + numAscii);
      } else {
        bool isUpper = char.IsUpper(c);
        int offset = (int)char.ToLower(c);
        int newoffset = (((offset - charAscii) + rotationFactor) % alpha) + charAscii;
        output[pos++] = isUpper ? char.ToUpper((char)newoffset) : (char)newoffset;
      }
    }
    var result = new string(output);
    return result;
  }
}