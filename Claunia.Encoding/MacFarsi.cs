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

namespace Claunia.Encoding;

/// <summary>Represents an Mac Farsi character encoding of Unicode characters.</summary>
public class MacFarsi : SingleByteEncoding
{
    /// <inheritdoc />
    public override string BodyName => "x-mac-farsi";
    /// <inheritdoc />
    public override int CodePage => 10014;
    /// <inheritdoc />
    public override string EncodingName => "Farsi (Mac)";
    /// <inheritdoc />
    public override string HeaderName => "x-mac-farsi";
    /// <inheritdoc />
    public override string WebName => "x-mac-farsi";
    /// <inheritdoc />
    public override int WindowsCodePage => 10014;

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

    /// <summary>The Macintosh Farsi to Unicode character map.</summary>
    protected override char[] CharTable => new[]
    {
        // 0x00
        '\u0000', '\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\u0007',

        // 0x08
        '\u0008', '\u0009', '\u000A', '\u000B', '\u000C', '\u000D', '\u000E', '\u000F',

        // 0x10
        '\u0010', '\u2318', '\u2713', '\u25C6', '\uF8FF', '\u0015', '\u0016', '\u0017',

        // 0x18
        '\u0018', '\u0019', '\u001A', '\u001B', '\u001C', '\u001D', '\u001E', '\u001F',

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
        '\u0060', '\u0061', '\u0062', '\u0063', '\u0064', '\u0065', '\u0066', '\u0067',

        // 0x68
        '\u0068', '\u0069', '\u006A', '\u006B', '\u006C', '\u006D', '\u006E', '\u006F',

        // 0x70
        '\u0070', '\u0071', '\u0072', '\u0073', '\u0074', '\u0075', '\u0076', '\u0077',

        // 0x78
        '\u0078', '\u0079', '\u007A', '\u007B', '\u007C', '\u007D', '\u007E', '\u007F',

        // 0x80
        '\u00C4', '\u00A0', '\u00C7', '\u00C9', '\u00D1', '\u00D6', '\u00DC', '\u00E1',

        // 0x88
        '\u00E0', '\u00E2', '\u00E4', '\u06BA', '\u00AB', '\u00E7', '\u00E9', '\u00E8',

        // 0x90
        '\u00EA', '\u00EB', '\u00ED', '\u2026', '\u00EE', '\u00EF', '\u00F1', '\u00F3',

        // 0x98
        '\u00BB', '\u00F4', '\u00F6', '\u00F7', '\u00FA', '\u00F9', '\u00FB', '\u00FC',

        // 0xA0
        '\u0020', '\u0021', '\u0022', '\u0023', '\u0024', '\u066A', '\u0026', '\u0027',

        // 0xA8
        '\u0028', '\u0029', '\u002A', '\u002B', '\u060C', '\u002D', '\u002E', '\u002F',

        // 0xB0
        '\u06F0', '\u06F1', '\u06F2', '\u06F3', '\u06F4', '\u06F5', '\u06F6', '\u06F7',

        // 0xB8
        '\u06F8', '\u06F9', '\u003A', '\u061B', '\u003C', '\u003D', '\u003E', '\u061F',

        // 0xC0
        '\u274A', '\u0621', '\u0622', '\u0623', '\u0624', '\u0625', '\u0626', '\u0627',

        // 0xC8
        '\u0628', '\u0629', '\u062A', '\u062B', '\u062C', '\u062D', '\u062E', '\u062F',

        // 0xD0
        '\u0630', '\u0631', '\u0632', '\u0633', '\u0634', '\u0635', '\u0636', '\u0637',

        // 0xD8
        '\u0638', '\u0639', '\u063A', '\u005B', '\u005C', '\u005D', '\u005E', '\u005F',

        // 0xE0
        '\u0640', '\u0641', '\u0642', '\u0643', '\u0644', '\u0645', '\u0646', '\u0647',

        // 0xE8
        '\u0648', '\u0649', '\u064A', '\u064B', '\u064C', '\u064D', '\u064E', '\u064F',

        // 0xF0
        '\u0650', '\u0651', '\u0652', '\u067E', '\u0679', '\u0686', '\u06D5', '\u06A4',

        // 0xF8
        '\u06AF', '\u0688', '\u0691', '\u007B', '\u007C', '\u007D', '\u0698', '\u06D2'
    };

