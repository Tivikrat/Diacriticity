using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diacriticity
{
    class Symbols
    {
        static public Dictionary<char, string> dictionary = new Dictionary<char, string>();
        static public Dictionary<char, string> symbols = new Dictionary<char, string>();
        static public void SetDictionary()
        {
            dictionary.Add('a', "aăąªäåæāàáâã");
            dictionary.Add('b', "b");
            dictionary.Add('c', "cčĉçćċ");
            dictionary.Add('d', "dðďđ");
            dictionary.Add('e', "eėēĕęěéèêë");
            dictionary.Add('f', "f");
            dictionary.Add('g', "gġĝğģ");
            dictionary.Add('h', "hĥ");
            dictionary.Add('i', "iįıĭīïĩîíì");
            dictionary.Add('j', "jĵ");
            dictionary.Add('k', "kķĸ");
            dictionary.Add('l', "lłŀľļĺ");
            dictionary.Add('m', "m");
            dictionary.Add('n', "nŋňŉņñń");
            dictionary.Add('o', "oºœőŏōøöõôóò");
            dictionary.Add('p', "p");
            dictionary.Add('q', "q");
            dictionary.Add('r', "rŗŕř");
            dictionary.Add('s', "sſşšŝßś");
            dictionary.Add('t', "tŧţþť");
            dictionary.Add('u', "uųůűūüũŭúùû");
            dictionary.Add('v', "v");
            dictionary.Add('w', "wŵ");
            dictionary.Add('x', "x");
            dictionary.Add('y', "yŷýÿ");
            dictionary.Add('z', "zžźż");
            dictionary.Add('A', "AĂĄÄÅÆĀÀÁÂÃ");
            dictionary.Add('B', "B");
            dictionary.Add('C', "CČĈÇĆĊ");
            dictionary.Add('D', "DÐĎĐ");
            dictionary.Add('E', "EĖĒĔĘĚÉÈÊË");
            dictionary.Add('F', "F");
            dictionary.Add('G', "GĠĜĞĢ");
            dictionary.Add('H', "HĤ");
            dictionary.Add('I', "IĮĬĪÏĨÎÍÌ");
            dictionary.Add('J', "JĴ");
            dictionary.Add('K', "KĶ");
            dictionary.Add('L', "LŁĿĽĻĹ");
            dictionary.Add('M', "M");
            dictionary.Add('N', "NŊŇŅÑŃ");
            dictionary.Add('O', "OŒŐŎŌØÖÕÔÓÒ");
            dictionary.Add('P', "P");
            dictionary.Add('Q', "Q");
            dictionary.Add('R', "RŖŔŘ");
            dictionary.Add('S', "SŞŠŜẞŚ");
            dictionary.Add('T', "TŦŢÞŤ");
            dictionary.Add('U', "UŲŮŰŪÜŨŬÚÙÛ");
            dictionary.Add('V', "V");
            dictionary.Add('W', "WŴ");
            dictionary.Add('X', "X");
            dictionary.Add('Y', "YŶÝŸ");
            dictionary.Add('Z', "ZŽŹŻ");
            foreach (var key in dictionary.Keys)
            {
                foreach (var symbol in dictionary[key])
                {
                    if (symbols.ContainsKey(symbol))
                    {
                        symbols[symbol] += key;
                    }
                    else
                    {
                        symbols.Add(symbol, dictionary[key]);
                    }
                }
            }
        }
    }
}
