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

namespace Claunia.Encoding
{
    /// <summary>Represents an Apple IIgs character encoding of Unicode characters.</summary>
    public class Apple2Gs : SingleByteEncoding
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
        protected override char[] CharTable => new[]
        {
            // 0x00
            '\u0040', '\u0041', '\u0042', '\u0043', '\u0044', '\u0045', '\u0046', '\u0047',

            // 0x08
            '\u0048', '\u0049', '\u004A', '\u004B', '\u004C', '\u004D', '\u004E', '\u004F',

            // 0x10
            '\u0050', '\u0051', '\u0052', '\u0053', '\u0054', '\u0055', '\u0056', '\u0057',

            // 0x18
            '\u0058', '\u0059', '\u005A', '\u005B', '\u005C', '\u005D', '\u005E', '\u0020',

            // 0x20
            '\u2588', '\u0021', '\u0022', '\u0023', '\u0024', '\u0025', '\u0026', '\u0027',

            // 0x28
            '\u0028', '\u0029', '\u002A', '\u002B', '\u002C', '\u002D', '\u002E', '\u002F',

            // 0x30
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x38
            '\u0038', '\u0039', '\u003A', '\u003B', '\u003C', '\u003D', '\u003E', '\u003F',

            // 0x40
            '\u0000', '\u0000', '\u0000', '\u231B', '\u2713', '\u0000', '\u0000', '\u0000',

            // 0x48
            '\u2190', '\u2026', '\u2193', '\u2191', '\u0000', '\u21B5', '\u0000', '\u0000',

            // 0x50
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u2192', '\u0000', '\u0000',

            // 0x58
            '\u0000', '\u0000', '\u0000', '\u25C6', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x60
            '\u0060', '\u0061', '\u0062', '\u0063', '\u0064', '\u0065', '\u0066', '\u0067',

            // 0x68
            '\u0068', '\u0069', '\u006A', '\u006B', '\u006C', '\u006D', '\u006E', '\u006F',

            // 0x70
            '\u0070', '\u0071', '\u0072', '\u0073', '\u0074', '\u0075', '\u0076', '\u0077',

            // 0x78
            '\u0078', '\u0079', '\u007A', '\u007B', '\u007C', '\u007D', '\u007E', '\u0000',

            // 0x80
            '\u0040', '\u0041', '\u0042', '\u0043', '\u0044', '\u0045', '\u0046', '\u0047',

            // 0x88
            '\u0048', '\u0049', '\u004A', '\u004B', '\u004C', '\u004D', '\u004E', '\u004F',

            // 0x90
            '\u0050', '\u0051', '\u0052', '\u0053', '\u0054', '\u0055', '\u0056', '\u0057',

            // 0x98
            '\u0058', '\u0059', '\u005A', '\u005B', '\u005C', '\u005D', '\u005E', '\u005F',

            // 0xA0
            '\u0020', '\u0021', '\u0022', '\u0023', '\u0024', '\u0025', '\u0026', '\u0027',

            // 0xA8
            '\u0028', '\u0029', '\u002A', '\u002B', '\u002C', '\u002D', '\u002E', '\u002F',

            // 0xB0
            '\u0030', '\u0031', '\u0032', '\u0033', '\u0034', '\u0035', '\u0036', '\u0037',

            // 0xB8
            '\u0038', '\u0039', '\u003A', '\u003B', '\u003C', '\u003D', '\u003E', '\u003F',

            // 0xC0
            '\u0040', '\u0041', '\u0042', '\u0043', '\u0044', '\u0045', '\u0046', '\u0047',

            // 0xC8
            '\u0048', '\u0049', '\u004A', '\u004B', '\u004C', '\u004D', '\u004E', '\u004F',

            // 0xD0
            '\u0050', '\u0051', '\u0052', '\u0053', '\u0054', '\u0055', '\u0056', '\u0057',

            // 0xD8
            '\u0058', '\u0059', '\u005A', '\u005B', '\u005C', '\u005D', '\u005E', '\u005F',

            // 0xE0
            '\u0060', '\u0061', '\u0062', '\u0063', '\u0064', '\u0065', '\u0066', '\u0067',

            // 0xE8
            '\u0068', '\u0069', '\u006A', '\u006B', '\u006C', '\u006D', '\u006E', '\u006F',

            // 0xF0
            '\u0070', '\u0071', '\u0072', '\u0073', '\u0074', '\u0075', '\u0076', '\u0077',

            // 0xF8
            '\u0078', '\u0079', '\u007A', '\u007B', '\u007C', '\u007D', '\u007E', '\u0000'
        };

