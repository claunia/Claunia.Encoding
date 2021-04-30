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

using System.Text;

namespace Claunia.Encoding
{
    /// <summary>Represents an Atari ST character encoding of Unicode characters.</summary>
    public class AtariST : SingleByteEncodingWithRunes
    {
        /// <inheritdoc />
        public override string BodyName => "atarist";
        /// <inheritdoc />
        public override int CodePage => 0;
        /// <inheritdoc />
        public override string EncodingName => "Western European (Atari ST)";
        /// <inheritdoc />
        public override string HeaderName => "atarist";
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

        /// <summary>The Atari ST to Unicode character map.</summary>
        protected override Rune[] CharTable => new[]
        {
            // 0x00
            new Rune(0x0000), new Rune(0x21E7), new Rune(0x21E9), new Rune(0x21E8), new Rune(0x21E6), new Rune(0x1FBBD),
            new Rune(0x1FBBE), new Rune(0x1FBBF),

            // 0x08
            new Rune(0x2713), new Rune(0x1F552), new Rune(0x1F514), new Rune(0x266A), new Rune(0x000C),
            new Rune(0x000D), new Rune(0xFFFD), new Rune(0xFFFD),

            // 0x10
            new Rune(0x1FBF0), new Rune(0x1FBF1), new Rune(0x1FBF2), new Rune(0x1FBF3), new Rune(0x1FBF4),
            new Rune(0x1FBF5), new Rune(0x1FBF6), new Rune(0x1FBF7),

            // 0x18
            new Rune(0x1FBF8), new Rune(0x1FBF9), new Rune(0x0259), new Rune(0x001B), new Rune(0xFFFD),
            new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD),

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
            new Rune(0x0060), new Rune(0x0061), new Rune(0x0062), new Rune(0x0063), new Rune(0x0064), new Rune(0x0065),
            new Rune(0x0066), new Rune(0x0067),

            // 0x68
            new Rune(0x0068), new Rune(0x0069), new Rune(0x006A), new Rune(0x006B), new Rune(0x006C), new Rune(0x006D),
            new Rune(0x006E), new Rune(0x006F),

            // 0x70
            new Rune(0x0070), new Rune(0x0071), new Rune(0x0072), new Rune(0x0073), new Rune(0x0074), new Rune(0x0075),
            new Rune(0x0076), new Rune(0x0077),

            // 0x78
            new Rune(0x0078), new Rune(0x0079), new Rune(0x007A), new Rune(0x007B), new Rune(0x007C), new Rune(0x007D),
            new Rune(0x007E), new Rune(0x2302),

            // 0x80
            new Rune(0x00C7), new Rune(0x00FC), new Rune(0x00E9), new Rune(0x00E2), new Rune(0x00E4), new Rune(0x00E0),
            new Rune(0x00E5), new Rune(0x00E7),

            // 0x88
            new Rune(0x00EA), new Rune(0x00EB), new Rune(0x00E8), new Rune(0x00EF), new Rune(0x00EE), new Rune(0x00EC),
            new Rune(0x00C4), new Rune(0x00C5),

            // 0x90
            new Rune(0x00C9), new Rune(0x00E6), new Rune(0x00C6), new Rune(0x00F4), new Rune(0x00F6), new Rune(0x00F2),
            new Rune(0x00FB), new Rune(0x00F9),

            // 0x98
            new Rune(0x00FF), new Rune(0x00D6), new Rune(0x00DC), new Rune(0x00A2), new Rune(0x00A3), new Rune(0x00A5),
            new Rune(0x00DF), new Rune(0x0192),

            // 0xA0
            new Rune(0x00E1), new Rune(0x00ED), new Rune(0x00F3), new Rune(0x00FA), new Rune(0x00F1), new Rune(0x00D1),
            new Rune(0x00AA), new Rune(0x00BA),

            // 0xA8
            new Rune(0x00BF), new Rune(0x2310), new Rune(0x00AC), new Rune(0x00BD), new Rune(0x00BC), new Rune(0x00A1),
            new Rune(0x00AB), new Rune(0x00BB),

            // 0xB0
            new Rune(0x00E3), new Rune(0x00F5), new Rune(0x00D8), new Rune(0x00F8), new Rune(0x0153), new Rune(0x0152),
            new Rune(0x00C0), new Rune(0x00C3),

