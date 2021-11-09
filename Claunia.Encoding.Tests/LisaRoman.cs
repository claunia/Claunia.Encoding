//
// LisaRoman.cs
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
public class LisaRoman
{
    const string PUNCTUATIONS = "!\"#$%&()*+,-./:;<=>?@[\\]^_{|}~";
    readonly byte[] _punctuationsBytes =
    {
        0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x28, 0x29, 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F, 0x3A, 0x3B, 0x3C, 0x3D,
        0x3E, 0x3F, 0x40, 0x5B, 0x5C, 0x5D, 0x5E, 0x5F, 0x7B, 0x7C, 0x7D, 0x7E
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
        0xC1, 0xC0, 0x87, 0x8E, 0x92, 0x97, 0x9C, 0x9F, 0x96, 0x83, 0x86, 0x84
    };
    const string FRENCH = "éÉàèùÀâêîôûëïüÿçÇœŒæÆ";
    readonly byte[] _frenchBytes =
    {
        0x8E, 0x83, 0x88, 0x8F, 0x9D, 0xCB, 0x89, 0x90, 0x94, 0x99, 0x9E, 0x91, 0x95, 0x9F, 0xD8, 0x8D, 0x82, 0xCF,
        0xCE, 0xBE, 0xAE
    };
    const string GERMAN = "äöüßÄÖÜ";
    readonly byte[] _germanBytes =
    {
        0x8A, 0x9A, 0x9F, 0xA7, 0x80, 0x85, 0x86
    };
    const string NORWEGIAN = "æøåÆØÅ";
    readonly byte[] _norwegianBytes =
    {
        0xBE, 0xBF, 0x8C, 0xAE, 0xAF, 0x81
    };
    const string PORTUGUESE = "áéíóúÉâêôãõÃÕçÇ";
    readonly byte[] _portugueseBytes =
    {
        0x87, 0x8E, 0x92, 0x97, 0x9C, 0x83, 0x89, 0x90, 0x99, 0x8B, 0x9B, 0xCC, 0xCD, 0x8D, 0x82
    };

    const string TYPOGRAPHIC = "†°•¶®©™´¨ªº«»…–—“”‘’§";
    readonly byte[] _typographicBytes =
    {
        0xA0, 0xA1, 0xA5, 0xA6, 0xA8, 0xA9, 0xAA, 0xAB, 0xAC, 0xBB, 0xBC, 0xC7, 0xC8, 0xC9, 0xD0, 0xD1, 0xD2, 0xD3,
        0xD4, 0xD5, 0xA4
    };
    const string CURRENCY = "¢£¥";
    readonly byte[] _currencyBytes =
    {
        0xA2, 0xA3, 0xB4
    };
    const string MATHEMATICS = "≠∞±≤≥µ∂∑∏π∫Ω¬√ƒ≈∆÷◊";
    readonly byte[] _mathematicsBytes =
    {
        0xAD, 0xB0, 0xB1, 0xB2, 0xB3, 0xB5, 0xB6, 0xB7, 0xB8, 0xB9, 0xBA, 0xBD, 0xC2, 0xC3, 0xC4, 0xC5, 0xC6, 0xD6, 0xD7
    };

    [Test]
    public void LisaPangrams()
    {
        byte[] byteArray;
        string testString;

        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.BASQUE);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.BASQUE, testString);
        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.BRETON);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.BRETON, testString);
        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.DANISH);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.DANISH, testString);
        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.DUTCH);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.DUTCH, testString);
        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.ENGLISH);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.ENGLISH, testString);
        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.FINNISH);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.FINNISH, testString);
        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.FRENCH);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.FRENCH, testString);
        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.GALICIAN);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.GALICIAN, testString);
        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.GERMAN);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.GERMAN, testString);
        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.NORWEGIAN);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.NORWEGIAN, testString);
        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.PORTUGUESE);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.PORTUGUESE, testString);
        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.SPANISH);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.SPANISH, testString);
        byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.SWEDISH);
        testString = Encoding.LisaEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.SWEDISH, testString);
    }

    [Test]
    public void LisaToUnicode()
    {
        string testString;

        testString = Encoding.LisaEncoding.GetString(_punctuationsBytes);
        Assert.AreEqual(PUNCTUATIONS, testString);
        testString = Encoding.LisaEncoding.GetString(_digitsBytes);
        Assert.AreEqual(DIGITS, testString);
        testString = Encoding.LisaEncoding.GetString(_upperLatinBytes);
        Assert.AreEqual(UPPER_LATIN, testString);
        testString = Encoding.LisaEncoding.GetString(_lowerLatinBytes);
        Assert.AreEqual(LOWER_LATIN, testString);

        testString = Encoding.LisaEncoding.GetString(_spanishBytes);
        Assert.AreEqual(SPANISH, testString);
        testString = Encoding.LisaEncoding.GetString(_frenchBytes);
        Assert.AreEqual(FRENCH, testString);
        testString = Encoding.LisaEncoding.GetString(_germanBytes);
        Assert.AreEqual(GERMAN, testString);
        testString = Encoding.LisaEncoding.GetString(_norwegianBytes);
        Assert.AreEqual(NORWEGIAN, testString);
        testString = Encoding.LisaEncoding.GetString(_portugueseBytes);
        Assert.AreEqual(PORTUGUESE, testString);

        testString = Encoding.LisaEncoding.GetString(_typographicBytes);
        Assert.AreEqual(TYPOGRAPHIC, testString);
        testString = Encoding.LisaEncoding.GetString(_currencyBytes);
        Assert.AreEqual(CURRENCY, testString);
        testString = Encoding.LisaEncoding.GetString(_mathematicsBytes);
        Assert.AreEqual(MATHEMATICS, testString);
    }

    [Test]
    public void UnicodeToLisa()
    {
        byte[] byteArray;

        byteArray = Encoding.LisaEncoding.GetBytes(PUNCTUATIONS);
        Assert.AreEqual(_punctuationsBytes, byteArray);
        byteArray = Encoding.LisaEncoding.GetBytes(DIGITS);
        Assert.AreEqual(_digitsBytes, byteArray);
        byteArray = Encoding.LisaEncoding.GetBytes(UPPER_LATIN);
        Assert.AreEqual(_upperLatinBytes, byteArray);
        byteArray = Encoding.LisaEncoding.GetBytes(LOWER_LATIN);
        Assert.AreEqual(_lowerLatinBytes, byteArray);

        byteArray = Encoding.LisaEncoding.GetBytes(SPANISH);
        Assert.AreEqual(_spanishBytes, byteArray);
        byteArray = Encoding.LisaEncoding.GetBytes(FRENCH);
        Assert.AreEqual(_frenchBytes, byteArray);
        byteArray = Encoding.LisaEncoding.GetBytes(GERMAN);
        Assert.AreEqual(_germanBytes, byteArray);
        byteArray = Encoding.LisaEncoding.GetBytes(NORWEGIAN);
        Assert.AreEqual(_norwegianBytes, byteArray);
        byteArray = Encoding.LisaEncoding.GetBytes(PORTUGUESE);
        Assert.AreEqual(_portugueseBytes, byteArray);

        byteArray = Encoding.LisaEncoding.GetBytes(TYPOGRAPHIC);
        Assert.AreEqual(_typographicBytes, byteArray);
        byteArray = Encoding.LisaEncoding.GetBytes(CURRENCY);
        Assert.AreEqual(_currencyBytes, byteArray);
        byteArray = Encoding.LisaEncoding.GetBytes(MATHEMATICS);
        Assert.AreEqual(_mathematicsBytes, byteArray);
    }
}