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

using System;

namespace Claunia.Encoding
{
    /// <summary>Represents an Mac CentralEuropean character encoding of Unicode characters.</summary>
    public class MacCentralEuropean : Encoding
    {
        const string BODY_NAME        = "x-mac-ce";
        const int    CODEPAGE         = 10029;
        const string ENCODING_NAME    = "Central European (Mac)";
        const string HEADER_NAME      = "x-mac-ce";
        const string WEB_NAME         = "x-mac-ce";
        const int    WINDOWS_CODEPAGE = 10029;

        const bool BROWSER_DISPLAY   = false;
        const bool BROWSER_SAVE      = false;
        const bool MAIL_NEWS_DISPLAY = false;
        const bool MAIL_NEWS_SAVE    = false;
        const bool READ_ONLY         = true;
        const bool SINGLE_BYTE       = true;

        /// <summary>The Macintosh CentralEuropean to Unicode character map.</summary>
        static readonly char[] _macCentralEuropeanTable =
        {
            // 0x00
            '\u0000', '\u0001', '\u0002', '\u0003', '\u0004', '\u0005', '\u0006', '\u0007',

            // 0x08
            '\u0008', '\u0009', '\u000A', '\u000B', '\u000C', '\u000D', '\u000E', '\u000F',

            // 0x10
            '\u0010', '\u0011', '\u0012', '\u0013', '\u0014', '\u0015', '\u0016', '\u0017',

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
            '\u00C4', '\u0100', '\u0101', '\u00C9', '\u0104', '\u00D6', '\u00DC', '\u00E1',

            // 0x88
            '\u0105', '\u010C', '\u00E4', '\u010D', '\u0106', '\u0107', '\u00E9', '\u0179',

            // 0x90
            '\u017A', '\u010E', '\u00ED', '\u010F', '\u0112', '\u0113', '\u0116', '\u00F3',

            // 0x98
            '\u0117', '\u00F4', '\u00F6', '\u00F5', '\u00FA', '\u011A', '\u011B', '\u00FC',

            // 0xA0
            '\u2020', '\u00B0', '\u0118', '\u00A3', '\u00A7', '\u2022', '\u00B6', '\u00DF',

            // 0xA8
            '\u00AE', '\u00A9', '\u2122', '\u0119', '\u00A8', '\u2260', '\u0123', '\u012E',

            // 0xB0
            '\u012F', '\u012A', '\u2264', '\u2265', '\u012B', '\u0136', '\u2202', '\u2211',

            // 0xB8
            '\u0142', '\u013B', '\u013C', '\u013D', '\u013E', '\u0139', '\u013A', '\u0145',

            // 0xC0
            '\u0146', '\u0143', '\u00AC', '\u221A', '\u0144', '\u0147', '\u2206', '\u00AB',

            // 0xC8
            '\u00BB', '\u2026', '\u00A0', '\u0148', '\u0150', '\u00D5', '\u0151', '\u014C',

            // 0xD0
            '\u2013', '\u2014', '\u201C', '\u201D', '\u2018', '\u2019', '\u00F7', '\u25CA',

            // 0xD8
            '\u014D', '\u0154', '\u0155', '\u0158', '\u2039', '\u203A', '\u0159', '\u0156',

            // 0xE0
            '\u0157', '\u0160', '\u201A', '\u201E', '\u0161', '\u015A', '\u015B', '\u00C1',

            // 0xE8
            '\u0164', '\u0165', '\u00CD', '\u017D', '\u017E', '\u016A', '\u00D3', '\u00D4',

            // 0xF0
            '\u016B', '\u016E', '\u00DA', '\u016F', '\u0170', '\u0171', '\u0172', '\u0173',

            // 0xF8
            '\u00DD', '\u00FD', '\u0137', '\u017B', '\u0141', '\u017C', '\u0122', '\u02C7'
        };

        /// <summary>Gets a value indicating whether the current encoding can be used by browser clients for displaying content.</summary>
        public override bool IsBrowserDisplay => BROWSER_DISPLAY;

        /// <summary>Gets a value indicating whether the current encoding can be used by browser clients for saving content.</summary>
        public override bool IsBrowserSave => BROWSER_SAVE;

