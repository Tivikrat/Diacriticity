using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diacriticity
{
    class Symbols
    {
        static Dictionary<char, char[]> symbols = new Dictionary<char, char[]>();
        static void SetSymbols()
        {
            symbols.Add('a', new char[] { 'a', 'ă', 'ą', 'ª', 'ä', 'å', 'æ', 'ā', 'à', 'á', 'â', 'ã' });
            symbols.Add('b', new char[] { 'b' });
            symbols.Add('c', new char[] { 'c', 'č', 'ĉ', 'ç', 'ć', 'ċ' });
            symbols.Add('d', new char[] { 'd', 'ð', 'ď', 'đ' });
            symbols.Add('e', new char[] { 'e', 'ė', 'ē', 'ĕ', 'ę', 'ě', 'é', 'è', 'ê', 'ë' });
            symbols.Add('f', new char[] { 'f' });
            symbols.Add('g', new char[] { 'g', 'ġ', 'ĝ', 'ğ', 'ģ' });
            symbols.Add('h', new char[] { 'h', 'ĥ' });
            symbols.Add('i', new char[] { 'i', 'į', 'ı', 'ĭ', 'ī', 'ï', 'ĩ', 'î', 'í', 'ì' });
            symbols.Add('j', new char[] { 'j', 'ĵ' });
            symbols.Add('k', new char[] { 'k', 'ķ', 'ĸ' });
            symbols.Add('l', new char[] { 'l', 'ł', 'ŀ', 'ľ', 'ļ', 'ĺ' });
            symbols.Add('m', new char[] { 'm' });
            symbols.Add('n', new char[] { 'n', 'ŋ', 'ň', 'ŉ', 'ņ', 'ñ', 'ń' });
            symbols.Add('o', new char[] { 'o', 'º', 'œ', 'ő', 'ŏ', 'ō', 'ø', 'ö', 'õ', 'ô', 'ó', 'ò' });

            //To be continued!
            /*
            p
            q
            rŗŕř
            sſşšŝßś
            tŧţþť
            uųůűūüũŭúùû
            v
            wŵ
            x
            yŷýÿ
            zžźż
            AĂĄÄÅÆĀÀÁÂÃ
            B
            CČĈÇĆĊ
            DÐĎĐ
            EĖĒĔĘĚÉÈÊË
            F
            GĠĜĞĢ
            HĤ
            IĮĬĪÏĨÎÍÌ
            JĴ
            KĶ
            LŁĿĽĻĹ
            M
            NŊŇŅÑŃ
            OŒŐŎŌØÖÕÔÓÒ
            P
            Q
            RŖŔŘ
            SŞŠŜẞŚ
            TŦŢÞŤ
            UŲŮŰŪÜŨŬÚÙÛ
            V
            WŴ
            X
            YŶÝŸ
            ZŽŹŻ
            */
        }
    }
}
