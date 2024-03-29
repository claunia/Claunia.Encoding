﻿//
// ATASCII.cs
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
public class Atascii
{
    const string PUNCTUATIONS = "!\"#$%&'()*+,-./:;<=>?@[\\]^_|";
    readonly byte[] _punctuationsBytes =
    {
        0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27, 0x28, 0x29, 0x2A, 0x2B, 0x2C, 0x2D, 0x2E, 0x2F, 0x3A, 0x3B, 0x3C,
        0x3D, 0x3E, 0x3F, 0x40, 0x5B, 0x5C, 0x5D, 0x5E, 0x5F, 0x7C
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

    const string GRAPHICS = "├┘┤┐╱╲◢▗◣▝▘▂▖┌─┼●▄▎┬┴▌└";
    readonly byte[] _graphicsBytes =
    {
        0x01, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0E, 0x0F, 0x11, 0x12, 0x13, 0x14, 0x15,
        0x16, 0x17, 0x18, 0x19, 0x1A
    };
    const string ARROWS = "↑↓←→🢰◀▶";
    readonly byte[] _arrowsBytes =
    {
        0x1C, 0x1D, 0x1E, 0x1F, 0x7D, 0x7E, 0x7F
    };
    const string DECKS = "♥♣♦♠";
    readonly byte[] _decksBytes =
    {
        0x00, 0x10, 0x60, 0x7B
    };

    [Test]
    public void AtariPangrams()
    {
        byte[] byteArray;
        string testString;

        byteArray  = Encoding.AtariEncoding.GetBytes(Pangrams.ENGLISH);
        testString = Encoding.AtariEncoding.GetString(byteArray);
        Assert.AreEqual(Pangrams.ENGLISH, testString);
    }

    [Test]
    public void AtariToUnicode()
    {
        string testString;

        testString = Encoding.AtariEncoding.GetString(_punctuationsBytes);
        Assert.AreEqual(PUNCTUATIONS, testString);
        testString = Encoding.AtariEncoding.GetString(_digitsBytes);
        Assert.AreEqual(DIGITS, testString);
        testString = Encoding.AtariEncoding.GetString(_upperLatinBytes);
        Assert.AreEqual(UPPER_LATIN, testString);
        testString = Encoding.AtariEncoding.GetString(_lowerLatinBytes);
        Assert.AreEqual(LOWER_LATIN, testString);

        testString = Encoding.AtariEncoding.GetString(_graphicsBytes);
        Assert.AreEqual(GRAPHICS, testString);
        testString = Encoding.AtariEncoding.GetString(_arrowsBytes);
        Assert.AreEqual(ARROWS, testString);
        testString = Encoding.AtariEncoding.GetString(_decksBytes);
        Assert.AreEqual(DECKS, testString);
    }

    [Test]
    public void UnicodeToAtari()
    {
        byte[] byteArray;

        byteArray = Encoding.AtariEncoding.GetBytes(PUNCTUATIONS);
        Assert.AreEqual(_punctuationsBytes, byteArray);
        byteArray = Encoding.AtariEncoding.GetBytes(DIGITS);
        Assert.AreEqual(_digitsBytes, byteArray);
        byteArray = Encoding.AtariEncoding.GetBytes(UPPER_LATIN);
        Assert.AreEqual(_upperLatinBytes, byteArray);
        byteArray = Encoding.AtariEncoding.GetBytes(LOWER_LATIN);
        Assert.AreEqual(_lowerLatinBytes, byteArray);

        byteArray = Encoding.AtariEncoding.GetBytes(GRAPHICS);
        Assert.AreEqual(_graphicsBytes, byteArray);
        byteArray = Encoding.AtariEncoding.GetBytes(ARROWS);
        Assert.AreEqual(_arrowsBytes, byteArray);
        byteArray = Encoding.AtariEncoding.GetBytes(DECKS);
        Assert.AreEqual(_decksBytes, byteArray);
    }
}