        /// <summary>
        ///     Gets a value indicating whether the current encoding can be used by mail and news clients for displaying
        ///     content.
        /// </summary>
        public override bool IsMailNewsDisplay => MAIL_NEWS_DISPLAY;

        /// <summary>Gets a value indicating whether the current encoding can be used by mail and news clients for saving content.</summary>
        public override bool IsMailNewsSave => MAIL_NEWS_SAVE;

        /// <summary>Gets a value indicating whether the current encoding is read-only.</summary>
        /// <value>The is single byte.</value>
        public override bool IsReadOnly => READ_ONLY;

        /// <summary>Gets a value indicating whether the current encoding uses single-byte code points.</summary>
        public override bool IsSingleByte => SINGLE_BYTE;

        /// <summary>Gets the code page identifier of the current Encoding.</summary>
        public override int CodePage => CODEPAGE;

        /// <summary>Gets a name for the current encoding that can be used with mail agent body tags</summary>
        public override string BodyName => BODY_NAME;

        /// <summary>Gets a name for the current encoding that can be used with mail agent header tags</summary>
        public override string HeaderName => HEADER_NAME;

        /// <summary>Gets the name registered with the Internet Assigned Numbers Authority (IANA) for the current encoding.</summary>
        public override string WebName => WEB_NAME;

        /// <summary>Gets the human-readable description of the current encoding.</summary>
        public override string EncodingName => ENCODING_NAME;

        /// <summary>Gets the Windows operating system code page that most closely corresponds to the current encoding.</summary>
        public override int WindowsCodePage => WINDOWS_CODEPAGE;

        /// <summary>Calculates the number of bytes produced by encoding the characters in the specified <see cref="string" />.</summary>
        /// <returns>The number of bytes produced by encoding the specified characters.</returns>
        /// <param name="s">The <see cref="string" /> containing the set of characters to encode.</param>
        public override int GetByteCount(string s)
        {
            if(s == null)
                throw new ArgumentNullException(nameof(s));

            return s.Length;
        }