        /// <summary>Converts a Unicode character to an Apple IIgs character</summary>
        /// <returns>Apple IIgs character.</returns>
        /// <param name="character">Unicode character.</param>
        private protected override byte GetByte(char character)
        {
            switch(character)
            {
                case '\u2588': return 0x20;
                case '\u231B': return 0x43;
                case '\u2713': return 0x44;
                case '\u2190': return 0x48;
                case '\u2026': return 0x49;
                case '\u2193': return 0x4A;
                case '\u2191': return 0x4B;
                case '\u21B5': return 0x4D;
                case '\u2192': return 0x55;
                case '\u25C6': return 0x5B;
                case '\u0040': return 0x80;
                case '\u0041': return 0x81;
                case '\u0042': return 0x82;
                case '\u0043': return 0x83;
                case '\u0044': return 0x84;
                case '\u0045': return 0x85;
                case '\u0046': return 0x86;
                case '\u0047': return 0x87;
                case '\u0048': return 0x88;
                case '\u0049': return 0x89;
                case '\u004A': return 0x8A;
                case '\u004B': return 0x8B;
                case '\u004C': return 0x8C;
                case '\u004D': return 0x8D;
                case '\u004E': return 0x8E;
                case '\u004F': return 0x8F;
                case '\u0050': return 0x90;
                case '\u0051': return 0x91;
                case '\u0052': return 0x92;
                case '\u0053': return 0x93;
                case '\u0054': return 0x94;
                case '\u0055': return 0x95;
                case '\u0056': return 0x96;
                case '\u0057': return 0x97;
                case '\u0058': return 0x98;
                case '\u0059': return 0x99;
                case '\u005A': return 0x9A;
                case '\u005B': return 0x9B;
                case '\u005C': return 0x9C;
                case '\u005D': return 0x9D;
                case '\u005E': return 0x9E;
                case '\u005F': return 0x9F;
                case '\u0020': return 0xA0;
                case '\u0021': return 0xA1;
                case '\u0022': return 0xA2;
                case '\u0023': return 0xA3;
                case '\u0024': return 0xA4;
                case '\u2025': return 0xA5;
                case '\u0026': return 0xA6;
                case '\u0027': return 0xA7;
                case '\u0028': return 0xA8;
                case '\u0029': return 0xA9;
                case '\u002A': return 0xAA;
                case '\u002B': return 0xAB;
                case '\u002C': return 0xAC;
                case '\u002D': return 0xAD;
                case '\u002E': return 0xAE;
                case '\u002F': return 0xAF;
                case '\u0030': return 0xB0;
                case '\u0031': return 0xB1;
                case '\u0032': return 0xB2;
                case '\u0033': return 0xB3;
                case '\u0034': return 0xB4;
                case '\u0035': return 0xB5;
                case '\u0036': return 0xB6;
                case '\u0037': return 0xB7;
                case '\u0038': return 0xB8;
                case '\u0039': return 0xB9;
                case '\u003A': return 0xBA;
                case '\u003B': return 0xBB;
                case '\u003C': return 0xBC;
                case '\u003D': return 0xBD;
                case '\u003E': return 0xBE;
                case '\u003F': return 0xBF;
                case '\u0060': return 0xE0;
                case '\u0061': return 0xE1;
                case '\u0062': return 0xE2;
                case '\u0063': return 0xE3;
                case '\u0064': return 0xE4;
                case '\u0065': return 0xE5;
                case '\u0066': return 0xE6;
                case '\u0067': return 0xE7;
                case '\u0068': return 0xE8;
                case '\u0069': return 0xE9;
                case '\u006A': return 0xEA;
                case '\u006B': return 0xEB;
                case '\u006C': return 0xEC;
                case '\u006D': return 0xED;
                case '\u006E': return 0xEE;
                case '\u006F': return 0xEF;
                case '\u0070': return 0xF0;
                case '\u0071': return 0xF1;
                case '\u0072': return 0xF2;
                case '\u0073': return 0xF3;
                case '\u0074': return 0xF4;
                case '\u0075': return 0xF5;
                case '\u0076': return 0xF6;
                case '\u0077': return 0xF7;
                case '\u0078': return 0xF8;
                case '\u0079': return 0xF9;
                case '\u007A': return 0xFA;
                case '\u007B': return 0xFB;
                case '\u007C': return 0xFC;
                case '\u007D': return 0xFD;
                case '\u007E': return 0xFE;
                default:
                    // Fallback to '?'
                    return 0xBF;
            }
        }
    }
}