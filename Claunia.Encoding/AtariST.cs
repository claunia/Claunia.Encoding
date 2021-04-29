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
    public class AtariSt : SingleByteEncodingWithRunes
    {
        public override string BodyName        => "atarist";
        public override int    CodePage        => 0;
        public override string EncodingName    => "Western European (Atari ST)";
        public override string HeaderName      => "atarist";
        public override string WebName         => "";
        public override int    WindowsCodePage => 0;

        public override bool IsBrowserDisplay  => false;
        public override bool IsBrowserSave     => false;
        public override bool IsMailNewsDisplay => false;
        public override bool IsMailNewsSave    => false;
        public override bool IsReadOnly        => false;
        public override bool IsSingleByte      => true;

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
        private protected override byte GetByte(Rune character)
        {
            switch(character.Value)
            {
                case 0x0000:  return 0x00;
                case 0x21E7:  return 0x01;
                case 0x21E9:  return 0x02;
                case 0x21E8:  return 0x03;
                case 0x21E6:  return 0x04;
                case 0x274E:  return 0x05;
                case 0x1FBBD: return 0x05;
                case 0x1FBBE: return 0x06;
                case 0x1FBBF: return 0x07;
                case 0x2713:  return 0x08;
                case 0x1F552: return 0x09;
                case 0x1F514: return 0x0A;
                case 0x266A:  return 0x0B;
                case 0x000C:  return 0x0C;
                case 0x000D:  return 0x0D;
                case 0x1FBF0: return 0x10;
                case 0x1FBF1: return 0x11;
                case 0x1FBF2: return 0x12;
                case 0x1FBF3: return 0x13;
                case 0x1FBF4: return 0x14;
                case 0x1FBF5: return 0x15;
                case 0x1FBF6: return 0x16;
                case 0x1FBF7: return 0x17;
                case 0x1FBF8: return 0x18;
                case 0x1FBF9: return 0x19;
                case 0x0259:  return 0x1A;
                case 0x001B:  return 0x1B;
                case 0x0020:  return 0x20;
                case 0x0021:  return 0x21;
                case 0x0022:  return 0x22;
                case 0x0023:  return 0x23;
                case 0x0024:  return 0x24;
                case 0x0025:  return 0x25;
                case 0x0026:  return 0x26;
                case 0x0027:  return 0x27;
                case 0x0028:  return 0x28;
                case 0x0029:  return 0x29;
                case 0x002A:  return 0x2A;
                case 0x002B:  return 0x2B;
                case 0x002C:  return 0x2C;
                case 0x002D:  return 0x2D;
                case 0x002E:  return 0x2E;
                case 0x002F:  return 0x2F;
                case 0x0030:  return 0x30;
                case 0x0031:  return 0x31;
                case 0x0032:  return 0x32;
                case 0x0033:  return 0x33;
                case 0x0034:  return 0x34;
                case 0x0035:  return 0x35;
                case 0x0036:  return 0x36;
                case 0x0037:  return 0x37;
                case 0x0038:  return 0x38;
                case 0x0039:  return 0x39;
                case 0x003A:  return 0x3A;
                case 0x003B:  return 0x3B;
                case 0x003C:  return 0x3C;
                case 0x003D:  return 0x3D;
                case 0x003E:  return 0x3E;
                case 0x003F:  return 0x3F;
                case 0x0040:  return 0x40;
                case 0x0041:  return 0x41;
                case 0x0042:  return 0x42;
                case 0x0043:  return 0x43;
                case 0x0044:  return 0x44;
                case 0x0045:  return 0x45;
                case 0x0046:  return 0x46;
                case 0x0047:  return 0x47;
                case 0x0048:  return 0x48;
                case 0x0049:  return 0x49;
                case 0x004A:  return 0x4A;
                case 0x004B:  return 0x4B;
                case 0x004C:  return 0x4C;
                case 0x004D:  return 0x4D;
                case 0x004E:  return 0x4E;
                case 0x004F:  return 0x4F;
                case 0x0050:  return 0x50;
                case 0x0051:  return 0x51;
                case 0x0052:  return 0x52;
                case 0x0053:  return 0x53;
                case 0x0054:  return 0x54;
                case 0x0055:  return 0x55;
                case 0x0056:  return 0x56;
                case 0x0057:  return 0x57;
                case 0x0058:  return 0x58;
                case 0x0059:  return 0x59;
                case 0x005A:  return 0x5A;
                case 0x005B:  return 0x5B;
                case 0x005C:  return 0x5C;
                case 0x005D:  return 0x5D;
                case 0x005E:  return 0x5E;
                case 0x005F:  return 0x5F;
                case 0x0060:  return 0x60;
                case 0x0061:  return 0x61;
                case 0x0062:  return 0x62;
                case 0x0063:  return 0x63;
                case 0x0064:  return 0x64;
                case 0x0065:  return 0x65;
                case 0x0066:  return 0x66;
                case 0x0067:  return 0x67;
                case 0x0068:  return 0x68;
                case 0x0069:  return 0x69;
                case 0x006A:  return 0x6A;
                case 0x006B:  return 0x6B;
                case 0x006C:  return 0x6C;
                case 0x006D:  return 0x6D;
                case 0x006E:  return 0x6E;
                case 0x006F:  return 0x6F;
                case 0x0070:  return 0x70;
                case 0x0071:  return 0x71;
                case 0x0072:  return 0x72;
                case 0x0073:  return 0x73;
                case 0x0074:  return 0x74;
                case 0x0075:  return 0x75;
                case 0x0076:  return 0x76;
                case 0x0077:  return 0x77;
                case 0x0078:  return 0x78;
                case 0x0079:  return 0x79;
                case 0x007A:  return 0x7A;
                case 0x007B:  return 0x7B;
                case 0x007C:  return 0x7C;
                case 0x007D:  return 0x7D;
                case 0x007E:  return 0x7E;
                case 0x2302:  return 0x7F;
                case 0x00C7:  return 0x80;
                case 0x00FC:  return 0x81;
                case 0x00E9:  return 0x82;
                case 0x00E2:  return 0x83;
                case 0x00E4:  return 0x84;
                case 0x00E0:  return 0x85;
                case 0x00E5:  return 0x86;
                case 0x00E7:  return 0x87;
                case 0x00EA:  return 0x88;
                case 0x00EB:  return 0x89;
                case 0x00E8:  return 0x8A;
                case 0x00EF:  return 0x8B;
                case 0x00EE:  return 0x8C;
                case 0x00EC:  return 0x8D;
                case 0x00C4:  return 0x8E;
                case 0x00C5:  return 0x8F;
                case 0x00C9:  return 0x90;
                case 0x00E6:  return 0x91;
                case 0x00C6:  return 0x92;
                case 0x00F4:  return 0x93;
                case 0x00F6:  return 0x94;
                case 0x00F2:  return 0x95;
                case 0x00FB:  return 0x96;
                case 0x00F9:  return 0x97;
                case 0x00FF:  return 0x98;
                case 0x00D6:  return 0x99;
                case 0x00DC:  return 0x9A;
                case 0x00A2:  return 0x9B;
                case 0x00A3:  return 0x9C;
                case 0x00A5:  return 0x9D;
                case 0x00DF:  return 0x9E;
                case 0x0192:  return 0x9F;
                case 0x00E1:  return 0xA0;
                case 0x00ED:  return 0xA1;
                case 0x00F3:  return 0xA2;
                case 0x00FA:  return 0xA3;
                case 0x00F1:  return 0xA4;
                case 0x00D1:  return 0xA5;
                case 0x00AA:  return 0xA6;
                case 0x00BA:  return 0xA7;
                case 0x00BF:  return 0xA8;
                case 0x2310:  return 0xA9;
                case 0x00AC:  return 0xAA;
                case 0x00BD:  return 0xAB;
                case 0x00BC:  return 0xAC;
                case 0x00A1:  return 0xAD;
                case 0x00AB:  return 0xAE;
                case 0x00BB:  return 0xAF;
                case 0x00E3:  return 0xB0;
                case 0x00F5:  return 0xB1;
                case 0x00D8:  return 0xB2;
                case 0x00F8:  return 0xB3;
                case 0x0153:  return 0xB4;
                case 0x0152:  return 0xB5;
                case 0x00C0:  return 0xB6;
                case 0x00C3:  return 0xB7;
                case 0x00D5:  return 0xB8;
                case 0x00A8:  return 0xB9;
                case 0x00B4:  return 0xBA;
                case 0x2020:  return 0xBB;
                case 0x00B6:  return 0xBC;
                case 0x00A9:  return 0xBD;
                case 0x00AE:  return 0xBE;
                case 0x2122:  return 0xBF;
                case 0x0133:  return 0xC0;
                case 0x0132:  return 0xC1;
                case 0x05D0:  return 0xC2;
                case 0x05D1:  return 0xC3;
                case 0x05D2:  return 0xC4;
                case 0x05D3:  return 0xC5;
                case 0x05D4:  return 0xC6;
                case 0x05D5:  return 0xC7;
                case 0x05D6:  return 0xC8;
                case 0x05D7:  return 0xC9;
                case 0x05D8:  return 0xCA;
                case 0x05D9:  return 0xCB;
                case 0x05DB:  return 0xCC;
                case 0x05DC:  return 0xCD;
                case 0x05DE:  return 0xCE;
                case 0x05E0:  return 0xCF;
                case 0x05E1:  return 0xD0;
                case 0x05E2:  return 0xD1;
                case 0x05E4:  return 0xD2;
                case 0x05E6:  return 0xD3;
                case 0x05E7:  return 0xD4;
                case 0x05E8:  return 0xD5;
                case 0x05E9:  return 0xD6;
                case 0x05EA:  return 0xD7;
                case 0x05DF:  return 0xD8;
                case 0x05DA:  return 0xD9;
                case 0x05DD:  return 0xDA;
                case 0x05E3:  return 0xDB;
                case 0x05E5:  return 0xDC;
                case 0x00A7:  return 0xDD;
                case 0x2227:  return 0xDE;
                case 0x221E:  return 0xDF;
                case 0x03B1:  return 0xE0;
                case 0x03B2:  return 0xE1;
                case 0x0393:  return 0xE2;
                case 0x03C0:  return 0xE3;
                case 0x03A3:  return 0xE4;
                case 0x03C3:  return 0xE5;
                case 0x00B5:  return 0xE6;
                case 0x03C4:  return 0xE7;
                case 0x03A6:  return 0xE8;
                case 0x0398:  return 0xE9;
                case 0x03A9:  return 0xEA;
                case 0x03B4:  return 0xEB;
                case 0x222E:  return 0xEC;
                case 0x03D5:  return 0xED;
                case 0x2208:  return 0xEE;
                case 0x2229:  return 0xEF;
                case 0x2261:  return 0xF0;
                case 0x00B1:  return 0xF1;
                case 0x2265:  return 0xF2;
                case 0x2264:  return 0xF3;
                case 0x2320:  return 0xF4;
                case 0x2321:  return 0xF5;
                case 0x00F7:  return 0xF6;
                case 0x2248:  return 0xF7;
                case 0x00B0:  return 0xF8;
                case 0x2219:  return 0xF9;
                case 0x00B7:  return 0xFA;
                case 0x221A:  return 0xFB;
                case 0x207F:  return 0xFC;
                case 0x00B2:  return 0xFD;
                case 0x00B3:  return 0xFE;
                case 0x00AF:  return 0xFF;
                default:
                    // Fallback to '?'
                    return 0x3F;
            }
        }
    }
}