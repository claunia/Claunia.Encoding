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

using System.Text;

namespace Claunia.Encoding
{
    /// <summary>
    ///     Represents an Commodore PET Standard Code for Information Interchange (aka CBM ASCII) character encoding of
    ///     Unicode characters.
    /// </summary>
    public class Petscii : SingleByteEncodingWithRunes
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
        protected override Rune[] CharTable => new[]
        {
            // 0x00
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0003), new Rune(0x0000), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

            // 0x08
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x000A),
            new Rune(0x0000), new Rune(0x0000),

            // 0x10
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0008), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

            // 0x18
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

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
            new Rune(0x2191), new Rune(0x2190),

            // 0x60
            new Rune(0x1FB79), new Rune(0x2660), new Rune(0x1FB72), new Rune(0x1FB78), new Rune(0x1FB77),
            new Rune(0x1FB76), new Rune(0x1FB7A), new Rune(0x1FB71),

            // 0x68
            new Rune(0x1FB74), new Rune(0x256E), new Rune(0x2570), new Rune(0x256F), new Rune(0x1FB7C),
            new Rune(0x2572), new Rune(0x2571), new Rune(0x1FB7D),

            // 0x70
            new Rune(0x1FB7E), new Rune(0x25CF), new Rune(0x1FB7B), new Rune(0x2665), new Rune(0x1FB70),
            new Rune(0x256D), new Rune(0x2573), new Rune(0x25CB),

            // 0x78
            new Rune(0x2663), new Rune(0x1FB75), new Rune(0x2666), new Rune(0x253C), new Rune(0x1FB8C),
            new Rune(0x2502), new Rune(0x03C0), new Rune(0x25E5),

            // 0x80
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

            // 0x88
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x2028),
            new Rune(0x0000), new Rune(0x0000),

            // 0x90
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

            // 0x98
            new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000), new Rune(0x0000),
            new Rune(0x0000), new Rune(0x0000),

            // 0xA0
            new Rune(0x00A0), new Rune(0x258C), new Rune(0x2584), new Rune(0x2594), new Rune(0x2581), new Rune(0x258E),
            new Rune(0x2592), new Rune(0x2595),

            // 0xA8
            new Rune(0x1FB8F), new Rune(0x25E4), new Rune(0x1FB87), new Rune(0x251C), new Rune(0x2597),
            new Rune(0x2514), new Rune(0x2510), new Rune(0x2582),

            // 0xB0
            new Rune(0x250C), new Rune(0x2534), new Rune(0x252C), new Rune(0x2524), new Rune(0x258E), new Rune(0x258D),
            new Rune(0x1FB88), new Rune(0x1FB82),

            // 0xB8
            new Rune(0x1FB83), new Rune(0x2583), new Rune(0x1FB7F), new Rune(0x2596), new Rune(0x259D),
            new Rune(0x2518), new Rune(0x2598), new Rune(0x259A),

            // 0xC0 (repeats 0x60 - 0x67)
            new Rune(0x1FB79), new Rune(0x2660), new Rune(0x1FB72), new Rune(0x1FB78), new Rune(0x1FB77),
            new Rune(0x1FB76), new Rune(0x1FB7A), new Rune(0x1FB71),

            // 0xC8 (repeats 0x68 - 0x6F)
            new Rune(0x1FB74), new Rune(0x256E), new Rune(0x2570), new Rune(0x256F), new Rune(0x1FB7C),
            new Rune(0x2572), new Rune(0x2571), new Rune(0x1FB7D),

            // 0xD0 (repeats 0x70 - 0x77)
            new Rune(0x1FB7E), new Rune(0x25CF), new Rune(0x1FB7B), new Rune(0x2665), new Rune(0x1FB70),
            new Rune(0x256D), new Rune(0x2573), new Rune(0x25CB),

            // 0xD8 (repeats 0x78 - 0x7F)
            new Rune(0x2663), new Rune(0x1FB75), new Rune(0x2666), new Rune(0x253C), new Rune(0x1FB8C),
            new Rune(0x2502), new Rune(0x03C0), new Rune(0x25E5),

            // 0xE0 (repeats 0xA0 - 0xA7)
            new Rune(0x00A0), new Rune(0x258C), new Rune(0x2584), new Rune(0x2594), new Rune(0x2581), new Rune(0x258E),
            new Rune(0x2592), new Rune(0x2595),

            // 0xE8 (repeats 0xA8 - 0xAF)
            new Rune(0x1FB8F), new Rune(0x25E4), new Rune(0x1FB87), new Rune(0x251C), new Rune(0x2597),
            new Rune(0x2514), new Rune(0x2510), new Rune(0x2582),

            // 0xF0 (repeats 0xB0 - 0xB7)
            new Rune(0x250C), new Rune(0x2534), new Rune(0x252C), new Rune(0x2524), new Rune(0x258E), new Rune(0x258D),
            new Rune(0x1FB88), new Rune(0x1FB82),

            // 0xF8 (repeats 0xB8 - 0xBF)
            new Rune(0x1FB83), new Rune(0x2583), new Rune(0x1FB7F), new Rune(0x2596), new Rune(0x259D),
            new Rune(0x2518), new Rune(0x2598), new Rune(0x259A)
        };

        /// <summary>Converts a Unicode character to an PETSCII character</summary>
        /// <returns>PETSCII character.</returns>
        /// <param name="character">Unicode character.</param>
        private protected override byte GetByte(Rune character)
        {
            if(character.Value == 0x0000)
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