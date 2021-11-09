//
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

namespace Claunia.Encoding;

/// <summary>Represents an ATARI Standard Code for Information Interchange character encoding of Unicode characters.</summary>
public class ATASCII : SingleByteEncodingWithRunes
{
    /// <inheritdoc />
    public override string BodyName => "atascii";
    /// <inheritdoc />
    public override int CodePage => 0;
    /// <inheritdoc />
    public override string EncodingName => "Atari Standard Code for Information Interchange";
    /// <inheritdoc />
    public override string HeaderName => "atascii";
    /// <inheritdoc />
    public override string WebName => "";
    /// <inheritdoc />
    public override int WindowsCodePage => 0;

    /// <inheritdoc />
    public override bool IsBrowserDisplay => false;
    /// <inheritdoc />
    public override bool IsBrowserSave => false;
    /// <inheritdoc />
    public override bool IsMailNewsDisplay => false;
    /// <inheritdoc />
    public override bool IsMailNewsSave => false;
    /// <inheritdoc />
    public override bool IsReadOnly => false;
    /// <inheritdoc />
    public override bool IsSingleByte => true;

    /// <summary>The ATASCII to Unicode character map.</summary>
    protected override Rune[] CharTable => new[]
    {
        // 0x00
        new Rune(0x2665), new Rune(0x251C), new Rune(0x1FB87), new Rune(0x2518), new Rune(0x2524), new Rune(0x2510),
        new Rune(0x2571), new Rune(0x2572),

        // 0x08
        new Rune(0x25E2), new Rune(0x2597), new Rune(0x25E3), new Rune(0x259D), new Rune(0x2598), new Rune(0x1FB82),
        new Rune(0x2582), new Rune(0x2596),

        // 0x10
        new Rune(0x2663), new Rune(0x250C), new Rune(0x2500), new Rune(0x253C), new Rune(0x25CF), new Rune(0x2584),
        new Rune(0x258E), new Rune(0x252C),

        // 0x18
        new Rune(0x2534), new Rune(0x258C), new Rune(0x2514), new Rune(0x001B), new Rune(0x2191), new Rune(0x2193),
        new Rune(0x2190), new Rune(0x2192),

        // 0x20
        new Rune(0x0020), new Rune(0x0021), new Rune(0x0022), new Rune(0x0023), new Rune(0x0024), new Rune(0x0025),
        new Rune(0x0026), new Rune(0x0027),

        // 0x28
        new Rune(0x0028), new Rune(0x0029), new Rune(0x002A), new Rune(0x002B), new Rune(0x002C), new Rune(0x002D),
        new Rune(0x002E), new Rune(0x002F),

        // 0x30
        new Rune(0x0030), new Rune(0x0031), new Rune(0x0032), new Rune(0x0033), new Rune(0x0034), new Rune(0x0035),
        new Rune(0x0036), new Rune(0x0037),

        // 0x38
        new Rune(0x0038), new Rune(0x0039), new Rune(0x003A), new Rune(0x003B), new Rune(0x003C), new Rune(0x003D),
        new Rune(0x003E), new Rune(0x003F),

        // 0x40
        new Rune(0x0040), new Rune(0x0041), new Rune(0x0042), new Rune(0x0043), new Rune(0x0044), new Rune(0x0045),
        new Rune(0x0046), new Rune(0x0047),

        // 0x48
        new Rune(0x0048), new Rune(0x0049), new Rune(0x004A), new Rune(0x004B), new Rune(0x004C), new Rune(0x004D),
        new Rune(0x004E), new Rune(0x004F),

        // 0x50
        new Rune(0x0050), new Rune(0x0051), new Rune(0x0052), new Rune(0x0053), new Rune(0x0054), new Rune(0x0055),
        new Rune(0x0056), new Rune(0x0057),

        // 0x58
        new Rune(0x0058), new Rune(0x0059), new Rune(0x005A), new Rune(0x005B), new Rune(0x005C), new Rune(0x005D),
        new Rune(0x005E), new Rune(0x005F),

        // 0x60
        new Rune(0x2666), new Rune(0x0061), new Rune(0x0062), new Rune(0x0063), new Rune(0x0064), new Rune(0x0065),
        new Rune(0x0066), new Rune(0x0067),

        // 0x68
        new Rune(0x0068), new Rune(0x0069), new Rune(0x006A), new Rune(0x006B), new Rune(0x006C), new Rune(0x006D),
        new Rune(0x006E), new Rune(0x006F),

        // 0x70
        new Rune(0x0070), new Rune(0x0071), new Rune(0x0072), new Rune(0x0073), new Rune(0x0074), new Rune(0x0075),
        new Rune(0x0076), new Rune(0x0077),

        // 0x78
        new Rune(0x0078), new Rune(0x0079), new Rune(0x007A), new Rune(0x2660), new Rune(0x007C), new Rune(0x1F8B0),
        new Rune(0x25C0), new Rune(0x25B6),

        // 0x80
        new Rune(0x0000), new Rune(0x0000), new Rune(0x258A), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0x88
        new Rune(0x25E4), new Rune(0x259B), new Rune(0x25E5), new Rune(0x2599), new Rune(0x259F), new Rune(0x2586),
        new Rune(0x0000), new Rune(0x259C),

        // 0x90
        new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x25D8), new Rune(0x2580),
        new Rune(0x0000), new Rune(0x0000),

