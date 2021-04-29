//
// Encoding.cs
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
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Claunia.Encoding
{
    /// <summary>This class contains static instances of the supported encodings.</summary>
    public abstract class Encoding : System.Text.Encoding
    {
        /// <summary>Static instance for the LisaRoman encoding</summary>
        public static System.Text.Encoding LisaEncoding = new LisaRoman();
        /// <summary>Static instance for the ATASCII encoding</summary>
        public static System.Text.Encoding AtariEncoding = new Atascii();
        /// <summary>Static instance for the Atari ST encoding</summary>
        public static System.Text.Encoding AtariStEncoding = new AtariSt();
        /// <summary>Static instance for the PETSCII encoding</summary>
        public static System.Text.Encoding PetEncoding = new Petscii();
        /// <summary>Static instance for the DEC Radix-50 encoding</summary>
        public static System.Text.Encoding Radix50Encoding = new Radix50();
        /// <summary>Static instance for the GEM encoding</summary>
        public static System.Text.Encoding GemEncoding = new Gem();
        /// <summary>Static instance for the GEM encoding</summary>
        public static System.Text.Encoding GeosEncoding = new Geos();

        /// <summary>Gets a value indicating whether the current encoding can be used by browser clients for displaying content.</summary>
        public abstract override bool IsBrowserDisplay { get; }

        /// <summary>Gets a value indicating whether the current encoding can be used by browser clients for saving content.</summary>
        public abstract override bool IsBrowserSave { get; }

        /// <summary>
        ///     Gets a value indicating whether the current encoding can be used by mail and news clients for displaying
        ///     content.
        /// </summary>
        public abstract override bool IsMailNewsDisplay { get; }

        /// <summary>Gets a value indicating whether the current encoding can be used by mail and news clients for saving content.</summary>
        public abstract override bool IsMailNewsSave { get; }

        /// <summary>Gets a value indicating whether the current encoding is read-only.</summary>
        /// <value>The is single byte.</value>
        public new abstract bool IsReadOnly { get; }

        /// <summary>Gets a value indicating whether the current encoding uses single-byte code points.</summary>
        public abstract override bool IsSingleByte { get; }

        /// <summary>Gets the code page identifier of the current Encoding.</summary>
        public abstract override int CodePage { get; }

        /// <summary>Gets a name for the current encoding that can be used with mail agent body tags</summary>
        public abstract override string BodyName { get; }

        /// <summary>Gets a name for the current encoding that can be used with mail agent header tags</summary>
        public abstract override string HeaderName { get; }

        /// <summary>Gets the name registered with the Internet Assigned Numbers Authority (IANA) for the current encoding.</summary>
        public abstract override string WebName { get; }

        /// <summary>Gets the human-readable description of the current encoding.</summary>
        public abstract override string EncodingName { get; }

        /// <summary>Gets the Windows operating system code page that most closely corresponds to the current encoding.</summary>
        public abstract override int WindowsCodePage { get; }

        /// <summary>Returns an array that contains all encodings.</summary>
        /// <returns>An array that contains all encodings.</returns>
        public new static IEnumerable<EncodingInfo> GetEncodings() =>
            from type in Assembly.GetExecutingAssembly().GetTypes()
            where type.IsSubclassOf(typeof(Encoding)) && !type.IsAbstract let encoding = (Encoding)type.
                GetConstructor(new Type[]
                                   {})?.Invoke(new object[]
                                                   {}) where encoding is {}
            select new EncodingInfo(encoding.CodePage, encoding.BodyName, encoding.EncodingName, false, type);

        /// <summary>Returns the encoding associated with the specified code page name.</summary>
        /// <returns>The encoding associated with the specified code page.</returns>
        /// <param name="name">
        ///     The code page name of the preferred encoding. Any value returned by the WebName property is valid.
        ///     Possible values are listed in the Name column of the table that appears in the Encoding class topic.
        /// </param>
        public new static System.Text.Encoding GetEncoding(string name)
        {
            foreach(Type type in Assembly.GetExecutingAssembly().GetTypes())
                if(type.IsSubclassOf(typeof(Encoding)) &&
                   !type.IsAbstract)
                {
                    var encoding = (Encoding)type.GetConstructor(new Type[]
                                                                     {})?.Invoke(new object[]
                        {});

                    if(encoding?.BodyName == name.ToLowerInvariant())
                        return encoding;
                }

            return System.Text.Encoding.GetEncoding(name);
        }
    }
}