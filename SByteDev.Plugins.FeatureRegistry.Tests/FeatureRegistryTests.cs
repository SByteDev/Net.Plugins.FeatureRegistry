using System;
using NUnit.Framework;

namespace SByteDev.Plugins.FeatureRegistry.Tests
{
    [TestFixture]
    public class FeatureRegistryTests
    {
        private enum TestEnum
        {
            Test
        }

        private class TestClass
        {
        }

        [TestFixture]
        public class WhenGetCalled
        {
            [TestFixture]
            public class AndFeatureIsNull
            {
                [Test]
                public void ArgumentNullExceptionExceptionShouldBeThrownForEnum()
                {
                    var sut = new FeatureRegistry();

                    Assert.Throws<ArgumentNullException>(() =>
                    {
                        var _ = sut[default(Enum)];
                    });
                }

                [Test]
                public void ArgumentNullExceptionExceptionShouldBeThrownForType()
                {
                    var sut = new FeatureRegistry();

                    Assert.Throws<ArgumentNullException>(() =>
                    {
                        var _ = sut[default(Type)];
                    });
                }

                [Test]
                public void ArgumentNullExceptionExceptionShouldBeThrownForString()
                {
                    var sut = new FeatureRegistry();

                    Assert.Throws<ArgumentNullException>(() =>
                    {
                        var _ = sut[default(string)];
                    });
                }
            }

            [TestFixture]
            public class AndFeatureIsNotSet
            {
                [Test]
                public void FalseShouldBeReturnedForEnum()
                {
                    var sut = new FeatureRegistry();

                    Assert.IsFalse(sut[TestEnum.Test]);
                }

                [Test]
                public void FalseShouldBeReturnedForType()
                {
                    var sut = new FeatureRegistry();

                    Assert.IsFalse(sut[typeof(TestClass)]);
                }

                [Test]
                public void FalseShouldBeReturnedForString()
                {
                    var sut = new FeatureRegistry();

                    Assert.IsFalse(sut["First"]);
                }
            }

            [TestFixture]
            public class AndFeatureIsDisabled
            {
                [Test]
                public void FalseShouldBeReturnedForEnum()
                {
                    var sut = new FeatureRegistry {[TestEnum.Test] = false};

                    Assert.IsFalse(sut[TestEnum.Test]);
                }

                [Test]
                public void FalseShouldBeReturnedForType()
                {
                    var sut = new FeatureRegistry {[typeof(TestClass)] = false};

                    Assert.IsFalse(sut[typeof(TestClass)]);
                }

                [Test]
                public void FalseShouldBeReturnedForString()
                {
                    var sut = new FeatureRegistry {["First"] = false};

                    Assert.IsFalse(sut["First"]);
                }
            }

            [TestFixture]
            public class AndFeatureIsEnabled
            {
                [Test]
                public void FalseShouldBeReturnedForEnum()
                {
                    var sut = new FeatureRegistry {[TestEnum.Test] = true};

                    Assert.IsTrue(sut[TestEnum.Test]);
                }

                [Test]
                public void FalseShouldBeReturnedForType()
                {
                    var sut = new FeatureRegistry {[typeof(TestClass)] = true};

                    Assert.IsTrue(sut[typeof(TestClass)]);
                }

                [Test]
                public void FalseShouldBeReturnedForString()
                {
                    var sut = new FeatureRegistry {["First"] = true};

                    Assert.IsTrue(sut["First"]);
                }
            }
        }

        [TestFixture]
        public class WhenSetCalled
        {
            [TestFixture]
            public class AndFeatureIsNull
            {
                [Test]
                public void ArgumentNullExceptionExceptionShouldBeThrownForEnum()
                {
                    var sut = new FeatureRegistry();

                    Assert.Throws<ArgumentNullException>(() => { sut[default(Enum)] = false; });
                }

                [Test]
                public void ArgumentNullExceptionExceptionShouldBeThrownForType()
                {
                    var sut = new FeatureRegistry();

                    Assert.Throws<ArgumentNullException>(() => { sut[default(Type)] = false; });
                }

                [Test]
                public void ArgumentNullExceptionExceptionShouldBeThrownForString()
                {
                    var sut = new FeatureRegistry();

                    Assert.Throws<ArgumentNullException>(() => { sut[default(string)] = false; });
                }
            }

            [Test]
            [TestCase(false)]
            [TestCase(true)]
            public void ValueShouldBeSetForEnum(bool isEnabled)
            {
                var sut = new FeatureRegistry {[TestEnum.Test] = isEnabled};

                Assert.AreEqual(isEnabled, sut[TestEnum.Test]);
            }

            [Test]
            [TestCase(false)]
            [TestCase(true)]
            public void ValueShouldBeSetForType(bool isEnabled)
            {
                var sut = new FeatureRegistry {[typeof(TestClass)] = isEnabled};

                Assert.AreEqual(isEnabled, sut[typeof(TestClass)]);
            }

            [Test]
            [TestCase(false)]
            [TestCase(true)]
            public void ValueShouldBeSetForString(bool isEnabled)
            {
                var sut = new FeatureRegistry {["First"] = isEnabled};

                Assert.AreEqual(isEnabled, sut["First"]);
            }
        }
    }
}