            // 0xB8
            new Rune(0x00D5), new Rune(0x00A8), new Rune(0x00B4), new Rune(0x2020), new Rune(0x00B6), new Rune(0x00A9),
            new Rune(0x00AE), new Rune(0x2122),

            // 0xC0
            new Rune(0x0133), new Rune(0x0132), new Rune(0x05D0), new Rune(0x05D1), new Rune(0x05D2), new Rune(0x05D3),
            new Rune(0x05D4), new Rune(0x05D5),

            // 0xC8
            new Rune(0x05D6), new Rune(0x05D7), new Rune(0x05D8), new Rune(0x05D9), new Rune(0x05DB), new Rune(0x05DC),
            new Rune(0x05DE), new Rune(0x05E0),

            // 0xD0
            new Rune(0x05E1), new Rune(0x05E2), new Rune(0x05E4), new Rune(0x05E6), new Rune(0x05E7), new Rune(0x05E8),
            new Rune(0x05E9), new Rune(0x05EA),

            // 0xD8
            new Rune(0x05DF), new Rune(0x05DA), new Rune(0x05DD), new Rune(0x05E3), new Rune(0x05E5), new Rune(0x00A7),
            new Rune(0x2227), new Rune(0x221E),

            // 0xE0
            new Rune(0x03B1), new Rune(0x03B2), new Rune(0x0393), new Rune(0x03C0), new Rune(0x03A3), new Rune(0x03C3),
            new Rune(0x00B5), new Rune(0x03C4),

            // 0xE8
            new Rune(0x03A6), new Rune(0x0398), new Rune(0x03A9), new Rune(0x03B4), new Rune(0x222E), new Rune(0x03D5),
            new Rune(0x2208), new Rune(0x2229),

            // 0xF0
            new Rune(0x2261), new Rune(0x00B1), new Rune(0x2265), new Rune(0x2264), new Rune(0x2320), new Rune(0x2321),
            new Rune(0x00F7), new Rune(0x2248),

            // 0xF8
            new Rune(0x00B0), new Rune(0x2219), new Rune(0x00B7), new Rune(0x221A), new Rune(0x207F), new Rune(0x00B2),
            new Rune(0x00B3), new Rune(0x00AF)
        };

