//
// Apple IIgs.cs
//
// Author:
//       Natalia Portillo <claunia@claunia.com>
//
// Copyright © 2016-2018 Natalia Portillo
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
    /// <summary>
    ///     Represents an Apple IIgs character encoding of Unicode characters.
    /// </summary>
    public class Apple2gs : Encoding
    {
        const string _bodyname        = "apple2gs";
        const int    _codepage        = 0;
        const string _encodingname    = "Western European (Apple IIgs)";
        const string _headername      = "apple2gs";
        const string _webname         = "";
        const int    _windowsCodepage = 0;

        const bool browserDisplay  = false;
        const bool browserSave     = false;
        const bool mailNewsDisplay = false;
        const bool mailNewsSave    = false;
        const bool readOnly        = true;
        const bool singleByte      = true;

        /// <summary>
        ///     The Apple IIgs to Unicode character map.
        ///     Inverted screen characters are mapped to normal characters.
        /// </summary>
        static readonly char[] Apple2gsTable =
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

        /// <summary>
        ///     Gets a value indicating whether the current encoding can be used by browser clients for displaying content.
        /// </summary>
        public override bool IsBrowserDisplay => browserDisplay;

        /// <summary>
        ///     Gets a value indicating whether the current encoding can be used by browser clients for saving content.
        /// </summary>
        public override bool IsBrowserSave => browserSave;

        /// <summary>
        ///     Gets a value indicating whether the current encoding can be used by mail and news clients for displaying content.
        /// </summary>
        public override bool IsMailNewsDisplay => mailNewsDisplay;

        /// <summary>
        ///     Gets a value indicating whether the current encoding can be used by mail and news clients for saving content.
        /// </summary>
        public override bool IsMailNewsSave => mailNewsSave;

        /// <summary>
        ///     Gets a value indicating whether the current encoding is read-only.
        /// </summary>
        /// <value>The is single byte.</value>
        public override bool IsReadOnly => readOnly;

        /// <summary>
        ///     Gets a value indicating whether the current encoding uses single-byte code points.
        /// </summary>
        public override bool IsSingleByte => singleByte;

        /// <summary>
        ///     Gets the code page identifier of the current Encoding.
        /// </summary>
        public override int CodePage => _codepage;

        /// <summary>
        ///     Gets a name for the current encoding that can be used with mail agent body tags
        /// </summary>
        public override string BodyName => _bodyname;

        /// <summary>
        ///     Gets a name for the current encoding that can be used with mail agent header tags
        /// </summary>
        public override string HeaderName => _headername;

        /// <summary>
        ///     Ggets the name registered with the Internet Assigned Numbers Authority (IANA) for the current encoding.
        /// </summary>
        public override string WebName => _webname;

        /// <summary>
        ///     Gets the human-readable description of the current encoding.
        /// </summary>
        public override string EncodingName => _encodingname;

        /// <summary>
        ///     Gets the Windows operating system code page that most closely corresponds to the current encoding.
        /// </summary>
        public override int WindowsCodePage => _windowsCodepage;

        /// <summary>
        ///     Calculates the number of bytes produced by encoding the characters in the specified <see cref="string" />.
        /// </summary>
        /// <returns>The number of bytes produced by encoding the specified characters.</returns>
        /// <param name="s">The <see cref="string" /> containing the set of characters to encode.</param>
        public override int GetByteCount(string s)
        {
            if(s == null) throw new ArgumentNullException(nameof(s));

            return s.Length;
        }

        /// <summary>
        ///     Calculates the number of bytes produced by encoding a set of characters from the specified character array.
        /// </summary>
        /// <returns>The number of bytes produced by encoding the specified characters.</returns>
        /// <param name="chars">The character array containing the set of characters to encode.</param>
        /// <param name="index">The index of the first character to encode.</param>
        /// <param name="count">The number of characters to encode.</param>
        public override int GetByteCount(char[] chars, int index, int count)
        {
            if(chars == null) throw new ArgumentNullException(nameof(chars));

            if(index < 0 || index >= chars.Length) throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0 || index + count > chars.Length) throw new ArgumentOutOfRangeException(nameof(index));

            return count;
        }

        /// <summary>
        ///     Calculates the number of bytes produced by encoding all the characters in the specified character array.
        /// </summary>
        /// <returns>The number of bytes produced by encoding all the characters in the specified character array.</returns>
        /// <param name="chars">The character array containing the characters to encode.</param>
        public override int GetByteCount(char[] chars)
        {
            if(chars == null) throw new ArgumentNullException(nameof(chars));

            return chars.Length;
        }

        /// <summary>
        ///     Encodes a set of characters from the specified <see cref="string" /> into the specified byte array.
        /// </summary>
        /// <returns>The actual number of bytes written into bytes.</returns>
        /// <param name="s">The <see cref="string" /> containing the set of characters to encode.</param>
        /// <param name="charIndex">The index of the first character to encode.</param>
        /// <param name="charCount">The number of characters to encode.</param>
        /// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
        /// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            return GetBytes(s.ToCharArray(), charIndex, charCount, bytes, byteIndex);
        }

        /// <summary>
        ///     Encodes all the characters in the specified string into a sequence of bytes.
        /// </summary>
        /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
        /// <param name="s">The string containing the characters to encode.</param>
        public override byte[] GetBytes(string s)
        {
            if(s == null) throw new ArgumentNullException(nameof(s));

            return GetBytes(s.ToCharArray(), 0, s.Length);
        }

        /// <summary>
        ///     Encodes a set of characters from the specified character array into the specified byte array.
        /// </summary>
        /// <returns>The actual number of bytes written into bytes.</returns>
        /// <param name="chars">The character array containing the set of characters to encode.</param>
        /// <param name="charIndex">The index of the first character to encode.</param>
        /// <param name="charCount">The number of characters to encode.</param>
        /// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
        /// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
        public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            if(chars == null) throw new ArgumentNullException(nameof(chars));

            if(bytes == null) throw new ArgumentNullException(nameof(bytes));

            if(charIndex < 0) throw new ArgumentOutOfRangeException(nameof(charIndex));

            if(charCount < 0) throw new ArgumentOutOfRangeException(nameof(charCount));

            if(byteIndex < 0) throw new ArgumentOutOfRangeException(nameof(byteIndex));

            if(charIndex >= chars.Length) throw new ArgumentOutOfRangeException(nameof(charIndex));

            if(charCount + charIndex > chars.Length) throw new ArgumentOutOfRangeException(nameof(charCount));

            if(byteIndex >= bytes.Length) throw new ArgumentOutOfRangeException(nameof(byteIndex));

            if(byteIndex + charCount > bytes.Length) throw new ArgumentException(nameof(bytes));

            byte[] temp = GetBytes(chars, charIndex, charCount);

            for(int i = 0; i < temp.Length; i++) bytes[i + byteIndex] = temp[i];

            return charCount;
        }

        /// <summary>
        ///     Encodes a set of characters from the specified character array into a sequence of bytes.
        /// </summary>
        /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
        /// <param name="chars">The character array containing the set of characters to encode.</param>
        /// <param name="index">The index of the first character to encode.</param>
        /// <param name="count">The number of characters to encode.</param>
        public override byte[] GetBytes(char[] chars, int index, int count)
        {
            if(chars == null) throw new ArgumentNullException(nameof(chars));

            if(index < 0) throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0) throw new ArgumentOutOfRangeException(nameof(count));

            if(count + index > chars.Length) throw new ArgumentOutOfRangeException(nameof(count));

            byte[] bytes = new byte[count];

            for(int i = 0; i < count; i++) bytes[i] = GetByte(chars[index + i]);

            return bytes;
        }

        /// <summary>
        ///     Encodes all the characters in the specified character array into a sequence of bytes.
        /// </summary>
        /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
        /// <param name="chars">The character array containing the characters to encode.</param>
        public override byte[] GetBytes(char[] chars)
        {
            return GetBytes(chars, 0, chars.Length);
        }

        /// <summary>
        ///     Calculates the number of characters produced by decoding all the bytes in the specified byte array.
        /// </summary>
        /// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        public override int GetCharCount(byte[] bytes)
        {
            return GetCharCount(bytes, 0, bytes.Length);
        }

        /// <summary>
        ///     Calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.
        /// </summary>
        /// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <param name="index">The index of the first byte to decode.</param>
        /// <param name="count">The number of bytes to decode.</param>
        public override int GetCharCount(byte[] bytes, int index, int count)
        {
            if(bytes == null) throw new ArgumentNullException(nameof(bytes));

            if(index < 0) throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0) throw new ArgumentOutOfRangeException(nameof(count));

            if(count + index > bytes.Length) throw new ArgumentOutOfRangeException(nameof(count));

            return count;
        }

        /// <summary>
        ///     Decodes a sequence of bytes from the specified byte array into the specified character array.
        /// </summary>
        /// <returns>The actual number of characters written into chars.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <param name="byteIndex">The index of the first byte to decode.</param>
        /// <param name="byteCount">The number of bytes to decode.</param>
        /// <param name="chars">The character array to contain the resulting set of characters.</param>
        /// <param name="charIndex">The index at which to start writing the resulting set of characters.</param>
        public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
        {
            if(bytes == null) throw new ArgumentNullException(nameof(bytes));

            if(chars == null) throw new ArgumentNullException(nameof(chars));

            if(byteIndex < 0) throw new ArgumentOutOfRangeException(nameof(byteIndex));

            if(byteCount < 0) throw new ArgumentOutOfRangeException(nameof(byteCount));

            if(charIndex < 0) throw new ArgumentOutOfRangeException(nameof(charIndex));

            if(byteIndex >= bytes.Length) throw new ArgumentOutOfRangeException(nameof(byteIndex));

            if(byteCount + byteIndex > bytes.Length) throw new ArgumentOutOfRangeException(nameof(byteCount));

            if(charIndex >= chars.Length) throw new ArgumentOutOfRangeException(nameof(charIndex));

            if(charIndex + byteCount > chars.Length) throw new ArgumentException(nameof(chars));

            char[] temp = GetChars(bytes, byteIndex, byteCount);

            for(int i = 0; i < temp.Length; i++) chars[i + charIndex] = temp[i];

            return byteCount;
        }

        /// <summary>
        ///     Decodes all the bytes in the specified byte array into a set of characters.
        /// </summary>
        /// <returns>A character array containing the results of decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        public override char[] GetChars(byte[] bytes)
        {
            return GetChars(bytes, 0, bytes.Length);
        }

        /// <summary>
        ///     Decodes a sequence of bytes from the specified byte array into a set of characters.
        /// </summary>
        /// <returns>The chars.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <param name="index">The index of the first byte to decode.</param>
        /// <param name="count">The number of bytes to decode.</param>
        public override char[] GetChars(byte[] bytes, int index, int count)
        {
            if(bytes == null) throw new ArgumentNullException(nameof(bytes));

            if(index < 0) throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0) throw new ArgumentOutOfRangeException(nameof(count));

            if(count + index > bytes.Length) throw new ArgumentOutOfRangeException(nameof(count));

            char[] chars = new char[count];

            for(int i = 0; i < count; i++) chars[i] = GetChar(bytes[index + i]);

            return chars;
        }

        /// <summary>
        ///     Calculates the maximum number of bytes produced by encoding the specified number of characters.
        /// </summary>
        /// <returns>The maximum number of bytes produced by encoding the specified number of characters.</returns>
        /// <param name="charCount">The number of characters to encode.</param>
        public override int GetMaxByteCount(int charCount)
        {
            if(charCount < 0) throw new ArgumentOutOfRangeException(nameof(charCount));

            return charCount;
        }

        /// <summary>
        ///     Calculates the maximum number of characters produced by decoding the specified number of bytes.
        /// </summary>
        /// <returns>The maximum number of characters produced by decoding the specified number of bytes.</returns>
        /// <param name="byteCount">The number of bytes to decode.</param>
        public override int GetMaxCharCount(int byteCount)
        {
            if(byteCount < 0) throw new ArgumentOutOfRangeException(nameof(byteCount));

            return byteCount;
        }

        /// <summary>
        ///     Returns a sequence of bytes that specifies the encoding used.
        /// </summary>
        /// <returns>A byte array of length zero, as a preamble is not required.</returns>
        public override byte[] GetPreamble()
        {
            return new byte[0];
        }

        /// <summary>
        ///     Decodes all the bytes in the specified byte array into a string.
        /// </summary>
        /// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        public override string GetString(byte[] bytes)
        {
            return GetString(bytes, 0, bytes.Length);
        }

        /// <summary>
        ///     Decodes a sequence of bytes from the specified byte array into a string.
        /// </summary>
        /// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        /// <param name="index">The index of the first byte to decode.</param>
        /// <param name="count">The number of bytes to decode.</param>
        public override string GetString(byte[] bytes, int index, int count)
        {
            return new string(GetChars(bytes, index, count));
        }

        /// <summary>
        ///     Converts a Apple IIgs character to an Unicode character
        /// </summary>
        /// <returns>Unicode character.</returns>
        /// <param name="character">Apple IIgs character.</param>
        static char GetChar(byte character)
        {
            return Apple2gsTable[character];
        }

        /// <summary>
        ///     Converts a Unicode character to an Apple IIgs character
        /// </summary>
        /// <returns>Apple IIgs character.</returns>
        /// <param name="character">Unicode character.</param>
        static byte GetByte(char character)
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