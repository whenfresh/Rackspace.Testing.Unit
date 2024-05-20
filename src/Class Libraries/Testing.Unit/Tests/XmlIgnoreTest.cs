namespace WhenFresh.Rackspace.Tests
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Xml.Serialization;
    using WhenFresh.Rackspace.Properties;

    public sealed class XmlIgnoreTest : MemberTestBase
    {
        public XmlIgnoreTest(MemberInfo info)
            : base(info)
        {
        }

        public override bool Check()
        {
            if (null == Attribute.GetCustomAttribute(Member, typeof(XmlIgnoreAttribute), false) as XmlIgnoreAttribute)
            {
                throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.XmlIgnoreDecorationTestException_Message, Member.Name));
            }

            return true;
        }
    }
}