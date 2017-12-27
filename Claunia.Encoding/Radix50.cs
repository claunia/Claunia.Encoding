﻿//
// Apple II.cs
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
    ///     Represents an Radix-50 (PDP-11) character encoding of Unicode characters.
    /// </summary>
    public class Radix50 : Encoding
    {
        const string _bodyname = "radix50";
        const int _codepage = 0;
        const string _encodingname = "Western European (Radix-50)";
        const string _headername = "radix50";
        const string _webname = "";
        const int _windowsCodepage = 0;

        const bool browserDisplay = false;
        const bool browserSave = false;
        const bool mailNewsDisplay = false;
        const bool mailNewsSave = false;
        const bool readOnly = false;
        const bool singleByte = false;

        /// <summary>
        ///     The Radix-50 to Unicode character map, when bits are shifted right
        /// </summary>
        static readonly char[] Radix50Table =
        {
            // 0x00
            '\u0020', '\u0041', '\u0042', '\u0043', '\u0044', '\u0045', '\u0046', '\u0047',
            // 0x08
            '\u0048', '\u0049', '\u004A', '\u004B', '\u004C', '\u004D', '\u004E', '\u004F',
            // 0x10
            '\u0050', '\u0051', '\u0052', '\u0053', '\u0054', '\u0055', '\u0056', '\u0057',
            // 0x18
            '\u0058', '\u0059', '\u005A', '\u0024', '\u002E', '\u0025', '\u0030', '\u0031',
            // 0x20
            '\u0032', '\u0033', '\u0034', '\u0035', '\u0036', '\u0037', '\u0038', '\u0039',
            // 0x28 (unused but legal)
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',
            // 0x30 (unused but legal)
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000',
            // 0x38 (unused but legal)
            '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000', '\u0000'
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

            return s.Length * 6 % 8 > 0 ? s.Length * 6 / 8 + 1 : s.Length * 6 / 8;
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

            return count * 6 % 8 > 0 ? count * 6 / 8 + 1 : count * 6 / 8;
        }

        /// <summary>
        ///     Calculates the number of bytes produced by encoding all the characters in the specified character array.
        /// </summary>
        /// <returns>The number of bytes produced by encoding all the characters in the specified character array.</returns>
        /// <param name="chars">The character array containing the characters to encode.</param>
        public override int GetByteCount(char[] chars)
        {
            if(chars == null) throw new ArgumentNullException(nameof(chars));

            return chars.Length * 6 % 8 > 0 ? chars.Length * 6 / 8 + 1 : chars.Length * 6 / 8;
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

            byte[] bytes = new byte[count * 6 % 8 > 0 ? count * 6 / 8 + 1 : count * 6 / 8];
            int outPos = 0;

            for(int i = 0; i < count; i++)
            {
                byte thisByte = GetByte(chars[index + i]);

                switch(i % 4)
                {
                    case 0:
                        if(outPos >= bytes.Length) break;

                        bytes[outPos] = (byte)(thisByte << 2);
                        break;
                    case 1:
                        if(outPos + 1 >= bytes.Length) break;

                        bytes[outPos] += (byte)((thisByte & 0x30) >> 4);
                        bytes[outPos + 1] = (byte)((thisByte & 0xF) << 4);
                        break;
                    case 2:
                        if(outPos + 2 >= bytes.Length) break;

                        bytes[outPos + 1] += (byte)((thisByte & 0x3C) >> 2);
                        bytes[outPos + 2] = (byte)((thisByte & 0x3) << 6);
                        break;
                    case 3:
                        if(outPos + 2 >= bytes.Length) break;

                        bytes[outPos + 2] += (byte)(thisByte & 0x3F);
                        outPos += 3;
                        break;
                }
            }

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

            return count * 8 / 6;
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

            char[] chars = new char[count * 8 / 6];

            // aaaaaabb bbbbcccc ccdddddd

            int outPos = 0;
            for(int i = 0; i < count; i++)
            {
                byte rd50;
                switch(i % 3)
                {
                    case 0:
                        rd50 = (byte)((bytes[index + i] & 0xFC) >> 2);
                        chars[outPos] = GetChar(rd50);
                        outPos++;
                        break;
                    case 1:
                        rd50 = (byte)(((bytes[index + i - 1] & 0x03) << 4) + ((bytes[index + i] & 0xF0) >> 4));
                        chars[outPos] = GetChar(rd50);
                        outPos++;
                        break;
                    case 2:
                        rd50 = (byte)(((bytes[index + i - 1] & 0x0F) << 2) + ((bytes[index + i] & 0xC0) >> 6));
                        chars[outPos] = GetChar(rd50);
                        chars[outPos + 1] = GetChar((byte)(bytes[index + i] & 0x3F));
                        outPos += 2;
                        break;
                }
            }

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

            return charCount * 6 % 8 > 0 ? charCount * 6 / 8 + 1 : charCount * 6 / 8;
        }

        /// <summary>
        ///     Calculates the maximum number of characters produced by decoding the specified number of bytes.
        /// </summary>
        /// <returns>The maximum number of characters produced by decoding the specified number of bytes.</returns>
        /// <param name="byteCount">The number of bytes to decode.</param>
        public override int GetMaxCharCount(int byteCount)
        {
            if(byteCount < 0) throw new ArgumentOutOfRangeException(nameof(byteCount));

            return byteCount * 8 / 6;
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
        public string GetString(byte[] bytes)
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
        ///     Converts a Apple II character to an Unicode character
        /// </summary>
        /// <returns>Unicode character.</returns>
        /// <param name="character">Apple II character.</param>
        static char GetChar(byte character)
        {
            return Radix50Table[character & 0x3F];
        }

        /// <summary>
        ///     Converts a Unicode character to an Apple II character
        /// </summary>
        /// <returns>Apple II character.</returns>
        /// <param name="character">Unicode character.</param>
        static byte GetByte(char character)
        {
            switch(character)
            {
                case '\u0020': return 0x00;
                case '\u0041': return 0x01;
                case '\u0042': return 0x02;
                case '\u0043': return 0x03;
                case '\u0044': return 0x04;
                case '\u0045': return 0x05;
                case '\u0046': return 0x06;
                case '\u0047': return 0x07;
                case '\u0048': return 0x08;
                case '\u0049': return 0x09;
                case '\u004A': return 0x0A;
                case '\u004B': return 0x0B;
                case '\u004C': return 0x0C;
                case '\u004D': return 0x0D;
                case '\u004E': return 0x0E;
                case '\u004F': return 0x0F;
                case '\u0050': return 0x10;
                case '\u0051': return 0x11;
                case '\u0052': return 0x12;
                case '\u0053': return 0x13;
                case '\u0054': return 0x14;
                case '\u0055': return 0x15;
                case '\u0056': return 0x16;
                case '\u0057': return 0x17;
                case '\u0058': return 0x18;
                case '\u0059': return 0x19;
                case '\u005A': return 0x1A;
                case '\u0024': return 0x1B;
                case '\u002E': return 0x1C;
                case '\u0025': return 0x1D;
                case '\u0030': return 0x1E;
                case '\u0031': return 0x1F;
                case '\u0032': return 0x20;
                case '\u0033': return 0x21;
                case '\u0034': return 0x22;
                case '\u0035': return 0x23;
                case '\u0036': return 0x24;
                case '\u0037': return 0x25;
                case '\u0038': return 0x26;
                case '\u0039': return 0x27;
                default:
                    // Fallback to '.'
                    return 0x1C;
            }
        }
    }
}