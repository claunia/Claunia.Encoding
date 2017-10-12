﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Claunia.Encoding
{
    /// <summary>
    /// Provides basic information about an encoding.
    /// </summary>
    public sealed class EncodingInfo
    {
        private int iCodePage;          // Code Page #
        private string strEncodingName;    // Short name (web name)
        private string strDisplayName;     // Full localized name
        private bool isSystem;
        private Type thisType;

        internal EncodingInfo(int codePage, string name, string displayName, bool system = true, Type internalType = null)
        {
            iCodePage = codePage;
            strEncodingName = name;
            strDisplayName = displayName;
            isSystem = system;
            thisType = internalType;
        }

        /// <summary>
        /// Gets the code page identifier of the encoding.
        /// </summary>
        /// <value>The code page identifier of the encoding.</value>
        public int CodePage {
            get {
                return iCodePage;
            }
        }

        /// <summary>
        /// Gets the name registered with the Internet Assigned Numbers Authority (IANA) for the encoding.
        /// </summary>
        /// <value>The IANA name for the encoding. For more information about the IANA, see www.iana.org.</value>
        public string Name {
            get {
                return strEncodingName;
            }
        }

        /// <summary>
        /// Gets the human-readable description of the encoding.
        /// </summary>
        /// <value>The human-readable description of the encoding.</value>
        public string DisplayName {
            get {
                return strDisplayName;
            }
        }

        /// <summary>
        /// Returns a Encoding object that corresponds to the current EncodingInfo object.
        /// </summary>
        /// <returns>A <see cref="T:Claunia.Encoding.Encoding"/> object that corresponds to the current <see cref="T:Claunia.Encoding.EncodingInfo"/> object.</returns>
        public Encoding GetEncoding()
        {
            return (Encoding)thisType.GetConstructor(new Type[] { }).Invoke(new object[] { });
        }

        /// <summary>
        /// Gets a value indicating whether the specified object is equal to the current EncodingInfo object.
        /// </summary>
        /// <param name="value">An object to compare to the current <see cref="T:Claunia.Encoding.EncodingInfo"/> object.</param>
        /// <returns><c>true</c> if value is a <see cref="T:Claunia.Encoding.EncodingInfo"/> and is equal to the current <see cref="T:Claunia.Encoding.EncodingInfo"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(Object value)
        {
            EncodingInfo that = value as EncodingInfo;
            if(that != null) {
                return (this.CodePage == that.CodePage);
            }
            return (false);
        }

        /// <summary>
        /// Returns the hash code for the current EncodingInfo object.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            return this.CodePage;
        }
    }
}