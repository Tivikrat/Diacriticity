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
                    if (symbols.ContainsKey(symbol.ToString().ToUpper()[0]))
                    {
                        symbols[symbol.ToString().ToUpper()[0]] += key.ToString().ToUpper()[0];
                    }
                    else
                    {
                        symbols.Add(symbol.ToString().ToUpper()[0], dictionary[key].ToUpper());
                    }
                }
            }
        }
    }
}
