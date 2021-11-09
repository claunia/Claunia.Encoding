//
// AtariST.cs
//
// Author:
//       Natalia Portillo <claunia@claunia.com>
//
// Copyright © 2016-2021 Natalia Portillo
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.


namespace Claunia.Encoding.Tests;

[TestFixture]
public class AtariSt
{
    const string PUNCTUATIONS = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
    readonly byte[] _punctuationsBytes =
    {
        0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F, 0x3A, 0x3B, 0x3C,
        0x3D, 0x3E, 0x3F, 0x40, 0x5B, 0x5C, 0x5D, 0x5E, 0x5F, 0x60, 0x7B, 0x7C, 0x7D, 0x7E
    };
    const string DIGITS = "0123456789";
    readonly byte[] _digitsBytes =
    {
        0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39
    };
    const string UPPER_LATIN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    readonly byte[] _upperLatinBytes =
    {
        0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4A, 0x4B, 0x4C, 0x4D, 0x4E, 0x4F, 0x50, 0x51, 0x52,
        0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5A
    };
    const string LOWER_LATIN = "abcdefghijklmnopqrstuvwxyz";
    readonly byte[] _lowerLatinBytes =
    {
        0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6A, 0x6B, 0x6C, 0x6D, 0x6E, 0x6F, 0x70, 0x71, 0x72,
        0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7A
    };

    const string SPANISH = "¡¿áéíóúüñÉÜÑ";
    readonly byte[] _spanishBytes =
    {
        0xAD, 0xA8, 0xA0, 0x82, 0xA1, 0xA2, 0xA3, 0x81, 0xA4, 0x90, 0x9A, 0xA5
    };
    const string FRENCH = "éÉàèùÀâêîôûëïüÿçÇœŒæÆ";
    readonly byte[] _frenchBytes =
    {
        0x82, 0x90, 0x85, 0x8A, 0x97, 0xB6, 0x83, 0x88, 0x8C, 0x93, 0x96, 0x89, 0x8B, 0x81, 0x98, 0x87, 0x80, 0xB4,
        0xB5, 0x91, 0x92
    };
    const string GERMAN = "äöüßÄÖÜ";
    readonly byte[] _germanBytes =
    {
        0x84, 0x94, 0x81, 0x9E, 0x8E, 0x99, 0x9A
    };
    const string NORWEGIAN = "æøåÆØÅ";
    readonly byte[] _norwegianBytes =
    {
        0x91, 0xB3, 0x86, 0x92, 0xB2, 0x8F
    };
    const string PORTUGUESE = "áéíóúÉâêôãõÃÕçÇ";
    readonly byte[] _portugueseBytes =
    {
        0xA0, 0x82, 0xA1, 0xA2, 0xA3, 0x90, 0x83, 0x88, 0x93, 0xB0, 0xB1, 0xB7, 0xB8, 0x87, 0x80
    };
    const string DUTCH = "ĳĲ";
    readonly byte[] _dutchBytes =
    {
        0xC0, 0xC1
    };
    const string HEBREW = "אבגדהוזחטיכלמנסעפצקרשתןךםףץ";
    readonly byte[] _hebrewBytes =
    {
        0xC2, 0xC3, 0xC4, 0xC5, 0xC6, 0xC7, 0xC8, 0xC9, 0xCA, 0xCB, 0xCC, 0xCD, 0xCE, 0xCF, 0xD0, 0xD1, 0xD2, 0xD3,
        0xD4, 0xD5, 0xD6, 0xD7, 0xD8, 0xD9, 0xDA, 0xDB, 0xDC
    };
    const string GREEK = "αβΓπΣσµτΦΘΩδ¯";
    readonly byte[] _greekBytes =
    {
        0xE0, 0xE1, 0xE2, 0xE3, 0xE4, 0xE5, 0xE6, 0xE7, 0xE8, 0xE9, 0xEA, 0xEB, 0xFF
    };

