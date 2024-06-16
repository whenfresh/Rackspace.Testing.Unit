﻿namespace WhenFresh.Utilities.Testing.Unit.Facts.Tests
{
    using System;
    using WhenFresh.Utilities.Testing.Unit;
    using WhenFresh.Utilities.Testing.Unit.Facts.Types;
    using WhenFresh.Utilities.Testing.Unit.Tests;
    using Xunit;

    public sealed class AttributeMemberTestFacts
    {
        [Fact]
        public void ctor_MemberInfoNull_Type()
        {
            Assert.Throws<ArgumentNullException>(() => new AttributeMemberTest(null, typeof(Attribute1Attribute)));
        }

        [Fact]
        public void ctor_MemberInfo_Type()
        {
            Assert.NotNull(new AttributeMemberTest(typeof(object), typeof(Attribute1Attribute)));
        }

        [Fact]
        public void ctor_MemberInfo_TypeNull()
        {
            Assert.NotNull(new AttributeMemberTest(typeof(object), null));
        }

        [Fact]
        public void is_AttributePropertyTest()
        {
            Assert.IsAssignableFrom<MemberTestBase>(new AttributeMemberTest(typeof(object), typeof(Attribute1Attribute)));
        }

        [Fact]
        public void op_Check_whenFalse()
        {
            Assert.Throws<UnitTestException>(() => new AttributeMemberTest(typeof(object), typeof(Attribute1Attribute)).Check());
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            Assert.True(new AttributeMemberTest(typeof(AttributedClass1), typeof(Attribute1Attribute)).Check());
        }

        [Fact]
        public void op_Check_whenUnexpectedAttribute()
        {
            Assert.Throws<UnitTestException>(() => new AttributeMemberTest(typeof(AttributedClass1), null).Check());
        }

        [Fact]
        public void prop_Attribute()
        {
            var expected = typeof(Attribute1Attribute);

            var obj = new AttributeMemberTest(typeof(object), null)
                          {
                              Attribute = expected
                          };

            var actual = obj.Attribute;

            Assert.Same(expected, actual);
        }
    }
}