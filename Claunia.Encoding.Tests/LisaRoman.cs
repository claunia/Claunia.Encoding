//
// LisaRoman.cs
//
// Author:
//       Natalia Portillo <claunia@claunia.com>
//
// Copyright © 2016-2019 Natalia Portillo
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

namespace Claunia.Encoding.Tests
{
    [TestFixture]
    public class LisaRoman
    {
        const string Punctuations = "!\"#$%&()*+,-./:;<=>?@[\\]^_{|}~";
        readonly byte[] PunctuationsBytes =
        {
            0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x28, 0x29, 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F, 0x3A, 0x3B, 0x3C,
            0x3D, 0x3E, 0x3F, 0x40, 0x5B, 0x5C, 0x5D, 0x5E, 0x5F, 0x7B, 0x7C, 0x7D, 0x7E
        };
        const    string Digits      = "0123456789";
        readonly byte[] DigitsBytes = {0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39};
        const    string UpperLatin  = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly byte[] UpperLatinBytes =
        {
            0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4A, 0x4B, 0x4C, 0x4D, 0x4E, 0x4F, 0x50, 0x51,
            0x52, 0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5A
        };
        const string LowerLatin = "abcdefghijklmnopqrstuvwxyz";
        readonly byte[] LowerLatinBytes =
        {
            0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6A, 0x6B, 0x6C, 0x6D, 0x6E, 0x6F, 0x70, 0x71,
            0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7A
        };

        const    string Spanish      = "¡¿áéíóúüñÉÜÑ";
        readonly byte[] SpanishBytes = {0xC1, 0xC0, 0x87, 0x8E, 0x92, 0x97, 0x9C, 0x9F, 0x96, 0x83, 0x86, 0x84};
        const    string French       = "éÉàèùÀâêîôûëïüÿçÇœŒæÆ";
        readonly byte[] FrenchBytes =
        {
            0x8E, 0x83, 0x88, 0x8F, 0x9D, 0xCB, 0x89, 0x90, 0x94, 0x99, 0x9E, 0x91, 0x95, 0x9F, 0xD8, 0x8D, 0x82,
            0xCF, 0xCE, 0xBE, 0xAE
        };
        const    string German         = "äöüßÄÖÜ";
        readonly byte[] GermanBytes    = {0x8A, 0x9A, 0x9F, 0xA7, 0x80, 0x85, 0x86};
        const    string Norwegian      = "æøåÆØÅ";
        readonly byte[] NorwegianBytes = {0xBE, 0xBF, 0x8C, 0xAE, 0xAF, 0x81};
        const    string Portuguese     = "áéíóúÉâêôãõÃÕçÇ";
        readonly byte[] PortugueseBytes =
        {
            0x87, 0x8E, 0x92, 0x97, 0x9C, 0x83, 0x89, 0x90, 0x99, 0x8B, 0x9B, 0xCC, 0xCD, 0x8D, 0x82
        };

        const string Typographic = "†°•¶®©™´¨ªº«»…–—“”‘’§";
        readonly byte[] TypographicBytes =
        {
            0xA0, 0xA1, 0xA5, 0xA6, 0xA8, 0xA9, 0xAA, 0xAB, 0xAC, 0xBB, 0xBC, 0xC7, 0xC8, 0xC9, 0xD0, 0xD1, 0xD2,
            0xD3, 0xD4, 0xD5, 0xA4
        };
        const    string Currency      = "¢£¥";
        readonly byte[] CurrencyBytes = {0xA2, 0xA3, 0xB4};
        const    string Mathematics   = "≠∞±≤≥µ∂∑∏π∫Ω¬√ƒ≈∆÷◊";
        readonly byte[] MathematicsBytes =
        {
            0xAD, 0xB0, 0xB1, 0xB2, 0xB3, 0xB5, 0xB6, 0xB7, 0xB8, 0xB9, 0xBA, 0xBD, 0xC2, 0xC3, 0xC4, 0xC5, 0xC6,
            0xD6, 0xD7
        };

