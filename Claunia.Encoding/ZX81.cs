//
// ZX81.cs
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
    /// <summary>Represents a ZX81 character encoding of Unicode characters.</summary>
    public class Zx81 : Encoding
    {
        const string BODY_NAME        = "zx81";
        const int    CODEPAGE         = 0;
        const string ENCODING_NAME    = "Sinclair ZX81 character set";
        const string HEADER_NAME      = "zx81";
        const string WEB_NAME         = "";
        const int    WINDOWS_CODEPAGE = 0;

        const bool BROWSER_DISPLAY   = false;
        const bool BROWSER_SAVE      = false;
        const bool MAIL_NEWS_DISPLAY = false;
        const bool MAIL_NEWS_SAVE    = false;
        const bool READ_ONLY         = false;
        const bool SINGLE_BYTE       = true;

        /// <summary>The ZX81 to Unicode character map.</summary>
        static readonly char[] _zx81Table =
        {
            // 0x00
            '\u0020', '\u2598', '\u259D', '\u2580', '\u2596', '\u258C', '\u259E', '\u259B',

            // 0x08
            '\u2592', '\uFFFD', '\uFFFD', '\u0022', '\u00A3', '\u0024', '\u003A', '\u003F',

            // 0x10
            '\u0028', '\u0029', '\u003E', '\u003C', '\u003D', '\u002B', '\u002D', '\u002A',

            // 0x18
            '\u002F', '\u003B', '\u002C', '\u002E', '\u0030', '\u0031', '\u0032', '\u0033',

            // 0x20
            '\u0034', '\u0035', '\u0036', '\u0037', '\u0038', '\u0039', '\u0041', '\u0042',

            // 0x28
            '\u0043', '\u0044', '\u0045', '\u0046', '\u0047', '\u0048', '\u0049', '\u004A',

            // 0x30
            '\u004B', '\u004C', '\u004D', '\u004E', '\u004F', '\u0050', '\u0051', '\u0052',

            // 0x38
            '\u0053', '\u0054', '\u0055', '\u0056', '\u0057', '\u0058', '\u0059', '\u005A',

            // 0x40
            '\uFFFF', '\uFFFF', '\uFFFF', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x48
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x50
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x58
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x60
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x68
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',

            // 0x70
            '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF', '\u000A', '\u0008',

            // 0x78
            '\uFFFF', '\uFFFF', '\u0000', '\u0000', '\u0000', '\u0000', '\uFFFF', '\uFFFF',

            // 0x80
            '\u2588', '\u259F', '\u2599', '\u2584', '\u259C', '\u2590', '\u259A', '\u2597',

            // 0x88
            '\u2592', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD',

            // 0x90
            '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD',

            // 0x98
            '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD',

            // 0xA0
            '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD',

            // 0xA8
            '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD',

            // 0xB0
            '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD',

            // 0xB8
            '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD', '\uFFFD',

            // 0xC0
            '\uFFFF', '\uFFFF', '\uFFFF', '\u0000', '\uFFFF', '\uFFFF', '\uFFFF', '\uFFFF',

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

        /// <summary>Converts a ZX81 character to an Unicode character</summary>
        /// <returns>Unicode character.</returns>
        /// <param name="character">ZX81 character.</param>
        static char GetChar(byte character) => _zx81Table[character];

        /// <summary>Converts a Unicode character to an ZX81 character</summary>
        /// <returns>ZX81 character.</returns>
        /// <param name="character">Unicode character.</param>
        static byte GetByte(char character)
        {
            switch(character)
            {
                case '\u0020': return 0x00;
                case '\u2598': return 0x01;
                case '\u259D': return 0x02;
                case '\u2580': return 0x03;
                case '\u2596': return 0x04;
                case '\u258C': return 0x05;
                case '\u259E': return 0x06;
                case '\u259B': return 0x07;
                case '\u2592': return 0x08;
                case '\u0022': return 0x0B;
                case '\u00A3': return 0x0C;
                case '\u0024': return 0x0D;
                case '\u003A': return 0x0E;
                case '\u003F': return 0x0F;
                case '\u0028': return 0x10;
                case '\u0029': return 0x11;
                case '\u003E': return 0x12;
                case '\u003C': return 0x13;
                case '\u003D': return 0x14;
                case '\u002B': return 0x15;
                case '\u002D': return 0x16;
                case '\u002A': return 0x17;
                case '\u002F': return 0x18;
                case '\u003B': return 0x19;
                case '\u002C': return 0x1A;
                case '\u002E': return 0x1B;
                case '\u0030': return 0x1C;
                case '\u0031': return 0x1D;
                case '\u0032': return 0x1E;
                case '\u0033': return 0x1F;
                case '\u0034': return 0x20;
                case '\u0035': return 0x21;
                case '\u0036': return 0x22;
                case '\u0037': return 0x23;
                case '\u0038': return 0x24;
                case '\u0039': return 0x25;
                case '\u0041': return 0x26;
                case '\u0042': return 0x27;
                case '\u0043': return 0x28;
                case '\u0044': return 0x29;
                case '\u0045': return 0x2A;
                case '\u0046': return 0x2B;
                case '\u0047': return 0x2C;
                case '\u0048': return 0x2D;
                case '\u0049': return 0x2E;
                case '\u004A': return 0x2F;
                case '\u004B': return 0x30;
                case '\u004C': return 0x31;
                case '\u004D': return 0x32;
                case '\u004E': return 0x33;
                case '\u004F': return 0x34;
                case '\u0050': return 0x35;
                case '\u0051': return 0x36;
                case '\u0052': return 0x37;
                case '\u0053': return 0x38;
                case '\u0054': return 0x39;
                case '\u0055': return 0x3A;
                case '\u0056': return 0x3B;
                case '\u0057': return 0x3C;
                case '\u0058': return 0x3D;
                case '\u0059': return 0x3E;
                case '\u005A': return 0x3F;
                case '\u000D': return 0x74;
                case '\u000A': return 0x76;
                case '\u0008': return 0x77;
                case '\u2588': return 0x80;
                case '\u259F': return 0x81;
                case '\u2599': return 0x82;
                case '\u2584': return 0x83;
                case '\u259C': return 0x84;
                case '\u2590': return 0x85;
                case '\u259A': return 0x86;
                case '\u2597': return 0x87;
                default:
                    // Fallback to '?'
                    return 0x0F;
            }
        }
    }
}