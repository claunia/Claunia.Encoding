//
// Apple II.cs
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

namespace Claunia.Encoding
{
    /// <summary>Represents an Apple II character encoding of Unicode characters.</summary>
    public sealed class Apple2 : SingleByteEncoding
    {
        /// <inheritdoc />
        public override string BodyName => "apple2";
        /// <inheritdoc />
        public override int CodePage => 0;
        /// <inheritdoc />
        public override string EncodingName => "Western European (Apple II)";
        /// <inheritdoc />
        public override string HeaderName => "apple2";
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

        /// <summary>The Apple II to Unicode character map.</summary>
        protected override char[] CharTable => new[]
        {
            // 0x00
            '\u0040', '\u0041', '\u0042', '\u0043', '\u0044', '\u0045', '\u0046', '\u0047',

            // 0x08
            '\u0048', '\u0049', '\u004A', '\u004B', '\u004C', '\u004D', '\u004E', '\u004F',

            // 0x10
            '\u0050', '\u0051', '\u0052', '\u0053', '\u0054', '\u0055', '\u0056', '\u0057',

            // 0x18
            '\u0058', '\u0059', '\u005A', '\u005B', '\u005C', '\u005D', '\u005E', '\u005F',

            // 0x20
            '\u0020', '\u0021', '\u0022', '\u0023', '\u0024', '\u0025', '\u0026', '\u0027',

            // 0x28
            '\u0028', '\u0029', '\u002A', '\u002B', '\u002C', '\u002D', '\u002E', '\u002F',

            // 0x30
            '\u0030', '\u0031', '\u0032', '\u0033', '\u0034', '\u0035', '\u0036', '\u0037',

            // 0x38
            '\u0038', '\u0039', '\u003A', '\u003B', '\u003C', '\u003D', '\u003E', '\u003F',

            // 0x40
            '\u0040', '\u0041', '\u0042', '\u0043', '\u0044', '\u0045', '\u0046', '\u0047',

            // 0x48
            '\u0048', '\u0049', '\u004A', '\u004B', '\u004C', '\u004D', '\u004E', '\u004F',

            // 0x50
            '\u0050', '\u0051', '\u0052', '\u0053', '\u0054', '\u0055', '\u0056', '\u0057',

            // 0x58
            '\u0058', '\u0059', '\u005A', '\u005B', '\u005C', '\u005D', '\u005E', '\u005F',

            // 0x60
            '\u0020', '\u0021', '\u0022', '\u0023', '\u0024', '\u0025', '\u0026', '\u0027',

            // 0x68
            '\u0028', '\u0029', '\u002A', '\u002B', '\u002C', '\u002D', '\u002E', '\u002F',

            // 0x70
            '\u0030', '\u0031', '\u0032', '\u0033', '\u0034', '\u0035', '\u0036', '\u0037',

            // 0x78
            '\u0038', '\u0039', '\u003A', '\u003B', '\u003C', '\u003D', '\u003E', '\u003F',

            // 0x80
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x88
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x90
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x98
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xA0
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xA8
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xB0
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xB8
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xC0
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xC8
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xD0
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xD8
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xE0
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xE8
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xF0
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xF8
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000'
        };

        /// <summary>Converts a Unicode character to an Apple II character</summary>
        /// <returns>Apple II character.</returns>
        /// <param name="character">Unicode character.</param>
        private protected override byte GetByte(char character) => character switch
        {
            '\u0020' => 0x20,
            '\u0021' => 0x21,
            '\u0022' => 0x22,
            '\u0023' => 0x23,
            '\u0024' => 0x24,
            '\u0025' => 0x25,
            '\u0026' => 0x26,
            '\u0027' => 0x27,
            '\u0028' => 0x28,
            '\u0029' => 0x29,
            '\u002A' => 0x2A,
            '\u002B' => 0x2B,
            '\u002C' => 0x2C,
            '\u002D' => 0x2D,
            '\u002E' => 0x2E,
            '\u002F' => 0x2F,
            '\u0030' => 0x30,
            '\u0031' => 0x31,
            '\u0032' => 0x32,
            '\u0033' => 0x33,
            '\u0034' => 0x34,
            '\u0035' => 0x35,
            '\u0036' => 0x36,
            '\u0037' => 0x37,
            '\u0038' => 0x38,
            '\u0039' => 0x39,
            '\u003A' => 0x3A,
            '\u003B' => 0x3B,
            '\u003C' => 0x3C,
            '\u003D' => 0x3D,
            '\u003E' => 0x3E,
            '\u003F' => 0x3F,
            '\u0040' => 0x40,
            '\u0041' => 0x41,
            '\u0042' => 0x42,
            '\u0043' => 0x43,
            '\u0044' => 0x44,
            '\u0045' => 0x45,
            '\u0046' => 0x46,
            '\u0047' => 0x47,
            '\u0048' => 0x48,
            '\u0049' => 0x49,
            '\u004A' => 0x4A,
            '\u004B' => 0x4B,
            '\u004C' => 0x4C,
            '\u004D' => 0x4D,
            '\u004E' => 0x4E,
            '\u004F' => 0x4F,
            '\u0050' => 0x50,
            '\u0051' => 0x51,
            '\u0052' => 0x52,
            '\u0053' => 0x53,
            '\u0054' => 0x54,
            '\u0055' => 0x55,
            '\u0056' => 0x56,
            '\u0057' => 0x57,
            '\u0058' => 0x58,
            '\u0059' => 0x59,
            '\u005A' => 0x5A,
            '\u005B' => 0x5B,
            '\u005C' => 0x5C,
            '\u005D' => 0x5D,
            '\u005E' => 0x5E,
            '\u005F' => 0x5F,
            _        => 0x3F
        };
    }
}