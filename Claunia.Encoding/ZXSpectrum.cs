//
// ZXSpectrum.cs
//
// Author:
//       Natalia Portillo <claunia@claunia.com>
//
// Copyright (c) 2016 © Claunia.com
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
    /// Represents an ZX Spectrum character encoding of Unicode characters.
    /// </summary>
    public class ZXSpectrum : System.Text.Encoding
    {
        const string _bodyname = "spectrum";
        const int _codepage = 0;
        const string _encodingname = "ZX Spectrum";
        const string _headername = "spectrum";
        const string _webname = "";
        const int _windowsCodepage = 0;

        const bool browserDisplay = false;
        const bool browserSave = false;
        const bool mailNewsDisplay = false;
        const bool mailNewsSave = false;
        const bool readOnly = false;
        const bool singleByte = true;

        /// <summary>
        /// Gets a value indicating whether the current encoding can be used by browser clients for displaying content.
        /// </summary>
        public bool IsBrowserDisplay {
            get { return browserDisplay; }
        }

        /// <summary>
        /// Gets a value indicating whether the current encoding can be used by browser clients for saving content.
        /// </summary>
        public bool IsBrowserSave {
            get { return browserSave; }
        }

        /// <summary>
        /// Gets a value indicating whether the current encoding can be used by mail and news clients for displaying content.
        /// </summary>
        public bool IsMailNewsDisplay {
            get { return mailNewsDisplay; }
        }

        /// <summary>
        /// Gets a value indicating whether the current encoding can be used by mail and news clients for saving content.
        /// </summary>
        public bool IsMailNewsSave {
            get { return mailNewsSave; }
        }

        /// <summary>
        /// Gets a value indicating whether the current encoding is read-only.
        /// </summary>
        /// <value>The is single byte.</value>
        public bool IsReadOnly {
            get { return readOnly; }
        }

        /// <summary>
        /// Gets a value indicating whether the current encoding uses single-byte code points.
        /// </summary>
        public bool IsSingleByte {
            get { return singleByte; }
        }

        /// <summary>
        /// Gets the code page identifier of the current Encoding.
        /// </summary>
        public int CodePage {
            get { return _codepage; }
        }

        /// <summary>
        /// Gets a name for the current encoding that can be used with mail agent body tags
        /// </summary>
        public string BodyName {
            get { return _bodyname; }
        }

        /// <summary>
        /// Gets a name for the current encoding that can be used with mail agent header tags
        /// </summary>
        public string HeaderName {
            get { return _headername; }
        }

        /// <summary>
        /// Ggets the name registered with the Internet Assigned Numbers Authority (IANA) for the current encoding.
        /// </summary>
        public override string WebName {
            get { return _webname; }
        }

        /// <summary>
        /// Gets the human-readable description of the current encoding.
        /// </summary>
        public string EncodingName {
            get { return _encodingname; }
        }

        /// <summary>
        /// Gets the Windows operating system code page that most closely corresponds to the current encoding.
        /// </summary>
        public int WindowsCodePage {
            get { return _windowsCodepage; }
        }

        /// <summary>
        /// Calculates the number of bytes produced by encoding the characters in the specified <see cref="string"/>.
        /// </summary>
        /// <returns>The number of bytes produced by encoding the specified characters.</returns>
        /// <param name="s">The <see cref="string"/> containing the set of characters to encode.</param>
        public override int GetByteCount(string s)
        {
            if(s == null)
                throw new ArgumentNullException(nameof(s));

            return s.Length;
        }

        /// <summary>
        /// Calculates the number of bytes produced by encoding a set of characters from the specified character array.
        /// </summary>
        /// <returns>The number of bytes produced by encoding the specified characters.</returns>
        /// <param name="chars">The character array containing the set of characters to encode.</param>
        /// <param name="index">The index of the first character to encode.</param>
        /// <param name="count">The number of characters to encode.</param>
        public override int GetByteCount(char[] chars, int index, int count)
        {
            if(chars == null)
                throw new ArgumentNullException(nameof(chars));

            if(index < 0 || index >= chars.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0 || index + count > chars.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            return count;
        }

        /// <summary>
        /// Calculates the number of bytes produced by encoding all the characters in the specified character array.
        /// </summary>
        /// <returns>The number of bytes produced by encoding all the characters in the specified character array.</returns>
        /// <param name="chars">The character array containing the characters to encode.</param>
        public override int GetByteCount(char[] chars)
        {
            if(chars == null)
                throw new ArgumentNullException(nameof(chars));

            return chars.Length;
        }

        /// <summary>
        /// Encodes a set of characters from the specified <see cref="string"/> into the specified byte array.
        /// </summary>
        /// <returns>The actual number of bytes written into bytes.</returns>
        /// <param name="s">The <see cref="string"/> containing the set of characters to encode.</param>
        /// <param name="charIndex">The index of the first character to encode.</param>
        /// <param name="charCount">The number of characters to encode.</param>
        /// <param name="bytes">The byte array to contain the resulting sequence of bytes.</param>
        /// <param name="byteIndex">The index at which to start writing the resulting sequence of bytes.</param>
        public override int GetBytes(string s, int charIndex, int charCount, byte[] bytes, int byteIndex)
        {
            return GetBytes(s.ToCharArray(), charIndex, charCount, bytes, byteIndex);
        }

        /// <summary>
        /// Encodes all the characters in the specified string into a sequence of bytes.
        /// </summary>
        /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
        /// <param name="s">The string containing the characters to encode.</param>
        public override byte[] GetBytes(string s)
        {
            if(s == null)
                throw new ArgumentNullException(nameof(s));

            return GetBytes(s.ToCharArray(), 0, s.Length);
        }

        /// <summary>
        /// Encodes a set of characters from the specified character array into the specified byte array.
        /// </summary>
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

        /// <summary>
        /// Encodes a set of characters from the specified character array into a sequence of bytes.
        /// </summary>
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

        /// <summary>
        /// Encodes all the characters in the specified character array into a sequence of bytes.
        /// </summary>
        /// <returns>A byte array containing the results of encoding the specified set of characters.</returns>
        /// <param name="chars">The character array containing the characters to encode.</param>
        public override byte[] GetBytes(char[] chars)
        {
            return GetBytes(chars, 0, chars.Length);
        }

        /// <summary>
        /// Calculates the number of characters produced by decoding all the bytes in the specified byte array.
        /// </summary>
        /// <returns>The number of characters produced by decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        public override int GetCharCount(byte[] bytes)
        {
            return GetCharCount(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Calculates the number of characters produced by decoding a sequence of bytes from the specified byte array.
        /// </summary>
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

        /// <summary>
        /// Decodes a sequence of bytes from the specified byte array into the specified character array.
        /// </summary>
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

        /// <summary>
        /// Decodes all the bytes in the specified byte array into a set of characters.
        /// </summary>
        /// <returns>A character array containing the results of decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        public override char[] GetChars(byte[] bytes)
        {
            return GetChars(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Decodes a sequence of bytes from the specified byte array into a set of characters.
        /// </summary>
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

        /// <summary>
        /// Calculates the maximum number of bytes produced by encoding the specified number of characters.
        /// </summary>
        /// <returns>The maximum number of bytes produced by encoding the specified number of characters.</returns>
        /// <param name="charCount">The number of characters to encode.</param>
        public override int GetMaxByteCount(int charCount)
        {
            if(charCount < 0)
                throw new ArgumentOutOfRangeException(nameof(charCount));

            return charCount;
        }

        /// <summary>
        /// Calculates the maximum number of characters produced by decoding the specified number of bytes.
        /// </summary>
        /// <returns>The maximum number of characters produced by decoding the specified number of bytes.</returns>
        /// <param name="byteCount">The number of bytes to decode.</param>
        public override int GetMaxCharCount(int byteCount)
        {
            if(byteCount < 0)
                throw new ArgumentOutOfRangeException(nameof(byteCount));

            return byteCount;
        }

        /// <summary>
        /// Returns a sequence of bytes that specifies the encoding used.
        /// </summary>
        /// <returns>A byte array of length zero, as a preamble is not required.</returns>
        public override byte[] GetPreamble()
        {
            return new byte[0];
        }

        /// <summary>
        /// Decodes all the bytes in the specified byte array into a string.
        /// </summary>
        /// <returns>A string that contains the results of decoding the specified sequence of bytes.</returns>
        /// <param name="bytes">The byte array containing the sequence of bytes to decode.</param>
        public string GetString(byte[] bytes)
        {
            return GetString(bytes, 0, bytes.Length);
        }

        /// <summary>
        /// Decodes a sequence of bytes from the specified byte array into a string.
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
        /// The ZX Spectrum to Unicode character map.
        /// </summary>
        static readonly char[] ZXSpectrumTable = {
            // 0x00
            '\u0000','\u0000','\u0000','\u0000','\u0000','\u0000','\u0009','\u0000',
            // 0x08
            '\uFFFF','\uFFFF','\u0000','\u0000','\u0000','\u000D','\uFFFF','\u0000',
            // 0x10
            '\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\u0009',
            // 0x18
            '\u0000','\u0000','\u0000','\u0000','\u0000','\u0000','\u0000','\u0000',
            // 0x20
            '\u0020','\u0021','\u0022','\u0023','\u0024','\u0025','\u0026','\u0027',
            // 0x28
            '\u0028','\u0029','\u002A','\u002B','\u002C','\u002D','\u002E','\u002F',
            // 0x30
            '\u0030','\u0031','\u0032','\u0033','\u0034','\u0035','\u0036','\u0037',
            // 0x38
            '\u0038','\u0039','\u003A','\u003B','\u003C','\u003D','\u003E','\u003F',
            // 0x40
            '\u0040','\u0041','\u0042','\u0043','\u0044','\u0045','\u0046','\u0047',
            // 0x48
            '\u0048','\u0049','\u004A','\u004B','\u004C','\u004D','\u004E','\u004F',
            // 0x50
            '\u0050','\u0051','\u0052','\u0053','\u0054','\u0055','\u0056','\u0057',
            // 0x58
            '\u0058','\u0059','\u005A','\u005B','\u005C','\u005D','\u2191','\u005F',
            // 0x60
            '\u00A3','\u0061','\u0062','\u0063','\u0064','\u0065','\u0066','\u0067',
            // 0x68
            '\u0068','\u0069','\u006A','\u006B','\u006C','\u006D','\u006E','\u006F',
            // 0x70
            '\u0070','\u0071','\u0072','\u0073','\u0074','\u0075','\u0076','\u0077',
            // 0x78
            '\u0078','\u0079','\u007A','\u007B','\u007C','\u007D','\u007E','\u00A9',
            // 0x80
            '\u0020','\u259D','\u2598','\u2580','\u2597','\u2590','\u259A','\u259C',
            // 0x88
            '\u2596','\u259E','\u258C','\u259B','\u2584','\u259F','\u2599','\u2588',
            // 0x90
            '\uFFFD','\uFFFD','\uFFFD','\uFFFD','\uFFFD','\uFFFD','\uFFFD','\uFFFD',
            // 0x98
            '\uFFFD','\uFFFD','\uFFFD','\uFFFD','\uFFFD','\uFFFD','\uFFFD','\uFFFD',
            // 0xA0
            '\uFFFD','\uFFFD','\uFFFD','\uFFFD','\uFFFD','\uFFFF','\uFFFF','\uFFFF',
            // 0xA8
            '\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF',
            // 0xB0
            '\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF',
            // 0xB8
            '\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF',
            // 0xC0
            '\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF',
            // 0xC8
            '\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF',
            // 0xD0
            '\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF',
            // 0xD8
            '\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF',
            // 0xE0
            '\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF',
            // 0xE8
            '\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF',
            // 0xF0
            '\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF',
            // 0xF8
            '\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF','\uFFFF'
        };

        /// <summary>
        /// Converts a ZX Spectrum character to an Unicode character
        /// </summary>
        /// <returns>Unicode character.</returns>
        /// <param name="character">ZX Spectrum character.</param>
        static char GetChar(byte character)
        {
            return ZXSpectrumTable[character];
        }

        /// <summary>
        /// Converts a Unicode character to an ZX Spectrum character
        /// </summary>
        /// <returns>ZX Spectrum character.</returns>
        /// <param name="character">Unicode character.</param>
        static byte GetByte(char character)
        {
            switch(character) {
                case '\u0009':
                    return 0x06;
                case '\u000D':
                    return 0x0D;
                case '\u0020':
                    return 0x20;
                case '\u0021':
                    return 0x21;
                case '\u0022':
                    return 0x22;
                case '\u0023':
                    return 0x23;
                case '\u0024':
                    return 0x24;
                case '\u0025':
                    return 0x25;
                case '\u0026':
                    return 0x26;
                case '\u0027':
                    return 0x27;
                case '\u0028':
                    return 0x28;
                case '\u0029':
                    return 0x29;
                case '\u002A':
                    return 0x2A;
                case '\u002B':
                    return 0x2B;
                case '\u002C':
                    return 0x2C;
                case '\u002D':
                    return 0x2D;
                case '\u002E':
                    return 0x2E;
                case '\u002F':
                    return 0x2F;
                case '\u0030':
                    return 0x30;
                case '\u0031':
                    return 0x31;
                case '\u0032':
                    return 0x32;
                case '\u0033':
                    return 0x33;
                case '\u0034':
                    return 0x34;
                case '\u0035':
                    return 0x35;
                case '\u0036':
                    return 0x36;
                case '\u0037':
                    return 0x37;
                case '\u0038':
                    return 0x38;
                case '\u0039':
                    return 0x39;
                case '\u003A':
                    return 0x3A;
                case '\u003B':
                    return 0x3B;
                case '\u003C':
                    return 0x3C;
                case '\u003D':
                    return 0x3D;
                case '\u003E':
                    return 0x3E;
                case '\u003F':
                    return 0x3F;
                case '\u0040':
                    return 0x40;
                case '\u0041':
                    return 0x41;
                case '\u0042':
                    return 0x42;
                case '\u0043':
                    return 0x43;
                case '\u0044':
                    return 0x44;
                case '\u0045':
                    return 0x45;
                case '\u0046':
                    return 0x46;
                case '\u0047':
                    return 0x47;
                case '\u0048':
                    return 0x48;
                case '\u0049':
                    return 0x49;
                case '\u004A':
                    return 0x4A;
                case '\u004B':
                    return 0x4B;
                case '\u004C':
                    return 0x4C;
                case '\u004D':
                    return 0x4D;
                case '\u004E':
                    return 0x4E;
                case '\u004F':
                    return 0x4F;
                case '\u0050':
                    return 0x50;
                case '\u0051':
                    return 0x51;
                case '\u0052':
                    return 0x52;
                case '\u0053':
                    return 0x53;
                case '\u0054':
                    return 0x54;
                case '\u0055':
                    return 0x55;
                case '\u0056':
                    return 0x56;
                case '\u0057':
                    return 0x57;
                case '\u0058':
                    return 0x58;
                case '\u0059':
                    return 0x59;
                case '\u005A':
                    return 0x5A;
                case '\u005B':
                    return 0x5B;
                case '\u005C':
                    return 0x5C;
                case '\u005D':
                    return 0x5D;
                case '\u2191':
                    return 0x5E;
                case '\u005F':
                    return 0x5F;
                case '\u00A3':
                    return 0x60;
                case '\u0061':
                    return 0x61;
                case '\u0062':
                    return 0x62;
                case '\u0063':
                    return 0x63;
                case '\u0064':
                    return 0x64;
                case '\u0065':
                    return 0x65;
                case '\u0066':
                    return 0x66;
                case '\u0067':
                    return 0x67;
                case '\u0068':
                    return 0x68;
                case '\u0069':
                    return 0x69;
                case '\u006A':
                    return 0x6A;
                case '\u006B':
                    return 0x6B;
                case '\u006C':
                    return 0x6C;
                case '\u006D':
                    return 0x6D;
                case '\u006E':
                    return 0x6E;
                case '\u006F':
                    return 0x6F;
                case '\u0070':
                    return 0x70;
                case '\u0071':
                    return 0x71;
                case '\u0072':
                    return 0x72;
                case '\u0073':
                    return 0x73;
                case '\u0074':
                    return 0x74;
                case '\u0075':
                    return 0x75;
                case '\u0076':
                    return 0x76;
                case '\u0077':
                    return 0x77;
                case '\u0078':
                    return 0x78;
                case '\u0079':
                    return 0x79;
                case '\u007A':
                    return 0x7A;
                case '\u007B':
                    return 0x7B;
                case '\u007C':
                    return 0x7C;
                case '\u007D':
                    return 0x7D;
                case '\u007E':
                    return 0x7E;
                case '\u00A9':
                    return 0x7F;
                case '\u259D':
                    return 0x81;
                case '\u2598':
                    return 0x82;
                case '\u2580':
                    return 0x83;
                case '\u2597':
                    return 0x84;
                case '\u2590':
                    return 0x85;
                case '\u259A':
                    return 0x86;
                case '\u259C':
                    return 0x87;
                case '\u2596':
                    return 0x88;
                case '\u259E':
                    return 0x89;
                case '\u258C':
                    return 0x8A;
                case '\u259B':
                    return 0x8B;
                case '\u2584':
                    return 0x8C;
                case '\u259F':
                    return 0x8D;
                case '\u2599':
                    return 0x8E;
                case '\u2588':
                    return 0x8F;
                default:
                    // Fallback to '?'
                    return 0x3F;
            }
        }
    }
}