    const string TYPOGRAPHIC = "ªº«»¨´†¶©®™§°∙·";
    readonly byte[] _typographicBytes =
    {
        0xA6, 0xA7, 0xAE, 0xAF, 0xB9, 0xBA, 0xBB, 0xBC, 0xBD, 0xBE, 0xBF, 0xDD, 0xF8, 0xF9, 0xFA
    };
    const string CURRENCY = "¢£¥ƒ";
    readonly byte[] _currencyBytes =
    {
        0x9B, 0x9C, 0x9D, 0x9F
    };
    const string MATHEMATICS = "⌐¬½¼∧∞∮ϕ∈∩≡±≥≤⌠⌡÷≈√ⁿ²³";
    readonly byte[] _mathematicsBytes =
    {
        0xA9, 0xAA, 0xAB, 0xAC, 0xDE, 0xDF, 0xEC, 0xED, 0xEE, 0xEF, 0xF0, 0xF1, 0xF2, 0xF3, 0xF4, 0xF5, 0xF6, 0xF7,
        0xFB, 0xFC, 0xFD, 0xFE
    };
    const string SYMBOLS = "⇧⇩⇨⇦🮽✓♪ə";
    readonly byte[] _symbolsBytes =
    {
        0x01, 0x02, 0x03, 0x04, 0x05, 0x08, 0x0B, 0x1A
    };