        /// <summary>Calculates the number of bytes produced by encoding a set of characters from the specified character array.</summary>
        /// <returns>The number of bytes produced by encoding the specified characters.</returns>
        /// <param name="chars">The character array containing the set of characters to encode.</param>
        /// <param name="index">The index of the first character to encode.</param>
        /// <param name="count">The number of characters to encode.</param>
        public override int GetByteCount(char[] chars, int index, int count)
        {
            if(chars == null)
                throw new ArgumentNullException(nameof(chars));

            if(index < 0 ||
               index >= chars.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            if(count         < 0 ||
               index + count > chars.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            return count;
        }

        /// <summary>Calculates the number of bytes produced by encoding all the characters in the specified character array.</summary>
        /// <returns>The number of bytes produced by encoding all the characters in the specified character array.</returns>
        /// <param name="chars">The character array containing the characters to encode.</param>
        public override int GetByteCount(char[] chars)
        {
            if(chars == null)
                throw new ArgumentNullException(nameof(chars));

            return chars.Length;
        }

        /// <summary>Encodes a set of characters from the specified <see cref="string" /> into the specified byte array.</summary>
        /// <returns>The actual number of bytes written into bytes.</returns>
        /// <param name="s">The <see cref="string" /> containing the set of characters to encode.</param>
        /// <param name="charIndex">The index of the first character to encode.</param>
        /// <param name="charCount">The number of characters to encode.</param>
        /// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
        /// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex) =>
            GetBytes(s.ToCharArray(), charIndex, charCount, bytes, byteIndex);

        /// <summary>Encodes all the characters in the specified string into a sequence of bytes.</summary>
        /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
        /// <param name="s">The string containing the characters to encode.</param>
        public override byte[] GetBytes(string s)
        {
            if(s == null)
                throw new ArgumentNullException(nameof(s));

            return GetBytes(s.ToCharArray(), 0, s.Length);
        }

        /// <summary>Encodes a set of characters from the specified character array into the specified byte array.</summary>
        /// <returns>The actual number of bytes written into bytes.</returns>
        /// <param name="chars">The character array containing the set of characters to encode.</param>
        /// <param name="charIndex">The index of the first character to encode.</param>
        /// <param name="charCount">The number of characters to encode.</param>
        /// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
        /// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            if(chars == null)
                throw new ArgumentNullException(nameof(chars));

            if(bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            if(charIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(charIndex));

            if(charCount < 0)
                throw new ArgumentOutOfRangeException(nameof(charCount));

            if(byteIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(byteIndex));

            if(charIndex >= chars.Length)
                throw new ArgumentOutOfRangeException(nameof(charIndex));

            if(charCount + charIndex > chars.Length)
                throw new ArgumentOutOfRangeException(nameof(charCount));

            if(byteIndex >= bytes.Length)
                throw new ArgumentOutOfRangeException(nameof(byteIndex));

            if(byteIndex + charCount > bytes.Length)
                throw new ArgumentException(nameof(bytes));

            byte[] temp = GetBytes(chars, charIndex, charCount);

            for(int i = 0; i < temp.Length; i++)
                bytes[i + byteIndex] = temp[i];

            return charCount;
        }

        /// <summary>Encodes a set of characters from the specified character array into a sequence of bytes.</summary>
        /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
        /// <param name="chars">The character array containing the set of characters to encode.</param>
        /// <param name="index">The index of the first character to encode.</param>
        /// <param name="count">The number of characters to encode.</param>
        public override byte[] GetBytes(char[] chars, int index, int count)
        {
            if(chars == null)
                throw new ArgumentNullException(nameof(chars));

            if(index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if(count + index > chars.Length)
                throw new ArgumentOutOfRangeException(nameof(count));

            byte[] bytes = new byte[count];

            for(int i = 0; i < count; i++)
                bytes[i] = GetByte(chars[index + i]);

            return bytes;
        }

        /// <summary>Encodes all the characters in the specified character array into a sequence of bytes.</summary>
        /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
        /// <param name="chars">The character array containing the characters to encode.</param>
        public override byte[] GetBytes(char[] chars) => GetBytes(chars, 0, chars.Length);

        /// <summary>Calculates the number of characters produced by decoding all the bytes in the specified byte array.</summary>
        /// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        public override int GetCharCount(byte[] bytes) => GetCharCount(bytes, 0, bytes.Length);

        /// <summary>Calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.</summary>
        /// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <param name="index">The index of the first byte to decode.</param>
        /// <param name="count">The number of bytes to decode.</param>
        public override int GetCharCount(byte[] bytes, int index, int count)
        {
            if(bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            if(index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if(count + index > bytes.Length)
                throw new ArgumentOutOfRangeException(nameof(count));

            return count;
        }

        /// <summary>Decodes a sequence of bytes from the specified byte array into the specified character array.</summary>
        /// <returns>The actual number of characters written into chars.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <param name="byteIndex">The index of the first byte to decode.</param>
        /// <param name="byteCount">The number of bytes to decode.</param>
        /// <param name="chars">The character array to contain the resulting set of characters.</param>
        /// <param name="charIndex">The index at which to start writing the resulting set of characters.</param>
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
        {
            if(bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            if(chars == null)
                throw new ArgumentNullException(nameof(chars));

            if(byteIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(byteIndex));

            if(byteCount < 0)
                throw new ArgumentOutOfRangeException(nameof(byteCount));

            if(charIndex < 0)
                throw new ArgumentOutOfRangeException(nameof(charIndex));

            if(byteIndex >= bytes.Length)
                throw new ArgumentOutOfRangeException(nameof(byteIndex));

            if(byteCount + byteIndex > bytes.Length)
                throw new ArgumentOutOfRangeException(nameof(byteCount));

            if(charIndex >= chars.Length)
                throw new ArgumentOutOfRangeException(nameof(charIndex));

            if(charIndex + byteCount > chars.Length)
                throw new ArgumentException(nameof(chars));

            char[] temp = GetChars(bytes, byteIndex, byteCount);

            for(int i = 0; i < temp.Length; i++)
                chars[i + charIndex] = temp[i];

            return byteCount;
        }

        /// <summary>Decodes all the bytes in the specified byte array into a set of characters.</summary>
        /// <returns>A character array containing the results of decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        public override char[] GetChars(byte[] bytes) => GetChars(bytes, 0, bytes.Length);

        /// <summary>Decodes a sequence of bytes from the specified byte array into a set of characters.</summary>
        /// <returns>The chars.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <param name="index">The index of the first byte to decode.</param>
        /// <param name="count">The number of bytes to decode.</param>
        public override char[] GetChars(byte[] bytes, int index, int count)
        {
            if(bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            if(index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if(count + index > bytes.Length)
                throw new ArgumentOutOfRangeException(nameof(count));

            char[] chars = new char[count];

            for(int i = 0; i < count; i++)
                chars[i] = GetChar(bytes[index + i]);

            return chars;
        }

        /// <summary>Calculates the maximum number of bytes produced by encoding the specified number of characters.</summary>
        /// <returns>The maximum number of bytes produced by encoding the specified number of characters.</returns>
        /// <param name="charCount">The number of characters to encode.</param>
        public override int GetMaxByteCount(int charCount)
        {
            if(charCount < 0)
                throw new ArgumentOutOfRangeException(nameof(charCount));

            return charCount;
        }

        /// <summary>Calculates the maximum number of characters produced by decoding the specified number of bytes.</summary>
        /// <returns>The maximum number of characters produced by decoding the specified number of bytes.</returns>
        /// <param name="byteCount">The number of bytes to decode.</param>
        public override int GetMaxCharCount(int byteCount)
        {
            if(byteCount < 0)
                throw new ArgumentOutOfRangeException(nameof(byteCount));

            return byteCount;
        }

        /// <summary>Returns a sequence of bytes that specifies the encoding used.</summary>
        /// <returns>A byte array of length zero, as a preamble is not required.</returns>
        public override byte[] GetPreamble() => new byte[0];

        /// <summary>Decodes all the bytes in the specified byte array into a string.</summary>
        /// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        public override string GetString(byte[] bytes) => GetString(bytes, 0, bytes.Length);

        /// <summary>Decodes a sequence of bytes from the specified byte array into a string.</summary>
        /// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <param name="index">The index of the first byte to decode.</param>
        /// <param name="count">The number of bytes to decode.</param>
        public override string GetString(byte[] bytes, int index, int count) => new(GetChars(bytes, index, count));

        /// <summary>Converts a Mac CentralEuropean character to an Unicode character</summary>
        /// <returns>Unicode character.</returns>
        /// <param name="character">Mac CentralEuropean character.</param>
        static char GetChar(byte character) => _macCentralEuropeanTable[character];

        /// <summary>Converts a Unicode character to an Mac CentralEuropean character</summary>
        /// <returns>Mac CentralEuropean character.</returns>
        /// <param name="character">Unicode character.</param>
        static byte GetByte(char character)
        {
            switch(character)
            {
                case '\u0000': return 0x00;
                case '\u0001': return 0x01;
                case '\u0002': return 0x02;
                case '\u0003': return 0x03;
                case '\u0004': return 0x04;
                case '\u0005': return 0x05;
                case '\u0006': return 0x06;
                case '\u0007': return 0x07;
                case '\u0008': return 0x08;
                case '\u0009': return 0x09;
                case '\u000A': return 0x0A;
                case '\u000B': return 0x0B;
                case '\u000C': return 0x0C;
                case '\u000D': return 0x0D;
                case '\u000E': return 0x0E;
                case '\u000F': return 0x0F;
                case '\u0010': return 0x10;
                case '\u0011': return 0x11;
                case '\u0012': return 0x12;
                case '\u0013': return 0x13;
                case '\u0014': return 0x14;
                case '\u0015': return 0x15;
                case '\u0016': return 0x16;
                case '\u0017': return 0x17;
                case '\u0018': return 0x18;
                case '\u0019': return 0x19;
                case '\u001A': return 0x1A;
                case '\u001B': return 0x1B;
                case '\u001C': return 0x1C;
                case '\u001D': return 0x1D;
                case '\u001E': return 0x1E;
                case '\u001F': return 0x1F;
                case '\u0020': return 0x20;
                case '\u0021': return 0x21;
                case '\u0022': return 0x22;
                case '\u0023': return 0x23;
                case '\u0024': return 0x24;
                case '\u0025': return 0x25;
                case '\u0026': return 0x26;
                case '\u0027': return 0x27;
                case '\u0028': return 0x28;
                case '\u0029': return 0x29;
                case '\u002A': return 0x2A;
                case '\u002B': return 0x2B;
                case '\u002C': return 0x2C;
                case '\u002D': return 0x2D;
                case '\u002E': return 0x2E;
                case '\u002F': return 0x2F;
                case '\u0030': return 0x30;
                case '\u0031': return 0x31;
                case '\u0032': return 0x32;
                case '\u0033': return 0x33;
                case '\u0034': return 0x34;
                case '\u0035': return 0x35;
                case '\u0036': return 0x36;
                case '\u0037': return 0x37;
                case '\u0038': return 0x38;
                case '\u0039': return 0x39;
                case '\u003A': return 0x3A;
                case '\u003B': return 0x3B;
                case '\u003C': return 0x3C;
                case '\u003D': return 0x3D;
                case '\u003E': return 0x3E;
                case '\u003F': return 0x3F;
                case '\u0040': return 0x40;
                case '\u0041': return 0x41;
                case '\u0042': return 0x42;
                case '\u0043': return 0x43;
                case '\u0044': return 0x44;
                case '\u0045': return 0x45;
                case '\u0046': return 0x46;
                case '\u0047': return 0x47;
                case '\u0048': return 0x48;
                case '\u0049': return 0x49;
                case '\u004A': return 0x4A;
                case '\u004B': return 0x4B;
                case '\u004C': return 0x4C;
                case '\u004D': return 0x4D;
                case '\u004E': return 0x4E;
                case '\u004F': return 0x4F;
                case '\u0050': return 0x50;
                case '\u0051': return 0x51;
                case '\u0052': return 0x52;
                case '\u0053': return 0x53;
                case '\u0054': return 0x54;
                case '\u0055': return 0x55;
                case '\u0056': return 0x56;
                case '\u0057': return 0x57;
                case '\u0058': return 0x58;
                case '\u0059': return 0x59;
                case '\u005A': return 0x5A;
                case '\u005B': return 0x5B;
                case '\u005C': return 0x5C;
                case '\u005D': return 0x5D;
                case '\u005E': return 0x5E;
                case '\u005F': return 0x5F;
                case '\u0060': return 0x60;
                case '\u0061': return 0x61;
                case '\u0062': return 0x62;
                case '\u0063': return 0x63;
                case '\u0064': return 0x64;
                case '\u0065': return 0x65;
                case '\u0066': return 0x66;
                case '\u0067': return 0x67;
                case '\u0068': return 0x68;
                case '\u0069': return 0x69;
                case '\u006A': return 0x6A;
                case '\u006B': return 0x6B;
                case '\u006C': return 0x6C;
                case '\u006D': return 0x6D;
                case '\u006E': return 0x6E;
                case '\u006F': return 0x6F;
                case '\u0070': return 0x70;
                case '\u0071': return 0x71;
                case '\u0072': return 0x72;
                case '\u0073': return 0x73;
                case '\u0074': return 0x74;
                case '\u0075': return 0x75;
                case '\u0076': return 0x76;
                case '\u0077': return 0x77;
                case '\u0078': return 0x78;
                case '\u0079': return 0x79;
                case '\u007A': return 0x7A;
                case '\u007B': return 0x7B;
                case '\u007C': return 0x7C;
                case '\u007D': return 0x7D;
                case '\u007E': return 0x7E;
                case '\u007F': return 0x7F;
                case '\u00C4': return 0x80;
                case '\u0100': return 0x81;
                case '\u0101': return 0x82;
                case '\u00C9': return 0x83;
                case '\u0104': return 0x84;
                case '\u00D6': return 0x85;
                case '\u00DC': return 0x86;
                case '\u00E1': return 0x87;
                case '\u0105': return 0x88;
                case '\u010C': return 0x89;
                case '\u00E4': return 0x8A;
                case '\u010D': return 0x8B;
                case '\u0106': return 0x8C;
                case '\u0107': return 0x8D;
                case '\u00E9': return 0x8E;
                case '\u0179': return 0x8F;
                case '\u017A': return 0x90;
                case '\u010E': return 0x91;
                case '\u00ED': return 0x92;
                case '\u010F': return 0x93;
                case '\u0112': return 0x94;
                case '\u0113': return 0x95;
                case '\u0116': return 0x96;
                case '\u00F3': return 0x97;
                case '\u0117': return 0x98;
                case '\u00F4': return 0x99;
                case '\u00F6': return 0x9A;
                case '\u00F5': return 0x9B;
                case '\u00FA': return 0x9C;
                case '\u011A': return 0x9D;
                case '\u011B': return 0x9E;
                case '\u00FC': return 0x9F;
                case '\u2020': return 0xA0;
                case '\u00B0': return 0xA1;
                case '\u0118': return 0xA2;
                case '\u00A3': return 0xA3;
                case '\u00A7': return 0xA4;
                case '\u2022': return 0xA5;
                case '\u00B6': return 0xA6;
                case '\u00DF': return 0xA7;
                case '\u00AE': return 0xA8;
                case '\u00A9': return 0xA9;
                case '\u2122': return 0xAA;
                case '\u0119': return 0xAB;
                case '\u00A8': return 0xAC;
                case '\u2260': return 0xAD;
                case '\u0123': return 0xAE;
                case '\u012E': return 0xAF;
                case '\u012F': return 0xB0;
                case '\u012A': return 0xB1;
                case '\u2264': return 0xB2;
                case '\u2265': return 0xB3;
                case '\u012B': return 0xB4;
                case '\u0136': return 0xB5;
                case '\u2202': return 0xB6;
                case '\u2211': return 0xB7;
                case '\u0142': return 0xB8;
                case '\u013B': return 0xB9;
                case '\u013C': return 0xBA;
                case '\u013D': return 0xBB;
                case '\u013E': return 0xBC;
                case '\u0139': return 0xBD;
                case '\u013A': return 0xBE;
                case '\u0145': return 0xBF;
                case '\u0146': return 0xC0;
                case '\u0143': return 0xC1;
                case '\u00AC': return 0xC2;
                case '\u221A': return 0xC3;
                case '\u0144': return 0xC4;
                case '\u0147': return 0xC5;
                case '\u2206': return 0xC6;
                case '\u00AB': return 0xC7;
                case '\u00BB': return 0xC8;
                case '\u2026': return 0xC9;
                case '\u00A0': return 0xCA;
                case '\u0148': return 0xCB;
                case '\u0150': return 0xCC;
                case '\u00D5': return 0xCD;
                case '\u0151': return 0xCE;
                case '\u014C': return 0xCF;
                case '\u2013': return 0xD0;
                case '\u2014': return 0xD1;
                case '\u201C': return 0xD2;
                case '\u201D': return 0xD3;
                case '\u2018': return 0xD4;
                case '\u2019': return 0xD5;
                case '\u00F7': return 0xD6;
                case '\u05CA': return 0xD7;
                case '\u014D': return 0xD8;
                case '\u0154': return 0xD9;
                case '\u0155': return 0xDA;
                case '\u0158': return 0xDB;
                case '\u2039': return 0xDC;
                case '\u203A': return 0xDD;
                case '\u0159': return 0xDE;
                case '\u0156': return 0xDF;
                case '\u0157': return 0xE0;
                case '\u0160': return 0xE1;
                case '\u201A': return 0xE2;
                case '\u201E': return 0xE3;
                case '\u0161': return 0xE4;
                case '\u015A': return 0xE5;
                case '\u015B': return 0xE6;
                case '\u00C1': return 0xE7;
                case '\u0164': return 0xE8;
                case '\u0165': return 0xE9;
                case '\u00CD': return 0xEA;
                case '\u017D': return 0xEB;
                case '\u017E': return 0xEC;
                case '\u016A': return 0xED;
                case '\u00D3': return 0xEE;
                case '\u00D4': return 0xEF;
                case '\u016B': return 0xF0;
                case '\u016E': return 0xF1;
                case '\u00DA': return 0xF2;
                case '\u016F': return 0xF3;
                case '\u0170': return 0xF4;
                case '\u0171': return 0xF5;
                case '\u0172': return 0xF6;
                case '\u0173': return 0xF7;
                case '\u00DD': return 0xF8;
                case '\u00FD': return 0xF9;
                case '\u0137': return 0xFA;
                case '\u017B': return 0xFB;
                case '\u0141': return 0xFC;
                case '\u017C': return 0xFD;
                case '\u0122': return 0xFE;
                case '\u02C7': return 0xFF;
                default:
                    // Fallback to '?'
                    return 0x3F;
            }
        }
    }
}