// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Claunia.Encoding;

/// <summary>Provides basic information about an encoding.</summary>
public sealed class EncodingInfo
{
    readonly Type _thisType;
    bool          _isSystem;

    internal EncodingInfo(int codePage, string name, string displayName, bool system = true,
                          Type internalType = null)
    {
        CodePage    = codePage;
        Name        = name;
        DisplayName = displayName;
        _isSystem   = system;
        _thisType   = internalType;
    }

    /// <summary>Gets the code page identifier of the encoding.</summary>
    /// <value>The code page identifier of the encoding.</value>
    public int CodePage { get; }

    /// <summary>Gets the name registered with the Internet Assigned Numbers Authority (IANA) for the encoding.</summary>
    /// <value>The IANA name for the encoding. For more information about the IANA, see www.iana.org.</value>
    public string Name { get; }

    /// <summary>Gets the human-readable description of the encoding.</summary>
    /// <value>The human-readable description of the encoding.</value>
    public string DisplayName { get; }

    /// <summary>Returns a Encoding object that corresponds to the current EncodingInfo object.</summary>
    /// <returns>
    ///     A <see cref="T:Claunia.Encoding.Encoding" /> object that corresponds to the current
    ///     <see cref="T:Claunia.Encoding.EncodingInfo" /> object.
    /// </returns>
    public Encoding GetEncoding() => (Encoding)_thisType.GetConstructor(new Type[]
                                                                            {}).Invoke(new object[]
        {});

    /// <summary>Gets a value indicating whether the specified object is equal to the current EncodingInfo object.</summary>
    /// <param name="value">An object to compare to the current <see cref="T:Claunia.Encoding.EncodingInfo" /> object.</param>
    /// <returns>
    ///     <c>true</c> if value is a <see cref="T:Claunia.Encoding.EncodingInfo" /> and is equal to the current
    ///     <see cref="T:Claunia.Encoding.EncodingInfo" />; otherwise, <c>false</c>.
    /// </returns>
    public override bool Equals(object value) => value is EncodingInfo that && CodePage == that.CodePage;

    /// <summary>Returns the hash code for the current EncodingInfo object.</summary>
    /// <returns>A 32-bit signed integer hash code.</returns>
    public override int GetHashCode() => CodePage;
}