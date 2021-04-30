//
// ZXSpectrum.cs
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
    /// <summary>Represents an ZX Spectrum character encoding of Unicode characters.</summary>
    public class ZxSpectrum : SingleByteEncoding
    {
        public override string BodyName        => "spectrum";
        public override int    CodePage        => 0;
        public override string EncodingName    => "Sinclair ZX Spectrum character set";
        public override string HeaderName      => "spectrum";
        public override string WebName         => "";
        public override int    WindowsCodePage => 0;

        public override bool IsBrowserDisplay  => false;
        public override bool IsBrowserSave     => false;
        public override bool IsMailNewsDisplay => false;
        public override bool IsMailNewsSave    => false;
        public override bool IsReadOnly        => false;
        public override bool IsSingleByte      => true;

        /// <summary>The ZX Spectrum to Unicode character map.</summary>
        protected override char[] CharTable => new[]
        {
            // 0x00
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0009', '\u0000',

            // 0x08
            '\uFFFF', '\uFFFF', '\u0000', '\u0000', '\u0000', '\u000D', '\uFFFF', '\u0000',

            // 0x10
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\u0009',

            // 0x18
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

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
            '\u0058', '\u0059', '\u005A', '\u005B', '\u005C', '\u005D', '\u2191', '\u005F',

            // 0x60
            '\u00A3', '\u0061', '\u0062', '\u0063', '\u0064', '\u0065', '\u0066', '\u0067',

            // 0x68
            '\u0068', '\u0069', '\u006A', '\u006B', '\u006C', '\u006D', '\u006E', '\u006F',

            // 0x70
            '\u0070', '\u0071', '\u0072', '\u0073', '\u0074', '\u0075', '\u0076', '\u0077',

            // 0x78
            '\u0078', '\u0079', '\u007A', '\u007B', '\u007C', '\u007D', '\u007E', '\u00A9',

            // 0x80
            '\u0020', '\u259D', '\u2598', '\u2580', '\u2597', '\u2590', '\u259A', '\u259C',

            // 0x88
            '\u2596', '\u259E', '\u258C', '\u259B', '\u2584', '\u259F', '\u2599', '\u2588',

            // 0x90
            '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD',

            // 0x98
            '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD',

            // 0xA0
            '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFF', '\uFFFF', '\uFFFF',

            // 0xA8
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF',

            // 0xB0
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF',

            // 0xB8
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF',

            // 0xC0
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF',

            // 0xC8
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF',

            // 0xD0
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF',

            // 0xD8
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF',

            // 0xE0
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF',

            // 0xE8
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF',

            // 0xF0
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF',

            // 0xF8
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF'
        };

        /// <summary>Converts a Unicode character to an ZX Spectrum character</summary>
        /// <returns>ZX Spectrum character.</returns>
        /// <param name="character">Unicode character.</param>
        private protected override byte GetByte(char character) => character switch
        {
            '\u0009' => 0x06,
            '\u000D' => 0x0D,
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
            '\u2191' => 0x5E,
            '\u005F' => 0x5F,
            '\u00A3' => 0x60,
            '\u0061' => 0x61,
            '\u0062' => 0x62,
            '\u0063' => 0x63,
            '\u0064' => 0x64,
            '\u0065' => 0x65,
            '\u0066' => 0x66,
            '\u0067' => 0x67,
            '\u0068' => 0x68,
            '\u0069' => 0x69,
            '\u006A' => 0x6A,
            '\u006B' => 0x6B,
            '\u006C' => 0x6C,
            '\u006D' => 0x6D,
            '\u006E' => 0x6E,
            '\u006F' => 0x6F,
            '\u0070' => 0x70,
            '\u0071' => 0x71,
            '\u0072' => 0x72,
            '\u0073' => 0x73,
            '\u0074' => 0x74,
            '\u0075' => 0x75,
            '\u0076' => 0x76,
            '\u0077' => 0x77,
            '\u0078' => 0x78,
            '\u0079' => 0x79,
            '\u007A' => 0x7A,
            '\u007B' => 0x7B,
            '\u007C' => 0x7C,
            '\u007D' => 0x7D,
            '\u007E' => 0x7E,
            '\u00A9' => 0x7F,
            '\u259D' => 0x81,
            '\u2598' => 0x82,
            '\u2580' => 0x83,
            '\u2597' => 0x84,
            '\u2590' => 0x85,
            '\u259A' => 0x86,
            '\u259C' => 0x87,
            '\u2596' => 0x88,
            '\u259E' => 0x89,
            '\u258C' => 0x8A,
            '\u259B' => 0x8B,
            '\u2584' => 0x8C,
            '\u259F' => 0x8D,
            '\u2599' => 0x8E,
            '\u2588' => 0x8F,
            _        => 0x3F
        };
    }
}