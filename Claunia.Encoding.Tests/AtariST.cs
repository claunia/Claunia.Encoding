//
// AtariST.cs
//
// Author:
//       Natalia Portillo <claunia@claunia.com>
//
// Copyright © 2016-2018 Natalia Portillo
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

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Claunia.Encoding.Tests
{
    [TestFixture]
    public class AtariST
    {
        const string Punctuations = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
        readonly byte[] PunctuationsBytes = { 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F, 0x3A, 0x3B, 0x3C, 0x3D, 0x3E,
            0x3F, 0x40, 0x5B, 0x5C, 0x5D, 0x5E, 0x5F, 0x60, 0x7B, 0x7C, 0x7D, 0x7E };
        const string Digits = "0123456789";
        readonly byte[] DigitsBytes = { 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39 };
        const string UpperLatin = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly byte[] UpperLatinBytes = { 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4A, 0x4B, 0x4C, 0x4D, 0x4E, 0x4F, 0x50, 0x51, 0x52, 0x53, 0x54,
            0x55, 0x56, 0x57, 0x58, 0x59, 0x5A };
        const string LowerLatin = "abcdefghijklmnopqrstuvwxyz";
        readonly byte[] LowerLatinBytes = { 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6A, 0x6B, 0x6C, 0x6D, 0x6E, 0x6F, 0x70, 0x71, 0x72, 0x73, 0x74,
            0x75, 0x76, 0x77, 0x78, 0x79, 0x7A };

        const string Spanish = "¡¿áéíóúüñÉÜÑ";
        readonly byte[] SpanishBytes = { 0xAD, 0xA8, 0xA0, 0x82, 0xA1, 0xA2, 0xA3, 0x81, 0xA4, 0x90, 0x9A, 0xA5 };
        const string French = "éÉàèùÀâêîôûëïüÿçÇœŒæÆ";
        readonly byte[] FrenchBytes = { 0x82, 0x90, 0x85, 0x8A, 0x97, 0xB6, 0x83, 0x88, 0x8C, 0x93, 0x96, 0x89, 0x8B, 0x81, 0x98, 0x87, 0x80, 0xB4, 0xB5, 0x91, 0x92 };
        const string German = "äöüßÄÖÜ";
        readonly byte[] GermanBytes = { 0x84, 0x94, 0x81, 0x9E, 0x8E, 0x99, 0x9A };
        const string Norwegian = "æøåÆØÅ";
        readonly byte[] NorwegianBytes = { 0x91, 0xB3, 0x86, 0x92, 0xB2, 0x8F };
        const string Portuguese = "áéíóúÉâêôãõÃÕçÇ";
        readonly byte[] PortugueseBytes = { 0xA0, 0x82, 0xA1, 0xA2, 0xA3, 0x90, 0x83, 0x88, 0x93, 0xB0, 0xB1, 0xB7, 0xB8, 0x87, 0x80 };
        const string Dutch = "ĳĲ";
        readonly byte[] DutchBytes = { 0xC0, 0xC1 };
        const string Hebrew = "אבגדהוזחטיכלמנסעפצקרשתןךםףץ";
        readonly byte[] HebrewBytes = { 0xC2, 0xC3, 0xC4, 0xC5, 0xC6, 0xC7, 0xC8, 0xC9, 0xCA, 0xCB, 0xCC, 0xCD, 0xCE, 0xCF, 0xD0, 0xD1, 0xD2, 0xD3, 0xD4, 0xD5, 0xD6,
            0xD7, 0xD8, 0xD9, 0xDA, 0xDB, 0xDC};
        const string Greek = "αβΓπΣσµτΦΘΩδ¯";
        readonly byte[] GreekBytes = { 0xE0, 0xE1, 0xE2, 0xE3, 0xE4, 0xE5, 0xE6, 0xE7, 0xE8, 0xE9, 0xEA, 0xEB, 0xFF };

        const string Typographic = "ªº«»¨´†¶©®™§°∙·";
        readonly byte[] TypographicBytes = { 0xA6, 0xA7, 0xAE, 0xAF, 0xB9, 0xBA, 0xBB, 0xBC, 0xBD, 0xBE, 0xBF, 0xDD, 0xF8, 0xF9, 0xFA };
        const string Currency = "¢£¥ƒ";
        readonly byte[] CurrencyBytes = { 0x9B, 0x9C, 0x9D, 0x9F };
        const string Mathematics = "⌐¬½¼∧∞∮ϕ∈∩≡±≥≤⌠⌡÷≈√ⁿ²³";
        readonly byte[] MathematicsBytes = { 0xA9, 0xAA, 0xAB, 0xAC, 0xDE, 0xDF, 0xEC, 0xED, 0xEE, 0xEF, 0xF0, 0xF1, 0xF2, 0xF3, 0xF4, 0xF5, 0xF6, 0xF7, 0xFB, 0xFC,
            0xFD, 0xFE};
        const string Symbols = "⇧⇩⇨⇦❎✓♪ə";
        readonly byte[] SymbolsBytes = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x08, 0x0B, 0x1A };
        // TODO: 0x09 => U+1F552, 0x0A => U+1F514
        /*const string SymbolsUnicode32 = "\ud83d\udd52\ud83d\udd14";
        readonly byte[] SymbolsUnicode32Bytes = { 0x09, 0x0A };*/

        [Test]
        public void UnicodeToAtariST()
        {
            byte[] byteArray;

            byteArray = Encoding.AtariSTEncoding.GetBytes(Punctuations);
            Assert.AreEqual(PunctuationsBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Digits);
            Assert.AreEqual(DigitsBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(UpperLatin);
            Assert.AreEqual(UpperLatinBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(LowerLatin);
            Assert.AreEqual(LowerLatinBytes, byteArray);

            byteArray = Encoding.AtariSTEncoding.GetBytes(Spanish);
            Assert.AreEqual(SpanishBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(French);
            Assert.AreEqual(FrenchBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(German);
            Assert.AreEqual(GermanBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Norwegian);
            Assert.AreEqual(NorwegianBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Portuguese);
            Assert.AreEqual(PortugueseBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Dutch);
            Assert.AreEqual(DutchBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Hebrew);
            Assert.AreEqual(HebrewBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Greek);
            Assert.AreEqual(GreekBytes, byteArray);

            byteArray = Encoding.AtariSTEncoding.GetBytes(Typographic);
            Assert.AreEqual(TypographicBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Currency);
            Assert.AreEqual(CurrencyBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Mathematics);
            Assert.AreEqual(MathematicsBytes, byteArray);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Symbols);
            Assert.AreEqual(SymbolsBytes, byteArray);
            // TODO: 0x09 => U+1F552, 0x0A => U+1F514
            /*byteArray = Encoding.AtariSTEncoding.GetBytes(SymbolsUnicode32);
            Assert.AreEqual(SymbolsUnicode32Bytes, byteArray);*/
        }

        [Test]
        public void AtariSTToUnicode()
        {
            string testString;

            testString = Encoding.AtariSTEncoding.GetString(PunctuationsBytes);
            Assert.AreEqual(Punctuations, testString);
            testString = Encoding.AtariSTEncoding.GetString(DigitsBytes);
            Assert.AreEqual(Digits, testString);
            testString = Encoding.AtariSTEncoding.GetString(UpperLatinBytes);
            Assert.AreEqual(UpperLatin, testString);
            testString = Encoding.AtariSTEncoding.GetString(LowerLatinBytes);
            Assert.AreEqual(LowerLatin, testString);

            testString = Encoding.AtariSTEncoding.GetString(SpanishBytes);
            Assert.AreEqual(Spanish, testString);
            testString = Encoding.AtariSTEncoding.GetString(FrenchBytes);
            Assert.AreEqual(French, testString);
            testString = Encoding.AtariSTEncoding.GetString(GermanBytes);
            Assert.AreEqual(German, testString);
            testString = Encoding.AtariSTEncoding.GetString(NorwegianBytes);
            Assert.AreEqual(Norwegian, testString);
            testString = Encoding.AtariSTEncoding.GetString(PortugueseBytes);
            Assert.AreEqual(Portuguese, testString);
            testString = Encoding.AtariSTEncoding.GetString(DutchBytes);
            Assert.AreEqual(Dutch, testString);
            testString = Encoding.AtariSTEncoding.GetString(HebrewBytes);
            Assert.AreEqual(Hebrew, testString);
            testString = Encoding.AtariSTEncoding.GetString(GreekBytes);
            Assert.AreEqual(Greek, testString);

            testString = Encoding.AtariSTEncoding.GetString(TypographicBytes);
            Assert.AreEqual(Typographic, testString);
            testString = Encoding.AtariSTEncoding.GetString(CurrencyBytes);
            Assert.AreEqual(Currency, testString);
            testString = Encoding.AtariSTEncoding.GetString(MathematicsBytes);
            Assert.AreEqual(Mathematics, testString);
            testString = Encoding.AtariSTEncoding.GetString(SymbolsBytes);
            Assert.AreEqual(Symbols, testString);
            // TODO: 0x09 => U+1F552, 0x0A => U+1F514
            /*testString = Encoding.AtariSTEncoding.GetString(SymbolsUnicode32Bytes);
            Assert.AreEqual(SymbolsUnicode32, testString);*/
        }

        [Test]
        public void AtariSTPangrams()
        {
            byte[] byteArray;
            string testString;

            byteArray = Encoding.AtariSTEncoding.GetBytes(Pangrams.Basque);
            testString = Encoding.AtariSTEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Basque, testString);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Pangrams.Danish);
            testString = Encoding.AtariSTEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Danish, testString);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Pangrams.English);
            testString = Encoding.AtariSTEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.English, testString);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Pangrams.Finnish);
            testString = Encoding.AtariSTEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Finnish, testString);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Pangrams.French);
            testString = Encoding.AtariSTEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.French, testString);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Pangrams.Galician);
            testString = Encoding.AtariSTEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Galician, testString);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Pangrams.German);
            testString = Encoding.AtariSTEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.German, testString);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Pangrams.Hebrew);
            testString = Encoding.AtariSTEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Hebrew, testString);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Pangrams.Norwegian);
            testString = Encoding.AtariSTEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Norwegian, testString);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Pangrams.Portuguese);
            testString = Encoding.AtariSTEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Portuguese, testString);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Pangrams.Spanish);
            testString = Encoding.AtariSTEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Spanish, testString);
            byteArray = Encoding.AtariSTEncoding.GetBytes(Pangrams.Swedish);
            testString = Encoding.AtariSTEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Swedish, testString);
        }
    }
}