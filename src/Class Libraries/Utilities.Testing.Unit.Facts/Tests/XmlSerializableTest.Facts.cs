﻿namespace WhenFresh.Utilities.Testing.Unit.Facts.Tests
{
    using WhenFresh.Utilities.Testing.Unit;
    using WhenFresh.Utilities.Testing.Unit.Facts.Types;
    using WhenFresh.Utilities.Testing.Unit.Fluent;
    using WhenFresh.Utilities.Testing.Unit.Tests;
    using Xunit;

    public sealed class XmlSerializableTestOfTFacts
    {
        [Fact]
        public void a_definition()
        {
            Assert.True(new TypeExpectations<XmlSerializableTest>()
                            .DerivesFrom<object>()
                            .IsConcreteClass()
                            .IsSealed()
                            .NoDefaultConstructor()
                            .IsNotDecorated()
                            .Implements<ITestExpectation>()
                            .Result);
        }

        [Fact]
        public void ctor_Type_bool()
        {
            Assert.NotNull(new XmlSerializableTest(typeof(Class1), false));
        }

        [Fact]
        public void op_Check()
        {
            Assert.True(new XmlSerializableTest(typeof(XmlSerializationClass4), true).Check());
        }

        [Fact]
        public void op_Check_whenFalseVerification()
        {
            Assert.True(new XmlSerializableTest(typeof(XmlSerializationClass4), false).Check());
        }

        [Fact]
        public void op_Check_whenGetSchemaDoesNotThrowException()
        {
            Assert.Throws<UnitTestException>(() => new XmlSerializableTest(typeof(XmlSerializationClass1), true).Check());
        }

        [Fact]
        public void op_Check_whenInterfaceNotImplemented()
        {
            Assert.Throws<UnitTestException>(() => new XmlSerializableTest(typeof(Class1), true).Check());
        }

        [Fact]
        public void op_Check_whenReadXmlDoesNotThrowException()
        {
            Assert.Throws<UnitTestException>(() => new XmlSerializableTest(typeof(XmlSerializationClass2), true).Check());
        }

        [Fact]
        public void op_Check_whenWriteXmlDoesNotThrowException()
        {
            Assert.Throws<UnitTestException>(() => new XmlSerializableTest(typeof(XmlSerializationClass3), true).Check());
        }

        [Fact]
        public void op_Check_whenXmlRoot()
        {
            Assert.True(new XmlSerializableTest(typeof(XmlSerializationClass5), true).Check());
        }
    }
}