        /// <summary>Converts a Unicode character to an Atari ST character</summary>
        /// <returns>Atari ST character.</returns>
        /// <param name="character">Unicode character.</param>
        private protected override byte GetByte(Rune character) => character.Value switch
        {
            0x0000  => 0x00,
            0x21E7  => 0x01,
            0x21E9  => 0x02,
            0x21E8  => 0x03,
            0x21E6  => 0x04,
            0x274E  => 0x05,
            0x1FBBD => 0x05,
            0x1FBBE => 0x06,
            0x1FBBF => 0x07,
            0x2713  => 0x08,
            0x1F552 => 0x09,
            0x1F514 => 0x0A,
            0x266A  => 0x0B,
            0x000C  => 0x0C,
            0x000D  => 0x0D,
            0x1FBF0 => 0x10,
            0x1FBF1 => 0x11,
            0x1FBF2 => 0x12,
            0x1FBF3 => 0x13,
            0x1FBF4 => 0x14,
            0x1FBF5 => 0x15,
            0x1FBF6 => 0x16,
            0x1FBF7 => 0x17,
            0x1FBF8 => 0x18,
            0x1FBF9 => 0x19,
            0x0259  => 0x1A,
            0x001B  => 0x1B,
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
            0x0060  => 0x60,
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
            0x007B  => 0x7B,
            0x007C  => 0x7C,
            0x007D  => 0x7D,
            0x007E  => 0x7E,
            0x2302  => 0x7F,
            0x00C7  => 0x80,
            0x00FC  => 0x81,
            0x00E9  => 0x82,
            0x00E2  => 0x83,
            0x00E4  => 0x84,
            0x00E0  => 0x85,
            0x00E5  => 0x86,
            0x00E7  => 0x87,
            0x00EA  => 0x88,
            0x00EB  => 0x89,
            0x00E8  => 0x8A,
            0x00EF  => 0x8B,
            0x00EE  => 0x8C,
            0x00EC  => 0x8D,
            0x00C4  => 0x8E,
            0x00C5  => 0x8F,
            0x00C9  => 0x90,
            0x00E6  => 0x91,
            0x00C6  => 0x92,
            0x00F4  => 0x93,
            0x00F6  => 0x94,
            0x00F2  => 0x95,
            0x00FB  => 0x96,
            0x00F9  => 0x97,
            0x00FF  => 0x98,
            0x00D6  => 0x99,
            0x00DC  => 0x9A,
            0x00A2  => 0x9B,
            0x00A3  => 0x9C,
            0x00A5  => 0x9D,
            0x00DF  => 0x9E,
            0x0192  => 0x9F,
            0x00E1  => 0xA0,
            0x00ED  => 0xA1,
            0x00F3  => 0xA2,
            0x00FA  => 0xA3,
            0x00F1  => 0xA4,
            0x00D1  => 0xA5,
            0x00AA  => 0xA6,
            0x00BA  => 0xA7,
            0x00BF  => 0xA8,
            0x2310  => 0xA9,
            0x00AC  => 0xAA,
            0x00BD  => 0xAB,
            0x00BC  => 0xAC,
            0x00A1  => 0xAD,
            0x00AB  => 0xAE,
            0x00BB  => 0xAF,
            0x00E3  => 0xB0,
            0x00F5  => 0xB1,
            0x00D8  => 0xB2,
            0x00F8  => 0xB3,
            0x0153  => 0xB4,
            0x0152  => 0xB5,
            0x00C0  => 0xB6,
            0x00C3  => 0xB7,
            0x00D5  => 0xB8,
            0x00A8  => 0xB9,
            0x00B4  => 0xBA,
            0x2020  => 0xBB,
            0x00B6  => 0xBC,
            0x00A9  => 0xBD,
            0x00AE  => 0xBE,
            0x2122  => 0xBF,
            0x0133  => 0xC0,
            0x0132  => 0xC1,
            0x05D0  => 0xC2,
            0x05D1  => 0xC3,
            0x05D2  => 0xC4,
            0x05D3  => 0xC5,
            0x05D4  => 0xC6,
            0x05D5  => 0xC7,
            0x05D6  => 0xC8,
            0x05D7  => 0xC9,
            0x05D8  => 0xCA,
            0x05D9  => 0xCB,
            0x05DB  => 0xCC,
            0x05DC  => 0xCD,
            0x05DE  => 0xCE,
            0x05E0  => 0xCF,
            0x05E1  => 0xD0,
            0x05E2  => 0xD1,
            0x05E4  => 0xD2,
            0x05E6  => 0xD3,
            0x05E7  => 0xD4,
            0x05E8  => 0xD5,
            0x05E9  => 0xD6,
            0x05EA  => 0xD7,
            0x05DF  => 0xD8,
            0x05DA  => 0xD9,
            0x05DD  => 0xDA,
            0x05E3  => 0xDB,
            0x05E5  => 0xDC,
            0x00A7  => 0xDD,
            0x2227  => 0xDE,
            0x221E  => 0xDF,
            0x03B1  => 0xE0,
            0x03B2  => 0xE1,
            0x0393  => 0xE2,
            0x03C0  => 0xE3,
            0x03A3  => 0xE4,
            0x03C3  => 0xE5,
            0x00B5  => 0xE6,
            0x03C4  => 0xE7,
            0x03A6  => 0xE8,
            0x0398  => 0xE9,
            0x03A9  => 0xEA,
            0x03B4  => 0xEB,
            0x222E  => 0xEC,
            0x03D5  => 0xED,
            0x2208  => 0xEE,
            0x2229  => 0xEF,
            0x2261  => 0xF0,
            0x00B1  => 0xF1,
            0x2265  => 0xF2,
            0x2264  => 0xF3,
            0x2320  => 0xF4,
            0x2321  => 0xF5,
            0x00F7  => 0xF6,
            0x2248  => 0xF7,
            0x00B0  => 0xF8,
            0x2219  => 0xF9,
            0x00B7  => 0xFA,
            0x221A  => 0xFB,
            0x207F  => 0xFC,
            0x00B2  => 0xFD,
            0x00B3  => 0xFE,
            0x00AF  => 0xFF,
            _       => 0x3F
        };
    }
}