    /// <summary>Converts a Unicode character to an Mac Farsi character</summary>
    /// <returns>Mac Farsi character.</returns>
    /// <param name="character">Unicode character.</param>
    private protected override byte GetByte(char character) => character switch
    {
        '\u0000' => 0x00,
        '\u0001' => 0x01,
        '\u0002' => 0x02,
        '\u0003' => 0x03,
        '\u0004' => 0x04,
        '\u0005' => 0x05,
        '\u0006' => 0x06,
        '\u0007' => 0x07,
        '\u0008' => 0x08,
        '\u0009' => 0x09,
        '\u000A' => 0x0A,
        '\u000B' => 0x0B,
        '\u000C' => 0x0C,
        '\u000D' => 0x0D,
        '\u000E' => 0x0E,
        '\u000F' => 0x0F,
        '\u0010' => 0x10,
        '\u2318' => 0x11,
        '\u0012' => 0x12,
        '\u2713' => 0x12,
        '\u0013' => 0x13,
        '\u25C6' => 0x13,
        '\uF8FF' => 0x14,
        '\u0014' => 0x14,
        '\u0015' => 0x15,
        '\u0016' => 0x16,
        '\u0017' => 0x17,
        '\u0018' => 0x18,
        '\u0019' => 0x19,
        '\u001A' => 0x1A,
        '\u001B' => 0x1B,
        '\u001C' => 0x1C,
        '\u001D' => 0x1D,
        '\u001E' => 0x1E,
        '\u001F' => 0x1F,
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
        '\u0060' => 0x60,
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
        '\u007F' => 0x7F,
        '\u00C4' => 0x80,
        '\u00A0' => 0x81,
        '\u00C7' => 0x82,
        '\u00C9' => 0x83,
        '\u00D1' => 0x84,
        '\u00D6' => 0x85,
        '\u00DC' => 0x86,
        '\u00E1' => 0x87,
        '\u00E0' => 0x88,
        '\u00E2' => 0x89,
        '\u00E4' => 0x8A,
        '\u06BA' => 0x8B,
        '\u00AB' => 0x8C,
        '\u00E7' => 0x8D,
        '\u00E9' => 0x8E,
        '\u00E8' => 0x8F,
        '\u00EA' => 0x90,
        '\u00EB' => 0x91,
        '\u00ED' => 0x92,
        '\u2026' => 0x93,
        '\u00EE' => 0x94,
        '\u00EF' => 0x95,
        '\u00F1' => 0x96,
        '\u00F3' => 0x97,
        '\u00BB' => 0x98,
        '\u00F4' => 0x99,
        '\u00F6' => 0x9A,
        '\u00F7' => 0x9B,
        '\u00FA' => 0x9C,
        '\u00F9' => 0x9D,
        '\u00FB' => 0x9E,
        '\u00FC' => 0x9F,
        '\u066A' => 0xA5,
        '\u060C' => 0xAC,
        '\u06F0' => 0xB0,
        '\u06F1' => 0xB1,
        '\u06F2' => 0xB2,
        '\u06F3' => 0xB3,
        '\u06F4' => 0xB4,
        '\u06F5' => 0xB5,
        '\u06F6' => 0xB6,
        '\u06F7' => 0xB7,
        '\u06F8' => 0xB8,
        '\u06F9' => 0xB9,
        '\u061B' => 0xBB,
        '\u061F' => 0xBF,
        '\u274A' => 0xC0,
        '\u0621' => 0xC1,
        '\u0622' => 0xC2,
        '\u0623' => 0xC3,
        '\u0624' => 0xC4,
        '\u0625' => 0xC5,
        '\u0626' => 0xC6,
        '\u0627' => 0xC7,
        '\u0628' => 0xC8,
        '\u0629' => 0xC9,
        '\u062A' => 0xCA,
        '\u062B' => 0xCB,
        '\u062C' => 0xCC,
        '\u062D' => 0xCD,
        '\u062E' => 0xCE,
        '\u062F' => 0xCF,
        '\u0630' => 0xD0,
        '\u0631' => 0xD1,
        '\u0632' => 0xD2,
        '\u0633' => 0xD3,
        '\u0634' => 0xD4,
        '\u0635' => 0xD5,
        '\u0636' => 0xD6,
        '\u0637' => 0xD7,
        '\u0638' => 0xD8,
        '\u0639' => 0xD9,
        '\u063A' => 0xDA,
        '\u0640' => 0xE0,
        '\u0641' => 0xE1,
        '\u0642' => 0xE2,
        '\u0643' => 0xE3,
        '\u0644' => 0xE4,
        '\u0645' => 0xE5,
        '\u0646' => 0xE6,
        '\u0647' => 0xE7,
        '\u0648' => 0xE8,
        '\u0649' => 0xE9,
        '\u064A' => 0xEA,
        '\u064B' => 0xEB,
        '\u064C' => 0xEC,
        '\u064D' => 0xED,
        '\u064E' => 0xEE,
        '\u064F' => 0xEF,
        '\u0650' => 0xF0,
        '\u0651' => 0xF1,
        '\u0652' => 0xF2,
        '\u067E' => 0xF3,
        '\u0679' => 0xF4,
        '\u0686' => 0xF5,
        '\u06D5' => 0xF6,
        '\u06A4' => 0xF7,
        '\u06AF' => 0xF8,
        '\u0688' => 0xF9,
        '\u0691' => 0xFA,
        '\u0698' => 0xFE,
        '\u06D2' => 0xFF,
        _        => 0x3F
    };
}