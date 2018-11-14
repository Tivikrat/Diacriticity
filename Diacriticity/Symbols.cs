using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diacriticity
{
    class Symbols
    {
        static Dictionary<char, string> symbols = new Dictionary<char, string>();
        static void SetSymbols()
        {
            symbols.Add('a', "aăąªäåæāàáâã");
            symbols.Add('b', "b");
            symbols.Add('c', "cčĉçćċ");
            symbols.Add('d', "dðďđ");
            symbols.Add('e', "eėēĕęěéèêë");
            symbols.Add('f', "f");
            symbols.Add('g', "gġĝğģ");
            symbols.Add('h', "hĥ");
            symbols.Add('i', "iįıĭīïĩîíì");
            symbols.Add('j', "jĵ");
            symbols.Add('k', "kķĸ");
            symbols.Add('l', "lłŀľļĺ");
            symbols.Add('m', "m");
            symbols.Add('n', "nŋňŉņñń");
            symbols.Add('o', "oºœőŏōøöõôóò");
            symbols.Add('p', "p");
            symbols.Add('q', "q");
            symbols.Add('r', "rŗŕř");
            symbols.Add('s', "sſşšŝßś");
            symbols.Add('t', "tŧţþť");
            symbols.Add('u', "uųůűūüũŭúùû");
            symbols.Add('v', "v");
            symbols.Add('w', "wŵ");
            symbols.Add('x', "x");
            symbols.Add('y', "yŷýÿ");
            symbols.Add('z', "zžźż");
            symbols.Add('A', "AĂĄÄÅÆĀÀÁÂÃ");
            symbols.Add('B', "B");
            symbols.Add('C', "CČĈÇĆĊ");
            symbols.Add('D', "DÐĎĐ");
            symbols.Add('E', "EĖĒĔĘĚÉÈÊË");
            symbols.Add('F', "F");
            symbols.Add('G', "GĠĜĞĢ");
            symbols.Add('H', "HĤ");
            symbols.Add('I', "IĮĬĪÏĨÎÍÌ");
            symbols.Add('J', "JĴ");
            symbols.Add('K', "KĶ");
            symbols.Add('L', "LŁĿĽĻĹ");
            symbols.Add('M', "M");
            symbols.Add('N', "NŊŇŅÑŃ");
            symbols.Add('O', "OŒŐŎŌØÖÕÔÓÒ");
            symbols.Add('P', "P");
            symbols.Add('Q', "Q");
            symbols.Add('R', "RŖŔŘ");
            symbols.Add('S', "SŞŠŜẞŚ");
            symbols.Add('T', "TŦŢÞŤ");
            symbols.Add('U', "UŲŮŰŪÜŨŬÚÙÛ");
            symbols.Add('V', "V");
            symbols.Add('W', "WŴ");
            symbols.Add('X', "X");
            symbols.Add('Y', "YŶÝŸ");
            symbols.Add('Z', "ZŽŹŻ");
        }
    }
}
