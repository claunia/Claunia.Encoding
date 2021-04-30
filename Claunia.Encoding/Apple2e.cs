//
// Apple IIe.cs
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
    /// <summary>Represents an Apple IIe character encoding of Unicode characters.</summary>
    public class Apple2e : SingleByteEncoding
    {
        /// <inheritdoc />
        public override string BodyName => "apple2e";
        /// <inheritdoc />
        public override int CodePage => 0;
        /// <inheritdoc />
        public override string EncodingName => "Western European (Apple IIe)";
        /// <inheritdoc />
        public override string HeaderName => "apple2e";
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

        /// <summary>The Apple IIe to Unicode character map.</summary>
        protected override char[] CharTable => new[]
        {
            // 0x00
            '\u0020', '\u0021', '\u0022', '\u0023', '\u0024', '\u0025', '\u0026', '\u0027',

            // 0x08
            '\u0028', '\u0029', '\u002A', '\u002B', '\u002C', '\u002D', '\u002E', '\u002F',

            // 0x10
            '\u0030', '\u0031', '\u0032', '\u0033', '\u0034', '\u0035', '\u0036', '\u0037',

            // 0x18
            '\u0038', '\u0039', '\u003A', '\u003B', '\u003C', '\u003D', '\u003E', '\u003F',

            // 0x20
            '\u0040', '\u0061', '\u0062', '\u0063', '\u0064', '\u0065', '\u0066', '\u0067',

            // 0x28
            '\u0068', '\u0069', '\u006A', '\u006B', '\u006C', '\u006D', '\u006E', '\u006F',

            // 0x30
            '\u0070', '\u0071', '\u0072', '\u0073', '\u0074', '\u0075', '\u0076', '\u0077',

            // 0x38
            '\u0078', '\u0079', '\u007A', '\u005B', '\u005C', '\u005D', '\u005E', '\u005F',

            // 0x40
            '\u00A0', '\u2575', '\u2574', '\u2577', '\u2576', '\u2518', '\u2510', '\u250C',

            // 0x48
            '\u2514', '\u2500', '\u2502', '\u2534', '\u2524', '\u252C', '\u251C', '\u253C',

            // 0x50
            '\u25E4', '\u25E5', '\u2592', '\u2598', '\u259D', '\u2580', '\u2596', '\u2597',

            // 0x58
            '\u259A', '\u258C', '\u0000', '\u0000', '\u2190', '\u2191', '\u2192', '\u2193',

            // 0x60
            '\u03C0', '\u0041', '\u0042', '\u0043', '\u0044', '\u0045', '\u0046', '\u0047',

            // 0x68
            '\u0048', '\u0049', '\u004A', '\u004B', '\u004C', '\u004D', '\u004E', '\u004F',

            // 0x70
            '\u0050', '\u0051', '\u0052', '\u0053', '\u0054', '\u0055', '\u0056', '\u0057',

            // 0x78
            '\u0058', '\u0059', '\u005A', '\u007B', '\u007C', '\u007D', '\u007E', '\u0000',

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

        /// <summary>Converts a Unicode character to an Apple IIe character</summary>
        /// <returns>Apple IIe character.</returns>
        /// <param name="character">Unicode character.</param>
        private protected override byte GetByte(char character) => character switch
        {
            '\u0020' => 0x00,
            '\u0021' => 0x01,
            '\u0022' => 0x02,
            '\u0023' => 0x03,
            '\u0024' => 0x04,
            '\u0025' => 0x05,
            '\u0026' => 0x06,
            '\u0027' => 0x07,
            '\u0028' => 0x08,
            '\u0029' => 0x09,
            '\u002A' => 0x0A,
            '\u002B' => 0x0B,
            '\u002C' => 0x0C,
            '\u002D' => 0x0D,
            '\u002E' => 0x0E,
            '\u002F' => 0x0F,
            '\u0030' => 0x10,
            '\u0031' => 0x11,
            '\u0032' => 0x12,
            '\u0033' => 0x13,
            '\u0034' => 0x14,
            '\u0035' => 0x15,
            '\u0036' => 0x16,
            '\u0037' => 0x17,
            '\u0038' => 0x18,
            '\u0039' => 0x19,
            '\u003A' => 0x1A,
            '\u003B' => 0x1B,
            '\u003C' => 0x1C,
            '\u003D' => 0x1D,
            '\u003E' => 0x1E,
            '\u003F' => 0x1F,
            '\u0040' => 0x20,
            '\u0061' => 0x21,
            '\u0062' => 0x22,
            '\u0063' => 0x23,
            '\u0064' => 0x24,
            '\u0065' => 0x25,
            '\u0066' => 0x26,
            '\u0067' => 0x27,
            '\u0068' => 0x28,
            '\u0069' => 0x29,
            '\u006A' => 0x2A,
            '\u006B' => 0x2B,
            '\u006C' => 0x2C,
            '\u006D' => 0x2D,
            '\u006E' => 0x2E,
            '\u006F' => 0x2F,
            '\u0070' => 0x30,
            '\u0071' => 0x31,
            '\u0072' => 0x32,
            '\u0073' => 0x33,
            '\u0074' => 0x34,
            '\u0075' => 0x35,
            '\u0076' => 0x36,
            '\u0077' => 0x37,
            '\u0078' => 0x38,
            '\u0079' => 0x39,
            '\u007A' => 0x3A,
            '\u005B' => 0x3B,
            '\u005C' => 0x3C,
            '\u005D' => 0x3D,
            '\u005E' => 0x3E,
            '\u005F' => 0x3F,
            '\u00A0' => 0x40,
            '\u2575' => 0x41,
            '\u2574' => 0x42,
            '\u2577' => 0x43,
            '\u2576' => 0x44,
            '\u2518' => 0x45,
            '\u2510' => 0x46,
            '\u250C' => 0x47,
            '\u2514' => 0x48,
            '\u2500' => 0x49,
            '\u2502' => 0x4A,
            '\u2534' => 0x4B,
            '\u2524' => 0x4C,
            '\u252C' => 0x4D,
            '\u251C' => 0x4E,
            '\u253C' => 0x4F,
            '\u25E4' => 0x50,
            '\u25E5' => 0x51,
            '\u2592' => 0x52,
            '\u2598' => 0x53,
            '\u259D' => 0x54,
            '\u2580' => 0x55,
            '\u2596' => 0x56,
            '\u2597' => 0x57,
            '\u259A' => 0x58,
            '\u258C' => 0x59,
            '\u2190' => 0x5C,
            '\u2191' => 0x5D,
            '\u2192' => 0x5E,
            '\u2193' => 0x5F,
            '\u03C0' => 0x60,
            '\u0041' => 0x61,
            '\u0042' => 0x62,
            '\u0043' => 0x63,
            '\u0044' => 0x64,
            '\u0045' => 0x65,
            '\u0046' => 0x66,
            '\u0047' => 0x67,
            '\u0048' => 0x68,
            '\u0049' => 0x69,
            '\u004A' => 0x6A,
            '\u004B' => 0x6B,
            '\u004C' => 0x6C,
            '\u004D' => 0x6D,
            '\u004E' => 0x6E,
            '\u004F' => 0x6F,
            '\u0050' => 0x70,
            '\u0051' => 0x71,
            '\u0052' => 0x72,
            '\u0053' => 0x73,
            '\u0054' => 0x74,
            '\u0055' => 0x75,
            '\u0056' => 0x76,
            '\u0057' => 0x77,
            '\u0058' => 0x78,
            '\u0059' => 0x79,
            '\u005A' => 0x7A,
            '\u007B' => 0x7B,
            '\u007C' => 0x7C,
            '\u007D' => 0x7D,
            '\u007E' => 0x7E,
            _        => 0x3F
        };
    }
}