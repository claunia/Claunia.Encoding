//
// GetEncs.cs
//
// Author:
//       Natalia Portillo <claunia@claunia.com>
//
// Copyright (c) 2017 Copyright © Claunia.com
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
using NUnit.Framework;

namespace Claunia.Encoding.Tests
{
	[TestFixture]
	public class GetEncs
    {
		[Test]
		// Well basically this is taken from MSDN's documentation :p
		public void GetAllEncs()
        {
			// Print the header.
			Console.Write("CodePage identifier and name     ");
			Console.Write("BrDisp   BrSave   ");
			Console.Write("MNDisp   MNSave   ");
			Console.WriteLine("1-Byte   ReadOnly ");

			// For every encoding, get the property values.
			foreach(EncodingInfo ei in Encoding.GetEncodings())
            {
				Encoding e = ei.GetEncoding();

				Console.Write("{0,-6} {1,-25} ", ei.CodePage, ei.Name);
				Console.Write("{0,-8} {1,-8} ", e.IsBrowserDisplay, e.IsBrowserSave);
				Console.Write("{0,-8} {1,-8} ", e.IsMailNewsDisplay, e.IsMailNewsSave);
				Console.WriteLine("{0,-8} {1,-8} ", e.IsSingleByte, e.IsReadOnly);
            }
        }
    }
}
