//
// ZX81.cs
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
    /// <summary>Represents a ZX81 character encoding of Unicode characters.</summary>
    public class ZX81 : SingleByteEncodingWithRunes
    {
        /// <inheritdoc />
        public override string BodyName => "zx81";
        /// <inheritdoc />
        public override int CodePage => 0;
        /// <inheritdoc />
        public override string EncodingName => "Sinclair ZX81 character set";
        /// <inheritdoc />
        public override string HeaderName => "zx81";
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

        /// <summary>The ZX81 to Unicode character map.</summary>
        protected override Rune[] CharTable => new[]
        {
            // 0x00
            new Rune(0x0020), new Rune(0x2598), new Rune(0x259D), new Rune(0x2580), new Rune(0x2596), new Rune(0x258C),
            new Rune(0x259E), new Rune(0x259B),

            // 0x08
            new Rune(0x2592), new Rune(0x1FB8F), new Rune(0x1FB8E), new Rune(0x0022), new Rune(0x00A3),
            new Rune(0x0024), new Rune(0x003A), new Rune(0x003F),

            // 0x10
            new Rune(0x0028), new Rune(0x0029), new Rune(0x003E), new Rune(0x003C), new Rune(0x003D), new Rune(0x002B),
            new Rune(0x002D), new Rune(0x002A),

            // 0x18
            new Rune(0x002F), new Rune(0x003B), new Rune(0x002C), new Rune(0x002E), new Rune(0x0030), new Rune(0x0031),
            new Rune(0x0032), new Rune(0x0033),

            // 0x20
            new Rune(0x0034), new Rune(0x0035), new Rune(0x0036), new Rune(0x0037), new Rune(0x0038), new Rune(0x0039),
            new Rune(0x0041), new Rune(0x0042),

            // 0x28
            new Rune(0x0043), new Rune(0x0044), new Rune(0x0045), new Rune(0x0046), new Rune(0x0047), new Rune(0x0048),
            new Rune(0x0049), new Rune(0x004A),

            // 0x30
            new Rune(0x004B), new Rune(0x004C), new Rune(0x004D), new Rune(0x004E), new Rune(0x004F), new Rune(0x0050),
            new Rune(0x0051), new Rune(0x0052),

            // 0x38
            new Rune(0x0053), new Rune(0x0054), new Rune(0x0055), new Rune(0x0056), new Rune(0x0057), new Rune(0x0058),
            new Rune(0x0059), new Rune(0x005A),

            // 0x40
            new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

            // 0x48
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

            // 0x50
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

            // 0x58
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

            // 0x60
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

            // 0x68
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

            // 0x70
            new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF),
            new Rune(0x000A), new Rune(0x0008),

            // 0x78
            new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
            new Rune(0xFFFF), new Rune(0xFFFF),

            // 0x80
            new Rune(0x2588), new Rune(0x259F), new Rune(0x2599), new Rune(0x2584), new Rune(0x259C), new Rune(0x2590),
            new Rune(0x259A), new Rune(0x2597),

            // 0x88
            new Rune(0x1FB90), new Rune(0x1FB91), new Rune(0x1FB92), new Rune(0xFFFD), new Rune(0xFFFD),
            new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD),

            // 0x90
            new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD),
            new Rune(0xFFFD), new Rune(0xFFFD),

            // 0x98
            new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD),
            new Rune(0xFFFD), new Rune(0xFFFD),

            // 0xA0
            new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD),
            new Rune(0xFFFD), new Rune(0xFFFD),

            // 0xA8
            new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD),
            new Rune(0xFFFD), new Rune(0xFFFD),

            // 0xB0
            new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD),
            new Rune(0xFFFD), new Rune(0xFFFD),

            // 0xB8
            new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD), new Rune(0xFFFD),
            new Rune(0xFFFD), new Rune(0xFFFD),

            // 0xC0
            new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0x0000), new Rune(0xFFFF), new Rune(0xFFFF),
            new Rune(0xFFFF), new Rune(0xFFFF),

            // 0xC8
            new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF),
            new Rune(0xFFFF), new Rune(0xFFFF),

            // 0xD0
            new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF),
            new Rune(0xFFFF), new Rune(0xFFFF),

            // 0xD8
            new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF),
            new Rune(0xFFFF), new Rune(0xFFFF),

            // 0xE0
            new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF),
            new Rune(0xFFFF), new Rune(0xFFFF),

            // 0xE8
            new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF),
            new Rune(0xFFFF), new Rune(0xFFFF),

            // 0xF0
            new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF),
            new Rune(0xFFFF), new Rune(0xFFFF),

            // 0xF8
            new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF), new Rune(0xFFFF),
            new Rune(0xFFFF), new Rune(0xFFFF)
        };

        /// <summary>Converts a Unicode character to an ZX81 character</summary>
        /// <returns>ZX81 character.</returns>
        /// <param name="character">Unicode character.</param>
        private protected override byte GetByte(Rune character) => character.Value switch
        {
            0x0020  => 0x00,
            0x2598  => 0x01,
            0x259D  => 0x02,
            0x2580  => 0x03,
            0x2596  => 0x04,
            0x258C  => 0x05,
            0x259E  => 0x06,
            0x259B  => 0x07,
            0x2592  => 0x08,
            0x1FB8F => 0x09,
            0x1FB8E => 0x0A,
            0x0022  => 0x0B,
            0x00A3  => 0x0C,
            0x0024  => 0x0D,
            0x003A  => 0x0E,
            0x003F  => 0x0F,
            0x0028  => 0x10,
            0x0029  => 0x11,
            0x003E  => 0x12,
            0x003C  => 0x13,
            0x003D  => 0x14,
            0x002B  => 0x15,
            0x002D  => 0x16,
            0x002A  => 0x17,
            0x002F  => 0x18,
            0x003B  => 0x19,
            0x002C  => 0x1A,
            0x002E  => 0x1B,
            0x0030  => 0x1C,
            0x0031  => 0x1D,
            0x0032  => 0x1E,
            0x0033  => 0x1F,
            0x0034  => 0x20,
            0x0035  => 0x21,
            0x0036  => 0x22,
            0x0037  => 0x23,
            0x0038  => 0x24,
            0x0039  => 0x25,
            0x0041  => 0x26,
            0x0042  => 0x27,
            0x0043  => 0x28,
            0x0044  => 0x29,
            0x0045  => 0x2A,
            0x0046  => 0x2B,
            0x0047  => 0x2C,
            0x0048  => 0x2D,
            0x0049  => 0x2E,
            0x004A  => 0x2F,
            0x004B  => 0x30,
            0x004C  => 0x31,
            0x004D  => 0x32,
            0x004E  => 0x33,
            0x004F  => 0x34,
            0x0050  => 0x35,
            0x0051  => 0x36,
            0x0052  => 0x37,
            0x0053  => 0x38,
            0x0054  => 0x39,
            0x0055  => 0x3A,
            0x0056  => 0x3B,
            0x0057  => 0x3C,
            0x0058  => 0x3D,
            0x0059  => 0x3E,
            0x005A  => 0x3F,
            0x000D  => 0x74,
            0x000A  => 0x76,
            0x0008  => 0x77,
            0x2588  => 0x80,
            0x259F  => 0x81,
            0x2599  => 0x82,
            0x2584  => 0x83,
            0x259C  => 0x84,
            0x2590  => 0x85,
            0x259A  => 0x86,
            0x2597  => 0x87,
            0x1FB90 => 0x88,
            0x1FB91 => 0x89,
            0x1FB92 => 0x8A,
            _       => 0x0F
        };
    }
}