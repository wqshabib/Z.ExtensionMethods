// Copyright (c) 2015 ZZZ Projects. All rights reserved
// Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
// Website: http://www.zzzprojects.com/
// Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
// All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Type_GetSignature_InheritedClassAndInterface
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            Type @this = typeof(InheritedClassAndInterface);

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("InheritedClassAndInterface", result);
        }
    }
}