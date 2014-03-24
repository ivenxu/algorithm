using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm {
    public class BigNumber {
        private bool IsOdd(string s) {
            if (String.IsNullOrEmpty(s)) return false;
            return IsOdd(s.Last<char>());
        }
        private bool IsOdd(char c) {
            return (c - '0') % 2 == 1;
        }
        public string LongMultiple(string s1, string s2) {
            s1 = Reverse(s1);
            s2 = Reverse(s2);
            var n1 = s1.Length; 
            var n2 = s2.Length;
            var alignedN = Math.Max(n1, n2);
            s1.PadLeft(alignedN, '0'); 
            s2.PadLeft(alignedN, '0');
            var ret = string.Empty.PadLeft(2*alignedN, '0');
            var retArray = ret.ToCharArray();

            int x = 0;
            for (int i = 0; i < 2 * alignedN; i++) {
                for (int j = Math.Max(0, i + 1 - alignedN); j <= Math.Min(i, alignedN - 1); j++) {
                    var k = i - j;
                    x = x + (s1[j] - '0') * (s2[k] - '0');
                    retArray[i] = (char)((x % 10) + '0');
                }
                x = x/10;
            }

            ret = new String(retArray);
            return Reverse(ret).TrimStart('0');
        }
        public string PeasantMultiple(string s1, string s2) {
            var ret = "0";
            while (s1 != "0") {
                if (IsOdd(s1)) {
                    ret = Add(ret, s2);
                }
                s1 = DivideByTwo(s1);
                s2 = MultipleTwo(s2);
            }
            return ret;
        }

        public string MultipleTwo(string s) {
            var ret = string.Empty;
            s = Reverse(s);
            var carry = 0;
            foreach (var c in s.ToCharArray()) {
                var doubleC = (c - '0') * 2 ;
                var sum = doubleC + carry;
                carry = sum / 10;
                var remainder = sum % 10;
                ret = remainder + ret;
            }
            if (carry > 0) ret = carry + ret;
            return ret.TrimStart('0');
        }
        private string Reverse(string s) {
            return new String(s.Reverse().ToArray());
        }
        public string Add(string s1, string s2) {
            var ret = string.Empty;
            var maxLen = Math.Max(s1.Length, s2.Length);
            int carryNumber = 0;

            for (int i = 0; i < maxLen; i++) {
                int c1 = i >= s1.Length ? 0 : s1[s1.Length - 1 - i] - '0';
                int c2 = i >= s2.Length ? 0 : s2[s2.Length - 1 - i] - '0' ;
                int sum = c1 + c2 + carryNumber;
                if (sum >= 10) {
                    sum = sum - 10;
                    carryNumber = 1;
                } else {
                    carryNumber = 0;
                }

                ret = sum + ret;
            }

            if (carryNumber > 0) ret = carryNumber + ret;

            return ret;
        }
        public string DivideByTwo(string s) {
            var newS = string.Empty;
            var nextAdditive = 0;
            foreach (var c in s) {
                var additive = nextAdditive;
                if (IsOdd(c)) {
                    nextAdditive = 5;
                } else {
                    nextAdditive = 0;
                }

                char newC = (char)((c - '0') / 2 + additive + '0');
                newS += newC.ToString();
            }

            return newS.Length > 1 ? newS.TrimStart('0') : newS;
        }

        public List<byte> Encode(string s) {
            var ret = new List<byte> { {0} };
            if (s == "0") return ret;
            var count = 0;

            while (s != "0" && !string.IsNullOrEmpty(s)) {
                count++;
                var arrayIndex = count / BYTE_LEN;
                if (arrayIndex > ret.Count - 1) {
                    ret.Add(0);
                }
                var currentByte = ret[arrayIndex];
                var byteIndex = (count - 1) % BYTE_LEN;
                byte b = (byte) (1 << byteIndex);
                if (IsOdd(s)) {
                    currentByte = (byte)(currentByte | b);
                    ret[arrayIndex] = currentByte;
                } 
                s = DivideByTwo(s);
            }

            return ret;
        }

        public string Decode(List<byte> bytes) {
            string ret = "0";

            for (int j = 0; j<bytes.Count; j++) {
                var b = bytes[j];
                var sum = 0;
                for (int i = 0; i < BYTE_LEN; i++) {
                    sum += (POTENCY[i] & b) * 1 << (i + j*BYTE_LEN);               
                }
                ret = Add(ret, sum.ToString());
            }

            return ret;
        }

        public void PrintByteArray(List<byte> byteArray) {
            foreach (var b in byteArray) {
                Console.WriteLine(Convert.ToString(b, 2));
            }
        }

        private const int BYTE_LEN = 8;
        private static readonly byte[] POTENCY = { 0x1, 0x2, 0x4, 0x8, 0x10, 0x20, 0x40, 0x80};
    }
}
