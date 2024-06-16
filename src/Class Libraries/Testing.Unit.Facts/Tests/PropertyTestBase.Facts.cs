﻿namespace WhenFresh.Utilities.Testing.Unit.Facts.Tests
{
    using System;
    using WhenFresh.Utilities.Testing.Unit.Facts.Types;
    using Xunit;

    public sealed class PropertyTestBaseFacts
    {
        [Fact]
        public void ctor_PropertyInfo_object()
        {
            Assert.NotNull(new DerivedPropertyTest(typeof(PropertiedClass1).GetProperty("AutoBoolean")));
        }

        [Fact]
        public void op_Check()
        {
            Assert.Throws<NotImplementedException>(() => new DerivedPropertyTest(typeof(PropertiedClass1).GetProperty("AutoBoolean")).Check());
        }

        [Fact]
        public void prop_Property()
        {
            var expected = typeof(PropertiedClass1).GetProperty("AutoBoolean");

            var obj = new DerivedPropertyTest(null)
                          {
                              Property = expected
                          };

            var actual = obj.Property;

            Assert.Same(expected, actual);
        }
    }
}