    [Test]
    public void AtariStPangrams()
    {
        byte[] byteArray;
        string testString;

        byteArray  = Encoding.AtariStEncoding.GetBytes(Pangrams.BASQUE);
        testString = Encoding.AtariStEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.BASQUE, testString);
        byteArray  = Encoding.AtariStEncoding.GetBytes(Pangrams.DANISH);
        testString = Encoding.AtariStEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.DANISH, testString);
        byteArray  = Encoding.AtariStEncoding.GetBytes(Pangrams.ENGLISH);
        testString = Encoding.AtariStEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.ENGLISH, testString);
        byteArray  = Encoding.AtariStEncoding.GetBytes(Pangrams.FINNISH);
        testString = Encoding.AtariStEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.FINNISH, testString);
        byteArray  = Encoding.AtariStEncoding.GetBytes(Pangrams.FRENCH);
        testString = Encoding.AtariStEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.FRENCH, testString);
        byteArray  = Encoding.AtariStEncoding.GetBytes(Pangrams.GALICIAN);
        testString = Encoding.AtariStEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.GALICIAN, testString);
        byteArray  = Encoding.AtariStEncoding.GetBytes(Pangrams.GERMAN);
        testString = Encoding.AtariStEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.GERMAN, testString);
        byteArray  = Encoding.AtariStEncoding.GetBytes(Pangrams.HEBREW);
        testString = Encoding.AtariStEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.HEBREW, testString);
        byteArray  = Encoding.AtariStEncoding.GetBytes(Pangrams.NORWEGIAN);
        testString = Encoding.AtariStEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.NORWEGIAN, testString);
        byteArray  = Encoding.AtariStEncoding.GetBytes(Pangrams.PORTUGUESE);
        testString = Encoding.AtariStEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.PORTUGUESE, testString);
        byteArray  = Encoding.AtariStEncoding.GetBytes(Pangrams.SPANISH);
        testString = Encoding.AtariStEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.SPANISH, testString);
        byteArray  = Encoding.AtariStEncoding.GetBytes(Pangrams.SWEDISH);
        testString = Encoding.AtariStEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.SWEDISH, testString);
    }

    [Test]
    public void AtariStToUnicode()
    {
        string testString;

        testString = Encoding.AtariStEncoding.GetString(_punctuationsBytes);
        Assert.AreEqual(PUNCTUATIONS, testString);
        testString = Encoding.AtariStEncoding.GetString(_digitsBytes);
        Assert.AreEqual(DIGITS, testString);
        testString = Encoding.AtariStEncoding.GetString(_upperLatinBytes);
        Assert.AreEqual(UPPER_LATIN, testString);
        testString = Encoding.AtariStEncoding.GetString(_lowerLatinBytes);
        Assert.AreEqual(LOWER_LATIN, testString);

        testString = Encoding.AtariStEncoding.GetString(_spanishBytes);
        Assert.AreEqual(SPANISH, testString);
        testString = Encoding.AtariStEncoding.GetString(_frenchBytes);
        Assert.AreEqual(FRENCH, testString);
        testString = Encoding.AtariStEncoding.GetString(_germanBytes);
        Assert.AreEqual(GERMAN, testString);
        testString = Encoding.AtariStEncoding.GetString(_norwegianBytes);
        Assert.AreEqual(NORWEGIAN, testString);
        testString = Encoding.AtariStEncoding.GetString(_portugueseBytes);
        Assert.AreEqual(PORTUGUESE, testString);
        testString = Encoding.AtariStEncoding.GetString(_dutchBytes);
        Assert.AreEqual(DUTCH, testString);
        testString = Encoding.AtariStEncoding.GetString(_hebrewBytes);
        Assert.AreEqual(HEBREW, testString);
        testString = Encoding.AtariStEncoding.GetString(_greekBytes);
        Assert.AreEqual(GREEK, testString);

        testString = Encoding.AtariStEncoding.GetString(_typographicBytes);
        Assert.AreEqual(TYPOGRAPHIC, testString);
        testString = Encoding.AtariStEncoding.GetString(_currencyBytes);
        Assert.AreEqual(CURRENCY, testString);
        testString = Encoding.AtariStEncoding.GetString(_mathematicsBytes);
        Assert.AreEqual(MATHEMATICS, testString);
        testString = Encoding.AtariStEncoding.GetString(_symbolsBytes);
        Assert.AreEqual(SYMBOLS, testString);

        // TODO: 0x09 => U+1F552, 0x0A => U+1F514
        /*testString = Encoding.AtariSTEncoding.GetString(SymbolsUnicode32Bytes);
        Assert.AreEqual(SymbolsUnicode32, testString);*/
    }

    // TODO: 0x09 => U+1F552, 0x0A => U+1F514
    /*const string SymbolsUnicode32 = "\ud83d\udd52\ud83d\udd14";
    readonly byte[] SymbolsUnicode32Bytes = { 0x09, 0x0A };*/

    [Test]
    public void UnicodeToAtariSt()
    {
        byte[] byteArray;

        byteArray = Encoding.AtariStEncoding.GetBytes(PUNCTUATIONS);
        Assert.AreEqual(_punctuationsBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(DIGITS);
        Assert.AreEqual(_digitsBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(UPPER_LATIN);
        Assert.AreEqual(_upperLatinBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(LOWER_LATIN);
        Assert.AreEqual(_lowerLatinBytes, byteArray);

        byteArray = Encoding.AtariStEncoding.GetBytes(SPANISH);
        Assert.AreEqual(_spanishBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(FRENCH);
        Assert.AreEqual(_frenchBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(GERMAN);
        Assert.AreEqual(_germanBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(NORWEGIAN);
        Assert.AreEqual(_norwegianBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(PORTUGUESE);
        Assert.AreEqual(_portugueseBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(DUTCH);
        Assert.AreEqual(_dutchBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(HEBREW);
        Assert.AreEqual(_hebrewBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(GREEK);
        Assert.AreEqual(_greekBytes, byteArray);

        byteArray = Encoding.AtariStEncoding.GetBytes(TYPOGRAPHIC);
        Assert.AreEqual(_typographicBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(CURRENCY);
        Assert.AreEqual(_currencyBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(MATHEMATICS);
        Assert.AreEqual(_mathematicsBytes, byteArray);
        byteArray = Encoding.AtariStEncoding.GetBytes(SYMBOLS);
        Assert.AreEqual(_symbolsBytes, byteArray);

        // TODO: 0x09 => U+1F552, 0x0A => U+1F514
        /*byteArray = Encoding.AtariSTEncoding.GetBytes(SymbolsUnicode32);
        Assert.AreEqual(SymbolsUnicode32Bytes, byteArray);*/
    }
}