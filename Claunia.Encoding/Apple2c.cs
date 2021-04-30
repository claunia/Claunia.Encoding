//
// Apple IIc.cs
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
    /// <summary>Represents an Apple IIc character encoding of Unicode characters.</summary>
    public sealed class Apple2c : SingleByteEncodingWithRunes
    {
        /// <inheritdoc />
        public override string BodyName => "apple2c";
        /// <inheritdoc />
        public override int CodePage => 0;
        /// <inheritdoc />
        public override string EncodingName => "Western European (Apple IIc)";
        /// <inheritdoc />
        public override string HeaderName => "apple2c";
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
        public override bool IsReadOnly => true;
        /// <inheritdoc />
        public override bool IsSingleByte => true;

        /// <summary>The Apple IIc to Unicode character map. Inverted screen characters are mapped to normal characters.</summary>
        protected override Rune[] CharTable => new[]
        {
            // 0x00
            new Rune(0x0000), new Rune(0x0001), new Rune(0x0002), new Rune(0x0003), new Rune(0x0004), new Rune(0x0005),
            new Rune(0x0006), new Rune(0x0007),

            // 0x08
            new Rune(0x0008), new Rune(0x0009), new Rune(0x000A), new Rune(0x000B), new Rune(0x000C), new Rune(0x000D),
            new Rune(0x000E), new Rune(0x000F),

            // 0x10
            new Rune(0x0010), new Rune(0x0011), new Rune(0x0012), new Rune(0x0013), new Rune(0x0014), new Rune(0x0015),
            new Rune(0x0016), new Rune(0x0017),

            // 0x18
            new Rune(0x0018), new Rune(0x0019), new Rune(0x001A), new Rune(0x001B), new Rune(0x001C), new Rune(0x001D),
            new Rune(0x001E), new Rune(0x001F),

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
            new Rune(0x0058), new Rune(0x0059), new Rune(0x005A), new Rune(0x005B), new Rune(0x00A3), new Rune(0x005D),
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
            new Rune(0x007E), new Rune(0x007F),

            // 0x80
            new Rune(0x0040), new Rune(0x0041), new Rune(0x0042), new Rune(0x0043), new Rune(0x0044), new Rune(0x0045),
            new Rune(0x0046), new Rune(0x0047),

            // 0x88
            new Rune(0x0048), new Rune(0x0049), new Rune(0x004A), new Rune(0x004B), new Rune(0x004C), new Rune(0x004D),
            new Rune(0x004E), new Rune(0x004F),

            // 0x90
            new Rune(0x0050), new Rune(0x0051), new Rune(0x0052), new Rune(0x0053), new Rune(0x0054), new Rune(0x0055),
            new Rune(0x0056), new Rune(0x0057),

            // 0x98
            new Rune(0x0058), new Rune(0x0059), new Rune(0x005A), new Rune(0x005B), new Rune(0x00A3), new Rune(0x005D),
            new Rune(0x005E), new Rune(0x0020),

            // 0xA0
            new Rune(0x2588), new Rune(0x0021), new Rune(0x0022), new Rune(0x0023), new Rune(0x0024), new Rune(0x0025),
            new Rune(0x0026), new Rune(0x0027),

            // 0xA8
            new Rune(0x0028), new Rune(0x0029), new Rune(0x002A), new Rune(0x002B), new Rune(0x002C), new Rune(0x002D),
            new Rune(0x002E), new Rune(0x002F),

            // 0xB0
            new Rune(0x0030), new Rune(0x0031), new Rune(0x0032), new Rune(0x0033), new Rune(0x0034), new Rune(0x0035),
            new Rune(0x0036), new Rune(0x0037),

            // 0xB8
            new Rune(0x0030), new Rune(0x0031), new Rune(0x0032), new Rune(0x0033), new Rune(0x0034), new Rune(0x0035),
            new Rune(0x0036), new Rune(0x0037),

            // 0xC0
            new Rune(0xF8FF), new Rune(0x0000), new Rune(0x1FBB0), new Rune(0x231B), new Rune(0x2713),
            new Rune(0x1FBB1), new Rune(0x1FBB2), new Rune(0x1FBB3),

            // 0xC8
            new Rune(0x2190), new Rune(0x2026), new Rune(0x2193), new Rune(0x2191), new Rune(0x1FB76), new Rune(0x21B5),
            new Rune(0x2589), new Rune(0x1FBB5),

            // 0xD0
            new Rune(0x1FBB6), new Rune(0x1FBB7), new Rune(0x1FBB8), new Rune(0x2500), new Rune(0x1FB7C),
            new Rune(0x2192), new Rune(0x2592), new Rune(0x1FB90),

            // 0xD8
            new Rune(0x1FBB9), new Rune(0x1FBBA), new Rune(0x2595), new Rune(0x25c6), new Rune(0x1FB80),
            new Rune(0x1FBBB), new Rune(0x1FBBC), new Rune(0x258F),

            // 0xE0
            new Rune(0x0060), new Rune(0x0061), new Rune(0x0062), new Rune(0x0063), new Rune(0x0064), new Rune(0x0065),
            new Rune(0x0066), new Rune(0x0067),

            // 0xE8
            new Rune(0x0068), new Rune(0x0069), new Rune(0x006A), new Rune(0x006B), new Rune(0x006C), new Rune(0x006D),
            new Rune(0x006E), new Rune(0x006F),

            // 0xF0
            new Rune(0x0070), new Rune(0x0071), new Rune(0x0072), new Rune(0x0073), new Rune(0x0074), new Rune(0x0075),
            new Rune(0x0076), new Rune(0x0077),

            // 0xF8
            new Rune(0x0078), new Rune(0x0079), new Rune(0x007A), new Rune(0x007B), new Rune(0x007C), new Rune(0x007D),
            new Rune(0x007E), new Rune(0x007F)
        };

        /// <summary>Converts a Unicode character to an Apple IIc character</summary>
        /// <returns>Apple IIc character.</returns>
        /// <param name="character">Unicode character.</param>
        private protected override byte GetByte(Rune character) => character.Value switch
        {
            0x0000  => 0x00,
            0x0001  => 0x01,
            0x0002  => 0x02,
            0x0003  => 0x03,
            0x0004  => 0x04,
            0x0005  => 0x05,
            0x0006  => 0x06,
            0x0007  => 0x07,
            0x0008  => 0x08,
            0x0009  => 0x09,
            0x000A  => 0x0A,
            0x000B  => 0x0B,
            0x000C  => 0x0C,
            0x000D  => 0x0D,
            0x000E  => 0x0E,
            0x000F  => 0x0F,
            0x0010  => 0x10,
            0x0011  => 0x11,
            0x0012  => 0x12,
            0x0013  => 0x13,
            0x0014  => 0x14,
            0x0015  => 0x15,
            0x0016  => 0x16,
            0x0017  => 0x17,
            0x0018  => 0x18,
            0x0019  => 0x19,
            0x001A  => 0x1A,
            0x001B  => 0x1B,
            0x001C  => 0x1C,
            0x001D  => 0x1D,
            0x001E  => 0x1E,
            0x001F  => 0x1F,
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
            0x00A3  => 0x5C,
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
            0x007F  => 0x7F,
            0x2588  => 0xA0,
            0xF8FF  => 0xC0,
            0x1FBB0 => 0xC2,
            0x231B  => 0xC3,
            0x2713  => 0xC4,
            0x1FBB1 => 0xC5,
            0x1FBB2 => 0xC6,
            0x1FBB3 => 0xC7,
            0x2190  => 0xC8,
            0x2026  => 0xC9,
            0x2193  => 0xCA,
            0x2191  => 0xCB,
            0x1FB76 => 0xCC,
            0x21B5  => 0xCD,
            0x2589  => 0xCE,
            0x1FBB5 => 0xCF,
            0x1FBB6 => 0xD0,
            0x1FBB7 => 0xD1,
            0x1FBB8 => 0xD2,
            0x2500  => 0xD3,
            0x1FB7C => 0xD4,
            0x2192  => 0xD5,
            0x2592  => 0xD6,
            0x1FB90 => 0xD7,
            0x1FBB9 => 0xD8,
            0x1FBBA => 0xD9,
            0x2595  => 0xDA,
            0x25C6  => 0xDB,
            0x1FB80 => 0xDC,
            0x1FBBB => 0xDD,
            0x1FBBC => 0xDE,
            0x258F  => 0xDF,
            _       => 0x3F
        };
    }
}