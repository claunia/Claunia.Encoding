//
// Apple IIgs.cs
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
    /// <summary>Represents an Apple IIgs character encoding of Unicode characters.</summary>
    public class Apple2Gs : SingleByteEncodingWithRunes
    {
        public override string BodyName        => "apple2gs";
        public override int    CodePage        => 0;
        public override string EncodingName    => "Western European (Apple IIgs)";
        public override string HeaderName      => "apple2gs";
        public override string WebName         => "";
        public override int    WindowsCodePage => 0;

        public override bool IsBrowserDisplay  => false;
        public override bool IsBrowserSave     => false;
        public override bool IsMailNewsDisplay => false;
        public override bool IsMailNewsSave    => false;
        public override bool IsReadOnly        => true;
        public override bool IsSingleByte      => true;

        /// <summary>The Apple IIgs to Unicode character map. Inverted screen characters are mapped to normal characters.</summary>
        protected override Rune[] CharTable => new[]
        {
            // 0x00
            new Rune(0x0040), new Rune(0x0041), new Rune(0x0042), new Rune(0x0043), new Rune(0x0044), new Rune(0x0045),
            new Rune(0x0046), new Rune(0x0047),

            // 0x08
            new Rune(0x0048), new Rune(0x0049), new Rune(0x004A), new Rune(0x004B), new Rune(0x004C), new Rune(0x004D),
            new Rune(0x004E), new Rune(0x004F),

            // 0x10
            new Rune(0x0050), new Rune(0x0051), new Rune(0x0052), new Rune(0x0053), new Rune(0x0054), new Rune(0x0055),
            new Rune(0x0056), new Rune(0x0057),

            // 0x18
            new Rune(0x0058), new Rune(0x0059), new Rune(0x005A), new Rune(0x005B), new Rune(0x005C), new Rune(0x005D),
            new Rune(0x005E), new Rune(0x0020),

            // 0x20
            new Rune(0x2588), new Rune(0x0021), new Rune(0x0022), new Rune(0x0023), new Rune(0x0024), new Rune(0x0025),
            new Rune(0x0026), new Rune(0x0027),

            // 0x28
            new Rune(0x0028), new Rune(0x0029), new Rune(0x002A), new Rune(0x002B), new Rune(0x002C), new Rune(0x002D),
            new Rune(0x002E), new Rune(0x002F),

            // 0x30
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

            // 0x38
            new Rune(0x0038), new Rune(0x0039), new Rune(0x003A), new Rune(0x003B), new Rune(0x003C), new Rune(0x003D),
            new Rune(0x003E), new Rune(0x003F),

            // 0x40
            new Rune(0xF8FF), new Rune(0x0000), new Rune(0x1FBB0), new Rune(0x231B), new Rune(0x2713),
            new Rune(0x1FBB1), new Rune(0x1FBB4), new Rune(0x1FB81),

            // 0x48
            new Rune(0x2190), new Rune(0x2026), new Rune(0x2193), new Rune(0x2191), new Rune(0x2594), new Rune(0x21B5),
            new Rune(0x2589), new Rune(0x1FBB5),

            // 0x50
            new Rune(0x1FBB6), new Rune(0x1FBB7), new Rune(0x1FBB8), new Rune(0x2500), new Rune(0x1FB7C),
            new Rune(0x2192), new Rune(0x2592), new Rune(0x1FB90),

            // 0x58
            new Rune(0x1FBB9), new Rune(0x1FBBA), new Rune(0x2595), new Rune(0x25C6), new Rune(0x1FB80),
            new Rune(0x1FBBB), new Rune(0x1FBBC), new Rune(0x258F),

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
            new Rune(0x007E), new Rune(0x0000),

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
            new Rune(0x0058), new Rune(0x0059), new Rune(0x005A), new Rune(0x005B), new Rune(0x005C), new Rune(0x005D),
            new Rune(0x005E), new Rune(0x005F),

            // 0xA0
            new Rune(0x0020), new Rune(0x0021), new Rune(0x0022), new Rune(0x0023), new Rune(0x0024), new Rune(0x0025),
            new Rune(0x0026), new Rune(0x0027),

            // 0xA8
            new Rune(0x0028), new Rune(0x0029), new Rune(0x002A), new Rune(0x002B), new Rune(0x002C), new Rune(0x002D),
            new Rune(0x002E), new Rune(0x002F),

            // 0xB0
            new Rune(0x0030), new Rune(0x0031), new Rune(0x0032), new Rune(0x0033), new Rune(0x0034), new Rune(0x0035),
            new Rune(0x0036), new Rune(0x0037),

            // 0xB8
            new Rune(0x0038), new Rune(0x0039), new Rune(0x003A), new Rune(0x003B), new Rune(0x003C), new Rune(0x003D),
            new Rune(0x003E), new Rune(0x003F),

            // 0xC0
            new Rune(0x0040), new Rune(0x0041), new Rune(0x0042), new Rune(0x0043), new Rune(0x0044), new Rune(0x0045),
            new Rune(0x0046), new Rune(0x0047),

            // 0xC8
            new Rune(0x0048), new Rune(0x0049), new Rune(0x004A), new Rune(0x004B), new Rune(0x004C), new Rune(0x004D),
            new Rune(0x004E), new Rune(0x004F),

            // 0xD0
            new Rune(0x0050), new Rune(0x0051), new Rune(0x0052), new Rune(0x0053), new Rune(0x0054), new Rune(0x0055),
            new Rune(0x0056), new Rune(0x0057),

            // 0xD8
            new Rune(0x0058), new Rune(0x0059), new Rune(0x005A), new Rune(0x005B), new Rune(0x005C), new Rune(0x005D),
            new Rune(0x005E), new Rune(0x005F),

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
            new Rune(0x007E), new Rune(0x0000)
        };

        /// <summary>Converts a Unicode character to an Apple IIgs character</summary>
        /// <returns>Apple IIgs character.</returns>
        /// <param name="character">Unicode character.</param>
        private protected override byte GetByte(Rune character) => character.Value switch
        {
            0x2588  => 0x20,
            0xF8FF  => 0x40,
            0x1FBB0 => 0x42,
            0x231B  => 0x43,
            0x2713  => 0x44,
            0x1FBB1 => 0x45,
            0x1FBB4 => 0x46,
            0x1FB81 => 0x47,
            0x2190  => 0x48,
            0x2026  => 0x49,
            0x2193  => 0x4A,
            0x2191  => 0x4B,
            0x2594  => 0x4C,
            0x21B5  => 0x4D,
            0x2589  => 0x4E,
            0x1FBB5 => 0x4F,
            0x1FBB6 => 0x50,
            0x1FBB7 => 0x51,
            0x1FBB8 => 0x52,
            0x2500  => 0x53,
            0x1FB7C => 0x54,
            0x2192  => 0x55,
            0x2592  => 0x56,
            0x1FB90 => 0x57,
            0x1FBB9 => 0x58,
            0x1FBBA => 0x59,
            0x2595  => 0x5A,
            0x25C6  => 0x5B,
            0x1FB80 => 0x5C,
            0x1FBBB => 0x5D,
            0x1FBBC => 0x5E,
            0x258F  => 0x5F,
            0x0040  => 0x80,
            0x0041  => 0x81,
            0x0042  => 0x82,
            0x0043  => 0x83,
            0x0044  => 0x84,
            0x0045  => 0x85,
            0x0046  => 0x86,
            0x0047  => 0x87,
            0x0048  => 0x88,
            0x0049  => 0x89,
            0x004A  => 0x8A,
            0x004B  => 0x8B,
            0x004C  => 0x8C,
            0x004D  => 0x8D,
            0x004E  => 0x8E,
            0x004F  => 0x8F,
            0x0050  => 0x90,
            0x0051  => 0x91,
            0x0052  => 0x92,
            0x0053  => 0x93,
            0x0054  => 0x94,
            0x0055  => 0x95,
            0x0056  => 0x96,
            0x0057  => 0x97,
            0x0058  => 0x98,
            0x0059  => 0x99,
            0x005A  => 0x9A,
            0x005B  => 0x9B,
            0x005C  => 0x9C,
            0x005D  => 0x9D,
            0x005E  => 0x9E,
            0x005F  => 0x9F,
            0x0020  => 0xA0,
            0x0021  => 0xA1,
            0x0022  => 0xA2,
            0x0023  => 0xA3,
            0x0024  => 0xA4,
            0x2025  => 0xA5,
            0x0026  => 0xA6,
            0x0027  => 0xA7,
            0x0028  => 0xA8,
            0x0029  => 0xA9,
            0x002A  => 0xAA,
            0x002B  => 0xAB,
            0x002C  => 0xAC,
            0x002D  => 0xAD,
            0x002E  => 0xAE,
            0x002F  => 0xAF,
            0x0030  => 0xB0,
            0x0031  => 0xB1,
            0x0032  => 0xB2,
            0x0033  => 0xB3,
            0x0034  => 0xB4,
            0x0035  => 0xB5,
            0x0036  => 0xB6,
            0x0037  => 0xB7,
            0x0038  => 0xB8,
            0x0039  => 0xB9,
            0x003A  => 0xBA,
            0x003B  => 0xBB,
            0x003C  => 0xBC,
            0x003D  => 0xBD,
            0x003E  => 0xBE,
            0x003F  => 0xBF,
            0x0060  => 0xE0,
            0x0061  => 0xE1,
            0x0062  => 0xE2,
            0x0063  => 0xE3,
            0x0064  => 0xE4,
            0x0065  => 0xE5,
            0x0066  => 0xE6,
            0x0067  => 0xE7,
            0x0068  => 0xE8,
            0x0069  => 0xE9,
            0x006A  => 0xEA,
            0x006B  => 0xEB,
            0x006C  => 0xEC,
            0x006D  => 0xED,
            0x006E  => 0xEE,
            0x006F  => 0xEF,
            0x0070  => 0xF0,
            0x0071  => 0xF1,
            0x0072  => 0xF2,
            0x0073  => 0xF3,
            0x0074  => 0xF4,
            0x0075  => 0xF5,
            0x0076  => 0xF6,
            0x0077  => 0xF7,
            0x0078  => 0xF8,
            0x0079  => 0xF9,
            0x007A  => 0xFA,
            0x007B  => 0xFB,
            0x007C  => 0xFC,
            0x007D  => 0xFD,
            0x007E  => 0xFE,
            _       => 0xBF
        };
    }
}