        [Test]
        public void LisaPangrams()
        {
            byte[] byteArray;
            string testString;

            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.Basque);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Basque, testString);
            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.Breton);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Breton, testString);
            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.Danish);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Danish, testString);
            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.Dutch);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Dutch, testString);
            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.English);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.English, testString);
            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.Finnish);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Finnish, testString);
            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.French);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.French, testString);
            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.Galician);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Galician, testString);
            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.German);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.German, testString);
            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.Norwegian);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Norwegian, testString);
            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.Portuguese);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Portuguese, testString);
            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.Spanish);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Spanish, testString);
            byteArray  = Encoding.LisaEncoding.GetBytes(Pangrams.Swedish);
            testString = Encoding.LisaEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.Swedish, testString);
        }

        [Test]
        public void LisaToUnicode()
        {
            string testString;

            testString = Encoding.LisaEncoding.GetString(PunctuationsBytes);
            Assert.AreEqual(Punctuations, testString);
            testString = Encoding.LisaEncoding.GetString(DigitsBytes);
            Assert.AreEqual(Digits, testString);
            testString = Encoding.LisaEncoding.GetString(UpperLatinBytes);
            Assert.AreEqual(UpperLatin, testString);
            testString = Encoding.LisaEncoding.GetString(LowerLatinBytes);
            Assert.AreEqual(LowerLatin, testString);

            testString = Encoding.LisaEncoding.GetString(SpanishBytes);
            Assert.AreEqual(Spanish, testString);
            testString = Encoding.LisaEncoding.GetString(FrenchBytes);
            Assert.AreEqual(French, testString);
            testString = Encoding.LisaEncoding.GetString(GermanBytes);
            Assert.AreEqual(German, testString);
            testString = Encoding.LisaEncoding.GetString(NorwegianBytes);
            Assert.AreEqual(Norwegian, testString);
            testString = Encoding.LisaEncoding.GetString(PortugueseBytes);
            Assert.AreEqual(Portuguese, testString);

            testString = Encoding.LisaEncoding.GetString(TypographicBytes);
            Assert.AreEqual(Typographic, testString);
            testString = Encoding.LisaEncoding.GetString(CurrencyBytes);
            Assert.AreEqual(Currency, testString);
            testString = Encoding.LisaEncoding.GetString(MathematicsBytes);
            Assert.AreEqual(Mathematics, testString);
        }

        [Test]
        public void UnicodeToLisa()
        {
            byte[] byteArray;

            byteArray = Encoding.LisaEncoding.GetBytes(Punctuations);
            Assert.AreEqual(PunctuationsBytes, byteArray);
            byteArray = Encoding.LisaEncoding.GetBytes(Digits);
            Assert.AreEqual(DigitsBytes, byteArray);
            byteArray = Encoding.LisaEncoding.GetBytes(UpperLatin);
            Assert.AreEqual(UpperLatinBytes, byteArray);
            byteArray = Encoding.LisaEncoding.GetBytes(LowerLatin);
            Assert.AreEqual(LowerLatinBytes, byteArray);

            byteArray = Encoding.LisaEncoding.GetBytes(Spanish);
            Assert.AreEqual(SpanishBytes, byteArray);
            byteArray = Encoding.LisaEncoding.GetBytes(French);
            Assert.AreEqual(FrenchBytes, byteArray);
            byteArray = Encoding.LisaEncoding.GetBytes(German);
            Assert.AreEqual(GermanBytes, byteArray);
            byteArray = Encoding.LisaEncoding.GetBytes(Norwegian);
            Assert.AreEqual(NorwegianBytes, byteArray);
            byteArray = Encoding.LisaEncoding.GetBytes(Portuguese);
            Assert.AreEqual(PortugueseBytes, byteArray);

            byteArray = Encoding.LisaEncoding.GetBytes(Typographic);
            Assert.AreEqual(TypographicBytes, byteArray);
            byteArray = Encoding.LisaEncoding.GetBytes(Currency);
            Assert.AreEqual(CurrencyBytes, byteArray);
            byteArray = Encoding.LisaEncoding.GetBytes(Mathematics);
            Assert.AreEqual(MathematicsBytes, byteArray);
        }
    }
}