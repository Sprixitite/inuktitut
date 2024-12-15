using System;
using System.Collections.Generic;

public static class Program {

    static readonly Dictionary<string, string> replace_dict = new Dictionary<string, string> {
        { "b", "vii"  },
        { "c", "taa"  },
        { "d", "pii"  },
        { "e", "lii"  },
        { "f", "phh"  },
        { "o", "auug" },
        { "x", "aqus" },
        { "y", "wai"  },
        { "z", "sii"  }
    };

    static readonly List<Dictionary<string, string>> inuktitut_dict = new List<Dictionary<string, string>> {
        new Dictionary<string, string> {
            { "ᐃ" , "i" },
            { "ᐅ", "u" },
            { "ᐊ", "a" },
            { "ᕼ", "h" },
            { "ᐦ", "h" },
            { "ᑉ", "p" },
            { "ᑦ", "t" },
            { "ᒃ", "k" },
            { "ᒡ", "g" },
            { "ᒻ", "m" },
            { "ᓐ", "n" },
            { "ᔅ", "s" },
            { "ᓪ", "l" },
            { "ᔾ", "j" },
            { "ᕝ", "v" },
            { "ᕐ", "r" },
            { "ᖅ", "q" },
            { "ᖦ", "ł" }
        },
        new Dictionary<string, string> {
            { "ᐁ", "ai" },
            { "ᐄ", "ii" },
            { "ᐆ", "uu" },
            { "ᐋ", "aa" },
            { "ᐱ", "pi" },
            { "ᐳ", "pu" },
            { "ᐸ", "pa" },
            { "ᑎ", "ti" },
            { "ᑐ", "tu" },
            { "ᑕ", "ta" },
            { "ᑭ", "ki" },
            { "ᑯ", "ku" },
            { "ᑲ", "ka" },
            { "ᒋ", "gi" },
            { "ᒍ", "gu" },
            { "ᒐ", "ga" },
            { "ᒥ", "mi" },
            { "ᒧ", "mu" },
            { "ᒪ", "ma" },
            { "ᓂ", "ni" },
            { "ᓄ", "nu" },
            { "ᓇ", "na" },
            { "ᓯ", "si" },
            { "ᓱ", "su" },
            { "ᓴ", "sa" },
            { "ᓕ", "li" },
            { "ᓗ", "lu" },
            { "ᓚ", "la" },
            { "ᔨ", "ji" },
            { "ᔪ", "ju" },
            { "ᔭ", "ja" },
            { "ᕕ", "vi" },
            { "ᕗ", "vu" },
            { "ᕙ", "va" },
            { "ᕆ", "ri" },
            { "ᕈ", "ru" },
            { "ᕋ", "ra" },
            { "ᕿ", "qi" },
            { "ᖁ", "qu" },
            { "ᖃ", "qa" },
            { "ᖕ", "ng" },
            { "ᖠ", "łi" },
            { "ᖢ", "łu" },
            { "ᖤ", "ła" }
        },
        new Dictionary<string, string> {
            { "ᐯ", "pai" },
            { "ᐲ", "pii" },
            { "ᐴ", "puu" },
            { "ᐹ", "paa" },
            { "ᑌ", "tai" },
            { "ᑏ", "tii" },
            { "ᑑ", "tuu" },
            { "ᑖ", "taa" },
            { "ᑫ", "kai" },
            { "ᑮ", "kii" },
            { "ᑰ", "kuu" },
            { "ᑳ", "kaa" },
            { "ᒉ", "gai" },
            { "ᒌ", "gii" },
            { "ᒎ", "guu" },
            { "ᒑ", "gaa" },
            { "ᒣ", "mai" },
            { "ᒦ", "mii" },
            { "ᒨ", "muu" },
            { "ᒫ", "maa" },
            { "ᓀ", "nai" },
            { "ᓃ", "nii" },
            { "ᓅ", "nuu" },
            { "ᓈ", "naa" },
            { "ᓭ", "sai" },
            { "ᓰ", "sii" },
            { "ᓲ", "suu" },
            { "ᓵ", "saa" },
            { "ᓓ", "lai" },
            { "ᓖ", "lii" },
            { "ᓘ", "luu" },
            { "ᓛ", "laa" },
            { "ᔦ", "jai" },
            { "ᔩ", "jii" },
            { "ᔫ", "juu" },
            { "ᔮ", "jaa" },
            { "ᕓ", "vai" },
            { "ᕖ", "vii" },
            { "ᕘ", "vuu" },
            { "ᕚ", "vaa" },
            { "ᕃ", "rai" },
            { "ᕇ", "rii" },
            { "ᕉ", "ruu" },
            { "ᕌ", "raa" },
            { "ᙯ", "qai" },
            { "ᖀ", "qii" },
            { "ᖂ", "quu" },
            { "ᖄ", "qaa" },
            { "ᖏ", "ngi" },
            { "ᖑ", "ngu" },
            { "ᖓ", "nga" },
            { "ᖖ", "nng" },
            { "ᖡ", "łii" },
            { "ᖣ", "łuu" },
            { "ᖥ", "łaa" }
        },
        new Dictionary<string, string> {
            { "ᙰ", "ngai" },
            { "ᖐ", "ngii" },
            { "ᖒ", "nguu" },
            { "ᖔ", "ngaa" },
            { "ᙱ", "nngi" },
            { "ᙳ", "nngu" },
            { "ᙵ", "nnga" }
        },
        new Dictionary<string, string> {
            { "ᙲ", "nngii" },
            { "ᙴ", "nnguu" },
            { "ᙶ", "nngaa" }
        }
    };

    public static string Do(string input) {
        foreach ( var kvp in replace_dict ) {
            input = input.Replace( kvp.Key, kvp.Value );
        }
        input = input.Replace('w', 'ł');
        
        for ( int i=inuktitut_dict.Count-1; i>=0; i-- ) {
            foreach ( var kvp in inuktitut_dict[i] ) {
                input = input.Replace(kvp.Value, kvp.Key);
            }
        }

        return input;
    }

    public static string Undo(string input) {

        for ( int i=inuktitut_dict.Count-1; i>=0; i-- ) {
            foreach ( var kvp in inuktitut_dict[i] ) {
                input = input.Replace(kvp.Key, kvp.Value);
            }
        }

        input = input.Replace('ł', 'w');
        foreach ( var kvp in replace_dict ) {
            input = input.Replace( kvp.Value, kvp.Key );
        }

        return input;
    }

    public enum WhatWeDoing {
        DO,
        UNDO
    }

    // public static WhatWeDoing FigureOutWhatWeAreDoing() {

    //     Console.WriteLine("What do?");
    //     Console.WriteLine();

    // }

    public static void Main(string[] args) {

        Console.Write("Input: ");
        string input = Console.ReadLine().ToLower();
        
        Console.WriteLine(Do(input));
    }

}
