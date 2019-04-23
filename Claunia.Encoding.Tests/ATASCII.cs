﻿//
// ATASCII.cs
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
    public class ATASCII
    {
        const string Punctuations = "!\"#$%&'()*+,-./:;<=>?@[\\]^_|";
        readonly byte[] PunctuationsBytes =
        {
            0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F, 0x3A, 0x3B, 0x3C,
            0x3D, 0x3E, 0x3F, 0x40, 0x5B, 0x5C, 0x5D, 0x5E, 0x5F, 0x7C
        };
        const    string Digits      = "0123456789";
        readonly byte[] DigitsBytes = {0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39};
        const    string UpperLatin  = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly byte[] UpperLatinBytes =
        {
            0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48, 0x49, 0x4A, 0x4B, 0x4C, 0x4D, 0x4E, 0x4F, 0x50, 0x51, 0x52,
            0x53, 0x54, 0x55, 0x56, 0x57, 0x58, 0x59, 0x5A
        };
        const string LowerLatin = "abcdefghijklmnopqrstuvwxyz";
        readonly byte[] LowerLatinBytes =
        {
            0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x67, 0x68, 0x69, 0x6A, 0x6B, 0x6C, 0x6D, 0x6E, 0x6F, 0x70, 0x71, 0x72,
            0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7A
        };

        const string Graphics = "├┘┤┐╱╲◢▗◣▝▘▂▖┌─┼●▄▎┬┴▌└";
        readonly byte[] GraphicsBytes =
        {
            0x01, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0E, 0x0F, 0x11, 0x12, 0x13, 0x14, 0x15,
            0x16, 0x17, 0x18, 0x19, 0x1A
        };
        const    string Arrows      = "↑↓←→↰◀▶";
        readonly byte[] ArrowsBytes = {0x1C, 0x1D, 0x1E, 0x1F, 0x7D, 0x7E, 0x7F};
        const    string Decks       = "♥♣♦♠";
        readonly byte[] DecksBytes  = {0x00, 0x10, 0x60, 0x7B};

        [Test]
        public void AtariPangrams()
        {
            byte[] byteArray;
            string testString;

            byteArray  = Encoding.AtariEncoding.GetBytes(Pangrams.English);
            testString = Encoding.AtariEncoding.GetString(byteArray);
            Assert.AreEqual(Pangrams.English, testString);
        }

        [Test]
        public void AtariToUnicode()
        {
            string testString;

            testString = Encoding.AtariEncoding.GetString(PunctuationsBytes);
            Assert.AreEqual(Punctuations, testString);
            testString = Encoding.AtariEncoding.GetString(DigitsBytes);
            Assert.AreEqual(Digits, testString);
            testString = Encoding.AtariEncoding.GetString(UpperLatinBytes);
            Assert.AreEqual(UpperLatin, testString);
            testString = Encoding.AtariEncoding.GetString(LowerLatinBytes);
            Assert.AreEqual(LowerLatin, testString);

            testString = Encoding.AtariEncoding.GetString(GraphicsBytes);
            Assert.AreEqual(Graphics, testString);
            testString = Encoding.AtariEncoding.GetString(ArrowsBytes);
            Assert.AreEqual(Arrows, testString);
            testString = Encoding.AtariEncoding.GetString(DecksBytes);
            Assert.AreEqual(Decks, testString);
        }

        [Test]
        public void UnicodeToAtari()
        {
            byte[] byteArray;

            byteArray = Encoding.AtariEncoding.GetBytes(Punctuations);
            Assert.AreEqual(PunctuationsBytes, byteArray);
            byteArray = Encoding.AtariEncoding.GetBytes(Digits);
            Assert.AreEqual(DigitsBytes, byteArray);
            byteArray = Encoding.AtariEncoding.GetBytes(UpperLatin);
            Assert.AreEqual(UpperLatinBytes, byteArray);
            byteArray = Encoding.AtariEncoding.GetBytes(LowerLatin);
            Assert.AreEqual(LowerLatinBytes, byteArray);

            byteArray = Encoding.AtariEncoding.GetBytes(Graphics);
            Assert.AreEqual(GraphicsBytes, byteArray);
            byteArray = Encoding.AtariEncoding.GetBytes(Arrows);
            Assert.AreEqual(ArrowsBytes, byteArray);
            byteArray = Encoding.AtariEncoding.GetBytes(Decks);
            Assert.AreEqual(DecksBytes, byteArray);
        }
    }
}