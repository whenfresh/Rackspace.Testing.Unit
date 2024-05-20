namespace WhenFresh.Rackspace.Tests
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Xml.Serialization;
    using WhenFresh.Rackspace.Properties;

    public sealed class XmlTextTest : MemberTestBase
    {
        public XmlTextTest(MemberInfo info)
            : base(info)
        {
        }

        public override bool Check()
        {
            if (null == Attribute.GetCustomAttribute(Member, typeof(XmlTextAttribute), false) as XmlTextAttribute)
            {
                throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.XmlTextDecorationTestException_Message, Member.Name));
            }

            return true;
        }
    }
}