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
public class Radix50
{
    const string PUNCTUATIONS = " .$%";
    readonly byte[] _punctuationsBytes =
    {
        0b00000001, 0b11000110, 0b11011101
    };
    const string DIGITS = "0123456789";
    readonly byte[] _digitsBytes =
    {
        0b01111001, 0b11111000, 0b00100001, 0b10001010, 0b00111001, 0b00100101, 0b10011010, 0b01110000
    };
    const string UPPER_LATIN = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    readonly byte[] _upperLatinBytes =
    {
        0b00000100, 0b00100000, 0b11000100, 0b00010100, 0b01100001, 0b11001000, 0b00100100, 0b10100010, 0b11001100,
        0b00110100, 0b11100011, 0b11010000, 0b01000101, 0b00100100, 0b11010100, 0b01010101, 0b01100101, 0b11011000,
        0b01100101, 0b10100000
    };
    const string SENTENCE        = "THIS IS A TEST$";
    const string SENTENCE_PADDED = "THIS IS A TEST$ "; // It gets space padded when decoding is not multiple
    readonly byte[] _sentenceBytes =
    {
        0b01010000, 0b10000010, 0b01010011, 0b00000000, 0b10010100, 0b11000000, 0b00000100, 0b00000101, 0b00000101,
        0b01001101, 0b01000110, 0b11000000
    };

    [Test]
    public void RadixToUnicode()
    {
        string testString;

        testString = Encoding.Radix50Encoding.GetString(_punctuationsBytes);
        Assert.AreEqual(PUNCTUATIONS, testString);
        testString = Encoding.Radix50Encoding.GetString(_digitsBytes);
        Assert.AreEqual(DIGITS, testString);
        testString = Encoding.Radix50Encoding.GetString(_upperLatinBytes);
        Assert.AreEqual(UPPER_LATIN, testString);
        testString = Encoding.Radix50Encoding.GetString(_sentenceBytes);
        Assert.AreEqual(SENTENCE_PADDED, testString);
    }

    [Test]
    public void UnicodeToRadix()
    {
        byte[] byteArray;

        byteArray = Encoding.Radix50Encoding.GetBytes(PUNCTUATIONS);
        Assert.AreEqual(_punctuationsBytes, byteArray);
        byteArray = Encoding.Radix50Encoding.GetBytes(DIGITS);
        Assert.AreEqual(_digitsBytes, byteArray);
        byteArray = Encoding.Radix50Encoding.GetBytes(UPPER_LATIN);
        Assert.AreEqual(_upperLatinBytes, byteArray);
        byteArray = Encoding.Radix50Encoding.GetBytes(SENTENCE);
        Assert.AreEqual(_sentenceBytes, byteArray);
    }
}