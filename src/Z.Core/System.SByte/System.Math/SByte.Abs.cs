// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using System;

public static partial class Extensions
{
    /// <summary>
    ///     Returns the absolute value of an 8-bit signed integer.
    /// </summary>
    /// <param name="value">A number that is greater than , but less than or equal to .</param>
    /// <returns>An 8-bit signed integer, x, such that 0 ? x ?.</returns>
    public static SByte Abs(this SByte value)
    {
        return Math.Abs(value);
    }
}