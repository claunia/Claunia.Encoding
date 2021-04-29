//
// PETSCII.cs
//
// Author:
//       Michael Drüing <darkstar@drueing.de>
//
// Copyright © 2016-2021 Michael Drüing
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
    /// <summary>
    ///     Represents an Commodore PET Standard Code for Information Interchange (aka CBM ASCII) character encoding of
    ///     Unicode characters.
    /// </summary>
    public class Petscii : SingleByteEncoding
    {
        public override string BodyName        => "petscii";
        public override int    CodePage        => 0;
        public override string EncodingName    => "Commodore PET Standard Code for Information Interchange";
        public override string HeaderName      => "petscii";
        public override string WebName         => "";
        public override int    WindowsCodePage => 0;

        public override bool IsBrowserDisplay  => false;
        public override bool IsBrowserSave     => false;
        public override bool IsMailNewsDisplay => false;
        public override bool IsMailNewsSave    => false;
        public override bool IsReadOnly        => false;
        public override bool IsSingleByte      => true;

        /// <summary>The PETSCII to Unicode character map, unshifted (default) variant.</summary>
        /// <remarks>Reference used: http://style64.org/petscii/ and others.</remarks>
        protected override char[] CharTable => new[]
        {
            // 0x00
            '\u0000', '\u0000', '\u0000', '\u0003', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x08
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u000A', '\u0000', '\u0000',

            // 0x10
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0008', '\u0000', '\u0000', '\u0000',

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
            '\u0058', '\u0059', '\u005A', '\u005B', '\u00A3', '\u005D', '\u2191', '\u2190',

            // 0x60
            '\u2500', '\u2660', '\u2502', '\u2500', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x68
            '\u0000', '\u256E', '\u2570', '\u256F', '\u0000', '\u2572', '\u2571', '\u0000',

            // 0x70
            '\u0000', '\u2022', '\u0000', '\u2665', '\u0000', '\u256D', '\u2573', '\u25CB',

            // 0x78
            '\u2663', '\u0000', '\u2666', '\u253C', '\u0000', '\u2502', '\u03C0', '\u25E5',

            // 0x80
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x88
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u2028', '\u0000', '\u0000',

            // 0x90
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x98
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xA0
            '\u00A0', '\u258C', '\u2584', '\u2594', '\u2581', '\u258E', '\u2592', '\u0000',

            // 0xA8
            '\u0000', '\u25E4', '\u258A', '\u251C', '\u2597', '\u2514', '\u2510', '\u2582',

            // 0xB0
            '\u250C', '\u2534', '\u252C', '\u2524', '\u258E', '\u258D', '\u0000', '\u0000',

            // 0xB8
            '\u0000', '\u2583', '\u0000', '\u2596', '\u259D', '\u2518', '\u2598', '\u259A',

            // 0xC0 (repeats 0x60 - 0x67)
            '\u2500', '\u2660', '\u2502', '\u2500', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0xC8 (repeats 0x68 - 0x6F)
            '\u0000', '\u256E', '\u2570', '\u256F', '\u0000', '\u2572', '\u2571', '\u0000',

            // 0xD0 (repeats 0x70 - 0x77)
            '\u0000', '\u2022', '\u0000', '\u2665', '\u0000', '\u256D', '\u2573', '\u25CB',

            // 0xD8 (repeats 0x78 - 0x7F)
            '\u2663', '\u0000', '\u2666', '\u253C', '\u0000', '\u2502', '\u03C0', '\u25E5',

            // 0xE0 (repeats 0xA0 - 0xA7)
            '\u00A0', '\u258C', '\u2584', '\u2594', '\u2581', '\u258E', '\u2592', '\u0000',

            // 0xE8 (repeats 0xA8 - 0xAF)
            '\u0000', '\u25E4', '\u258A', '\u251C', '\u2597', '\u2514', '\u2510', '\u2582',

            // 0xF0 (repeats 0xB0 - 0xB7)
            '\u250C', '\u2534', '\u252C', '\u2524', '\u258E', '\u258D', '\u0000', '\u0000',

            // 0xF8 (repeats 0xB8 - 0xBF)
            '\u0000', '\u2583', '\u0000', '\u2596', '\u259D', '\u2518', '\u2598', '\u259A'
        };

        /// <summary>Converts a Unicode character to an PETSCII character</summary>
        /// <returns>PETSCII character.</returns>
        /// <param name="character">Unicode character.</param>
        private protected override byte GetByte(char character)
        {
            if(character == 0x0000)
                return 0x3F;

            for(int i = 0; i < 256; i++)

                // TODO: convert this to a gigantic switch statement too?
                if(CharTable[i] == character)
                    return (byte)i;

            // Fallback to '?'
            return 0x3F;
        }
    }
}