// Description: C# Extension Methods Library to enhances the .NET Framework by adding hundreds of new methods. It drastically increases developers productivity and code readability. Support C# and VB.NET
// Website & Documentation: https://github.com/zzzprojects/Z.ExtensionMethods
// Forum: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License: https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: http://www.zzzprojects.com/
// Copyright � ZZZ Projects Inc. 2014 - 2016. All rights reserved.
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class System_Object_SetFieldValue
    {
        [TestMethod]
        public void SetFieldValue()
        {
            // Type
            var @this = new TestClass();

            // Exemples
            @this.SetFieldValue("PublicField", 1);
            @this.SetFieldValue("InternaStaticlField", 2);

            // Unit Test
            Assert.AreEqual(1, @this.PublicField);
            Assert.AreEqual(2, TestClass.InternaStaticlField);
        }

        public class TestClass
        {
            internal static int InternaStaticlField = 2;
            public int PublicField = 1;
        }
    }
}