        // 0x98
        new Rune(0x0000), new Rune(0x2590), new Rune(0x0000), new Rune(0x000D), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0xA0
        new Rune(0x2588), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0xA8
        new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0xB0
        new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0xB8
        new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0xC0
        new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0xC8
        new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0xD0
        new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0xD8
        new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0xE0
        new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0xE8
        new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0xF0
        new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
        new Rune(0x0000), new Rune(0x0000),

        // 0xF8
        new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0007),
        new Rune(0x0000), new Rune(0x0000)
    };

    /// <summary>Converts a Unicode character to an ATASCII character</summary>
    /// <returns>ATASCII character.</returns>
    /// <param name="character">Unicode character.</param>
    private protected override byte GetByte(Rune character) => character.Value switch
    {
        0x2665  => 0x00,
        0x251C  => 0x01,
        0x1FB87 => 0x02,
        0x2518  => 0x03,
        0x2524  => 0x04,
        0x2510  => 0x05,
        0x2571  => 0x06,
        0x2572  => 0x07,
        0x25E2  => 0x08,
        0x2597  => 0x09,
        0x25E3  => 0x0A,
        0x259D  => 0x0B,
        0x2598  => 0x0C,
        0x1FB82 => 0x0D,
        0x2582  => 0x0E,
        0x2596  => 0x0F,
        0x2663  => 0x10,
        0x250C  => 0x11,
        0x2500  => 0x12,
        0x253C  => 0x13,
        0x25CF  => 0x14,
        0x2584  => 0x15,
        0x258E  => 0x16,
        0x252C  => 0x17,
        0x2534  => 0x18,
        0x258C  => 0x19,
        0x2514  => 0x1A,
        0x001B  => 0x1B,
        0x2191  => 0x1C,
        0x2193  => 0x1D,
        0x2190  => 0x1E,
        0x2192  => 0x1F,
        0x0020  => 0x20,
        0x0021  => 0x21,
        0x0022  => 0x22,
        0x0023  => 0x23,
        0x0024  => 0x24,
        0x0025  => 0x25,
        0x0026  => 0x26,
        0x0027  => 0x27,
        0x0028  => 0x28,
        0x0029  => 0x29,
        0x002A  => 0x2A,
        0x002B  => 0x2B,
        0x002C  => 0x2C,
        0x002D  => 0x2D,
        0x002E  => 0x2E,
        0x002F  => 0x2F,
        0x0030  => 0x30,
        0x0031  => 0x31,
        0x0032  => 0x32,
        0x0033  => 0x33,
        0x0034  => 0x34,
        0x0035  => 0x35,
        0x0036  => 0x36,
        0x0037  => 0x37,
        0x0038  => 0x38,
        0x0039  => 0x39,
        0x003A  => 0x3A,
        0x003B  => 0x3B,
        0x003C  => 0x3C,
        0x003D  => 0x3D,
        0x003E  => 0x3E,
        0x003F  => 0x3F,
        0x0040  => 0x40,
        0x0041  => 0x41,
        0x0042  => 0x42,
        0x0043  => 0x43,
        0x0044  => 0x44,
        0x0045  => 0x45,
        0x0046  => 0x46,
        0x0047  => 0x47,
        0x0048  => 0x48,
        0x0049  => 0x49,
        0x004A  => 0x4A,
        0x004B  => 0x4B,
        0x004C  => 0x4C,
        0x004D  => 0x4D,
        0x004E  => 0x4E,
        0x004F  => 0x4F,
        0x0050  => 0x50,
        0x0051  => 0x51,
        0x0052  => 0x52,
        0x0053  => 0x53,
        0x0054  => 0x54,
        0x0055  => 0x55,
        0x0056  => 0x56,
        0x0057  => 0x57,
        0x0058  => 0x58,
        0x0059  => 0x59,
        0x005A  => 0x5A,
        0x005B  => 0x5B,
        0x005C  => 0x5C,
        0x005D  => 0x5D,
        0x005E  => 0x5E,
        0x005F  => 0x5F,
        0x2666  => 0x60,
        0x0061  => 0x61,
        0x0062  => 0x62,
        0x0063  => 0x63,
        0x0064  => 0x64,
        0x0065  => 0x65,
        0x0066  => 0x66,
        0x0067  => 0x67,
        0x0068  => 0x68,
        0x0069  => 0x69,
        0x006A  => 0x6A,
        0x006B  => 0x6B,
        0x006C  => 0x6C,
        0x006D  => 0x6D,
        0x006E  => 0x6E,
        0x006F  => 0x6F,
        0x0070  => 0x70,
        0x0071  => 0x71,
        0x0072  => 0x72,
        0x0073  => 0x73,
        0x0074  => 0x74,
        0x0075  => 0x75,
        0x0076  => 0x76,
        0x0077  => 0x77,
        0x0078  => 0x78,
        0x0079  => 0x79,
        0x007A  => 0x7A,
        0x2660  => 0x7B,
        0x007C  => 0x7C,
        0x1F8B0 => 0x7D,
        0x25C0  => 0x7E,
        0x25B6  => 0x7F,
        0x258A  => 0x82,
        0x25E4  => 0x88,
        0x259B  => 0x89,
        0x25E5  => 0x8A,
        0x2599  => 0x8B,
        0x259F  => 0x8C,
        0x2586  => 0x8D,
        0x259C  => 0x8F,
        0x25D8  => 0x94,
        0x2580  => 0x95,
        0x2590  => 0x99,
        0x000D  => 0x9B,
        0x2588  => 0xA0,
        0x0007  => 0xFD,
        _       => 0x3F
    };
}