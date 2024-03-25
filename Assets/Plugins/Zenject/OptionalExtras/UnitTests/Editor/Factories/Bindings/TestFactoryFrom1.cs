using NUnit.Framework;
using Plugins.Zenject.OptionalExtras.TestFramework;
using Plugins.Zenject.Source.Factories;
using Assert = Plugins.Zenject.Source.Internal.Assert;

namespace Plugins.Zenject.OptionalExtras.UnitTests.Editor.Factories.Bindings
{
    [TestFixture]
    public class TestFactoryFrom1 : ZenjectUnitTestFixture
    {
        [Test]
        public void TestSelf()
        {
            Container.BindFactory<string, Foo, Foo.Factory>().NonLazy();

            Assert.IsEqual(Container.Resolve<Foo.Factory>().Create("asdf").Value, "asdf");
        }

        [Test]
        public void TestConcrete()
        {
            Container.BindFactory<string, IFoo, IFooFactory>().To<Foo>().NonLazy();

            var ifoo = Container.Resolve<IFooFactory>().Create("asdf");

            Assert.IsNotNull(ifoo);
            Assert.IsEqual(((Foo)ifoo).Value, "asdf");
        }

        interface IFoo
        {
        }

        class IFooFactory : PlaceholderFactory<string, IFoo>
        {
        }

        class Foo : IFoo
        {
            public Foo(string value)
            {
                Value = value;
            }

            public string Value
            {
                get;
                private set;
            }

            public class Factory : PlaceholderFactory<string, Foo>
            {
            }
        }
    }
}

