//
// PETSCII.cs
//
// Author:
//       Michael Drüing <darkstar@drueing.de>
//
// Copyright (c) 2016 © Michael Drüing
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
    ///     Represents an Commodore PET Standard Code for Information Interchange (aka CBM ASCII) character encoding of Unicode
    ///     characters.
    /// </summary>
    public class PETSCII : Encoding
    {
        const string _bodyname = "petscii";
        const int _codepage = 0;
        const string _encodingname = "Commodore PET Standard Code for Information Interchange";
        const string _headername = "petscii";
        const string _webname = "";
        const int _windowsCodepage = 0;

        const bool browserDisplay = false;
        const bool browserSave = false;
        const bool mailNewsDisplay = false;
        const bool mailNewsSave = false;
        const bool readOnly = false;
        const bool singleByte = true;

        /// <summary>
        ///     The PETSCII to Unicode character map, unshifted (default) variant.
        /// </summary>
        /// <remarks>Reference used: http://style64.org/petscii/ and others.</remarks>
        static readonly char[] PETSCIITable =
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
        ///     Converts a PETSCII character to an Unicode character
        /// </summary>
        /// <returns>Unicode character.</returns>
        /// <param name="character">PETSCII character.</param>
        static char GetChar(byte character)
        {
            return PETSCIITable[character];
        }

        /// <summary>
        ///     Converts a Unicode character to an PETSCII character
        /// </summary>
        /// <returns>PETSCII character.</returns>
        /// <param name="character">Unicode character.</param>
        static byte GetByte(char character)
        {
            if(character == 0x0000) return 0x3F;

            for(int i = 0; i < 256; i++)
                // TODO: convert this to a gigantic switch statement too?
                if(PETSCIITable[i] == character) return (byte)i;

            // Fallback to '?'
            return 0x3F;
        }
    }
}